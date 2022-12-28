

namespace BinaryRepresentation.Tests
{
    [TestClass]
    public class BinaryShiftNumbersTests
    {
        [TestMethod]
        public void CheckOutput_Input1_Output_0()
        {
            int number = 1;
            int[] expected = {0};
            BinaryShiftNumbers numbers = new(number);

            int[] actual = numbers.OneByteChangeBuilder();
            Array.Sort(actual);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }
        [TestMethod]
        public void CorrectNumbersCheck_Input0_Output_1()
        {
            int number = 0;
            int[] expected = {1};
            BinaryShiftNumbers numbers = new(number);

            int[] actual = numbers.OneByteChangeBuilder();
            Array.Sort(actual);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void CorrectNumbersCheck_Input5_Output_1_4_7()
        {
            int number = 5;
            int[] expected = {1,4,7};
            BinaryShiftNumbers numbers = new(number);

            int[] actual = numbers.OneByteChangeBuilder();
            Array.Sort(actual);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void CorrectNumbersCheck_InputMinus3_Output_Minus2_Minus1()
        {
            int number = -3;
            int[] expected = {-2,-1};
            BinaryShiftNumbers numbers = new(number);

            int[] actual = numbers.OneByteChangeBuilder();
            Array.Sort(actual);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void CheckOutput_Input11_Output_3_9_10_15()
        {
            int number = 11;
            int[] expected = {3,9,10,15};
            BinaryShiftNumbers numbers = new(number);

            int[] actual = numbers.OneByteChangeBuilder();
            Array.Sort(actual);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void CheckOutput_Input32_Output_0_33_34_36_40_48_0()
        {
            int number = 32;
            int[] expected = {0,33,34,36,40,48};
            BinaryShiftNumbers numbers = new(number);

            int[] actual = numbers.OneByteChangeBuilder();
            Array.Sort(actual);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void CheckOutput_Input63_Output_31_47_55_59_61_62()
        {
            int number = 63;
            int[] expected = {31,47,55,59,61,62 };
            BinaryShiftNumbers numbers = new(number);

            int[] actual = numbers.OneByteChangeBuilder();
            Array.Sort(actual);

            Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
}