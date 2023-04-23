using System;
using System.Windows.Forms;
using CUT.handler.console;
using CUT.handler.program;

namespace CUT
{
    internal class consoleWndw
    {
        static void Main(string[] args)
        {
            Console.Title = $"CUT | Cartel Update Tool";
            consoleManager.MoveWindowToCenter();
            Console.BufferWidth = Console.WindowWidth = 100;
            Console.BufferHeight = Console.WindowHeight = 28;
            Options();
        }

        static void Options()
        {
            Console.Clear();
            consoleWriter.writeLogo();
            Console.WriteLine("");

            consoleWriter.optionsWriter("Update cartel (unsigned)");
            consoleWriter.optionsWriter("Update cartel (signed)");
            consoleWriter.optionsWriter("Repair cartel");
            consoleWriter.optionsWriter("Exit");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Clear();
                    if (fstream.fileExists(Application.StartupPath + @"/cartel.exe"))
                    {
                        fstream.deleteFile(Application.StartupPath + @"/cartel.exe"); // delete old versions
                        threadManager.createThread(webClient.downloadUnsigned); // download new version
                        consoleManager.centerText("Found cartel. Updating file. Press any key to continue");
                        Console.ReadLine();
                        consoleWriter.resetOptions(); //reset the int varaible
                    }
                    else
                    {
                        consoleManager.centerText("Make sure cartel.exe is in the same folder. Press any key to continue");
                        Console.ReadLine();
                        consoleWriter.resetOptions(); //reset the int varaible
                        Options();
                    }
                break;

                case "2":
                    Console.Clear();
                    if (fstream.fileExists(Application.StartupPath + @"/cartel.exe"))
                    {
                        fstream.deleteFile(Application.StartupPath + @"/cartel.exe"); // delete old versions
                        threadManager.createThread(webClient.downloadSigned); // download new version
                        consoleManager.centerText("Found cartel. Updating file. Press any key to continue");
                        Console.ReadLine();
                        consoleWriter.resetOptions(); //reset the int varaible
                    }
                    else
                    {
                        consoleManager.centerText("Make sure cartel.exe is in the same folder. Press any key to continue");
                        Console.ReadLine();
                        consoleWriter.resetOptions(); //reset the int varaible
                        Options();
                    }
                    break;

                case "3":
                    Environment.Exit(0);
                break;
            }
            if (input != "1" || input != "2" || input != "3")
            {
                consoleWriter.resetOptions(); //reset the int varaible
                Options();
            }
        }
    }
}