using System;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("Quantos anos você tem?");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int meses,dias,horas,min;

            meses = idade * 12;
            dias = idade * 365;
            horas = dias * 24;
            min = horas * 60;

            Console.WriteLine("Você está vivendo há:");
            Console.WriteLine("Em Meses : " + meses);
            Console.WriteLine("Em Dias : " + dias);
            Console.WriteLine("Em Horas : " + horas + " h");
            Console.WriteLine("Em Minutos : " + min + " min");
            Console.WriteLine(":)");


        }
    }
}
