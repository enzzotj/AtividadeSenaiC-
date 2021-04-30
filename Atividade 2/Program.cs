using System;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo!\n");

            Console.WriteLine("Em qual ano você nasceu?");
            int anon = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Em qual ano você está?");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int idade,dias, diasb,meses,sem;

            idade = ano - anon;
            meses = idade * 12;
            diasb = idade / 4;
            dias = (meses * 365) + diasb;
            sem = meses * 4;

            Console.WriteLine("Sua idade é: " + idade + " anos");
            Console.WriteLine("Sua idade convertida em semana: {0}",sem);
            Console.WriteLine("Sua idade convertida dias: {0}",dias);
            Console.WriteLine(":)");
        }
    }
}
