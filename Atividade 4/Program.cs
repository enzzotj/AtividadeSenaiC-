using System;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao campeonato de natação!\n");
            Console.WriteLine("Qual é a sua idade?");
            double idade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (idade >= 5)
            {

                if (idade >= 5 && idade <= 7)
                {
                    Console.WriteLine("Categoria\t" + "Idade");
                    Console.WriteLine("Infantil A\t" + "5 – 7 anos");
                }
                else
                {
                    if (idade >= 8 && idade <= 10)
                    {
                        Console.WriteLine("Categoria\t" + "Idade");
                        Console.WriteLine("Infantil B\t" + "8 – 10 anos");
                    }
                    else
                    {
                        if (idade >= 11 && idade <= 13)
                        {
                            Console.WriteLine("Categoria\t" + "Idade");
                            Console.WriteLine("Juvenil A\t" + "11 – 13 anos");
                        }
                        else
                        {
                            if (idade >= 14 && idade <= 17)
                            {
                                Console.WriteLine("Categoria\t" + "Idade");
                                Console.WriteLine("Juvenil B\t" + "14 – 17 anos");
                            }
                            else
                            {
                                    Console.WriteLine("Categoria\t" + "Idade");
                                    Console.WriteLine("Sênior\t" + "Maiores de 18 anos");
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Sua idade não entra no requisito mínimo :(");
            }
        }
    }
}
