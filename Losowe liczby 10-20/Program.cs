using System;
using System.Collections.Generic;

namespace Losowe_liczby_10_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> Numbers = new List<int>();
            Numbers.Add(rnd.Next(10, 20));
            Numbers.Add(rnd.Next(10, 20));
            Numbers.Add(rnd.Next(10, 20));

            while (!CheckIfSumOf3NumbersDividedBy3(Numbers))
            {
                Numbers.Add(rnd.Next(10, 20));
            }
            
            {    
                Console.WriteLine("Ostatnie 3 liczby podzielne przez 3:");        
            }
            

            for (int i = Numbers.Count - 1; i >= Numbers.Count - 3; i--)
            {
                Console.WriteLine($"{Numbers[i]}, ");
            }

            
            Console.WriteLine("Wszystkie wylosowane liczby to:");

            foreach (var number in Numbers) 
            Console.Write($"{number}, ");
        }
      
        static bool CheckIfSumOf3NumbersDividedBy3(List<int> Numbers) //check
        {
            if (((Numbers[Numbers.Count - 1])+
                (Numbers[Numbers.Count - 2])+
                (Numbers[Numbers.Count - 3] ))% 3 == 0)
            {
                return true;
            }
            else return false;
        }
    }
}
