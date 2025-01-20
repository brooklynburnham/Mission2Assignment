namespace Mission2Assignment;

internal class Program
{
    private static void Main(string[] args)
    {
        int numRolls = 0;

        Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        numRolls = int.Parse(System.Console.ReadLine());

        DiceRoller roller = new DiceRoller();
        int[] results = roller.RollDice(numRolls);

        System.Console.WriteLine("ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + numRolls + ".");

// get histogram and %
        for (int i = 2; i <= 12; i++)
        {
            int percentage = (int)((results[i] / (double)numRolls) * 100);
            System.Console.WriteLine($"{i}: ");
            System.Console.WriteLine(new string('*', percentage));
        }

        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

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
