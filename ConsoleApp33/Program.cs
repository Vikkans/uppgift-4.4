using System;
using System.ComponentModel.Design;

namespace ConsoleApp33
{
   class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("1. Subtrahera ett tal med ett annat");
                Console.WriteLine("2. Dividera ett tal med ett annat");
                Console.WriteLine("3. Avsluta programmet");
                string svar = Console.ReadLine();

                if (svar == "1")
                {
                    Console.WriteLine("Välj två tal");
                    string xa = Console.ReadLine();
                    string[] xb = xa.Split(" ");

                    int xb2 = int.Parse(xb[0]);
                    int xb3 = int.Parse(xb[1]);
                    int sum = xb2 - xb3;

                    Console.WriteLine(sum);
                    break;

                }

                if (svar == "2")
                {
                    Console.WriteLine("Välj två tal");
                    string xa = Console.ReadLine();
                    string[] xb = xa.Split(" ");

                    double xb2 = double.Parse(xb[0]);
                    double xb3 = double.Parse(xb[1]);
                    double sum = xb2 / xb3;

                    Console.WriteLine(xb2 / xb3);

                    break;



                }

                if (svar == "3") { Console.WriteLine("Nu avslutas programmet"); }

                else { Console.WriteLine("Du valde inget av de giltiga alternativen"); }


            }
            




        }
    }
}

