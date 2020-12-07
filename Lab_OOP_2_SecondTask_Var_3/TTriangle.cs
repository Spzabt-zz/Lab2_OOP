using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_OOP_2_SecondTask_Var_3
{
    class TTriangle
    {
        private double _perimeter;
        private double _square;

        protected double _a;
        protected double _b;
        protected double _c;

        public double A
        {
            get
            {
                return _a;
            }
            private set
            {
                if (_a > 0)
                    _a = value;
                else
                    _a = 0;
            }
        }

        public double B
        {
            get
            {
                return _b;
            }
            private set
            {
                if (_b > 0)
                    _b = value;
                else
                    _b = 0;
            }
        }

        public double C
        {
            get
            {
                return _c;
            }
            private set
            {
                if (_c > 0)
                    _c = value;
                else
                    _c = 0;
            }
        }

        public TTriangle(double a, double b, double c)
        {
            if (b + c > a)
                _a = a;
            if (a + c > b)
                _b = b;
            if (a + b > c)
                _c = c;
        }

        public TTriangle()
        {
            _a = 5;
            _b = 7;
            _c = 5;
        }

        public TTriangle(TTriangle triangle)
        {
            _a = triangle._a;
            _b = triangle._b;
            _c = triangle._c;
        }

        public void ShowInfo()
        {
            try
            {
                if (A == 0 || B == 0 || C == 0)
                {
                    throw new Exception("Одна зі сторін дорівнює нулю.");
                }
                Console.WriteLine(ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Помилка - " + e.Message);
            }
        }

        public double CalculatePerimeter()
        {
            _perimeter = A + B + C;

            return _perimeter;
        }

        public virtual double CalculateSquare()
        {
            double halfPerimeter = CalculatePerimeter();
            halfPerimeter /= 2;

            return _square = Math.Sqrt(halfPerimeter * (halfPerimeter - A) *
                (halfPerimeter - B) * (halfPerimeter - C));
        }

        public void EqualityCheck(TTriangle triangle1, TTriangle triangle2)
        {
            if (triangle1.A == triangle2.A && triangle1.B == triangle2.B && triangle1.C == triangle2.C)
                Console.Write("Трикутники рівні!");
            else
                Console.Write("Трикутники нерівні!");
        }

        public static double operator *(TTriangle triangle, int value)
        {
            return (triangle.A + triangle.B + triangle.C) * value;
        }

        public static double operator *(int value, TTriangle triangle)
        {
            return value * (triangle.A + triangle.B + triangle.C);
        }

        public override string ToString()
        {
            return "Периметр заданого трикутника: " + _perimeter + "\n" + 
                "Площа заданого трикутника: " + Math.Round(_square, 2);
        }
    }
}
