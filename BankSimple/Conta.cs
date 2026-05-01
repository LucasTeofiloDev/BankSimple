using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace BankSimple
{
    internal class Conta
    {
        public int NumConta { get; private set; }
        private string _nome;
        public double Saldo { get; private set; }


        public Conta(int numconta, string nome)
        {
            NumConta = numconta;
            _nome = nome;
        }
        public Conta(int numconta, string nome, double depositoInicial) : this(numconta, nome)
        {
            
            Deposito(depositoInicial);
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
                Saldo += deposito;
            }
        }

        public void Saque(double saque)
        {
            if(saque <= 0)
            {
                Console.WriteLine("Error! Valor menor ou igual a zero");
            } else
            {
                Saldo += saque + 5.0;
                
            }
        }

        public override string ToString()
        {
            return "Conta "
                + NumConta
                + ", Tituar: "
                + _nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
