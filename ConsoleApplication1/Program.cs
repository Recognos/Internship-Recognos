using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public void toInt(String n)
        {
            int m = 0;
            double x = 0;
            //manual conversion without the use of any built in methods
            for (int i = 0; i <= n.Length-1; i++)
            {
                if (n[i].Equals('1'))
                {
                    m = 1;
                }
                else if (n[i].Equals('2'))
                {
                    m = 2;
                }
                else if (n[i].Equals('3'))
                {
                    m = 3;
                }
                else if (n[i].Equals('4'))
                {
                    m = 4;
                }
                else if (n[i].Equals('5'))
                {
                    m = 5;
                }
                else if (n[i].Equals('6'))
                {
                    m = 6;
                }
                else if (n[i].Equals('7'))
                {
                    m = 7;
                }
                else if (n[i].Equals('8'))
                {
                    m = 8;
                }
                else if (n[i].Equals('9'))
                {
                    m = 9;
                }
                //formula for calculating the final number 
                x = x + (m * (Math.Pow(10, n.Length-i-1)));
            }
            Console.WriteLine(" numarul este "+ x);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("write the number");
            String n = Console.ReadLine();
            //--just some code I had for checking stuff Console.WriteLine(n.Length);
            Program p1 = new Program();
            p1.toInt(n);

        }
    }
}
