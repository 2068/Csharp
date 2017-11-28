using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        enum Mydate
        {
            Sun=0,
            Mon=1,
            Tue=2,
            Wed=3,
            Thi=4,
            Fri=5,
            Sat=6,
        }
        static void Main(string[] args)
        {
            int k = (int)DateTime.Now.DayOfWeek;
            switch(k)
            {
                case (int)Mydate.Sun: Console.WriteLine("今天是星期日"); break;
                case (int)Mydate.Mon: Console.WriteLine("今天是星期一"); break;
                case (int)Mydate.Tue: Console.WriteLine("今天是星期二"); break;
                case (int)Mydate.Wed: Console.WriteLine("今天是星期三"); break;
                case (int)Mydate.Fri: Console.WriteLine("今天是星期四"); break;
                case (int)Mydate.Sat: Console.WriteLine("今天是星期五"); break;
            }
        }
    }
}
