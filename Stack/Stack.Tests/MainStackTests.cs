


namespace Stacks.Tests
{
    [TestClass]
    public class MainStackTests
    {

        [TestMethod]
        public void PushAndPeek_BigDataTest_StackLenght100000()
        {
            int stackLenght = 100000;
            Stack stack = new Stack(stackLenght);

            for (int i = 0; i < stackLenght; i++)
            {
                int expected = i;
                stack.Push(i);

                int actual = stack.Peek();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void PopAndPeekAfterPush_BigDataTest_StackLenght100000000()
        {
            int stackLenght = 100000000;
            Stack stack = new Stack(stackLenght);

            for (int i = 0; i < stackLenght; i++)
            {
                stack.Push(i);
            }

            for (int i = stackLenght - 1; i > 0; i--)
            {
                int expected = i - 1;
                stack.Pop();

                int actual = stack.Peek();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void CurrentStackSizeDurindPush_BigDataTest_StackLenght100000()
        
        {
            int stackLenght = 100000;
            Stack stack = new Stack(stackLenght);

            for (int i = 0; i < stackLenght; i++)
            {
                int expected = i+1;
                stack.Push(i);

                int actual = stack.CurrentStackSize;

                Assert.AreEqual(expected, actual);
            }


        }
        
        [TestMethod]
        public void PushPeek_Push5_PeekReturn5()
        {
            int stackLenght = 1;
            int addition = 5;
            int expected = 5;
            Stack stack = new Stack(stackLenght);

            stack.Push(addition);
            int actual = stack.Peek();

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void PushPopPeek_1InStack_Push5_Pop_PeekReturn1()
        {
            int stackLenght = 2;
            int expected = 1;
            Stack stack = new Stack(stackLenght);
            stack.Push(1);
            stack.Push(5);
            stack.Pop();

            int actual = stack.Peek();

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void PushCurrentStackSize_Push1Element_Return1()
        {
            int stackLenght = 1;
            int expected = 1;
            Stack stack = new Stack(stackLenght);
            stack.Push(5);

            int actual = stack.CurrentStackSize;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PushPopCurrentStackSize_Push5_Push2_Pop_Return1()
        {
            int stackLenght = 2;
            int expected = 1;
            Stack stack = new Stack(stackLenght);
            stack.Push(5);
            stack.Push(2);
            stack.Pop();

            int actual = stack.CurrentStackSize;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CurrentStackSizeOfEmptyStack_Return0()
        {
            int stackLenght = 1;
            int expected = 0;
            Stack stack = new Stack(stackLenght);

            int actual = stack.CurrentStackSize;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PopToEmptyStack_GetExeption()
        {
            int stackLenght = 1;
            Stack stack = new Stack(stackLenght);

            stack.Pop();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PeekEmptyStack_GetExeption()
        {
            int stackLenght = 1;
            Stack stack = new Stack(stackLenght);

            stack.Peek();
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PushWithoutSpace_GetExeption()
        {
            int stackLenght = 1;
            Stack stack = new Stack(stackLenght);
            stack.Push(5);

            stack.Push(6);
        }
    }
}