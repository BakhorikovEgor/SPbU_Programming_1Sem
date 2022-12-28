
namespace Magick.Tests
{
    [TestClass]
    public class MagickSquareTests
    {

        [TestMethod]
        public void CheckAllMagickSquares_Central_1To9Without5_Result_Nothing()
        {
            for (int cetralNumber = 1; cetralNumber < 10; cetralNumber++)
            {
                if (cetralNumber != 5)
                {
                    MagickSquare square = new MagickSquare(cetralNumber);
                    int[] expected = Array.Empty<int>();
                    int[][] actual = square.GetMagickSquares();

                    Assert.IsTrue(actual.Contains(expected), $"{cetralNumber} in centre test failed");

                }
            }
        }

        [TestMethod]
        public void CheckAllMagickSquares_Central_5_Result_SomeSquares()
        {
            int cetralNumber = 5;
            MagickSquare square = new MagickSquare(cetralNumber);
            int[] expected = {4, 3, 8,
                              9, 5, 1,
                              2, 7, 6};

            bool isContais = false;

            foreach (int[] OneSquare in square.GetMagickSquares())
            {
                isContais = true;
                for(int i = 0; i < 9; i++)
                {
                    if (expected[i] != OneSquare[i])
                    {
                        isContais = false;
                        break;
                    }
                }
                if (isContais) break;
            }
            Assert.IsTrue(isContais,$"{cetralNumber} in centre test failed");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckAllMagickSquares_Central_11_ThrowExeption()
        {
            int cetralNumber = 11;
            MagickSquare square = new MagickSquare(cetralNumber);

            square.GetMagickSquares();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckAllMagickSquares_Central_0_ThrowExeption()
        {
            int cetralNumber = 0;
            MagickSquare square = new MagickSquare(cetralNumber);

            square.GetMagickSquares();
        }
    }
}