

namespace Sequences
{
    class Programm
    {
        static void Main()
        {
        }
    }
    
    public class MorzTueSequence
    {
        private uint lenght;
        public MorzTueSequence(uint l)
        {
            lenght = l;
        }

        public string Build()
        {
            if (lenght == 0) return "";


            System.Text.StringBuilder output = new System.Text.StringBuilder("0");
            int counter = 0; int count = GetPower((int)lenght);

            while (counter != count)
            {
                System.Text.StringBuilder tmp = new System.Text.StringBuilder("");
                for (int i = 0; i < output.Length; i++)
                {
                    if (output[i] == '1') tmp.Append("10");
                    else tmp.Append("01");
                }
                output = tmp;
                counter++;
            }
            return output.ToString().Substring(0,(int)lenght);

        }
        static int GetPower(int lenght)
        {
            int op = 1;
            while (Math.Pow(2, op) <= lenght) op++;
            return op;
        }
    }
}