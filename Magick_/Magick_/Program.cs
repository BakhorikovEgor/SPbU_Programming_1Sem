
namespace Magick
{

    class Program
    {
        static void Main()
        {
            MagickSquare square = new(5);
            int count = 0;
            Console.WriteLine(new int[] { 1, 2, 3 } == new int[] {1,2,3});
            
        }

    }

    public class MagickSquare
    {

        const int MagickConst = 15; //  (n(n^-1) / 2)
        static int centralNumber;
        private List<int[]> goodSquares = new List<int[]>();
        static SquareNumbers square = new SquareNumbers();

        private struct SquareNumbers
        {
            public int First { get; private set; }
            public int Second { get; private set; }
            public int Third { get; private set; }
            public int Fourth { get; private set; }
            public int Fifth { get; private set; }
            public int Sixth { get; private set; }
            public int Seventh { get; private set; }
            public int Eight { get; private set; }
            public int Ninth { get; private set; }

            public void SetAllValues(int[] PermutationElements)
            {
                First = PermutationElements[0];
                Second = PermutationElements[1];
                Third = PermutationElements[2];
                Fourth = PermutationElements[3];
                Fifth = centralNumber;
                Sixth = PermutationElements[4];
                Seventh = PermutationElements[5];
                Eight = PermutationElements[6];
                Ninth = PermutationElements[7];
            }
        }

        public MagickSquare(int c)
        {
            centralNumber = c;
            
        }

        public int[][] GetMagickSquares()
        {

            if (!(centralNumber<10) || !(centralNumber > 0))
            {
                throw new ArgumentOutOfRangeException();
            }

            int[] ElementsForPermutation = new int[8];
            int index = 0;
            for (int i = 1; i != 10; i++)
            {
                if (i != centralNumber)
                {
                    ElementsForPermutation[index] = i;
                    index++;
                }
            }


            GetAndCheckPermutations(ElementsForPermutation, 8);
            if (goodSquares.Count == 0) 
            {
                return new int[][] {Array.Empty<int>()};
            }
            return goodSquares.ToArray();

        }

        private void GetAndCheckPermutations(int[] PermutationElements, int PermutationLenght)
        {
            if (PermutationLenght < 2 && PermutationCheck(PermutationElements))
            {
                goodSquares.Add(new int[] {square.First,square.Second,square.Third,
                                           square.Fourth,square.Fifth,square.Sixth,
                                           square.Seventh,square.Eight,square.Ninth });
            }
            else
            {
                for (int j = PermutationLenght - 1; j >= 0; j--)
                {
                    int temp = PermutationElements[j];
                    PermutationElements[j] = PermutationElements[PermutationLenght - 1];
                    PermutationElements[PermutationLenght - 1] = temp;

                    GetAndCheckPermutations(PermutationElements, PermutationLenght - 1);

                    PermutationElements[PermutationLenght - 1] = PermutationElements[j];
                    PermutationElements[j] = temp;
                }
            }
        }

        static bool PermutationCheck(int[] permutation)
        {

            square.SetAllValues(permutation);
            return square.First + square.Second + square.Third == MagickConst &&
                   square.Fourth + square.Fifth + square.Sixth == MagickConst &&
                   square.Seventh + square.Eight + square.Ninth == MagickConst &&

                   square.First + square.Fourth + square.Seventh == MagickConst &&
                   square.Second + square.Fifth + square.Eight == MagickConst &&
                   square.Third + square.Sixth + square.Ninth == MagickConst &&

                   square.First + square.Fifth + square.Ninth == MagickConst &&
                   square.Third + square.Fifth + square.Seventh == MagickConst;
        }

    }
}