using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Quadrangle : Shape
    {
        private Point a;
        private Point b;
        private Point c;
        private Point d;

        public Quadrangle()
        {
        }

        public Quadrangle(Point a, Point b, Point c, Point d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
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

        public Point GetD()
        {
            return d;
        }

        public void SetD(Point d)
        {
            this.d = d;
        }


        public override String ToString()
        {
            return "Quadrangle{" + "a=" + a + ", b=" + b + ", c=" + c + ", d=" + d + '}';
        }


        public override double GetPerimetr()
        {
            return Point.CalculationDistance(a, b) + Point.CalculationDistance(b, c)
                    + Point.CalculationDistance(c, d) + Point.CalculationDistance(d, a);
        }


        public override double GetArea()
        {
            double p = this.GetPerimetr() / 2;
            return Math.Sqrt((p - Point.CalculationDistance(a, b)) * (p - Point.CalculationDistance(b, c))
                             * (p - Point.CalculationDistance(c, d)) * (p - Point.CalculationDistance(d, a)));
        }
    }
}
