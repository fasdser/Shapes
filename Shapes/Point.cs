using System;

/*
 Создайте абстрактный класс Shape в котором есть два абстрактных метода double perimetr() и double area().
2.Создайте класс Point в котором есть два свойства double x double y.
3. Создайте классы которые описывают как минимум 3 геометрические фигуры (они должны быть подклассами Shape), при этом они в качестве свойств должны содержать классы Point.
4. Создайте класс доска. Доска поделена на 4 части в каждую часть доски можно положить одну из фигур. У доски должны быть методы которые помещают и удаляют фигуру с доски. Также должен быть метод который выводит информацию о всех фигурах лежащих   на доске и их суммарную площадь.
*/

public class Point
{
    private double x;
    private double y;

    public Point()
    {
    }

    public Point(double y, double x)
    {
        this.y = y;
        this.x = x;
    }

    public double GetX()
    {
        return x;
    }

    public void SetX(double x)
    {
        this.x = x;
    }

    public double GetY()
    {
        return y;
    }

    public void SetY(double y)
    {
        this.y = y;
    }

   
    public override String ToString() => "Point{" + "x=" + x + ", y=" + y + '}';

    public static double CalculationDistance(Point a, Point b)
    {
        return Math.Sqrt((a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y));
    }
}
