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

            consoleWriter.optionsWriter("Choose for me");
            consoleWriter.optionsWriter("Download cartel (rar)");
            consoleWriter.optionsWriter("Download cartel (signed rar)");
            consoleWriter.optionsWriter("Download cartel (executable only)");
            consoleWriter.optionsWriter("Download cartel (signed executable)");
            consoleWriter.optionsWriter("Download Cartel Account Maker (unsigned)");
            consoleWriter.optionsWriter("Download Cartel Account Maker (signed)");
            consoleWriter.optionsWriter("Exit");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Clear();
                    threadManager.createThread(webClient.serverDownloadUnsignedRar);
                    Console.WriteLine("Downloading cartel from the server [if you need to make an account, press 6 and then 1 to download Cartel Account Maker]. Press any key to continue");
                    Console.ReadLine();
                break;


                case "2":
                    Console.Clear();
                    consoleWriter.resetOptions();
                    consoleWriter.optionsWriter("download from website [stable]");
                    consoleWriter.optionsWriter("download from server [faster updates]");
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        threadManager.createThread(webClient.downloadUnsignedRar);
                        consoleManager.centerText("Downloading unsigned cartel rar. Press any key to continue");
                        Console.ReadLine();
                    }
                    if (input == "2")
                    {
                        threadManager.createThread(webClient.serverDownloadUnsignedRar);
                        consoleManager.centerText("Downloading unsigned cartel rar. Press any key to continue");
                        Console.ReadLine();
                    }
                break;

                case "3":
                    Console.Clear();
                    consoleWriter.resetOptions();
                    consoleWriter.optionsWriter("download from website [stable]");
                    consoleWriter.optionsWriter("download from server [faster updates]");
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        threadManager.createThread(webClient.downloadSignedRar);
                        consoleManager.centerText("Downloading cartel signed rar. Press any key to continue");
                        Console.ReadLine();
                    }
                    if (input == "2")
                    {
                        threadManager.createThread(webClient.serverDownloadSignedRar);
                        consoleManager.centerText("Downloading cartel signed rar. Press any key to continue");
                        Console.ReadLine();
                    }
                    break;

                case "4":
                    Console.Clear();
                    consoleWriter.resetOptions();
                    consoleWriter.optionsWriter("download from website [stable]");
                    consoleWriter.optionsWriter("download from server [faster updates]");
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        threadManager.createThread(webClient.downloadUnsignedExe);
                        consoleManager.centerText("Downloading cartels unsigned executable. Press any key to continue");
                        Console.ReadLine();
                    }
                    if (input == "2")
                    {
                        threadManager.createThread(webClient.serverDownloadUnsignedExe);
                        consoleManager.centerText("Downloading cartels unsigned executable. Press any key to continue");
                        Console.ReadLine();
                    }
                break;

                case "5":
                    Console.Clear();
                    consoleWriter.resetOptions();
                    consoleWriter.optionsWriter("download from website [stable]");
                    consoleWriter.optionsWriter("download from server [faster updates]");
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        threadManager.createThread(webClient.downloadSignedExe);
                        consoleManager.centerText("Downloading cartels signed executable. Press any key to continue");
                        Console.ReadLine();
                    }
                    if (input == "2")
                    {
                        threadManager.createThread(webClient.serverDownloadSignedExe);
                        consoleManager.centerText("Downloading cartels signed executable. Press any key to continue");
                        Console.ReadLine();
                    }
                break;

                case "6":
                    Console.Clear();
                    consoleWriter.resetOptions();
                    consoleWriter.optionsWriter("download from website [stable]");
                    consoleWriter.optionsWriter("download from server [faster updates]");
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        threadManager.createThread(webClient.downloadUnsignedCAM);
                        consoleManager.centerText("Downloading Cartel Account Maker. Press any key to continue");
                        Console.ReadLine();
                    }
                    if (input == "2")
                    {
                        threadManager.createThread(webClient.serverDownloadUnsignedCAM);
                        consoleManager.centerText("Downloading Cartel Account Maker. Press any key to continue");
                        Console.ReadLine();
                    }
                    break;

                case "7":
                    Console.Clear();
                    consoleWriter.resetOptions();
                    consoleWriter.optionsWriter("download from website [stable]");
                    consoleWriter.optionsWriter("download from server [faster updates]");
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        threadManager.createThread(webClient.downloadSignedCAM);
                        consoleManager.centerText("Downloading signed Cartel Account Maker. Press any key to continue");
                        Console.ReadLine();
                    }
                    if (input == "2")
                    {
                        threadManager.createThread(webClient.serverDownloadSignedCAM);
                        consoleManager.centerText("Downloading signed Cartel Account Maker. Press any key to continue");
                        Console.ReadLine();
                    }
                    break;

                case "8":
                   Environment.Exit(0);
                break;
            }
            if (input != "1" || input != "2" || input != "3" || input != "4" || input != "5" || input != "6" || input != "7" || input != "8")
            {
                consoleWriter.resetOptions(); //reset the int varaible
                Options();
            }
        }
    }
}