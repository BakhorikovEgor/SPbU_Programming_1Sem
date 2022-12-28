
namespace Magic_Choice
{
    public partial class MagickChoice : Form
    {
        public MagickChoice()
        {
            InitializeComponent();
        }

        GameLogick game = new GameLogick();
        private string result;
        private int UserAttemp;

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)          
            {
                if (int.TryParse(UserAttempField.Text, out UserAttemp) &&
                                (game.GetMinValue <= UserAttemp) &&
                                (UserAttemp <= game.GetMaxValue))
                {
                    result = game.CheckAttempt(UserAttemp);
                }

                else
                {
                    result = $"Input must be NUMBER in range({game.GetMinValue},{game.GetMaxValue}) !!!";
                }
                ChangeFormObjects(result);
            }
        }
        private void ChangeFormObjects(string result)
        {
            RemainingAttemps.Text = $"Remaining attemps: {game.GetAvailableAttemps}";
            MainInfoLabel.Text = result;
            PlayedGamesNumber.Text = $"Played: {game.GetNumberofPlayed}";
            WonGamesNumber.Text = $"Wins: {game.GetNumberOfWins}";
            UserAttempField.Clear();
        }
    }
}