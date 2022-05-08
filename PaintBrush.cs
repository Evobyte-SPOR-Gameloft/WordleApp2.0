using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleAppOOP
{
    internal class PaintBrush
    {
        private string Color { get; }

        public PaintBrush(string color)
        {
            this.Color = color;
        }

        public void PaintLineToCenter(string textToBePainted)
        {
            if (this.Color == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Utility.WriteToCenterLine(textToBePainted);
                Console.ResetColor();
            }
            else if(this.Color == "orange")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Utility.WriteToCenterLine(textToBePainted);
                Console.ResetColor();
            }
            else if (this.Color == "gray")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Utility.WriteToCenterLine(textToBePainted);
                Console.ResetColor();
            }
            else if (this.Color == "cyan")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Utility.WriteToCenterLine(textToBePainted);
                Console.ResetColor();
            }
            else if (this.Color == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Utility.WriteToCenterLine(textToBePainted);
                Console.ResetColor();
            }
            else
            {
                Utility.WriteToCenterLine("Never heard of that color...");
            }
        }

        public void PaintChar(char charToBePainted)
        {
            if (this.Color == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(charToBePainted);
                Console.ResetColor();
            }
            else if (this.Color == "orange")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(charToBePainted);
                Console.ResetColor();
            }
            else if (this.Color == "gray")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(charToBePainted);
                Console.ResetColor();
            }
            else if (this.Color == "cyan")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(charToBePainted);
                Console.ResetColor();
            }
            else if (this.Color == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(charToBePainted);
                Console.ResetColor();
            }
            else
            {
                Utility.WriteToCenterLine("Never heard of that color...");
            }
        }

        public void Paint(string textToBePainted)
        {
            if (this.Color == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(textToBePainted);
                Console.ResetColor();
            }
            else if (this.Color == "orange")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(textToBePainted);
                Console.ResetColor();
            }
            else if (this.Color == "gray")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(textToBePainted);
                Console.ResetColor();
            }
            else if (this.Color == "cyan")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(textToBePainted);
                Console.ResetColor();
            }
            else if (this.Color == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(textToBePainted);
                Console.ResetColor();
            }
            else
            {
                Utility.WriteToCenterLine("Never heard of that color...");
            }
        }
    }
}
