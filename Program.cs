using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace HW
{
    public class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array();
            for (int i=0; i<10; i++)
            {
                array[i] = i;
            }

            for (int i=0; i<10; ++i)
            {
                WriteLine("№{0}={1}",i,array[i]);
            }
            ReadLine();
        }
    }
}
