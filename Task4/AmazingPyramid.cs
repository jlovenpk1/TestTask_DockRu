using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask_DockRu.Task4
{
    class AmazingPyramid
    {
        private bool check;
        private int _number;

        public void Run()
        {
            Console.WriteLine("Введите номер строки пирамиды: ");
            check = int.TryParse(Console.ReadLine(), out _number);
            if (check == false) { Console.WriteLine("Введите число!"); Run(); }
            else
            if ((check == true) && (_number > 0)) { Console.WriteLine(Math.Pow(_number,3)); FunExample(_number); }
            else { Console.WriteLine("Число не может быть меньше или равно 0"); Run(); }
        }

        public void FunExample(int number)
        {

            int _step = 2;
            int _numberrow = 1;
            int result = 0;
            for (int i = 1; i < number; i++)
            {
                _numberrow += _step;
                _step += 2;
            }
            for (int i = 0; i < number; i++)
            {
                if (i != number) { Console.Write(_numberrow + " "); }
                result += _numberrow;
                _numberrow += 2;            
            }
            Console.Write(" = {0}", result);
        }
    }
}
