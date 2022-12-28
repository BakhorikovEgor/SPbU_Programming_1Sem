
namespace Polygons
{
    class Program
    {
        static void Main() { }

    }

    public struct Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
    }

    public class PolygonFigure
    {
        Point[] points;
        public PolygonFigure(params Point[] points)
        {
            if (points.Length < 3)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.points = points;
        }

        public enum PointLocation
        {
            pointOutPolygon,
            pointBelongsPlygon,
            pointInPolygon
        }

        public PointLocation GetPointLocation(double x, double y)
        {
            int countIntersects = 0;
            for (int i = 1; i <= points.Length; i++)
            {
                Point firstPoint = points[i - 1];
                Point secondPoint = points[i % points.Length];
                // обработка варианта соединения последней точки с первой

                int x1 = firstPoint.X;
                int y1 = firstPoint.Y;
                int x2 = secondPoint.X;
                int y2 = secondPoint.Y;

                if ((double)(x - x1) * (y2 - y1) - (x2 - x1) * (y - y1) == 0 && (double)(x1 - x) * (x2 - x) <= 0)
                {
                    return PointLocation.pointBelongsPlygon;
                }
                // Когда точка попала на отрезок

                if (y1 == y2) continue;
                //прямая вида y = b не не помогает узнать кол-во пересечений!

                else if (y == Math.Min(y1, y2)) continue;
                // пересекли нижнюю вершину, не считаем

                if (y <= Math.Max(y1, y2) && y > Math.Min(y1, y2))
                // пересекаем отрезок лучом 
                // также если y = max y1 y2 считаем при условиии что точка левее прямой(считаем только верхние вершины)
                {
                    if (x1 == x2 && x <= x1) countIntersects++;
                    // пересение лучом отрезка который является часть прямой вида x = const

                    else
                    {
                        double a = (double)(y1 - y2) / (double)(x1 - x2);
                        double b = (double)((x1 * y2) - (double)(y1 * x2)) / (x1 - x2);
                        if ((a > 0 && y > a * x + b) || (a < 0 && y < a * x + b)) countIntersects++;
                        //пересекаем лучом отрезок слева!
                    }
                }

            }
            return countIntersects % 2 == 1 ? PointLocation.pointInPolygon : PointLocation.pointOutPolygon;
            //Ecли кол-во пересечений четно, то точка вне многоульника. Нечетное - внутри
        }
    }
}
