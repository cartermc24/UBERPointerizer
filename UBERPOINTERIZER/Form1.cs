using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dynamitey.DynamicObjects;

namespace UBERPOINTERIZER
{
    public partial class Form1 : Form
    {
        public CefSharp.WinForms.ChromiumWebBrowser browser;

        Boolean updatingMapEnabled = true;
        int mapCount = 0;
        int runTime = 0;
        tripAnalyser ta;
        FileInterpreter fi;
        OnlineInterpreter oi;
        Inspector ib;
        List<Cab> OI_copy;
        BackgroundWorker mapUpdater;
        int runMode = -1; //0 for API // 1 For File

        public Form1()
        {
            InitializeComponent();

            CefSharp.Cef.Initialize();
            browser = new CefSharp.WinForms.ChromiumWebBrowser("about:blank");
            {
                Location = new Point(0, 0);
                Dock = DockStyle.Fill;
            };
            browser.Dock = DockStyle.Fill;
            browser.Location = new Point(0, 0);

            panel1.Controls.Add(browser);
            ib = new Inspector();
        }

        private void updateMapAsync()
        {
            if (updatingMapEnabled == false) { return; }
            browserLoad.Visible = true;
            mapUpdater = new BackgroundWorker();
            mapUpdater.DoWork += (sender, args) =>
            {
                int mode = (int)args.Argument;
                if (mode == 2)
                {
                    if (ta == null) { return; }// CONTROLLABEL.Text = "TREND ANALYSER NOT SETUP"; return; }
                    else if (ta.trips.Count == 0) { return; }//mapSelector.Value = 0; CONTROLLABEL.Text = "NO TRENDS FOUND"; return; }
                }
                updateMap(mode);
            };
            mapUpdater.RunWorkerCompleted += (sender, args) =>
            {
                browserLoad.Visible = false;
            };
            
            mapUpdater.RunWorkerAsync(mapSelector.Value);
        }

        private void updateMap(int selectorValue)
        {
            double centLat = 0, centLong = 0;
            if (provBOX.Checked == true) { centLat = MapMaker.providenceLat; centLong = MapMaker.providenceLon; }
            else if (bostonBOX.Checked == true) { centLat = MapMaker.bostonLat; centLong = MapMaker.bostonLon; }
            else if (nycBOX.Checked == true) { centLat = MapMaker.nycLat; centLong = MapMaker.nycLon; }
            else
            {
                centLat = Double.Parse(latBox.Text);
                centLong = Double.Parse(lonBox.Text);
            }

            List<Cab> cabList = null;
            if (runMode == 1) { cabList = fi.cabs; }
            else { cabList = oi.cabs; }
            if (selectorValue == 0)
            {
                String request = MapMaker.getHeatMapRequest(cabList, centLat, centLong);
                browser.LoadHtml(request, "http://rendering/");
            }
            if (selectorValue == 1)
            {
                String request = MapMaker.getRouteMapRequest(cabList, centLat, centLong);
                browser.LoadHtml(request, "http://rendering/");
            }
            if (selectorValue == 2)
            {
                 String request = MapMaker.getTrendMapRequest(ta.trips, centLat, centLong);
                 browser.LoadHtml(request, "http://rendering/");
            }
        }

        private void connectBOX_Click(object sender, EventArgs e)
        {
            connectBOX.Enabled = false;
            loginErrorLabel.Visible = false;
            CONTROLLABEL.Text = "CONNECTING...";
            if (otherLOCATIONBOX.Checked == true && (latBox.Text == "" || lonBox.Text == ""))
            {
                loginErrorLabel.Visible = true;
                CONTROLLABEL.Text = "ERROR";
                connectBOX.Enabled = true;
                return;
            }

            waitPanel.Visible = true;
            //If success
            runMode = 0;
            loginPanel.Visible = false;
            logoutButton.Visible = true;
            connectBOX.Enabled = true;
            mainPanel.Visible = true;
            runningTimer.Start();

            oi = new OnlineInterpreter();
            if (bostonBOX.Checked == true) { oi.lat = MapMaker.bostonLat; oi.lon = MapMaker.bostonLon; }
            else if (nycBOX.Checked == true) { oi.lat = MapMaker.nycLat; oi.lon = MapMaker.nycLon; }
            else if (provBOX.Checked == true) { oi.lat = MapMaker.providenceLat; oi.lon = MapMaker.providenceLon; }
            else
            {
                oi.lat = Double.Parse(latBox.Text);
                oi.lon = Double.Parse(lonBox.Text);
            }
            oi.connection = new ConnectionTrait(tokenBOX.Text, adBOX.Text, uberidBOX.Text, md5BOX.Text);
            System.Threading.Thread readerThread = new System.Threading.Thread(new System.Threading.ThreadStart(oi.startReading));
            readerThread.Start();
            onlineUpdater.Start();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if (oi != null) { oi.stop = true; }
            CONTROLLABEL.Text = "WAITING";
            mainPB.Style = ProgressBarStyle.Continuous;
            mainPanel.Visible = false;
            loginPanel.Visible = true;
            tripAnaPanel.Visible = false;
            button1.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
            carBox.Items.Clear();
            runningTimer.Stop();
            runTime = 0;
            logoutButton.Visible = false;
            mapSelector.Value = 1;
        }

        private void runningTimer_Tick(object sender, EventArgs e)
        {
            runTime++;
            timerLabel.Text = "Tracking for " + runTime + " seconds";
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            connectBOX.Enabled = false;
            loginErrorLabel.Visible = false;

            button1.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;

            loginPanel.Visible = false;
            logoutButton.Visible = true;
            connectBOX.Enabled = true;
            mainPanel.Visible = true;
            
            mainPB.Style = ProgressBarStyle.Marquee;
            runningTimer.Start();

            runMode = 1;
            fi = new FileInterpreter();
            DialogResult dr = MessageBox.Show("Choose a file to import: Press 'Yes' to import a UberPointerizer export file, or 'No' for raw Uber API dumps", "Choose file type", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes) { fi.filemode = 1; CONTROLLABEL.Text = "PROCESSING INFORMATION FROM UBER POINTERIZER EXPORT / PLEASE WAIT..."; }
            else { fi.filemode = 0; CONTROLLABEL.Text = "PROCESSING INFORMATION FROM UBER APIFILE / PLEASE WAIT..."; }
            System.Threading.Thread readerThread = new System.Threading.Thread(new System.Threading.ThreadStart(fi.startReading));
            readerThread.Start();
            fileReaderUpdater.Start();
        }

        private void fileReaderUpdater_Tick(object sender, EventArgs e)
        {
            switch (fi.status)
            {
                case -1:
                    fileReaderUpdater.Stop();
                    CONTROLLABEL.Text = "ERROR READING IN APIFILE / OR FILE DOES NOT EXIST";
                    break;
                case 1:
                    incomStatusLabel.Text = "Recieved " + fi.total + " updates / Processed " + fi.processed + " updates";
                    carBox.Items.Clear();
                    for (int i = 0; i < fi.processed; i++)
                    {
                        carBox.Items.Add(fi.cabs[i].cabIdentifier);
                    }
                    mainPB.Style = ProgressBarStyle.Continuous;
                    float progress = ((float)fi.processed / (float)fi.total) * 100;
                    mainPB.Value = (int)progress;
                    break;
                case 2:
                    incomStatusLabel.Text = "Received " + fi.total + " updates / Processed " + fi.processed + " updates" + " - ALL ITEMS PROCESSED";
                    carBox.Items.Clear();
                    for (int i = 0; i < fi.cabs.Count(); i++)
                    {
                        carBox.Items.Add(fi.cabs[i].cabIdentifier);
                    }
                    CONTROLLABEL.Text = "ALL DATA PROCESSED SUCESSFULLY";
                    fileReaderUpdater.Stop();
                    runningTimer.Stop();
                    mainPB.Value = 0;
                    updateMapAsync();
                    break;
            }
        }

        private void onlineUpdater_Tick(object sender, EventArgs e)
        {
            switch (oi.status)
            {
                case 0:
                    CONTROLLABEL.Text = "CONNECTING TO UBER NETWORK...";
                    mainPB.Style = ProgressBarStyle.Marquee;
                    break;
                case 2:
                    CONTROLLABEL.Text = "TRACKING ENABLED / FETCHING NEW LOCATIONS";
                    waitPanel.Visible = false;
                    mainPB.Style = ProgressBarStyle.Marquee;
                    carBox.Enabled = false;
                    incomStatusLabel.Text = "Received " + oi.total + " updates / Processed " + oi.processed + " updates";
                    mapCount++;
                    if (mapCount > 100)
                    {
                        carBox.Items.Clear();
                        OI_copy = oi.cabs;
                        for (int i = 0; i < oi.processed; i++)
                        {
                            carBox.Items.Add(OI_copy[i].cabIdentifier);
                        }
                        mapCount = 0;
                        updateMapAsync();
                    }
                    break;
                case 3:
                    CONTROLLABEL.Text = "ERROR ENCOUNTERED / TRACKING DISABLED FOR 30 SECONDS";
                    waitPanel.Visible = false;
                    mainPB.Style = ProgressBarStyle.Continuous;
                    break;
                case 4:
                    CONTROLLABEL.Text = "TRACKING STOPPED";
                    waitPanel.Visible = false;
                    carBox.Enabled = true;
                    mainPB.Style = ProgressBarStyle.Continuous;
                    onlineUpdater.Stop();
                    break;
            }
        }

        public class FileInterpreter
        {
            public List<Cab> cabs;
            public List<String> cabNames;
            public List<String> cabIdentifiers;
            public int status = 0;
            public int filemode = 0;
            public int total = 0;
            public int processed = 0;
            public void startReading()
            {
                cabs = new List<Cab>();
                if (filemode == 0)
                {
                    List<String> fileNames = new List<String>();
                    DirectoryInfo d = new DirectoryInfo(@"messages");
                    FileInfo[] Files = d.GetFiles("*.txt");
                    foreach (FileInfo file in Files) { fileNames.Add(file.Name); }
                    if (!(fileNames.Count > 1)) { status = -1; return; }
                    total = fileNames.Count;

                    StreamReader reader = new StreamReader(@"messages\" + fileNames.ElementAt(0));
                    String sampleMessage = reader.ReadToEnd();

                    cabIdentifiers = UberAPIReader.getUberCabTypeIdentifiers(sampleMessage);
                    cabNames = UberAPIReader.getUberCabTypeNames(sampleMessage, cabIdentifiers);

                    status = 1;
                    for (processed = 0; processed < total; processed++)
                    {
                        reader = new StreamReader(@"messages\" + fileNames.ElementAt(processed));
                        String message = reader.ReadToEnd();

                        List<Cab> newCabList = UberAPIReader.interpreteMessage(message, cabIdentifiers);
                        cabs = UberAPIReader.updateCabListWithNewList(cabs, newCabList);
                    }
                    status = 2;
                }
                else
                {
                    StreamReader reader = new StreamReader(@"export.txt");
                    if (reader.ReadLine() == "Uber Pointerizer / Carter McCardwell / Program Output:")
                    {
                        String nextLn = reader.ReadLine();
                        while (true)
                        {
                            Cab currentCab = new Cab();
                            if (!nextLn.StartsWith("Cab:")) { break; }
                            currentCab.cabIdentifier = nextLn.Replace("Cab:", "");
                            while (true)
                            {
                                nextLn = reader.ReadLine();
                                if (!nextLn.StartsWith("Epoch[")) { break; }
                                for (int i = 0; true; i++)
                                {
                                    if (nextLn.ToCharArray()[i] == ':') { nextLn = nextLn.Remove(0, i+1); currentCab.epoch.Add(Convert.ToInt64(nextLn)); break; }
                                }
                                nextLn = reader.ReadLine();
                                for (int i = 0; true; i++)
                                {
                                    if (nextLn.ToCharArray()[i] == ':') { nextLn = nextLn.Remove(0, i+1); currentCab.lat.Add(Convert.ToDouble(nextLn)); break; }
                                }
                                nextLn = reader.ReadLine();
                                for (int i = 0; true; i++)
                                {
                                    if (nextLn.ToCharArray()[i] == ':') { nextLn = nextLn.Remove(0, i+1); currentCab.lon.Add(Convert.ToDouble(nextLn)); break; }
                                }
                                nextLn = reader.ReadLine();
                                for (int i = 0; true; i++)
                                {
                                    if (nextLn.ToCharArray()[i] == ':') { nextLn = nextLn.Remove(0, i+1); currentCab.heading.Add((float)Convert.ToInt32(nextLn)); break; }
                                }
                            } cabs.Add(currentCab);
                        }
                        status = 2;
                    }
                    else { status = -1; }
                    
                }
            }
        }

        public class OnlineInterpreter
        {
            public List<Cab> cabs;
            public List<String> cabNames;
            public List<String> cabIdentifiers;
            public ConnectionTrait connection;
            public int status = 0;
            public int total = 0;
            public int processed = 0;
            public Boolean track = true;
            public Boolean stop = false;
            public Double lat, lon;

            public void startReading()
            {
                cabs = new List<Cab>();
                List<Cab> newCabList;
                String firstUpdate = UberConnection.sendRequest(lat, lon, connection);
                status = 1;
                total = 1;
                cabIdentifiers = UberAPIReader.getUberCabTypeIdentifiers(firstUpdate);
                cabNames = UberAPIReader.getUberCabTypeNames(firstUpdate, cabIdentifiers);
                newCabList = UberAPIReader.interpreteMessage(firstUpdate, cabIdentifiers);
                cabs = UberAPIReader.updateCabListWithNewList(cabs, newCabList);
                processed = 1;

                status = 2;
                while (true)
                {
                    if (stop) { status = 4; return; }
                        try
                        {
                            String update = UberConnection.sendRequest(lat, lon, connection);
                            total++;
                            newCabList = UberAPIReader.interpreteMessage(update, cabIdentifiers);
                            cabs = UberAPIReader.updateCabListWithNewList(cabs, newCabList);
                            processed++;
                        }
                        catch (Exception e)
                        {
                            status = 3;
                            track = false;
                            System.Threading.Thread.Sleep(30000);
                        }
                    System.Threading.Thread.Sleep(5000);
                }
            }
        }

        public class tripAnalyser
        {
            public List<Trip> trips;
            public long timeThreshold;
            public Double distThreshold;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ib.Show();
        }

        private void carBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ib.IB_head.Items.Clear();
            ib.IB_lat.Items.Clear();
            ib.IB_lon.Items.Clear();
            ib.IB_time.Items.Clear();
            Cab selectedCab = null;
            if (runMode == 1) { selectedCab = fi.cabs[carBox.SelectedIndex]; }
            else { selectedCab = OI_copy[carBox.SelectedIndex]; }
            ib.TB_cabid.Text = selectedCab.cabIdentifier;
            ib.TB_type.Text = "UberX";
            ib.TB_FSLS.Text = selectedCab.epoch[0] + " / " + selectedCab.epoch[selectedCab.epoch.Count() - 1];

            for (int i = 0; i < selectedCab.epoch.Count(); i++)
            {
                ib.IB_time.Items.Add(selectedCab.epoch[i]);
                ib.IB_lat.Items.Add(selectedCab.lat[i]);
                ib.IB_lon.Items.Add(selectedCab.lon[i]);
                ib.IB_head.Items.Add(selectedCab.heading[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateMapAsync();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (oi != null) 
            {
                if (oi.track == true) { oi.stop = true; }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (runMode == 0)
            {
                if (oi != null)
                {
                    if (oi.status != 2)
                    {
                        String path, writeContents;
                        OpenFileDialog file = new OpenFileDialog();
                        file.CheckFileExists = false;
                        file.AddExtension = true;
                        if (file.ShowDialog() == DialogResult.OK)
                        {
                            path = file.FileName;
                            writeContents = "Uber Pointerizer / Carter McCardwell / Program Output:";
                            for (int i = 0; i < oi.cabs.Count; i++)
                            {
                                writeContents += "\nCab:" + oi.cabs[i].cabIdentifier;
                                for (int ix = 0; ix < oi.cabs[i].epoch.Count; ix++)
                                {
                                    writeContents += "\nEpoch[" + ix + "]:" + oi.cabs[i].epoch[ix];
                                    writeContents += "\nLat[" + ix + "]:" + oi.cabs[i].lat[ix];
                                    writeContents += "\nLon[" + ix + "]:" + oi.cabs[i].lon[ix];
                                    writeContents += "\nHeading[" + ix + "]:" + oi.cabs[i].heading[ix];
                                }
                            }



                            if (ta != null)
                            {
                                if (ta.trips.Count > 0)
                                {
                                    writeContents += "\n\n-----TRIPS-----";
                                    writeContents += "\nTime Threshold: " + ta.timeThreshold + " / Distance Threshold: " + ta.distThreshold;
                                    for (int g = 0; g < ta.trips.Count; g++)
                                    {
                                        writeContents += "\nTrip[" + g + "]:";
                                        writeContents += "\nCab:" + ta.trips[g].cabIdentifier;
                                        writeContents += "\nStartLat:" + ta.trips[g].startLat;
                                        writeContents += "\nStartLon:" + ta.trips[g].startLon;
                                        writeContents += "\nEndLat:" + ta.trips[g].endLat;
                                        writeContents += "\nEndLon:" + ta.trips[g].endLon;
                                        writeContents += "\nDuration:" + ta.trips[g].tripDuration;
                                        writeContents += "\nDistance:" + ta.trips[g].distance;
                                    }
                                }
                            }
                            writeContents += "\nEND OF OUTPUT";
                            System.IO.File.WriteAllText(path, writeContents);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tracking must be paused to save data", "Error: Tracking enabled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tripAnaPanel.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tripAnaPanel.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tripAnaTimer.Stop();
            CONTROLLABEL.Text = "TRIP ANALYSIS STARTED";
            tripAnaPanel.Visible = false;
            if (runMode == 0)
            {
                ta = new tripAnalyser();
                ta.timeThreshold = (Convert.ToInt64(timeThresBox.Text)*1000);
                ta.distThreshold = Double.Parse(distThresBox.Text);
                tripAnaTimer.Start();
            }
            else
            {
                ta = new tripAnalyser();
                ta.trips = TrendFinder.identifyTripByPickupDropoff(fi.cabs, Convert.ToInt32(timeThresBox.Text), Double.Parse(distThresBox.Text));
                label15.Text = "Last Trip Analysis: " + DateTime.Now.ToShortTimeString() + " / " + ta.trips.Count + " Trips identified";
            }
        }

        private void tripAnaTimer_Tick(object sender, EventArgs e)
        {
            label15.Text = "Updating trips / Time Threshold: " + ta.timeThreshold + " Seconds / Distance Threshold: " + ta.distThreshold + "mi";
            ta.trips = TrendFinder.identifyTripByPickupDropoff(oi.cabs, ta.timeThreshold, ta.distThreshold);
            label15.Text = "Last Trip Analysis: " + DateTime.Now.ToShortTimeString() + " / " + ta.trips.Count + " Trips identified";
        }

        private void mapSelector_MouseUp(object sender, MouseEventArgs e)
        {
            updateMapAsync();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (updatingMapEnabled == true) { updatingMapEnabled = false; mapPausedLabel.Visible = true; button6.Text = "Resume Map Updating"; }
            else { updatingMapEnabled = true; mapPausedLabel.Visible = false; button6.Text = "Pause Map Updating"; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void latBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}