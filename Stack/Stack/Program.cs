
using System.Xml.Linq;

namespace Stacks
{
    class Program
    {
        static void Main()
        {
        }
    }

    public class Stack
    {
        private readonly int StackMaxLenght;
        private int TemporaryStackLenght = 0;
        private int[] stack;

        public Stack(int lenght)
        {
            StackMaxLenght = lenght;
            stack = new int[lenght];
        }

        public int CurrentStackSize
        {
            get
            {
                return TemporaryStackLenght;
            }
        }

        public int Push(int element)
        {
            if (TemporaryStackLenght < StackMaxLenght)
            {
                stack[TemporaryStackLenght] = element;
                TemporaryStackLenght++; ;

                return 1;
            }
            throw new InvalidOperationException();

        }

        public int Pop()
        {
            if (TemporaryStackLenght != 0)
            {
                TemporaryStackLenght--;
                return 1;
            }
            throw new InvalidOperationException();
        }

        public int Peek()
        {
            if (TemporaryStackLenght == 0)
            {
                throw new InvalidOperationException();
            }
            return stack[TemporaryStackLenght-1];
        }

    }
}