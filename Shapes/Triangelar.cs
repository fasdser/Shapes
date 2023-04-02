using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangelar : Shape
    {
        private Point a;
        private Point b;
        private Point c;

        public Triangelar()
        {
        }

        public Triangelar(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Point GetA()
        {
            return a;
        }

        public void SetA(Point a)
        {
            this.a = a;
        }

        public Point GetB()
        {
            return b;
        }

        public void SetB(Point b)
        {
            this.b = b;
        }

        public Point GetC()
        {
            return c;
        }

        public void SetC(Point c)
        {
            this.c = c;
        }


        public override String ToString()
        {
            return "Triangelar{" + "a=" + a + ", b=" + b + ", c=" + c + '}';
        }


        public override double GetArea()
        {
            double p = this.GetPerimetr() / 2.0;
            return Math.Sqrt(p * (p - Point.CalculationDistance(a, b))
                    * (p - Point.CalculationDistance(b, c))
                        * (p - Point.CalculationDistance(c, a)));
        }

        public override double GetPerimetr()
        {
            return Point.CalculationDistance(a, b) + Point.CalculationDistance(a, c) + Point.CalculationDistance(c, b);
        }
    }
}
