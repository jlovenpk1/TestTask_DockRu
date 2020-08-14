using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask_DockRu.Task3
{
    class ReverseNumber
    {
        private bool check;
        private int _number;

        public void Run()
        {
            Console.WriteLine("Введите число: ");
            check = int.TryParse(Console.ReadLine(), out _number);
            if (check == false) { Console.WriteLine("Введите число!"); Run(); }
            else
            if ((check == true) && (_number > 0)) { Console.WriteLine("Перевернули число: {0}",Example(_number));  }
            else { Console.WriteLine("Число не может быть меньше или равно 0"); Run(); }
        }

        private int Example(int number)
        {
            StringBuilder snumber = new StringBuilder();
            char[] _arrchar = number.ToString().ToArray();
            int[] _arrnumber = new int[_arrchar.Length];
            for(int i = 0; i < _arrchar.Length; i++)
            {
                _arrnumber[i] = int.Parse(_arrchar[i].ToString());
            }
            Array.Sort(_arrnumber);
            Array.Reverse(_arrnumber);
            for(int i = 0; i<_arrnumber.Length; i++)
            {
                snumber.Append(_arrnumber[i]);
            }
            
            return int.Parse(snumber.ToString());
        }
    }
}
