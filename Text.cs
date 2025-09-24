namespace Hacquer
{
    using System;
    using System.Threading;
    public class game
    {
        public class Enemy
        {
            private static int nextIndex = 0; // Tracks the next available index

            public int index { get; private set; } // Instance index

            int health { get; set; }
            int maxHealth { get; set; }
            int level { get; set; }
            int experience { get; set; }
            int money { get; set; }
            string name { get; set; }
            int damage { get; set; }

            public Enemy()
            {
                index = nextIndex++;// Assign and increment the index
            }

          
        }
        public class Player
        {
            int health { get; set; }
            int maxHealth { get; set; }
            int level { get; set; }
            int experience { get; set; }
            int money { get; set; }
            string name { get; set; }
        }
    }
    public class Text
    {
        // color codes
        public struct ColorCode
        {
            byte r;
            byte g;
            byte b;

            public ColorCode(byte r, byte g, byte b)
            {
                this.r = r;
                this.g = g;
                this.b = b;
            }
        }
        static ColorCode red = new ColorCode (255,0,0);
        static ColorCode green = new ColorCode(0, 255, 0);
        static ColorCode blue = new ColorCode(0, 0, 255);
        static ColorCode yellow = new ColorCode(255, 255, 0);
        static ColorCode white = new ColorCode(255, 255, 255);
        static ColorCode black = new ColorCode(0, 0, 0);
        static ColorCode orange = new ColorCode(255, 165, 0);



        public static void TypeLine(string message = "", int delayMs = 25)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.WriteLine();
        }
        public static void Color(string color)
        {
            switch (color)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "orange":
                    Xcolor.forground(255, 165, 0);
                    break;
                default:
                    Console.ResetColor();
                    break;
            }

        }
        public static class Xcolor
        {
            public static void forground(byte r, byte g, byte b)
            {
                Console.Write($"\x1b[38;2;{r};{g};{b}m");
            }
            public static void background(byte r, byte g, byte b)
            {
                Console.Write($"\x1b[48;2;{r};{g};{b}m");
            }
            public static void demo()// demo of all colors
            {
                for (int r = 0; r < 256; r += 51)
                {
                    for (int g = 0; g < 256; g += 51)
                    {
                        int b;
                        for (b = 0; b < 256; b += 51)
                        {
                            forground((byte)r, (byte)g, (byte)b);
                            Console.Write("█");
                            Console.ResetColor();
                        }
                        string rt = r.ToString();
                        string gt = g.ToString();
                        string bt = b.ToString();
                        Console.WriteLine($"R: {rt}, G: {gt}, B: {bt}");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
