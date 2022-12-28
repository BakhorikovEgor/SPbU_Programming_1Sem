
using Time;

namespace RightTime.Tests
{
    [TestClass]
    public class TimeByAngleTests
    {
        [TestMethod]
        public void GetRightTime_Hours0_Minutes0_Angle0_Return0_0()
        {
            int hours = 0;
            int minutes = 0;
            int finallAngle = 0;
            string expected = "0 0";
            TimeByAngle time = new TimeByAngle(hours, minutes, finallAngle);

            string actual = time.GetRightTime();

            Assert.AreEqual(expected, actual,"Time: 0 0 test failed !");     
        }

        [TestMethod]
        public void GetRightTime_Hours0_Minutes30_Angle180_Return0_30()
        {
            int hours = 0;
            int minutes = 30;
            int finallAngle = 165;
            string expected = "0 30";
            TimeByAngle time = new TimeByAngle(hours, minutes, finallAngle);

            string actual = time.GetRightTime();

            Assert.AreEqual(expected, actual, "Time: 1 30 test failed !");
        }


        [TestMethod]
        public void GetRightTime_Hours26_Minutes0_Angle_60_Return2_0()
        {
            int hours = 26;
            int minutes = 0;
            int finallAngle = 60;
            string expected = "2 0";
            TimeByAngle time = new TimeByAngle(hours, minutes, finallAngle);

            string actual = time.GetRightTime();

            Assert.AreEqual(expected, actual, "Time: 26 0 test failed !");
        }

        [TestMethod]
        public void GetRightTime_Hours47_Minutes62_Angle_11_Return0_2()
        {
            int hours = 47;
            int minutes = 62;
            int finallAngle = 11;
            string expected = "0 2";
            TimeByAngle time = new TimeByAngle(hours, minutes, finallAngle);

            string actual = time.GetRightTime();

            Assert.AreEqual(expected, actual, "Time: 47 62 test failed !");
        }

        [TestMethod]
        public void GetRightTime_Hours1_Minutes15_Angle_50_Return2_20()
        {
            int hours = 1;
            int minutes = 15;
            int finallAngle = 50;
            string expected = "2 20";
            TimeByAngle time = new TimeByAngle(hours, minutes, finallAngle);

            string actual = time.GetRightTime();

            Assert.AreEqual(expected, actual, "Time: 1 15 test failed !");
        }

        [TestMethod]
        public void GetRightTime_Hours12_Minutes0_Angle_60_Return12_11()
        {
            int hours = 12;
            int minutes = 0;
            int finallAngle = 60;
            string expected = "12 11";
            TimeByAngle time = new TimeByAngle(hours, minutes, finallAngle);

            string actual = time.GetRightTime();

            Assert.AreEqual(expected, actual, "Time: 1 15 test failed !");
        }




        public void GetRightTime_Hours0_Minutes0_AngleMinus1_Return_Error()
        {
            int hours = 0;
            int minutes = 15;
            int finallAngle = -1;
            string expected = "Error";
            TimeByAngle time = new TimeByAngle(hours, minutes, finallAngle);

            string actual = time.GetRightTime();

            Assert.AreEqual(expected, actual, "Negative angle test failed !");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]// тест пройдет если появится исключение
        public void GetRightTime_Hours0_Minutes0_Angle361_Return_Error()
        {
            int hours = 0;
            int minutes = 15;
            int finallAngle = 361;
            TimeByAngle time = new TimeByAngle(hours, minutes, finallAngle);

            time.GetRightTime();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]// тест пройдет если появится исключение
        public void GetRightTime_HoursMinus2_Minutes0_Angle11_Return_Error()
        {
            int hours = -2;
            int minutes = 0;
            int finallAngle = 11;
            TimeByAngle time = new TimeByAngle(hours, minutes, finallAngle);

            time.GetRightTime();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))] // тест пройдет если появится исключение
        public void GetRightTime_Hours0_MinutesMinus30_Angle165_Return_Error()
        {
            int hours = 0;
            int minutes = -30;
            int finallAngle = 165;
            TimeByAngle time = new TimeByAngle(hours, minutes, finallAngle);

            time.GetRightTime();
        }
    }
}