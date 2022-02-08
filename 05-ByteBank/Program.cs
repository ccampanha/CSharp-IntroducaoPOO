using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();
            //gabriela.Nome = "Gabriela";
            //gabriela.Cpf = "434.562.878-20";
            //gabriela.Profissao = "Desenvolvedora C#";

    
            
            ContaCorrente conta = new ContaCorrente();
            
            if (conta.titular == null)
                Console.WriteLine("Ops, a referencia em conta.Titular é NULL");

            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "434.562.878-20";
            conta.titular.profissao = "Desenvolvedora C#";
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;
            

           // Console.WriteLine(gabriela.Nome);
            Console.WriteLine(conta.titular.nome);
   

            Console.ReadLine();

        }
    }
}
