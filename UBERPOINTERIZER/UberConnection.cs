using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace UBERPOINTERIZER
{
    static class UberConnection
    {
        private static String request2 = "{\"version\":\"2.69.2\",\"deviceIds\":{\"advertiserId\":\"";
        private static String request3 = "\",\"bluetoothMac\":\"02:00:00:00:00:00\",\"advertiserTrackingEnabled\":false,\"uberId\":\"";
        private static String request4 = "\"},\"messageType\":\"PingClient\",\"longitude\":";
        private static String request5 = ",\"appId\":\"com.ubercab.UberClient\",\"deviceId\":\"02:00:00:00:00:00\",\"latitude\":";
        private static String request6 = ",\"deviceModel\":\"iPhone7,2\",\"app\":\"client\",\"deviceOS\":\"8.3\",\"language\":\"en\",\"token\":\"";
        private static String request8 = "\",\"localeFileMD5\":\"";
        private static String request9 = "\",\"epoch\":";
        private static String request10 = ",\"device\":\"iphone\",\"altitude\":0}";

        public static String sendRequest(double nlat, double nlon, ConnectionTrait connection)
        {
            String currentReq = request2 + connection.advertisingID + request3 + connection.uberID + request4 + nlon.ToString() + request5 + nlat.ToString() + request6 + connection.token + request8 + connection.fileMD5 + request9 + getEpoch() + request10;
            WebRequest wr = WebRequest.Create("https://cn-dc1.uber.com");
            wr.Credentials = CredentialCache.DefaultCredentials;
            ((HttpWebRequest)wr).UserAgent = "client/iphone/2.69.2";
            wr.Method = "POST";
            wr.ContentType = "application/json; charset=utf-8";
            ((HttpWebRequest)wr).KeepAlive = true;
 
            wr.Headers.Add("X-Uber-RedirectCount", "0");
            wr.Headers.Add("X-Uber-Token", connection.token);
            wr.Headers.Add("X-Uber-DCURL", "https://cn-dc1.uber.com/");
            wr.Headers.Add("X-Uber-Origin", "ios");
            wr.Headers.Add("Accept-Language", "en;q=1");

            ((HttpWebRequest)wr).AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            byte[] rOut = Encoding.UTF8.GetBytes(currentReq);
            wr.ContentLength = rOut.Length;

            System.IO.Stream dataStream = wr.GetRequestStream();
            dataStream.Write(rOut, 0, rOut.Length);
            dataStream.Close();

            WebResponse response = wr.GetResponse();
            dataStream = response.GetResponseStream();
            System.IO.StreamReader reader = new System.IO.StreamReader(dataStream);
            String finalResponse = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();

            return finalResponse;
        }
        
        private static int getEpoch()
        {
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int secondsSinceEpoch = (int)t.TotalSeconds;
            return secondsSinceEpoch;
        }
    }
}
