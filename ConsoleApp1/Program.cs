using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Double Tol = 0.1;
            int Sgib = 0;
            string name = "Миллиметров";
            int num = 41;
            while (Sgib <= num)
            {
                Tol = Tol * 2;
                Sgib++;
            }

            if (Tol >= 1000 && Tol < 10000)
            {
                Tol = Tol / 1000;
                name = "Сантиметров";
            }
            else if (Tol == 10000 && Tol < 100000)
            {
                Tol = Tol / 10000;
                name = "Метров";
            }
            else if (Tol >= 100000)
            {
                Tol = Tol / 100000;
                name = "Километров";
            }

            Console.WriteLine("Толщина = " + Tol + name);
            Console.ReadLine();
        }
    }
}
