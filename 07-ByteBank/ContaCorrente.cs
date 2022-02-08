﻿namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        private int _agencia;
        private int _numero { get; set; }
        
        private double _saldo = 100;

        public static int TotalDeContasCriadas { get; private set; }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
        }
        public int Agencia
        {
            get { return _agencia; }
            set 
            {
                if (value < 0)
                    return;
                _agencia = value; 
            }
        }

        public int Numero 
        { 
            get { return _numero; }
            set
            {
                if (value < 0)
                    return;
                _numero = value;
            }    
        
        }
        public double Saldo
        {
            get { return _saldo; }

            set
            {
                if (value < 0)
                    return;
                _saldo = value;
     
            }
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
                return false;

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
