using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.

namespace ITMO_BIM_m1_lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2;
            Console.WriteLine("Введите число A ( 7 < N < 10 ) для вычисления факториала:");
            n1 = Convert.ToInt32(Console.ReadLine());
            //Fact(n1);
            FactAsync(n1);

            Console.WriteLine("Введите число B ( 3 < B < 6 ) для вычисления факториала:");
            n2 = Convert.ToInt32(Console.ReadLine());
            FactAsync(n2);

            Console.ReadKey();
        }
        static void Fact(int n)
        {
            int r = 1;
            for (int i = 1; i <= n; i++)
            {
                r *= i;
                Thread.Sleep(3000);
            }
            Console.WriteLine($"Факториал {n} = {r}");
        }
        static async void FactAsync(int n)
        {
            await Task.Run(()=>Fact(n));
        }
    }
}
