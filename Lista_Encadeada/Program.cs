using System;

namespace Lista_Encadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            List x = new List();
            x.Listar();
            Console.WriteLine();
            Console.WriteLine("Digite os elementos a serem adicionados na lista:");
            while (true)
            {
                int elemento = int.Parse(Console.ReadLine());
                if (elemento == -1)
                {
                    x.Listar();
                    break;
                }
                else
                {
                    x.InserirElemento(elemento);
                }
            }

            Console.WriteLine("A lista está em ordem crescente?");
            Console.WriteLine(x.VerificarCrescente());
            Console.WriteLine("A lista está em ordem decrescente?");
            Console.WriteLine(x.VerificarDecrescente());
            Console.WriteLine("A lista está ordenada?");
            Console.WriteLine(x.VerificarOrdenada());
        }
    }
}
