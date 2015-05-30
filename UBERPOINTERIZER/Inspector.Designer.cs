namespace UBERPOINTERIZER
{
    partial class Inspector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inspector));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_cabid = new System.Windows.Forms.TextBox();
            this.TB_type = new System.Windows.Forms.TextBox();
            this.IB_time = new System.Windows.Forms.ListBox();
            this.IB_lat = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IB_lon = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IB_head = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_FSLS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TB_FSLS);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.IB_head);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.IB_lon);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.IB_lat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.IB_time);
            this.panel1.Controls.Add(this.TB_type);
            this.panel1.Controls.Add(this.TB_cabid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 667);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Inspector";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-13, 37);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(543, 10);
            this.progressBar1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vehicle Identifier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Update Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vehicle Type";
            // 
            // TB_cabid
            // 
            this.TB_cabid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_cabid.Location = new System.Drawing.Point(20, 70);
            this.TB_cabid.Name = "TB_cabid";
            this.TB_cabid.ReadOnly = true;
            this.TB_cabid.Size = new System.Drawing.Size(491, 25);
            this.TB_cabid.TabIndex = 5;
            // 
            // TB_type
            // 
            this.TB_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_type.Location = new System.Drawing.Point(20, 118);
            this.TB_type.Name = "TB_type";
            this.TB_type.ReadOnly = true;
            this.TB_type.Size = new System.Drawing.Size(491, 25);
            this.TB_type.TabIndex = 6;
            // 
            // IB_time
            // 
            this.IB_time.FormattingEnabled = true;
            this.IB_time.ItemHeight = 17;
            this.IB_time.Location = new System.Drawing.Point(9, 225);
            this.IB_time.Name = "IB_time";
            this.IB_time.Size = new System.Drawing.Size(130, 429);
            this.IB_time.TabIndex = 7;
            // 
            // IB_lat
            // 
            this.IB_lat.FormattingEnabled = true;
            this.IB_lat.ItemHeight = 17;
            this.IB_lat.Location = new System.Drawing.Point(145, 225);
            this.IB_lat.Name = "IB_lat";
            this.IB_lat.Size = new System.Drawing.Size(130, 429);
            this.IB_lat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Latitiude";
            // 
            // IB_lon
            // 
            this.IB_lon.FormattingEnabled = true;
            this.IB_lon.ItemHeight = 17;
            this.IB_lon.Location = new System.Drawing.Point(281, 225);
            this.IB_lon.Name = "IB_lon";
            this.IB_lon.Size = new System.Drawing.Size(130, 429);
            this.IB_lon.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Longitude";
            // 
            // IB_head
            // 
            this.IB_head.FormattingEnabled = true;
            this.IB_head.ItemHeight = 17;
            this.IB_head.Location = new System.Drawing.Point(417, 225);
            this.IB_head.Name = "IB_head";
            this.IB_head.Size = new System.Drawing.Size(130, 429);
            this.IB_head.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Heading";
            // 
            // TB_FSLS
            // 
            this.TB_FSLS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_FSLS.Location = new System.Drawing.Point(20, 168);
            this.TB_FSLS.Name = "TB_FSLS";
            this.TB_FSLS.ReadOnly = true;
            this.TB_FSLS.Size = new System.Drawing.Size(491, 25);
            this.TB_FSLS.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "First Seen / Last Seen";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(504, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(608, 721);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Inspector";
            this.Text = "Inspector";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox IB_lon;
        public System.Windows.Forms.ListBox IB_lat;
        public System.Windows.Forms.ListBox IB_time;
        public System.Windows.Forms.TextBox TB_type;
        public System.Windows.Forms.TextBox TB_cabid;
        public System.Windows.Forms.ListBox IB_head;
        public System.Windows.Forms.TextBox TB_FSLS;
    }
}