
namespace Magic_Choice
{
    internal class GameLogick
    {
        private int MinValue = 0;
        private int MaxValue = 9;
        private int AvailableAttemps = 3;
        private int wins = 0;
        private int played = 0;
        static readonly Random rand = new Random();
        int HiddenNumber = rand.Next(0, 9);

        public int GetNumberOfWins
        {
            get { return wins; }
        }

        public int GetNumberofPlayed
        {
            get { return played; } 
        }

        public int GetMinValue
        {
            get { return MinValue; }
        }

        public int GetMaxValue
        {
            get { return MaxValue; }
        }

        public int GetAvailableAttemps
        {
            get { return AvailableAttemps; }
        }

        protected internal string CheckAttempt(int UserAttempt)
        {
            if (UserAttempt == HiddenNumber)
            { 
                played++; 
                wins++;
                AvailableAttemps = 3;
                MinValue = 0; 
                MaxValue = 9;
                HiddenNumber = rand.Next(0, 9);
                return "Yow win ! \nChose the number in range (0,9)";
            }

            if (AvailableAttemps == 1)
            {
                played++;
                AvailableAttemps = 3;
                MinValue = 0;
                MaxValue = 9;
                HiddenNumber = rand.Next(0, 9);
                return "Chose the number in range (0,9)";
            }

            GameAsistent(UserAttempt);
            AvailableAttemps--;
            return $"The number is in range ({MinValue},{MaxValue})";
        }
        
        private void GameAsistent(int UserAttempt)
        {
            if (HiddenNumber > UserAttempt) MinValue = UserAttempt + 1;
            else MaxValue = UserAttempt - 1;
        }
    }
}
