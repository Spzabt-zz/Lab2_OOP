using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_OOP_2_SecondTask_Var_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            string exit = "Exit";

            while (isOpen)
            {
                Console.Write("Введіть довжину сторони A: ");
                double a = int.Parse(Console.ReadLine());
                Console.Write("Введіть довжину сторони B: ");
                double b = int.Parse(Console.ReadLine());
                Console.Write("Введіть довжину сторони C: ");
                double c = int.Parse(Console.ReadLine());

                Console.Clear();

                TTriangle triangle = new TTriangle(a, b, c);

                triangle.CalculatePerimeter();
                triangle.CalculateSquare();
                triangle.ShowInfo();
                
                Console.WriteLine("-------------------------");
                Console.WriteLine("Конструктор за замовчуванням:\n");

                TTriangle defaulTriangle = new TTriangle();

                defaulTriangle.CalculatePerimeter();
                defaulTriangle.CalculateSquare();
                defaulTriangle.ShowInfo();

                Console.WriteLine("-------------------------");
                Console.WriteLine("Конструктор копіювання:\n");

                TTriangle copiedTriangle = new TTriangle(triangle);

                copiedTriangle.CalculatePerimeter();
                copiedTriangle.CalculateSquare();
                copiedTriangle.ShowInfo();

                Console.WriteLine("-------------------------");
                Console.Write("Порівняння трикутників: ");
                triangle.EqualityCheck(triangle, defaulTriangle);

                Console.WriteLine("\n-------------------------");
                Console.WriteLine("Перевантаження операторів:\n");
                double result1 = triangle * 6;
                double result2 = 4 * defaulTriangle;
                Console.WriteLine($"Множення першого трикутника {result1}.\nМноження другого трикутника {result2}.");

                Console.WriteLine("-------------------------");
                Console.WriteLine("Знаходження об'єму призми:\n");

                TTrianglePrizm trianglePrizm = new TTrianglePrizm();

                Console.Write("Напишіть висоту призми: ");
                int height = Convert.ToInt32(Console.ReadLine());
                trianglePrizm.Height = height;
                TTriangle triangle1 = new TTriangle(5, 4, 6);
                Console.Write($"Новий трикутник зі сторонами: A-{triangle1.A}, B-{triangle1.B}, C-{triangle1.C}\n");

                triangle1.CalculatePerimeter();
                triangle1.CalculateSquare();
                triangle1.ShowInfo();

                Console.Write($"\nОб'єм призми: {Math.Round(trianglePrizm.Volume(triangle1), 2)}\n");

                Console.WriteLine("\nНатисніть будь-яку клавішу для продовження, " +
                    "або введіть команду Exit для виходу з програми...");
                if (Console.ReadLine() == exit)
                    isOpen = false;

                Console.Clear();
            }
        }
    }
}
