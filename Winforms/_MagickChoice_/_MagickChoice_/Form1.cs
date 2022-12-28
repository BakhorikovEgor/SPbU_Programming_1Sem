using System;
using System.Windows.Forms;

namespace _MagickChoice_
{
    public partial class _Magick_Choice_ : Form
    {
        public _Magick_Choice_()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int last = int.Parse(last_number.Text);
            int answer = int.Parse(this.number.Text);
            int chances = int.Parse(attemps_number.Text);
            if (chances == 3) answer = rand.Next(0, 10);
            if (!int.TryParse(main_field.Text, out int _))
            {
                select.Text = "Wrong format !";
                main_field.Clear();
                return;
            }
            this.number.Text = answer.ToString();
            int choice = int.Parse(main_field.Text);
            if (choice < 10 && choice >= 0)
            {
                string comparison = Check(choice, answer,last,chances);
                main_field.Clear();
                if (comparison == "You win !")
                {
                    select.Text = comparison;
                    attemps_number.Text = "3";
                    played_number.Text = (int.Parse(played_number.Text) + 1).ToString();
                    wins_number.Text = (int.Parse(wins_number.Text) + 1).ToString();
                    last_number.Text = "0";
                }
                else if (comparison.Substring(0,4) == "Your")  select.Text = comparison; 
                else
                {
                    if (chances == 1)
                    {
                        played_number.Text = (int.Parse(played_number.Text) + 1).ToString();
                        attemps_number.Text = "3";
                        select.Text = "Try again !";
                        last_number.Text = "0";
                    }
                    else
                    {
                        select.Text = comparison;
                        attemps_number.Text = (chances - 1).ToString();
                        last_number.Text = choice.ToString();
                    }
                }
                if (int.Parse(wins_number.Text) > 0)
                {
                    float a = float.Parse(wins_number.Text);
                    float b = float.Parse(played_number.Text);
                    float c = a/b;
                        
                    winrate_number.Text = (Convert.ToInt32(c*100)).ToString();
                }
            }
            else
            {
                select.Text = "Wrong format !";
            }
        }

        static string Check(int choice, int rand,int last,int chances)
        {
            if (choice == rand) return "You win !";

            if (choice>rand && last <=choice && last>rand&&chances != 3) return string.Format("Your attemp must be in range (0,{0}) !",last-1);
            if (choice < rand && last >=choice && last<rand && chances != 3) return string.Format("Your attemp must be in range ({0},9) !",last+1);

            if (choice>rand && last<rand && chances!=3) return string.Format("The answer is in range ({0},{1}) !",last+1,choice - 1);
            if (choice < rand && last > rand && chances != 3) return string.Format("The answer is in range ({0},{1}) !", choice+1, last - 1);

            if (choice > rand) return string.Format("The answer is in range (0,{0}) !", choice - 1);
            return string.Format("The answer is in range ({0},9) !", choice+1);
        }

        private void _Magick_Choice__Load(object sender, EventArgs e)
        {

        }
    }
}
