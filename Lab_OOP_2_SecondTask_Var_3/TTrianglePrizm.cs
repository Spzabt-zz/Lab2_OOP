using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_OOP_2_SecondTask_Var_3
{
    class TTrianglePrizm : TTriangle
    {
        private double _height;

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0)
                    _height = value;
                else
                    _height = 0;
            }
        }

        public double Volume(TTriangle triangle)
        {
            Console.WriteLine($"V = Sосн * h = {Math.Round(triangle.CalculateSquare(), 2)} * {_height}");
            return triangle.CalculateSquare() * _height;
        }

        public override double CalculateSquare()
        {
            return base.CalculateSquare();
        }
    }
}
