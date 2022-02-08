﻿using System;
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

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);

            bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);
            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            Console.WriteLine("Testando transferência:");
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: R$" + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: R$" + contaDaGabriela.saldo);

            contaDoBruno.Transferir(200, contaDaGabriela);
            Console.WriteLine("Saldos após a transferencia:");
            Console.WriteLine("Saldo do Bruno: R$" + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: R$" + contaDaGabriela.saldo);
            Console.ReadLine();

        }
    }
}
