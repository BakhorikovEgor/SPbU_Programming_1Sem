
namespace Beads
{
    class Programm
    {
        static void Main()
        {
            BeadsBuilder bb = new(1, 1, 1, 2);
            Console.WriteLine(bb.GetNumber());
        }

    }
    public class BeadsBuilder
    {
        private uint redBeads;
        private uint blueBeads;
        private uint greenBeads;
        readonly uint lastBeads;
        enum BeadNumber { Red, Blue, Green };


        public BeadsBuilder(uint redBeads, uint blueBeads, uint greenBeads,uint beadsLenght)
        {
            this.redBeads = redBeads;
            this.blueBeads = blueBeads;
            this.greenBeads = greenBeads;
            if (redBeads + blueBeads + greenBeads < beadsLenght)
            {
                throw new ArgumentOutOfRangeException();
            }
            lastBeads = (redBeads + blueBeads + greenBeads) - beadsLenght;
        }

        public uint GetNumber(int redMinus = 0, int blueMinus = 0, int greenMinus = 0,
                             int position = 1, int lastBeadNumber = -1)
        {
            if (redBeads - redMinus == -1 || blueBeads - blueMinus == -1 || greenBeads - greenMinus == -1)
            {
                return 0;
            }

            if ( (redBeads - redMinus) + (blueBeads - blueMinus) + (greenBeads - greenMinus) == lastBeads && position != 1)
            {
                return 1;
            }

            if (position % 2 == 0)
            {
                if (lastBeadNumber == (byte)BeadNumber.Red)
                {
                    return GetNumber(redMinus, blueMinus, greenMinus + 1, position + 1, (byte)BeadNumber.Green);
                }
                return GetNumber(redMinus, blueMinus + 1, greenMinus,     position + 1, (byte)BeadNumber.Blue) +
                       GetNumber(redMinus, blueMinus,     greenMinus + 1, position + 1, (byte)BeadNumber.Green);
            }
            //нечётные позиции
            return GetNumber(redMinus+1, blueMinus,     greenMinus,   position + 1, (byte)BeadNumber.Red) +
                   GetNumber(redMinus,   blueMinus + 1, greenMinus,   position + 1, (byte)BeadNumber.Blue) +
                   GetNumber(redMinus,   blueMinus,     greenMinus+1, position + 1, (byte)BeadNumber.Green);
        }
    }
}

