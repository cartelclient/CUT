using System;

namespace CUT.handler.console
{
    internal class consoleWriter
    {
        public static int options = 0;

        public static void writeLogo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            consoleManager.centerText(" ▄████▄   ▄▄▄       ██▀███  ▄▄▄█████▓▓█████  ██▓    ");
            consoleManager.centerText("▒██▀ ▀█  ▒████▄    ▓██ ▒ ██▒▓  ██▒ ▓▒▓█   ▀ ▓██▒    ");
            consoleManager.centerText("▒▓█    ▄ ▒██  ▀█▄  ▓██ ░▄█ ▒▒ ▓██░ ▒░▒███   ▒██░    ");
            consoleManager.centerText("▒▓▓▄ ▄██▒░██▄▄▄▄██ ▒██▀▀█▄  ░ ▓██▓ ░ ▒▓█  ▄ ▒██░    ");
            consoleManager.centerText("▒ ▓███▀ ░ ▓█   ▓██▒░██▓ ▒██▒  ▒██▒ ░ ░▒████▒░██████▒");
            consoleManager.centerText("░ ░▒ ▒  ░ ▒▒   ▓▒█░░ ▒▓ ░▒▓░  ▒ ░░   ░░ ▒░ ░░ ▒░▓  ░");
            consoleManager.centerText("  ░  ▒     ▒   ▒▒ ░  ░▒ ░ ▒░    ░     ░ ░  ░░ ░ ▒  ░");
            consoleManager.centerText("░          ░   ▒     ░░   ░   ░         ░     ░ ░   ");
            consoleManager.centerText("░ ░            ░  ░   ░                 ░  ░    ░  ░");
            consoleManager.centerText("░                                                  ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void optionsWriter(string text)
        {
            options++;
            Console.WriteLine($"{options}.) {text}");

        }

        public static void resetOptions()
        {
            options = 0;
        }
    }
}
