using System;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o seu salário :");
            double sal = double.Parse(Console.ReadLine());
            Console.WriteLine();
            
            if(500 >= sal) {
                double salp,aum,total;
                salp = 0.3;
                aum = salp * sal;
                total = aum + sal;
                Console.WriteLine("Aumento do salário: {0}",total.ToString("c"));

            } else {
                Console.WriteLine("Seu salário não esta nos requisitos para ser aumentado :)");
            }
        }
    }
}
