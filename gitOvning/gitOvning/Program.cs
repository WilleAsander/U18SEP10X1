using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitOvning
{
    class Program
    {
        static void Main(string[] args)
        {
            string ovning;

            Console.WriteLine("Välj en övning mellan A och G");
            ovning = Console.ReadLine();
            ovning.ToLower();

            switch (ovning)
            {
                case "a":
                    Console.Write("Mata in en mening, vilken som helst: ");
                    string mening = Console.ReadLine();
                    string[] orden = mening.Split(' ');
                    Console.WriteLine("Det är " + orden.Count() + " ord i meningen!");
                    int[] letters = new int [orden.Count()];
                    for (int i = 0; i < orden.Length; i++)
                    {
                        letters[i] = orden[i].Count();
                        Console.WriteLine(orden[i] + " (" + letters[i] + ") " );
                    }
                    Console.ReadLine();
                break;

                case "b":
                    Console.Write("Mata in en mening, vilken som helst: ");
                    mening = Console.ReadLine();
                    orden = mening.Split(' ');
                    Array.Sort(orden, (x, y) => x.Length.CompareTo(y.Length));
                    Array.Reverse(orden);

                    for (int i = 0; i < orden.Length; i++)
                    {
                        Console.WriteLine(orden[i]);
                    }
                    Console.WriteLine(" ");
                    Array.Reverse(orden);
                    for (int i = 0; i < orden.Length; i++)
                    {
                        Console.WriteLine(orden[i]);
                    }
                    Console.ReadLine();
                    break;
            } 
                
        }
    }
}
