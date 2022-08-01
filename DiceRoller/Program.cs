public class DiceRoller
{
    Random random = new Random();

    /*
     * Goal: Return a random value of a 6 sided die
     */
    public int Roll1()
    {
        
    }

    /*
     * Goal: Return a random value of a x sided die
     * Example: A 10 is inputed into this method, the output will be a number between 1 and 10
     */
    public int Roll1(int numbersOnDice)
    {
        
    }

    /*
     * Goal: Return a random value of 2 6 sided dice added together
     * Example: The output will be a number between 2 and 12.
     * Note: Make sure to roll 2 dice and add them together to get the proper distribution of numbers.
     */
    public int Roll2()
    {
        
    }

    /*
     * Goal: Return a random value of 2 x sided dice added together
     * Example:  A 10 is inputed into this method, The output will be a number between 2 and 20.
     * Note: Make sure to roll 2 dice and add them together to get the proper distribution of numbers.
     */
    public int Roll2(int numbersOnDice)
    {
        
    }

    /*
     * Goal: Return a random value of x, y sided dice added together
     * To Do: Write out at the start of the function- Start rolling x dy. For each die roll write to the console- You rolled a x on a dy. Where x and y are the inputed values to the method.
     * Example:  3, 10 is inputed into this method, The output will be a number between 3 and 30.
     * Note: Make sure to roll dice separetly and add them together to get the proper distribution of numbers. You will need to use a loop to roll an inputed number of dice.
     */
    public int Roll(int numberOfDice, int numbersOnDice)
    {
        
    }

    static void Main(string[] args)
    {
        DiceRoller diceRoller = new DiceRoller();
        Console.WriteLine("You Roll " + diceRoller.Roll1() + " on 1 d6.");
        Console.WriteLine("You Roll " + diceRoller.Roll1(8) + " on 1 d8.");
        Console.WriteLine("You Roll " + diceRoller.Roll2() + " on 2 d6.");
        Console.WriteLine("You Roll " + diceRoller.Roll2(20) + " on 2 d20.");
        Console.WriteLine("You Roll " + diceRoller.Roll(10, 6) + " on 10 d6.");
    }
}