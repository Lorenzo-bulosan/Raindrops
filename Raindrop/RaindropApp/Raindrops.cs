using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
## Raindrops

Write a function that takes as its input a number (n) and converts it to a string, the contents of which depend on the numbers factors

- if the number has a factor of 3, output 'Pling'
- if the number has a factor of 5, output 'Plang'
- if the number has a factor of 7, output 'Plong'
- if the number does not have any of the above as a factor simply return the numbers digits

## Examples

- 28's factors are 1, 2, 4, 7, 14 and 28: this would be a simple 'Plong'
- 30's factors are 1, 2, 3, 5, 6, 10, 15, 30: this would be a 'PlingPlang'
- 34 has four factors: 1, 2, 17, and 34: this would be '34'

This test can be completed in a language of your choice and should be made available on your Github account in a public repository that does not mention Deloitte. You should write tests to cover your expected range of inputs and outputs. Commit often and document well.

You will be assessed on the quality of your code, functional correctness, and your approach to quality assurance and testing.
 */

namespace RaindropApp
{
    public static  class Raindrops
    {
        
        public static string Solution { get; set; } = "";

        public static Dictionary<int, string> Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string Solve(int upperBound)
        {
            for (int currentNumber = 0; currentNumber < upperBound; currentNumber++)
            {
                
            }
            return Solution;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rainDropSound"></param>
        /// <param name="numToCheck"></param>
        /// <param name="factor"></param>
        /// <returns></returns>
        private static string ReturnStringWhenModZero(string rainDropSound, int numToCheck, int factor)
        {
            return numToCheck % factor == 0  ? rainDropSound : numToCheck.ToString();
        }
    }
}

