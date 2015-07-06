using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class Program
    {
        public void secretSanta(string[] lines) 
        {
            int person;
            int result;
            List<string> hat = new List<string>();
            for (int i = 0; i < lines.Length; i++) 
            {
                hat.Add(lines[i]); //putting the names in a "hat" 
            } 

            Random rnd = new Random(); 
            for (int i = 0; i < lines.Length; i++) 
            {
                do
                {
                    person = rnd.Next(0, hat.Count());//who gets picked
                }
                while (lines[person] == lines[i]);
                person=rnd.Next(0,hat.Count());//who gets picked
                Console.WriteLine("Persoana cu numele " + lines[i] + " a tras persoana cu numele " + hat[person]);
                hat.Remove(hat[person]);
            }
        }
        static void Main(string[] args)
        {
            //reading the names from the file
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\rares.ghencioiu\Documents\Visual Studio 2013\Projects\ConsoleApplication1\problem9names.txt");
            Console.WriteLine(lines[2]);
            Program p1 = new Program();
            p1.secretSanta(lines);

        }
    }
}
