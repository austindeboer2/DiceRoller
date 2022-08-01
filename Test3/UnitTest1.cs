namespace Test3
{
    public class Tests
    {
        DiceRoller dR;
        Random rand;
        [SetUp]
        public void Setup()
        {
            dR = new DiceRoller();
            rand = new Random();
        }

        [Test]
        public void RollTest()
        {
            int numDice = rand.Next(1, 5);
            int numFaces = rand.Next(1, 20);

            bool pass = true;
            bool high = false;
            bool low = false;

            for(int i = 0; i < 1000000; i++)
            {
                int roll = dR.Roll(numDice, numFaces);
                if (roll < (numDice) || (roll > (numDice * numFaces))) pass = false;
                if (roll == numDice) low = true;
                if (roll == (numDice * numFaces)) high = true;
            }

            if (pass && low && high) Assert.Pass();
            else Assert.Fail("Returned value from Roll(input, input) has not reached both ends of the expected values or has fallen outside of exceptable parameters.");
        }
    }
}