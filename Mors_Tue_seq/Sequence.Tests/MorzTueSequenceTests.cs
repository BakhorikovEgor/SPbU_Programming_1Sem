using Sequences;

namespace Sequence.Tests
{
    [TestClass]
    public class MorzTueSequenceTests
    {
        [TestMethod]
        public void CheckSequence_Lenght1_Return0()
        {
            uint lenght = 1;
            string expected = "0";
            MorzTueSequence sequence = new MorzTueSequence(lenght);

            string actual = sequence.Build();

            Assert.AreEqual(expected, actual,"Lenght 1 test failed");

        }

        [TestMethod]
        public void CheckSequence_Lenght0_ReturnNothing()
        {
            uint lenght = 0;
            string expected = "";
            MorzTueSequence sequence = new MorzTueSequence(lenght);

            string actual = sequence.Build();

            Assert.AreEqual(expected, actual, "Lenght 1 test failed");

        }

        [TestMethod]
        //Переход по разрядам
        public void CheckSequence_Lenght16_Return_0110100110010110()
        {
            uint lenght = 16;
            string expected = "0110100110010110";
            MorzTueSequence sequence = new MorzTueSequence(lenght);

            string actual = sequence.Build();

            Assert.AreEqual(expected, actual, "Lenght 16 test failed");

        }

        [TestMethod]
        //после перехода по разрядам
        public void CheckSequence_Lenght17_Return_01101001100101101()
        {
            uint lenght = 17;
            string expected = "01101001100101101";
            MorzTueSequence sequence = new MorzTueSequence(lenght);

            string actual = sequence.Build();

            Assert.AreEqual(expected, actual, "Lenght 17 test failed");

        }


        [TestMethod]
        //до перехода по разрядам
        public void CheckSequence_Lenght31_Return_0110100110010110100101100110100()
        {
            uint lenght = 31;
            string expected = "0110100110010110100101100110100";
            MorzTueSequence sequence = new MorzTueSequence(lenght);

            string actual = sequence.Build();

            Assert.AreEqual(expected, actual, "Lenght 17 test failed");

        }
    }
}