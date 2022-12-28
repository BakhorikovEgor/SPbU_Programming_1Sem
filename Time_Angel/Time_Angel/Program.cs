
namespace Time
{
    class Program
    {
        static void Main()
        {
        }
    }

    public class TimeByAngle
    {
        private int hours;
        private int minutes;
        private int finallAngle;
        private StartAngles angles; // углы между часовой и минутной стрелкой

        const double OneMinuteTurn = 5.5; // насколько меняется угол между стрелками за минуту
        const int FullTurn = 360; // полный оборот
        const int MinuteSectionAngle = 6; // сколько градусов занимается минутный сектор 
        const int HourSectionAngle = 30; // скольско градусов занимает часовой сектор
        private struct StartAngles
        {
            public double FirstAngle;
            public double SecondAngle;

            public StartAngles(double[] angles)
            {
                FirstAngle = angles[0];
                SecondAngle = angles[1];
            }
        }

        public TimeByAngle(int h,int m,int angle)
        {
            if (h < 0 || m < 0)
            {
                hours = -1;
                minutes = -1;
            }

            hours = (h + (m / 60))%24;
            minutes = m%60;
            finallAngle = angle;
            angles = new StartAngles(GetStartAngles(hours, minutes));
        }

        public string GetRightTime()
        {
            if (finallAngle>360 || finallAngle < 0 || hours<0 || minutes<0)
            {
                throw new ArgumentOutOfRangeException("Wrond data !");
            }
            int fullMinutes = (hours * 60) + minutes + GetAdditionMinutes(finallAngle, angles);
            return $"{(fullMinutes/60)%24} {fullMinutes%60}";
        }



        static int GetAdditionMinutes(int finallAngle,StartAngles angles)
        {
            int AdditionalMinutes = 0;

            while ((angles.FirstAngle != finallAngle) && (angles.SecondAngle != finallAngle))
            {
                angles.FirstAngle -= OneMinuteTurn;
                angles.SecondAngle += OneMinuteTurn;
                if (angles.SecondAngle >= FullTurn)
                {
                    angles.FirstAngle += FullTurn;
                    angles.SecondAngle -= FullTurn;
                }
                AdditionalMinutes++;
            }
            return AdditionalMinutes;
        }





        static double[] GetStartAngles(int h,int min)
        {
            double angle = (min * MinuteSectionAngle) - HourSectionAngle * (h + (double)min / 60);
            double temp = Math.Abs(angle);

            if (angle < 0)
            {
                return new double[] { temp, 360 - temp };
            }
            return new double[] { 360 - temp, temp };
        }
    }

}