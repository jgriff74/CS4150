using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Mr_Anaga
    {
        static void Main(string[] args)
        {
            string[] number_of_words_letters = Console.ReadLine().Split(' ');

            //get the n (number of words) and k (number of letters) out of the file
            int number_of_words = Convert.ToInt32(number_of_words_letters[0]);
            int number_of_letters = Convert.ToInt32(number_of_words_letters[1]);

            if ((number_of_words < 1 || number_of_words > 10000) && (number_of_letters < 1 || number_of_letters > 1000))
            {
                throw new System.IO.IOException();
            }

            List<string> solution = new List<string>();
            List<string> rejected = new List<string>();
            int number_tracker = number_of_words;
            while(--number_of_words >= 0)
            {
                string sorted_word = String.Concat(Console.ReadLine().OrderBy(c => c));   //order the word

                if(solution.Contains(sorted_word))
                {
                    solution.Remove(sorted_word);
                    rejected.Add(sorted_word);
                }
                else if(!rejected.Contains(sorted_word))
                {
                    solution.Add(sorted_word);
                }
            }

            if(solution.Count > number_tracker)
            {
                Console.WriteLine(solution.Count);
                Console.Read();
            }
            else
            {
                Console.WriteLine(solution.Count);
                Console.Read();
            }

        }
    }
}
