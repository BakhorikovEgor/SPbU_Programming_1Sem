
namespace Beads.Tests
{
    [TestClass]
    public class BeadsCombsBuilderTest
    {


        [TestMethod]
        public void HowManyBeads_R1B1G1L1_Return3() 
        {
            uint redBeads = 1;
            uint blueBeads = 1;
            uint greenBeads = 1;
            uint beadsLenght = 1;
            uint expected = 3;
            BeadsBuilder beads = new BeadsBuilder(redBeads, blueBeads, greenBeads,beadsLenght);

            uint actual = beads.GetNumber();
            
            Assert.AreEqual(expected, actual,"Standart test failed");
        }

        [TestMethod]
        public void HowManyBeads_R1B2G3L6_Return18()
        {
            uint redBeads = 1;
            uint blueBeads = 2;
            uint greenBeads = 3;
            uint beadsLenght = 6;
            uint expected = 18;
            BeadsBuilder beads = new BeadsBuilder(redBeads, blueBeads, greenBeads,beadsLenght);

            uint actual = beads.GetNumber();

            Assert.AreEqual(expected, actual,"Standart test failed");
        }

        [TestMethod]
        public void HowManyBeads_R1B2G3L3_Return13()
        {
            uint redBeads = 1;
            uint blueBeads = 2;
            uint greenBeads = 3;
            uint beadsLenght = 3;
            uint expected = 13;
            BeadsBuilder beads = new BeadsBuilder(redBeads, blueBeads, greenBeads, beadsLenght);

            uint actual = beads.GetNumber();

            Assert.AreEqual(expected, actual, "Standart test failed");
        }

        [TestMethod]
        public void HowManyBeads_R2B1G1L4_Return0()
        {
            uint redBeads = 2;
            uint blueBeads = 1;
            uint greenBeads = 1;
            uint beadsLenght = 4;
            uint expected = 0;
            BeadsBuilder beads = new BeadsBuilder(redBeads, blueBeads, greenBeads, beadsLenght);

            uint actual = beads.GetNumber();

            Assert.AreEqual(expected, actual,"RedPosition test failed");
        }



        [TestMethod]
        public void HowManyBeads_R0B1G1L1_Return2()
        {
            uint redBeads = 0;
            uint blueBeads = 1;
            uint greenBeads = 1;
            uint beadsLenght = 2;
            uint expected = 2;
            BeadsBuilder beads = new BeadsBuilder(redBeads, blueBeads, greenBeads, beadsLenght);

            uint actual = beads.GetNumber();

            Assert.AreEqual(expected, actual,"One empty number test failed");
        }

        [TestMethod]
        public void HowManyBeads_R0B0G1L1_Return1()
        {
            uint redBeads = 0;
            uint blueBeads = 0;
            uint greenBeads = 1;
            uint beadsLenght = 1;
            uint expected = 1;
            BeadsBuilder beads = new BeadsBuilder(redBeads, blueBeads, greenBeads,beadsLenght);

            uint actual = beads.GetNumber();

            Assert.AreEqual(expected, actual,"Two empty numbers test failed");
        }

        [TestMethod]
        public void HowManyBeads_R0B0G0L0_Return0()
        {
            uint redBeads = 0;
            uint blueBeads = 0;
            uint greenBeads = 0;
            uint beadsLenght = 0;
            uint expected = 0;
            BeadsBuilder beads = new BeadsBuilder(redBeads, blueBeads, greenBeads,beadsLenght);

            uint actual = beads.GetNumber();

            Assert.AreEqual(expected, actual,"All empty numbers test failed");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void HowManyBeads_LenghtMoreThanBeads_ThrowExeption()
        {
            uint redBeads = 0;
            uint blueBeads = 0;
            uint greenBeads = 0;
            uint beadsLenght = 1;
            BeadsBuilder beads = new BeadsBuilder(redBeads, blueBeads, greenBeads, beadsLenght); //сразу в конструкторе появилась ошибка

        }




















    }
}