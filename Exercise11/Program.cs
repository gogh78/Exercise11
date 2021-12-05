using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        //Разработать структуру для решения линейного уравнения 0=kx+b.
        //Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
        //Для решения уравнения предусмотреть метод Root.
        //Создать экземпляр разработанной структуры.
        //Осуществить использование экземпляра в программе.
        static void Main(string[] args)
        {
            Equation equation = new Equation();
            Console.WriteLine("Решение линейного уравнения 0 = kx + b");
            Console.WriteLine("Введите коэффициент k");
            equation.K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b");
            equation.B = Convert.ToInt32(Console.ReadLine());
            equation.Output();
            Console.ReadKey();
            Console.WriteLine();
        }
        struct Equation
        {
            public int K;
            public int B;

            static float Root(float K, float B)
            {
                float x = -B / K;
                return x;
            }
            public void Output()
            {
                float x = Root(K, B);
                Console.WriteLine("Значение x = {0:0.000}", x);
            }
        }
    }
}
