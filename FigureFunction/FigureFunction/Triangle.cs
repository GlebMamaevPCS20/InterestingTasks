using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static FigureFunction.Interface1;

namespace FigureFunction
{
    public class Triangle : IFigure
    {
        ///<summary>Формат записи: 1) целое число, где: 1 - три стороны, 2 - две стороны и угол между ними, 3 - сторона и два прилегающих у ней угла.
        ///2) набор не обязательно целых параметров, где: первое, второе и третье число соответсвенно равны длинам первой второй и третьей стороны; 
        ///четвертое число - величина угла между двумя известными сторонами в градусах; пятое число - величина первого известного угла прилегающего к единственной известной стороне,
        ///шестое число - величина второго известного угла, прилегающего к той же стороне</summary>
        public Triangle(int paramsSet, double[] parametri)
        {
            _paramsSet = paramsSet;
            _side1 = parametri[0];
            _side2 = parametri[1];
            _side3 = parametri[2];
            _angle12 = parametri[3];
            _angle1 = parametri[4];
            _angle2 = parametri[5];

        }
        
        double _angle12;
        int _paramsSet;
        double _side1;
        double _side2;
        double _side3;
        double _angle1;
        double _angle2;
        double _area;
        double _perimetr;
        
        public string Info()
        {
            CalcPerimetr();
            CalcArea();
            string str = $"Фигура: Треугольник, площадь: {_area}, периметр: {_perimetr}";
            return str;
        }

        public void CalcPerimetr()
        {
            if (_paramsSet ==0)
            {
                _perimetr = _side1 + _side2 + _side3;
            }
            else if (_paramsSet ==1)
            {
                _side3 = Math.Sqrt(Math.Pow(_side1,2) + Math.Pow(_side2, 2) - 2*_side1*_side2*Math.Cos(_angle12*Math.PI/180));
                _perimetr = _side1 + _side2 + _side3;
            }
            else if (_paramsSet == 2)
            {
                double _angle3 = (180 - _angle1 - _angle2)*Math.PI / 180 ;
                _angle1 = _angle1 * Math.PI / 180;
                _angle2 = _angle2 * Math.PI / 180;
                _side2 = _side1 * Math.Sin(_angle1) / Math.Sin(_angle3);
                _side3 = _side1 * Math.Sin(_angle2) / Math.Sin(_angle3);
                _perimetr = _side1 + _side2 + _side3;
            }



        }
        public void CalcArea()
        {
            double p = _perimetr / 2;
            _area = Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3));
        }
    }
}
