using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть натуральне число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
                Console.WriteLine("Введіть додатнє число.");

            NaturalNum naturalNum = new NaturalNum(num);

            Console.Write("Введіть індекс для доступу до цифр заданого числа (зліва направо): ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(naturalNum[index]);

            Console.WriteLine("Метод обернення числа: ");
            Console.Write(naturalNum.ReverseNum(num));

            Console.WriteLine("\nМетод підрахунку кількості нулів: ");
            Console.Write(naturalNum.ZeroCount(num));

            Console.ReadKey();
        }
    }
}
