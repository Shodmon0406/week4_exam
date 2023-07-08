using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Classes
{
    internal class Circle : Point
    {
        Point _center = new Point();
        double _radius = 1.0;
        public Circle()
        {
        }
        public Circle(int xCenter, int yCenter, double radius) : base (xCenter, yCenter)
        {
            _radius = radius;
        }
        public Circle(Point center, double radius) : base (center.GetX(), center.GetY())
        {
            _radius *= radius;
        }
        public double GetRadius() => _radius;
        public void SetRadius(double radius) => _radius = radius;
        public Point GetCenter() => _center;
        public void SetCenter(Point center) => _center = center;
        public int GetCenterX() => base.GetX();
        public void SetCenterX(int x) => base.SetX(x);
        public int GetCenterY() => base.GetY();
        public void SetCenterY(int y) => base.SetY(y);
        public int[] GetCenterXY() => base.GetXY();
        public void SetCenterXY(int x, int y) => base.SetXY(x, y);
        public override string ToString() => $"Circle[center={base.ToString()}, radius={_center}]";
        public double GetArea() => Math.PI * _radius * _radius;
        public double GetCircumference() => 2 * Math.PI * _radius;
        public double Distance(Circle another)
        {
            return base.Distance(another.GetX(), another.GetY());
        }
    }
}
