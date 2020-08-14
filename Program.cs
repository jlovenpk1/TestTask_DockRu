using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask_DockRu.Task1;
using TestTask_DockRu.Task2;
using TestTask_DockRu.Task3;
using TestTask_DockRu.Task4;
using TestTask_DockRu.Task5;

namespace TestTask_DockRu
{
    class Program
    {
        public static SumNumber _sn;
        public static Money _money;
        public static ReverseNumber _rn;
        public static AmazingPyramid _ap;
        public static AmazingReturn _ar;
        static void Main(string[] args)
        {
            //_sn = new SumNumber();
            //_sn.Run();
            //_money = new Money();
            //_money.Run();
            //_rn = new ReverseNumber();
            //_rn.Run();
            //_ap = new AmazingPyramid();
            //_ap.Run();
            _ar = new AmazingReturn();
            Console.WriteLine(_ar.ReturnFive());
            Console.ReadKey();
        }

    }
}
