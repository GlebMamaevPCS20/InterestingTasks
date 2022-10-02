using FigureFunction;
using System;
namespace program
{
    class program
    {
        static void Main()
        {
            Circle circ = new Circle(2);
            Console.WriteLine(circ.Info());
            Console.WriteLine();
            Rectangle rect = new Rectangle(2, 2);
            Console.WriteLine(rect.Info());
            Console.WriteLine();
            Triangle triang = new Triangle(2, new double[] {3,0,0,0,30,30});
            Console.WriteLine(triang.Info());
        }
    }

}

