using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FigureFunction.Interface1;

namespace FigureFunction
{
    public class Rectangle : IFigure
    {
        public Rectangle(double a, double b)
        {
            _side1 = a;
            _side2 = b;
        }
        public double A { get; set; }
        public double B { get; set; }
        double _side1;
        double _side2;
        double _area;
        double _perimetr;
        public string Info()
        {
            CalcArea();
            CalcPerimetr();
            string str = $"Фигура: Прямоугольник, площадь: {_area}, периметр: {_perimetr}";
            return str;
        }
        public void CalcArea()
        {
            _area = _side1 * _side2;
        }
        public void CalcPerimetr()
        {
            _perimetr = 2 * _side1 + 2 * _side2;
        }
    }
}
