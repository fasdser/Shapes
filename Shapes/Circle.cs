using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : Shape
    {
        private Point o;
        private Point a;

        public Circle()
        {
        }

        public Circle(Point o, Point a)
        {
            this.o = o;
            this.a = a;
        }

        public Point GetO()
        {
            return o;
        }

        public void SetO(Point o)
        {
            this.o = o;
        }

        public Point GetR()
        {
            return a;
        }

        public void SetR(Point a)
        {
            this.a = a;
        }


        public override String ToString()
        {
            return "Circle{" + "o=" + o + ", a=" + a + '}';
        }


        public override double GetPerimetr()
        {
            return 2 * Math.PI * Point.CalculationDistance(o, a);
        }


        public override double GetArea()
        {
            return Math.PI * Math.Pow(Point.CalculationDistance(o, a), 2);
        }
    }
}
