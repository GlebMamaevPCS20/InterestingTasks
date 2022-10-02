using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureFunction
{
    internal interface Interface1
    {
        public interface IFigure
        {
            ///Возвращает название фигуры,
            ///ее площадь и периметр
            ///<summary></summary>
            public string Info();
            ///Возвращает площадь фигуры,
            ///<summary></summary>
            public void CalcArea();
            ///Возвращает периметр фигуры,
            ///<summary></summary>
            public void CalcPerimetr();
        }
    }

}
