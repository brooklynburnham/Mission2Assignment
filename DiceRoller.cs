using System;

namespace Mission2Assignment
{
    public class DiceRoller
    {
        public int[] RollDice(int numRolls)
        {
            int[] results = new int[13]; // Array indices 2-12 will be used

            Random r = new Random();
            for (int i = 0; i < numRolls; i++)
            {
                int num1 = r.Next(1, 7); // Random number between 1 and 6
                int num2 = r.Next(1, 7); // Random number between 1 and 6
                int sum = num1 + num2;
                results[sum]++;
            }
            return results;
        }
    }
}



// layout
// keep track of roll, list how results came out
// 1. ask user how many times to roll
// 2. get their input
// for 'user input' then 
// 3. roll die 1 and collect result 
// 4. roll die 2 and collect result
// 5. add together and store result
// 6. for each number possible to be rolled
// print the number 
// calculate the % of times it was rolled
// print an asterisk for each % it was rolled
