namespace Matrixes
{


    class Program
    {
        static void Main()
        {
        }
    }

    public class MatrixBuilder
    {
        private int[,] matrix;
        public MatrixBuilder(int[,] matrix)
        {
            this.matrix = matrix;
        }
        public int[,] GetTurnedMatrix()
        {

            int lenght = (matrix.GetLength(1));

            if (matrix.GetLength(0)!=matrix.GetLength(1) || matrix.GetLength(0)<3 || matrix.GetLength(0) % 2 == 0) 
            {
                throw new ArgumentOutOfRangeException();
            }

            int[,] tmp = new int[lenght, lenght];

            for (int i = 0; i < lenght; i++)
                for (int j = 0; j < lenght; j++)
                {
                    if (i == j || (i + j) == lenght - 1)
                        tmp[i, j] = matrix[i, j];
                    else
                        tmp[j, lenght - i - 1] = matrix[i, j];
                }
            return tmp;

        }
    }
}