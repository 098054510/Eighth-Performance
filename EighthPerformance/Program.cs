using System;

namespace EighthPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1, N2, soma;
            string[] vet = Console.ReadLine().Split(' ');

            N1 = int.Parse(vet[0]);
            N2 = int.Parse(vet[1]);

            soma = 0;

            for (int i=N1; i<=N2; i++)
            {
                if(i % 2!= 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
