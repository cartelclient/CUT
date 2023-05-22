using System.IO;

namespace CUT.handler.program
{
    internal class fstream
    {
        /// <param name="path">Path to folder</param>
        public static bool folderExists(string path)
        {
            return Directory.Exists(path);
        }

        /// <param name="path">Path to file</param>
        public static bool fileExists(string path)
        {
            return File.Exists(path);
        }


        /// <param name="path">Path to file</param>
        public static void deleteFile(string path)
        {
            if (fileExists(path))
            {
                File.Delete(path);
            }
        }
    }
}
