using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Stopwatch s = new Stopwatch();

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

            s.Start();
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
            s.Stop();
            double regular_time = msecs(s);

            s = new Stopwatch();
            s.Start();
            while (--number_tracker >= 0)
            {
                // minus the overhead
            }
            s.Stop();
            double overhead = msecs(s);
            if (solution.Count > number_tracker)
            {
                Console.WriteLine(solution.Count);
                Console.WriteLine(regular_time - overhead);
                Console.Read();
            }
            else
            {
                Console.WriteLine(solution.Count);
                Console.WriteLine(regular_time - overhead);
                Console.Read();
            }
            

        }

        public static double msecs(Stopwatch sw)
        {
            return (((double)sw.ElapsedTicks) / Stopwatch.Frequency) * 1000;
        }
    }
}
