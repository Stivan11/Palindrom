using System;
using System.Linq;
using System.Collections.Generic;

namespace PalindromCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] characters = text.ToCharArray();

            var queue = new Queue<string>(characters.Select(x => x.ToString()));
            var stack = new Stack<string>(characters.Select(x => x.ToString()));

            int count = 0;
            int length = queue.Count();

            foreach (var item in queue)
            {
                if (item == stack.Pop())
                {
                    count++;
                }
            }

            if (count == length)
            {
                Console.WriteLine("Palindrom");
            }
        }
    }
}
