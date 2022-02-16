using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Delegates Program");
            Console.WriteLine("1.SingleCastDelegate" +
                              "\n2.Exit");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter option");
                int choose=Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        SingleCast1 singleCast1 = new SingleCast1(SingleCastDelegate.Addition);
                        int number=singleCast1(7, 8);
                        Console.WriteLine(number);

                        SingleCast2 singleCast2=new SingleCast2(SingleCastDelegate.Name);
                        string name = singleCast2("Nikhil","Kumar");
                        Console.WriteLine(name);
                        break;

                    case 2:
                        flag= false;
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;

                }
            }
        }
    }
}
