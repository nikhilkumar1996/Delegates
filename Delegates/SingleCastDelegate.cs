using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate int SingleCast1(int firstnumber,int secondnumber);
    public delegate string SingleCast2(string firstname, string secondname);
    public class SingleCastDelegate
    {
        public static int Addition(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public static string Name(string firstname, string secondname)
        {
            return firstname +" "+ secondname;
        }
    }
}
