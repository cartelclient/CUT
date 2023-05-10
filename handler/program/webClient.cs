using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Windows.Forms;

namespace CUT.handler.program
{
    internal class webClient
    {
        public static WebClient client = new WebClient();

        /// <summary>
        /// Download a file using async
        /// </summary>
        /// <param name="link">Direct link to download</param>
        /// <param name="path">Where to save the file to</param>
        /// <param name="fileName">Name to save the file as</param>
        /// <param name="extensionType">Type of file</param>
        public static void downloadFile(string link, string path, string fileName, string extensionType)
        {
            client.DownloadFileAsync(new Uri(link), path + $"/{fileName}.{extensionType}");
        }

        /// <summary>
        /// Download the unsigned version of the rar
        /// </summary>
        public static void downloadUnsignedRar()
        {
            dynamic json = readString("https://cartelclient.github.io/API/CUT.json");
            dynamic link = JObject.Parse(json)["unsignedrar"].ToString();
            downloadFile(link, Application.StartupPath, "cartel", "rar");
        }

        /// <summary>
        /// Download the unsigned version of the rar from the server
        /// </summary>
        public static void serverDownloadUnsignedRar()
        {
            dynamic json = readString("https://cartelclient.github.io/API/CUT.json");
            dynamic link = JObject.Parse(json)["serverunsignedrar"].ToString();
            downloadFile(link, Application.StartupPath, "cartel", "rar");
        }

        /// <summary>
        /// Download the signed version of the rar
        /// </summary>
        public static void downloadSignedRar()
        {
            dynamic json = readString("https://cartelclient.github.io/API/CUT.json");
            dynamic link = JObject.Parse(json)["signedrar"].ToString();
            downloadFile(link, Application.StartupPath, "cartel", "gpg");
        }

        /// <summary>
        /// Download the signed version of the rar from the server
        /// </summary>
        public static void serverDownloadSignedRar()
        {
            dynamic json = readString("https://cartelclient.github.io/API/CUT.json");
            dynamic link = JObject.Parse(json)["serversignedrar"].ToString();
            downloadFile(link, Application.StartupPath, "cartel", "gpg");
        }

        /// <summary>
        /// Download the signed version of the executable
        /// </summary>
        public static void downloadUnsignedExe()
        {
            dynamic json = readString("https://cartelclient.github.io/API/CUT.json");
            dynamic link = JObject.Parse(json)["unsignedexe"].ToString();
            downloadFile(link, Application.StartupPath, "cartel", "exe");
        }

        /// <summary>
        /// Download the unsigned version of the rar from the server
        /// </summary>
        public static void serverDownloadUnsignedExe()
        {
            dynamic json = readString("https://cartelclient.github.io/API/CUT.json");
            dynamic link = JObject.Parse(json)["serverunsignedexe"].ToString();
            downloadFile(link, Application.StartupPath, "cartel", "exe");
        }

        /// <summary>
        /// Download the signed version of the executable
        /// </summary>
        public static void downloadSignedExe()
        {
            dynamic json = readString("https://cartelclient.github.io/API/CUT.json");
            dynamic link = JObject.Parse(json)["unsignedexe"].ToString();
            downloadFile(link, Application.StartupPath, "cartel", "gpg");
        }

        /// <summary>
        /// Download the unsigned version of the rar from the server
        /// </summary>
        public static void serverDownloadSignedExe()
        {
            dynamic json = readString("https://cartelclient.github.io/API/CUT.json");
            dynamic link = JObject.Parse(json)["serversignedexe"].ToString();
            downloadFile(link, Application.StartupPath, "cartel", "gpg");
        }

        /// <summary>
        /// Download the unsigned version of CAM
        /// </summary>
        public static void downloadUnsignedCAM()
        {
            dynamic json = readString("https://cartelclient.github.io/API/CUT.json");
            dynamic link = JObject.Parse(json)["unsignedcam"].ToString();
            downloadFile(link, Application.StartupPath, "CAM", "exe");
        }

        /// <summary>
        /// Download the unsigned version of CAM from server
        /// </summary>
        public static void serverDownloadUnsignedCAM()
        {
            dynamic json = readString("https://cartelclient.github.io/API/CUT.json");
            dynamic link = JObject.Parse(json)["serverunsignedcam"].ToString(); //call it cam so json parser can download both files at the same time (for option 1)
            downloadFile(link, Application.StartupPath, "CAM", "exe");
        }

        /// <summary>
        /// Download the signed version of CAM
        /// </summary>
        public static void downloadSignedCAM()
        {
            dynamic json = readString("https://cartelclient.github.io/API/CUT.json");
            dynamic link = JObject.Parse(json)["signedcam"].ToString();
            downloadFile(link, Application.StartupPath, "CAM", "exe");
        }

        /// <summary>
        /// Download the unsigned version of CAM from server
        /// </summary>
        public static void serverDownloadSignedCAM()
        {
            dynamic json = readString("https://cartelclient.github.io/API/CUT.json");
            dynamic link = JObject.Parse(json)["serversignedcam"].ToString();
            downloadFile(link, Application.StartupPath, "CAM", "exe");
        }

        /// <summary>
        /// Return string from a link, can be JSON
        /// </summary>
        public static string readString(string link)
        {
            try
            {
                return client.DownloadString(link);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
