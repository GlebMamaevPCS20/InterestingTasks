using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FigureFunction.Interface1;

namespace FigureFunction
{
    public class Circle : IFigure
    {
     public Circle(double r)
        {
            _radius = r;
        }
        public double R { get; set; }
        double _radius;
        double _area;
        double _perimetr;
        public string Info()
        {
            CalcArea();
            CalcPerimetr();
            string str = $"Фигура: Круг, площадь: {_area}, периметр: {_perimetr}";
            return str;
        }
        public void CalcArea()
        {
            _area = Math.PI * _radius * _radius;
        }
        public void CalcPerimetr()
        {
            _perimetr = 2 * Math.PI * _radius;
        }
    }
}
