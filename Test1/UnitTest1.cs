namespace Test1
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
        public void Roll1Blank()
        {
            bool pass = true;

            for(int i = 0; i < 1000; i++)
            {
                int rollNum = dR.Roll1();
                if(rollNum < 1 || rollNum > 6) pass = false;
            }

            if (pass) Assert.Pass();
            else Assert.Fail("Returned value from Roll1() has fallen outside of acceptable bounds");
        }

        [Test]
        public void Roll1BlankContent()
        {
            bool one = false;
            bool two = false;
            bool three = false;
            bool four = false;
            bool five = false;
            bool six = false;

            for (int i = 0; i < 10000; i++)
            {
                int rollNum = dR.Roll1();
                if (rollNum == 1) one = true;
                if (rollNum == 2) two = true;
                if (rollNum == 3) three = true;
                if (rollNum == 4) four  = true;
                if (rollNum == 5) five  = true;
                if (rollNum == 6) six = true;
            }

            if (one && two && three && four && five && six) Assert.Pass();
            else Assert.Fail("Your program has not generated all the acceptable numbers for a six sidded die.");
        }

        [Test]
        public void Roll1Filled()
        {
            bool pass = true;
            int dieFaces = rand.Next(1, 100);

            for (int i = 0; i < 10000; i++)
            {
                int rollNum = dR.Roll1(dieFaces);
                if (rollNum < 1 || rollNum > dieFaces) pass = false;
            }

            if (pass) Assert.Pass();
            else Assert.Fail("Returned value from Roll1(dieFaces) has fallen outside of acceptable bounds");
        }
    }
}