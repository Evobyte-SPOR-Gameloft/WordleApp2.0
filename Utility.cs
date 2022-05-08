using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleAppOOP
{
    public static class Utility
    {
        public static void WriteToCenterLine(string textToCenter)
        {
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + textToCenter.Length / 2) + "}", textToCenter);
        }
        public static void WriteToCenter(string textToCenter)
        {
            Console.Write("{0," + ((Console.WindowWidth / 2) + textToCenter.Length / 2) + "}", textToCenter);
        }
        public static void DeletePrevConsoleLine()
        {
            if (Console.CursorTop == 0) return;
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
        }
        public static void MenuChoices()
        {
            PaintBrush cyanBrush = new("cyan");
            PaintBrush redBrush = new("red");

            Menu mainMenu = new("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~",
                                "Please enter your choice:",
                                "P - Play",
                                "Q - Quit");

            WriteToCenterLine(mainMenu.OptionOne);
            WriteToCenterLine(mainMenu.OptionTwo);
            WriteToCenterLine(mainMenu.OptionOne);
            cyanBrush.PaintLineToCenter(mainMenu.OptionThree);
            redBrush.PaintLineToCenter(mainMenu.OptionFour);
            WriteToCenterLine(mainMenu.OptionOne);
        }
        public static void PromptUserToGuess()
        {
            Menu secondaryMenu = new("Guess the five letter word!",
                                     "~ You've got 6 tries! ~");
            WriteToCenterLine(secondaryMenu.OptionOne);
            WriteToCenterLine(secondaryMenu.OptionTwo);
        }
    }
}
