namespace Test2
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
        public void Roll2Blank()
        {
            bool pass = true;

            for (int i = 0; i < 1000; i++)
            {
                int rollNum = dR.Roll2();
                if (rollNum < 2 || rollNum > 12) pass = false;
            }

            if (pass) Assert.Pass();
            else Assert.Fail("Returned value from Roll2() has fallen outside of acceptable bounds");
        }

        [Test]
        public void Roll2BlankContent()
        {
            bool two = false;
            bool twelve = false;

            for (int i = 0; i < 10000; i++)
            {
                int rollNum = dR.Roll2();
                if (rollNum == 2) two = true;
                if (rollNum == 12) twelve = true;
            }

            if (two && twelve) Assert.Pass();
            else Assert.Fail("Returned value from Roll2() has not reached both ends of the expected values.");
        }

        [Test]
        public void Roll2Filled()
        {
            bool pass = true;
            bool high = false;
            bool low = false;
            int diceFaces = rand.Next(1, 100);

            for (int i = 0; i < 100000; i++)
            {
                int rollNum = dR.Roll2(diceFaces);
                if(rollNum < 2 || rollNum > (2*diceFaces)) pass = false;
                if(rollNum == 2) low = true;
                if (rollNum == (2 * diceFaces)) high = true;
            }

            if (pass && low && high) Assert.Pass();
            else Assert.Fail("Returned value from Roll2(input) has not reached both ends of the expected values or has fallen outside of exceptable parameters.");
        }
    }
}