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
 */

namespace RaindropApp
{
    public class Raindrops
    {
        private string Solution { get; set; } = "";
        private Dictionary<int, string> Settings { get; set; } = new Dictionary<int, string>();

        public Raindrops()
        {
            Settings.Add(1, "");
            Settings.Add(3, "Pling");
            Settings.Add(5, "Plang");
            Settings.Add(7, "Plong");
        }

        /// Overload constructor: User Defined factors        
        public Raindrops(Dictionary<int, string> userSettings)
        {
            Settings = userSettings;
        }

        /// Method that returns a sound(string) depending on the factors of the input      
        public string Solve(int inputNum)
        {
            // edge cases: num is 0 and negatives
            if (inputNum == 0) return inputNum.ToString();
            int num = Math.Abs(inputNum);

            for (int possibleFactor = 1; possibleFactor <= num; possibleFactor++)
            {
                if (IsFactor(possibleFactor, num))
                {
                    Solution += GetRaindropSoundOrDefault(possibleFactor);
                }
            }
            return Solution == "" ? inputNum.ToString() : Solution;
        }

        /// helper method to test for factors
        private bool IsFactor(int possibleFactor, int num)
        {
            return num % possibleFactor == 0;
        }

        /// helper method that returns correct sound for a given factor
        private string GetRaindropSoundOrDefault(int num)
        {
            return Settings.ContainsKey(num) ? Settings[num] : "";
        }
    }
}

