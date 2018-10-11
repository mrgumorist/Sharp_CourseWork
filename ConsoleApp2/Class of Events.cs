using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    public delegate int MyDelegate(int x, int y);

    class ClassOfEvents

    {

        static int Sum(int x, int y)

        {

            return x + y;

        }

        //    static void Main()

        //    {

        //        MyDelegate d = new MyDelegate(Sum);

        //        int result = d.Invoke(12, 15);

        //        Console.WriteLine(result);

        //        Console.ReadLine();

        //    }

        //}\
    }
}
