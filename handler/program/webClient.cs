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
            dynamic unsigned = JObject.Parse(json)["unsignedrar"].ToString();
            downloadFile(unsigned, Application.StartupPath, "cartel", "rar");
        }

        /// <summary>
        /// Download the signed version of the rar
        /// </summary>
        public static void downloadSignedRar()
        {
            dynamic json = readString("https://cartelclient.github.io/API/CUT.json");
            dynamic unsigned = JObject.Parse(json)["signedrar"].ToString();
            downloadFile(unsigned, Application.StartupPath, "cartel", "gpg");
        }

        /// <summary>
        /// Download the signed version of the executable
        /// </summary>
        public static void downloadUnsignedExe()
        {
            dynamic json = readString("https://cartelclient.github.io/API/CUT.json");
            dynamic unsigned = JObject.Parse(json)["unsignedexe"].ToString();
            downloadFile(unsigned, Application.StartupPath, "cartel", "exe");
        }

        /// <summary>
        /// Download the signed version of the executable
        /// </summary>
        public static void downloadSignedExe()
        {
            dynamic json = readString("https://cartelclient.github.io/API/CUT.json");
            dynamic unsigned = JObject.Parse(json)["unsignedexe"].ToString();
            downloadFile(unsigned, Application.StartupPath, "cartel", "gpg");
        }

        /// <summary>
        /// Download the signed version of the executable
        /// </summary>
        public static void downloadSigned()
        {
            dynamic json = readString("https://cartelclient.github.io/API/CUT.json");
            dynamic unsigned = JObject.Parse(json)["signedexe"].ToString();
            downloadFile(unsigned, Application.StartupPath, "cartel", "exe.gpg");
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
