using System;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Saldo = -10;
            Console.WriteLine(conta.Saldo);

            conta.Saldo = 200;
            Console.WriteLine(conta.Saldo);
            
            Console.ReadLine();
        }
    }
}
