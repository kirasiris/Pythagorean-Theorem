using System;
using System.Globalization;

namespace Function2_CS_Bickham_Fonseca
{
    class Theorem
    {
        static void parabola(float a,
                         float b, float c)
        {
            Console.WriteLine("Vertex: (" +
                             (-b / (2 * a)) + ", " +
                             (((4 * a * c) - (b * b)) /
                             (4 * a)) + ")");

            Console.WriteLine("Focus: (" +
                             (-b / (2 * a)) + ", " +
                             (((4 * a * c) - (b * b) + 1) /
                             (4 * a)) + ")");

            Console.Write("Directrix:" + " y=" +
                         (int)(c - ((b * b) + 1) * 4 * a));
        }

        void findRoots(int a, int b, int c)
        {
            NumberFormatInfo setPrecision = new NumberFormatInfo();

            setPrecision.NumberDecimalDigits = 3;

            // If a is 0, then equation is   
            // not quadratic, but linear 

            if (a == 0)
            {
                Console.Write("Invalid");
                return;
            }

            int d = b * b - 4 * a * c;
            double sqrt_val = Math.Abs(d);

            if (d > 0)
            {
                Console.Write("Roots are real and different \n");

                Console.Write((double)(-b + sqrt_val) /
                              (2 * a) + "\n" + (double)
                              (-b - sqrt_val) / (2 * a));
            } else {
                Console.Write("Roots are complex \n");

                Console.Write(-(double)b / (2 * a) +
                            " + i" + sqrt_val + "\n" +
                               -(double)b / (2 * a) +
                                    " - i" + sqrt_val);
            }
        }

        public static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c)) {

                    return false;
                }
            }
            return true;
        }

        public void showMenu()
        {
            Console.WriteLine("P = a and b solve the Pythagorean Theorem - length of side c, the Hypotenuse");
            Console.WriteLine("S = given input of x1 and y1 and given input of x2 and y2 calculate the slope of a line");
            Console.WriteLine("V = accept the appropriate to calculate the vertex of a parabola");
            Console.WriteLine("Q = accept the appropriate input to calculate the value of x in the quadratic formula");
            Console.WriteLine("E = Exit");
            Console.WriteLine("Z = clear the screen show the menu on screen, thereafter");
        }

        public void handleOption(string opt) {

            NumberFormatInfo setPrecision = new NumberFormatInfo();

            setPrecision.NumberDecimalDigits = 3;

            if (opt == "P" || opt == "p") {


                int a = 0;
                int b = 0;

                Console.WriteLine("Please enter side of a");
                string inputA = Console.ReadLine();
                IsAllLetters(inputA);
                a = Convert.ToInt32(inputA);
                Console.WriteLine("Please enter side of b");
                string inputB = Console.ReadLine();
                IsAllLetters(inputB);
                b = Convert.ToInt32(inputB);

                int c = (a*a) + (b*b);
                Console.WriteLine("The side of c is equal to:");
                Console.WriteLine(c.ToString("N", setPrecision));

            }
            else if(opt == "S" || opt == "s") {

                int x1 = 0;
                int x2 = 0;
                int y1 = 0;
                int y2 = 0;

                Console.WriteLine("Please enter x1");
                string inputA = Console.ReadLine();
                x1 = Convert.ToInt32(inputA);
                Console.WriteLine("Please enter x2");
                string inputB = Console.ReadLine();
                x2 = Convert.ToInt32(inputB);
                Console.WriteLine("Please enter y1");
                string inputC = Console.ReadLine();
                y1 = Convert.ToInt32(inputC);
                Console.WriteLine("Please enter y2");
                string inputD = Console.ReadLine();
                y2 = Convert.ToInt32(inputD);


                int m = y2 - y1 / x2 - x1;
                Console.WriteLine("The side of c is equal to:");
                Console.WriteLine(m.ToString("N", setPrecision));
            }
            else if(opt == "V" || opt == "v") {
                int a = 0;
                int b = 0;
                int c = 0;

                Console.WriteLine("Please enter a");
                string inputA = Console.ReadLine();

                a = Convert.ToInt32(inputA);
                Console.WriteLine("Please enter b");
                string inputB = Console.ReadLine();
                b = Convert.ToInt32(inputB);
                Console.WriteLine("Please enter c");
                string inputC = Console.ReadLine();
                c = Convert.ToInt32(inputC);

                Console.WriteLine("The vertex of a parabola is:");
                parabola(a, b, c);
            }
            else if (opt == "Q" || opt == "q") {
                int a = 0;
                int b = 0;
                int c = 0;

                Console.WriteLine("Please enter a");
                string inputA = Console.ReadLine();
                a = Convert.ToInt32(inputA);
                Console.WriteLine("Please enter b");
                string inputB = Console.ReadLine();
                b = Convert.ToInt32(inputB);
                Console.WriteLine("Please enter c");
                string inputC = Console.ReadLine();
                c = Convert.ToInt32(inputC);

                Console.WriteLine("X is equal to:");
                findRoots(a, b, c);

            }
            else if (opt == "Z" || opt == "z") {
                Console.Clear();
            }
            else
            {
                return;
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Theorem t = new Theorem();
            string option = "";
            do {
                t.showMenu();
                Console.WriteLine("Please enter an option. Use capital letters, please");
                option = Console.ReadLine();
                t.handleOption(option);
            } while (option != "e" && option != "E");
        }
    }
}
