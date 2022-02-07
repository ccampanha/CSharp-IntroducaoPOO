using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.Titular = "Bruno";

            Console.WriteLine(contaDoBruno.Saldo);

            bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(contaDoBruno.Saldo);
            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoBruno.Saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.Saldo);

            Console.WriteLine("Testando transferência:");
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.Titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: R$" + contaDoBruno.Saldo);
            Console.WriteLine("Saldo da Gabriela: R$" + contaDaGabriela.Saldo);

            contaDoBruno.Transferir(200, contaDaGabriela);
            Console.WriteLine("Saldos após a transferencia:");
            Console.WriteLine("Saldo do Bruno: R$" + contaDoBruno.Saldo);
            Console.WriteLine("Saldo da Gabriela: R$" + contaDaGabriela.Saldo);
            Console.ReadLine();

        }
    }
}
