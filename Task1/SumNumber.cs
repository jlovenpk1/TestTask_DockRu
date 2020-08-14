using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TestTask_DockRu.Task1
{
    public class SumNumber : ISumNumber
    {
        private char[] _arrayNumber;
        private char[] _an;
        private int _number = 0;
        private int _suma = 0;
        bool check = true;
        public void Run()
        {
            Console.WriteLine("Введите натуральное число: ");
            check = int.TryParse(Console.ReadLine(), out _number);
            if (check == false) { Console.WriteLine("Введите число!"); Run(); } else
            if ((check == true) && (_number > 0)) { _suma = Summa(_number); Console.WriteLine("Сумма чисел {0} числа {1}", _number, _suma); } 
            else { Console.WriteLine("Число не может быть меньше или равно 0"); Run(); }
            
        }
        public bool CheckNumber(int checkNumber)
        {
            _arrayNumber = checkNumber.ToString().ToCharArray();
            return _arrayNumber.Length > 1 ? true : false;
        }
        public int Summa(int number)
        {

            _an = number.ToString().ToCharArray();
            int sum = 0;
            for(int i = 0; i < _an.Length; i++)
            {
                sum += int.Parse(_an[i].ToString());
            }
            if (CheckNumber(sum))
            {
                sum = Summa(sum);
            }
            return sum;
        }
    }
}
