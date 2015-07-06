using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        public void aveCaesar(int n)
        {
            string number = " ";
            int[] numbers = { 1000,900,500,400, 100,90, 50,40, 10, 5, 4,1 };
            string[] numbersRoman = { "M", "XM","D","CD", "C", "XC","L","XL" ,"X", "V","IV", "I" };
            int i = 0;
            while (n != 0)
            {
                if (n >= numbers[i])
                {
                    Console.Write(numbersRoman[i]);
                    n = n - numbers[i];
                }
                else
                {
                    i = i + 1;
                }
            }

            Console.WriteLine(number);
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Console.WriteLine("Write the number to be converted");
            int n = int.Parse(Console.ReadLine()); 

            p1.aveCaesar(n);
           // Console.WriteLine(n);

        }
    }
}
