using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask_DockRu.Task2
{
    class Money
    {
        struct PriceMonet
        {
            public static int _pennise = 1;
            public static int _nickels = 5;
            public static int _dimes = 10;
            public static int _quarters = 25;
        }
        private Dictionary<string, int> _monet = new Dictionary<string, int>(){ { "Nickels", 0 },{ "Pennies",0 },{ "Dimes",0 },{ "Quarters",0 } };
        private float _number = 7.5f;
        private bool check = true;

        public void Run()
        {
            Console.WriteLine("Введите сумму: ");
            check = float.TryParse(Console.ReadLine(), out _number);
            if (check == false) { Console.WriteLine("Введите число!"); Run(); }
            else
            if ((check == true)&&(_number != 0 && _number > 0)) { GetInfo((float)Math.Floor((_number))); }
            else 
            {
                Console.WriteLine("Nickels {0}", _monet["Nickels"]);
                Console.WriteLine("Pennies {0}", _monet["Pennies"]);
                Console.WriteLine("Dimes {0}", _monet["Dimes"]);
                Console.WriteLine("Quarters {0}", _monet["Quarters"]);
            }
        }

        private void GetInfo(float number)
        {
            while(number > PriceMonet._quarters)
            {
                number -= PriceMonet._quarters;
                _monet["Quarters"] += 1;
            }
            while(number > PriceMonet._dimes)
            {
                number -= PriceMonet._dimes;
                _monet["Dimes"] += 1;
            }
            while(number > PriceMonet._nickels)
            {
                number -= PriceMonet._nickels;
                _monet["Nickels"] += 1;
            }
            while(number >= PriceMonet._pennise)
            {
                number -= PriceMonet._pennise;
                _monet["Pennies"] += 1;
            }
            Console.WriteLine("Осталось: {0}", number);
            Console.WriteLine("Nickels {0}",_monet["Nickels"]);
            Console.WriteLine("Pennies {0}", _monet["Pennies"]);
            Console.WriteLine("Dimes {0}", _monet["Dimes"]);
            Console.WriteLine("Quarters {0}", _monet["Quarters"]);
        }

    }
}
