using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask_DockRu.Task5
{
    class AmazingReturn
    {
        public int ReturnFive()
        {
            return new DirectoryInfo(Directory.GetCurrentDirectory()).Name.Count();
            /*Хитрый и шаткий способ:
             У нас имеется 5 заданий Task1-Task5 - можно вернуть колличество выполненых заданий
            Можно так же вернуть название папки Debug, т.к так как раз 5 символов.

             */
        }
    }
}
