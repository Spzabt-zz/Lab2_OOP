using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OOP
{
    class NaturalNum
    {
        private int _num;

        public NaturalNum(int num)
        {
            _num = num;
        }

        private int GetNum(int index)
        {
            int digit = 0;
            int count = 0;
            int i = 0;

            while (_num > 0)
            {
                digit = _num % 10;
                if (digit == 1)
                    count++;
                _num /= 10;
                i++;
                if (index == i)
                    break;
            }
            return digit;
        }

        public int ReverseNum(int number)
        {
            int result = 0;

            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }

            return result;
        }

        public int ZeroCount(int number)
        {
            int result = 0;

            while (number > 0)
            {
                if (number % 10 == 0)
                    result++;
                number /= 10;
            }

            return result;
        }

        public int this[int index]
        {
            get { return GetNum(index); }
        }
    }
}
