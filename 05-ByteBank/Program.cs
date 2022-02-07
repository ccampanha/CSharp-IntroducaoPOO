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
            
            if (conta.Titular == null)
                Console.WriteLine("Ops, a referencia em conta.Titular é NULL");

            conta.Titular = new Cliente();
            conta.Titular.Nome = "Gabriela Costa";
            conta.Titular.Cpf = "434.562.878-20";
            conta.Titular.Profissao = "Desenvolvedora C#";
            conta.Saldo = 500;
            conta.Agencia = 563;
            conta.Numero = 5634527;
            

           // Console.WriteLine(gabriela.Nome);
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta);

            Console.ReadLine();

        }
    }
}
