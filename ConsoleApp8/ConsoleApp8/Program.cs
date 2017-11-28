using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str1 = "a,b#c";
            string Str2 = "bcd";
            string Str3 = "";
            string Str4 = Str1.Insert(1, "12");
            Console.WriteLine(Str4);
            char[] a = { ',', '#' };
            string[] b = new string[100];
            b = Str1.Split(a);
            for(int i=0;i<b.Length;i++)
            {
                Console.WriteLine("{0}:{1}", i, b[i]);
            }
            Str3 = Str1.Substring(1, 2);
            Console.WriteLine(Str3);
            Console.WriteLine(string.Compare(Str1, Str2));
            Console.WriteLine(string.Compare(Str1, Str1));
            Console.WriteLine(string.Compare(Str2, Str1));
            Console.WriteLine(Str1.CompareTo(Str2));
            string newstr = string.Format("{0},{1}!!!", Str1, Str2);
            Console.WriteLine(newstr);
            string str1 = "******!";
            string str2 = str1.PadLeft(7, '1');
            string str3 = str1.PadRight(8, '1');
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            string str4 = str1.Remove(0, 2);
            Console.WriteLine(str4);
            char[] str = new char[100];
            str1.CopyTo(1, str, 0, 2);
            Console.WriteLine(str);
            string s = str1.Replace('!', '.');
            string x = str1.Replace("******!", "******");
            Console.WriteLine(s);
            Console.WriteLine(x);
        }
    }
}
