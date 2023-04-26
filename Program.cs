using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Используем цикл for тк у нас есть определенные границы цикла
            int lowerBound = 5;
            int upperBound = 100;
            int circleStep =7;

            for(int i = lowerBound; i < upperBound; i += circleStep ) 
            {
                Console.Write(i + " ");
            }
        }
    }
}
