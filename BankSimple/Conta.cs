using System;
using System.Collections.Generic;
using System.Text;

namespace BankSimple
{
    internal class Conta
    {
        public int NumConta { get; private set; }
        private string _nome;
        private double _saldo;


        public Conta(int numconta, string nome)
        {
            NumConta = numconta;
            _nome = nome;
        }
        public Conta(int numconta, string nome, double saldo) : this(numconta, nome)
        {
            
            _saldo = saldo;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public void Deposito(double deposito)
        {
            if(deposito <= 0)
            {
                Console.WriteLine("Error! Valor menor ou igual a zero");
            } else
            {
                _saldo += deposito;
            }
        }

        public void Saque(double saque)
        {
            if(saque <= 0)
            {
                Console.WriteLine("Error! Valor menor ou igual a zero");
            } else
            {
                _saldo = ((_saldo - saque) - 5.0);
                
            }
        }

        public override string ToString()
        {
            return "Conta "
                + NumConta
                + ", Tituar: "
                + _nome
                + ", Saldo: $ "
                + _saldo;
        }
    }
}
