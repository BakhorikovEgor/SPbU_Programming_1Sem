
using Matrixes;

namespace Matrix.Tests
{
    [TestClass]
    public class MatrixTurnTests
    {
        [TestMethod]
        public void GetTurnedMartix_InOrder()
        {
            int[,] tempMatrix = { { 1, 2, 3 },
                                  { 4, 5, 6 },
                                  { 7, 8, 9 }};

            int[,] expected =   { { 1, 4, 3 },
                                  { 8, 5, 2 },
                                  { 7, 6, 9 }};
            bool equality = true;
            MatrixBuilder matrix = new(tempMatrix);


            int[,] actual = matrix.GetTurnedMatrix();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (expected[i, j] != actual[i, j])
                    {
                        equality = false;
                        break;
                    }
                    if (!equality) break;
                }
            }

            Assert.IsTrue(equality);

            //Assert.IsTrue(Enumerable.SequenceEqual(actual.Cast<int>().ToArray(), expected.Cast<int>().ToArray()));

        }


        [TestMethod]
        public void GetTurnedMartix_FiveInALine()
        {
            int[,] tempMatrix = { {1,  2,  3,  4,  5},
                                  {6,  7,  8,  9,  10 },
                                  {11, 12, 13, 14, 15},
                                  {16, 17, 18, 19, 20},
                                  {21, 22, 23, 24, 25} };

            int[,] expected = { {1,  16,  11,  6,  5},
                                {22,  7,  12,  9,  2 },
                                {23, 18,  13, 8, 3},
                                {24, 17, 14, 19, 4},
                                {21, 20, 15, 10, 25} };

            bool equality = true;
            MatrixBuilder matrix = new(tempMatrix);


            int[,] actual = matrix.GetTurnedMatrix();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (expected[i, j] != actual[i, j])
                    {
                        equality = false;
                        break;
                    }
                    if (!equality) break;
                }
            }

            Assert.IsTrue(equality);

        }


        [TestMethod]
        public void GetTurnedMartix_SameValues()
        {
            int[,] tempMatrix = { { 0, 0 ,0},
                                  { 0, 0 ,0 },
                                  { 0, 0 ,0 }};

            int[,] expected =   { { 0, 0 ,0},
                                  { 0, 0 ,0 },
                                  { 0, 0 ,0 }};


            bool equality = true;
            MatrixBuilder matrix = new(tempMatrix);


            int[,] actual = matrix.GetTurnedMatrix();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (expected[i, j] != actual[i, j])
                    {
                        equality = false;
                        break;
                    }
                    if (!equality) break;
                }
            }

            Assert.IsTrue(equality);

        }

        [TestMethod]
        public void GetTurnedMartix_SameDiagoanls()
        {
            int[,] tempMatrix = { { 3, 4 ,3},
                                  { 2, 3 ,6 },
                                  { 3, 8 ,3 }};

            int[,] expected =   { { 3, 2 ,3},
                                  { 8, 3 ,4 },
                                  { 3, 6 ,3 }};


            MatrixBuilder matrix = new(tempMatrix);


            int[,] actual = matrix.GetTurnedMatrix();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i,j]);
                }
            }

        }

        [TestMethod]
        public void GetTurnedMartix_SameButNotDiagonals()
        {
            int[,] tempMatrix = { { 1, 9 ,4},
                                  { 9, 2 ,9 },
                                  { 5, 9 ,3 }};

            int[,] expected =   { { 1, 9 ,4},
                                  { 9, 2 ,9 },
                                  { 5, 9 ,3 }};


            bool equality = true;
            MatrixBuilder matrix = new(tempMatrix);


            int[,] actual = matrix.GetTurnedMatrix();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (expected[i, j] != actual[i, j])
                    {
                        equality = false;
                        break;
                    }
                    if (!equality) break;
                }
            }

            Assert.IsTrue(equality);

        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetTurnedMartix_DimMod2_ThrowExeption()
        {
            int[,] tempMatrix = { { 2,  12 , 8,  18},
                                  { 6,  19 , 7,  5  },
                                  { 14, 11 , 3 , 13},
                                  { 1,  4 ,  15, 17 } };
            MatrixBuilder matrix = new(tempMatrix);

            matrix.GetTurnedMatrix();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetTurnedMartix_DifDims_ThrowExeption()
        {
            int[,] tempMatrix = { { 1, 2, 3 } };
            MatrixBuilder matrix = new(tempMatrix);

            matrix.GetTurnedMatrix();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetTurnedMartix_DimSmaller3_ThrowExeption()
        {
            int[,] tempMatrix = { { 1, 2 },
                                  { 3, 4 }};
            MatrixBuilder matrix = new(tempMatrix);

            matrix.GetTurnedMatrix();
        }
    }
}