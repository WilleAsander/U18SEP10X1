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
                    int[] letters = new int[orden.Count()];
                    for (int i = 0; i < orden.Length; i++)
                    {
                        letters[i] = orden[i].Count();
                        Console.WriteLine(orden[i] + " (" + letters[i] + ") ");
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

                case "c":
                    Console.Write("Mata in en mening, vilken som helst: ");
                    mening = Console.ReadLine();
                    string txt = mening.ToLower();
                    orden = txt.Split(' ');

                    var list = new List<string>(orden);
                    var q = list.GroupBy(x => x)
                                .Select(g => new { Value = g.Key, Count = g.Count() })
                                .OrderByDescending(x => x.Count);
                    foreach (var x in q)
                    {
                        Console.WriteLine("Ord: " + x.Value + " Antal: " + x.Count);
                    }
                    Console.ReadLine();
                    break;

                case "d":
                    Console.Write("Mata in en mening, vilken som helst: ");
                    mening = Console.ReadLine();
                    txt = mening.ToLower();
                    orden = txt.Split(new char[] { ' ' },
                        StringSplitOptions.RemoveEmptyEntries);
                    char[] characters = string.Join(string.Empty, orden).ToCharArray();
                    var character_query = (from char word in characters orderby word select word).Distinct();
                    int ammountThree = character_query.Count();
                    char[] resultTwo = character_query.ToArray();
                    foreach (char ch in resultTwo)
                    {
                        int count = mening.Count(g => g == ch);
                        Console.WriteLine(ch + "(" + count + ")");

                    }
                    Console.ReadLine();
                    break;

                case "e":
                    string ord = "";
                    string[] sentence = new string [100];
                    bool run = true;
                    var s = 0;
                    while (run)                   
                    {
                        Console.Write("Mata in ett ord: ");
                        ord = Console.ReadLine();                       
                        s++;                       
                        string small = ord.ToLower();
                        
                        if (small == "avsluta")
                        {
                            run = false;
                            s = 0;
                            sentence[s] = " ";
                        }
                        else
                        {
                            sentence[s] = small;
                        }
                    }

                    Console.Write("Din mening blev: ");
                    for (int i = 0; i < sentence.Length; i++)
                    {
                        Console.Write(sentence[i] + " ");
                    }
                    Console.ReadLine();

                    break;

                case "f":
                    bool sant = true;
                    int tal = 0;
                    Random slump = new Random();
                    tal = slump.Next(1, 21);


                    while (sant)
                    {
                        Console.WriteLine("Gissa på ett tal mellan 1 & 21");
                        Console.Write("Din gissning: ");
                        int gissning = int.Parse(Console.ReadLine());
                        if (gissning == tal)
                        {
                            Console.WriteLine("Du gissade rätt!! grattis");
                            sant = false;
                        }
                        else
                        {
                            Console.WriteLine("Du gissade fel!");
                        }
                    }
                    Console.ReadLine();
                    break;

                case "g":
                    Console.Write("Skriv en meing: ");
                    string sentenceSix = Console.ReadLine().ToUpper();
                    string newSentence = "";
                    Dictionary<string, string> leet = new Dictionary<string, string>();
                    leet.Add("A", @"/-\");
                    leet.Add("B", @"|3");
                    leet.Add("C", @"(");
                    leet.Add("D", @"|)");
                    leet.Add("E", @"3");
                    leet.Add("F", @"|=");
                    leet.Add("G", @"(");
                    leet.Add("H", @"|-|");
                    leet.Add("I", @"l");
                    leet.Add("J", @"    _|");
                    leet.Add("K", @"|<");
                    leet.Add("L", @"|_");
                    leet.Add("M", @"|\/|");
                    leet.Add("N", @"|\|");
                    leet.Add("O", @"0");
                    leet.Add("P", @"|2");
                    leet.Add("Q", @"(,)");
                    leet.Add("R", @"|2");
                    leet.Add("S", @"5");
                    leet.Add("T", @"+");
                    leet.Add("U", @"|_|");
                    leet.Add("V", @"    |/");
                    leet.Add("W", @"\/\/");
                    leet.Add("X", @"><");
                    leet.Add("Y", @"`/");
                    leet.Add("Z", @"2");

                    foreach (KeyValuePair<string, string> x in leet)
                    {
                        sentenceSix = sentenceSix.Replace(x.Key, x.Value);
                    }
                    Console.WriteLine("Your sentence in leet is: " + sentenceSix);
                    Console.ReadLine();
                    break;
             
            } 
                
        }
    }

    

}
