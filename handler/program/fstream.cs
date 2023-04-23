using System.IO;

namespace CUT.handler.program
{
    internal class fstream
    {
        /// <param name="path">Path to folder</param>
        public static bool folderExists(string path)
        {

            bool exists = Directory.Exists(path);

            if (exists)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        /// <param name="path">Path to file</param>
        public static bool fileExists(string path)
        {
            bool exists = File.Exists(path);

            if (exists)
            {
                return true;
            }

            else
            {
                return false;
            }
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
