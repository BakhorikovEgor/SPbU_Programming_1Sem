
using System.Linq;
namespace BinaryRepresentation
{
    class Programm
    {
        static void Main()
        {
            Console.WriteLine(Keys(3));

        }

        public static IEnumerable<string> Keys(int n)
        {
            for(int i = 0; i < n; i++)
            {
                yield return i.ToString();
            }
        }

    }
    public class BinaryShiftNumbers
    {
        readonly int inputNumber;
        readonly int inputPlusPart;
        readonly int inputSign;
        public BinaryShiftNumbers(int number)
        {
            inputNumber = number;
            inputPlusPart = Math.Abs(number);

            if (number >= 0) inputSign = 1;
            else inputSign = -1;

        }

        public int[] OneByteChangeBuilder(int cursor = 0)
        {

            int[] result = new int[(Convert.ToString(inputPlusPart,2)).Length];
            int index = 0;
            while ((1 << cursor) - inputPlusPart <= 0 || (inputNumber == 0 && cursor == 0))
            {
                result[index] = inputSign * (inputPlusPart ^ (1 << cursor)) ;
                index++;
                cursor++;
            }
            return result;
        }


    }
}