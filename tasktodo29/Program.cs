using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasktodo29
{
    class Program
    {
        public delegate string Mydel(int x, int y);

        static void Main(string[] args)
        {
            Mydel delg = new Mydel(AreaofTriangle);
            Console.WriteLine(delg(12, 25));
            delg += new Mydel(AreaofRectangle);
            Console.WriteLine(delg(12, 25));
        }

        public static string AreaofTriangle(int a, int b)
        {
            int c = a * b / 2;
            return Convert.ToString(c);
        }

        public static string AreaofRectangle(int a, int b)
        {
            int c = a * b ;
            return Convert.ToString(c);
        }
    }
}
