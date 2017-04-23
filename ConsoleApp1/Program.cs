using System;

namespace palindromos3digitos
{
    class Program
    {
        static int maior_palindromo = 0;

        static void Main(string[] args)
        {
            for (int a = 100; a <= 999; a++)
            {
                for (int b = 100; b <= 999; b++)
                {
                    if (a >= b && a % 10 != 0 && b % 10 != 0 )
                    {
                        int produto = a * b;

                        palindromo(produto);
                    }

                }
            }

            Console.WriteLine(maior_palindromo);
            Console.ReadKey();
        }

        static bool palindromo(int produto)
        {
            int aux = produto;
            int ult_digitido;
            int invertido = 0;

            while(aux != 0)
            {
                ult_digitido = aux % 10;
                invertido = invertido * 10 + ult_digitido;
                aux = aux / 10;
            }

            if (produto == invertido)
            {
                if (produto > maior_palindromo)
                {
                    maior_palindromo = produto;
                    return true;
                }

                return false;
            }

            else
            {
                return false;
            }
        }
    }
}