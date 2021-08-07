using System;
using System.Drawing;
using System.IO.Ports;
using System.Linq;

namespace Noticer
{
    public class CursorProcessor
    {
        private Point pointPrev = new Point(-1, -1);
        private double[] prevDistance = new double[50];
        private int iter = 0;

        public event EventHandler<double> ProcessCompleted;

        public CursorProcessor(int historySize = 50)
        {
            pointPrev = new Point(-1, -1);
            prevDistance = new double[historySize];
            iter = 0;
        }

        public double[] History => prevDistance;

        public void Process(Point point)
        {
            if ((pointPrev.X + pointPrev.Y) >= 0)
            {
                var length = GetDistance(point, pointPrev);
                var lengthAbs = Math.Abs(length);
                prevDistance[iter++] = lengthAbs;

                if (iter == prevDistance.Length)
                    iter = 0;
            }

            pointPrev = new Point(point.X, point.Y);

            var sum = prevDistance.Sum();

            sum = Math.Min(sum, 1500);

            sum = sum < 10 ? 0 : sum;

            var opacity = Map(sum, 0, 1500, 0, 1);

            // dispatch value
            ProcessCompleted?.Invoke(this, opacity);
        }

        public void Reset()
        {
            iter = 0;
            for (int i = 0; i < prevDistance.Length; i++)
            {
                prevDistance[i] = 0;
            }
            ProcessCompleted?.Invoke(this, 0);
        }

        private double GetDistance(Point p1, Point p2) => GetDistance(p1.X, p1.Y, p2.X, p2.Y);

        private double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        public double Map(double value, double fromSource, double toSource, double fromTarget, double toTarget)
        {
            return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
        }
    }
}
