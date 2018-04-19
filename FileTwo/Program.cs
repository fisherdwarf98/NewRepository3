using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please give me a sentence");
            //string sentence = Console.ReadLine();


            //String Split
            //string[] words = sentence.Split(" ".ToArray());

            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}


            //String Empty
            //string empty = string.Empty;

            //if (empty.Equals(""))
            //{
            //    Console.WriteLine("Empty string");
            //}
            //else
            //{
            //    Console.WriteLine($"Your string has {empty} as value");
            //}
            string dayOfWeek = "Tuesday";
            string date = DateTime.Now.ToShortDateString();
            string full = string.Join(" ", dayOfWeek, date);

            string.Concat(full);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
