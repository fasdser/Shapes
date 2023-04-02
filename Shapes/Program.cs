using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape triangelar = new Triangelar(new Point(0, 0), new Point(0, 4), new Point(3, 0));
            triangelar.GetArea();
            triangelar.GetPerimetr();

            Shape circle = new Circle(new Point(0, 0), new Point(3, 0));
            circle.GetArea();
            circle.GetPerimetr();

            Shape quadrangle = new Quadrangle(new Point(0, 0), new Point(2, 0), new Point(2, 2), new Point(2, 0));
            quadrangle.GetArea();
            quadrangle.GetPerimetr();

            Board board = new Board();
            board.AddShape(triangelar, 1);
            board.AddShape(triangelar, 1); //не добавится так как часть заполнена
            board.AddShape(triangelar, 5); //не добавится так как нет такой части
            board.AddShape(circle, 2);
            board.AddShape(quadrangle, 3);
            board.AddShape(quadrangle);
            board.AddShape(quadrangle); //не добавится так как нет места
            board.DelShape(5); //не удалится так как нет такой части
            board.DelShape(3);
            board.AddShape(triangelar, 3);
            board.Info();

            Console.ReadKey();
        }
    }
}
