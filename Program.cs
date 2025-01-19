using System;
using System.Collections.Generic;
namespace ISCAT
{
    class Program
    {
        static void Main()
        {
            Main1();
        }

        static void Main0()
        {
            Console.WriteLine(15 + 20);
            Console.WriteLine(100 % 7);
            Console.WriteLine(Math.Pow(535,353));
            Console.WriteLine(Math.Round(9.8));
        }

        static void Main1()
        {
            List<string> fruits = new List<string>();
            fruits.Add("apple");
            fruits.Add("orange");
            fruits.Add("banana");
            fruits.Add("kiwi");
            fruits.Add("pineapple");
            Console.WriteLine("Name a fruit:");
            fruits.Add(Console.ReadLine());
            Console.WriteLine("-------------------------->");
            for (int i = 0; i < fruits.Count; i++)
            {
                Console.WriteLine(fruits[i]);
            }
            Console.WriteLine("-------------------------->");
            Console.WriteLine("Chose a number to remove the fruit from the list:");
            string x = Console.ReadLine();
            int y = int.Parse(x);
            if (y >= 0 && y <= 5)
            {
                fruits.Remove(fruits[y]);
                for (int i = 0; i < fruits.Count; i++)
                {
                    Console.WriteLine(fruits[i]);
                }
                
            }
            else
            {
                Console.WriteLine("Use the number from 0 to 5");
            }
            
        }
    }
}
