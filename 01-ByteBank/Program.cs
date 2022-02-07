using System;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.Titular = "Gabriela";
            contaDaGabriela.Agencia = 863;
            contaDaGabriela.Numero = 863452;
            contaDaGabriela.Saldo = 100;

            Console.WriteLine(contaDaGabriela.Titular);
            Console.WriteLine("Agencia: " + contaDaGabriela.Agencia);
            Console.WriteLine(contaDaGabriela.Numero);
            Console.WriteLine(contaDaGabriela.Saldo);

            Console.ReadLine();
        }
    }
}
