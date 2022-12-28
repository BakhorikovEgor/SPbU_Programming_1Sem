
using Polygons;
namespace Polygon.Tests
{
    [TestClass]
    public class PointLocationTests
    {
        Point[] trianglePoints;
        PolygonFigure simpleTriangle;

        Point[] sharpPolygonPoints;
        PolygonFigure sharpPolygon;

        Point[] randomPolygonPoints;
        PolygonFigure randomPolygon;

        Point[] parallelPolygonPoints;
        PolygonFigure parallelPolygon;

        public enum PointLocation
        {
            pointOutPolygon,
            pointBelongsPlygon,
            pointInPolygon
        }

        [TestInitialize]
        public void InitializePolygonsByPoints()
        {
            trianglePoints = new Point[] { new Point(-2, 2), new Point(4, 4), new Point(2, -2) };
            simpleTriangle = new PolygonFigure(trianglePoints);


            sharpPolygonPoints = new Point[] {new Point(-2,4), new Point(-8,-8),new Point(-4,-2),
                                              new Point(-6,-8),new Point(-2,-2),new Point(-4,-4)};
            sharpPolygon = new PolygonFigure(sharpPolygonPoints);


            randomPolygonPoints = new Point[] {new Point(-8,0), new Point(-6,-6),new Point(0,2),new Point(2,-4),
                                               new Point(4,6),new Point(-4,6),new Point(-6,2)};
            randomPolygon = new PolygonFigure(randomPolygonPoints);


            parallelPolygonPoints = new Point[] {new Point(-1,3), new Point(-1,2), new Point(-3,2),
                                                 new Point(-3,-1), new Point(-1,-1), new Point(-1,-2),
                                                 new Point(1,-2), new Point(1,-1), new Point(2,-1),
                                                 new Point(2,1), new Point(3,1), new Point(3,3)};
            parallelPolygon = new PolygonFigure(parallelPolygonPoints);
        }


        [TestMethod]
        public void SimpleTriangle_Tops_Return_Belongs()
        {
            PointLocation expected = PointLocation.pointBelongsPlygon;
            foreach (Point point in trianglePoints)
            {
                var actual = simpleTriangle.GetPointLocation(point.X, point.Y);

                Assert.AreEqual((int)expected, (int)actual);
            }
        }

        [TestMethod]
        public void SimpleTriangle_OnTheSegment_Return_Belongs()
        {
            double xPos = -1;
            double yPos = 1;
            PointLocation expected = PointLocation.pointBelongsPlygon;

            var actual = simpleTriangle.GetPointLocation(xPos, yPos);

            Assert.AreEqual((int)expected, (int)actual);
        }

        [TestMethod]
        public void SimpleTriangle_OutPoint_Return_Out()
        {
            double pointX = 4;
            double pointY = 3;
            PointLocation expected = PointLocation.pointOutPolygon;

            var actual = simpleTriangle.GetPointLocation(pointX, pointY);


            Assert.AreEqual((int)expected, (int)actual);
        }

        [TestMethod]
        public void SimpleTriangleCheck_InsidePoint_Return_Inside()
        {
            double pointX = -1.5;
            double pointY = 2;
            PointLocation expected = PointLocation.pointInPolygon;

            var actual = simpleTriangle.GetPointLocation(pointX, pointY);


            Assert.AreEqual((int)expected, (int)actual);
        }



        [TestMethod]
        public void SharpPolygon_Tops_Return_Belongs()
        {
            PointLocation expected = PointLocation.pointBelongsPlygon;
            foreach (Point point in sharpPolygonPoints)
            {
                var actual = sharpPolygon.GetPointLocation(point.X, point.Y);

                Assert.AreEqual((int)expected, (int)actual);
            }
        }

        [TestMethod]
        public void SharpPolygon_OnTheSegment_Return_Belongs()
        {
            double xPos = -6;
            double yPos = -5;
            PointLocation expected = PointLocation.pointBelongsPlygon;

            var actual = sharpPolygon.GetPointLocation(xPos, yPos);


            Assert.AreEqual((int)expected, (int)actual);
        }

        [TestMethod]
        public void SharpPolygon_CheckArrayOfOutPoints_Return_Out()
        {
            double[,] outPoints = new double[3, 2] { { -3, -2.5 }, { -5, -4 }, { -6, -2 } };
            PointLocation expected = PointLocation.pointOutPolygon;

            for (int i = 0; i < outPoints.GetLength(0); i++)
            {
                var actual = sharpPolygon.GetPointLocation(outPoints[i, 0], outPoints[i, 1]);

                Assert.AreEqual((int)expected, (int)actual);
            }
        }

        [TestMethod]
        public void SharpPolygon_CheckArrayOfInsidePoints_Return_Inside()
        {
            double[,] insidePoints = new double[3, 2] { { -2.4, -2.5 }, { -2.1, 3.75 }, { -4, -1 } };
            PointLocation expected = PointLocation.pointInPolygon;

            for (int i = 0; i < insidePoints.GetLength(0); i++)
            {
                var actual = sharpPolygon.GetPointLocation(insidePoints[i, 0], insidePoints[i, 1]);

                Assert.AreEqual((int)expected, (int)actual);
            }
        }



        [TestMethod]
        public void RandomPolygon_Tops_Return_Belongs()
        {
            PointLocation expected = PointLocation.pointBelongsPlygon;
            foreach (Point point in randomPolygonPoints)
            {
                var actual = randomPolygon.GetPointLocation(point.X, point.Y);

                Assert.AreEqual((int)expected, (int)actual);
            }
        }

        [TestMethod]
        public void RandomPolygon_OnTheSegment_Return_Belongs()
        {
            double xPos = -0.75;
            double yPos = 1;
            PointLocation expected = PointLocation.pointBelongsPlygon;

            var actual = randomPolygon.GetPointLocation(xPos, yPos);


            Assert.AreEqual((int)expected, (int)actual);
        }

        [TestMethod]
        public void RandomPolygon_CheckArrayOfOutPoints_Return_Out()
        {
            double[,] outPoints = new double[3, 2] { { -0.2, 1.6 }, { -6.5, 2.5 }, { 4, 5 } };
            PointLocation expected = PointLocation.pointOutPolygon;

            for (int i = 0; i < outPoints.GetLength(0); i++)
            {
                var actual = randomPolygon.GetPointLocation(outPoints[i, 0], outPoints[i, 1]);

                Assert.AreEqual((int)expected, (int)actual);
            }
        }

        [TestMethod]
        public void RandomPolygon_CheckArrayOfInsidePoints_Return_Inside()
        {
            double[,] insidePoints = new double[3, 2] { { 2, -3.5 }, { -3, 4 }, { 0, 2.0001 } };
            PointLocation expected = PointLocation.pointInPolygon;

            for (int i = 0; i < insidePoints.GetLength(0); i++)
            {
                var actual = randomPolygon.GetPointLocation(insidePoints[i, 0], insidePoints[i, 1]);

                Assert.AreEqual((int)expected, (int)actual);
            }
        }



        [TestMethod]
        public void ParralelPolygon_CheckArrayOfOutPointsOnTheParralelLines_Return_Out()
        {
            double[,] outPoints = new double[6, 2] { { -2, 3 }, { -4, 2 }, { -4, 1 },
                                                     { -4, 0 }, { -4, -1 }, { -2, -2 } };
            PointLocation expected = PointLocation.pointOutPolygon;

            for (int i = 0; i < outPoints.GetLength(0); i++)
            {
                var actual = parallelPolygon.GetPointLocation(outPoints[i, 0], outPoints[i, 1]);

                Assert.AreEqual((int)expected, (int)actual);
            }
        }


        [TestMethod]
        public void ParralelPolygon_CheckArrayOfInsidePointsOnTheParralelLines_Return_In()
        {
            double[,] insidePoints = new double[4, 2] { { 0, 2 }, { 0, 1 }, { 0, 0 }, { 0, -1 } };
            PointLocation expected = PointLocation.pointInPolygon;

            for (int i = 0; i < insidePoints.GetLength(0); i++)
            {
                var actual = parallelPolygon.GetPointLocation(insidePoints[i, 0], insidePoints[i, 1]);

                Assert.AreEqual((int)expected, (int)actual);
            }
        }


        [TestMethod]
        public void ParralelPolygon_CheckArrayBelongsPointsOnTheParralelLines_Return_Out()
        {
            double[,] onTheLinePoints = new double[4, 2] { { 2, 3 }, { -2, 2 }, { 2, 0 }, { -2, -1 } };
            PointLocation expected = PointLocation.pointBelongsPlygon;

            for (int i = 0; i < onTheLinePoints.GetLength(0); i++)
            {
                var actual = parallelPolygon.GetPointLocation(onTheLinePoints[i, 0], onTheLinePoints[i, 1]);

                Assert.AreEqual((int)expected, (int)actual);
            }
        }
    }

}