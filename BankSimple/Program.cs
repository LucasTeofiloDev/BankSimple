using System;
using System.Globalization;
using System.Security.Cryptography;

namespace BankSimple.Main
{ 
    public class Program
    {
        public static void Main(string[] args)
        {

            

            Console.WriteLine("Entre o número da conta: ");
            int numconta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (s/n) ? ");
            string escolha = Console.ReadLine();
            escolha = escolha.Trim(); // remover os espaços
            escolha = escolha.ToLower(); //deixar tudo minusculo

            Conta c;

            if (escolha == "s")
            {
                Console.WriteLine("Entre com o valor depósito inicial:");
                double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                c = new Conta(numconta, nome, deposito);
            } else
            {
                c = new Conta(numconta, nome);
            }

            int opção = 0;

            do
            {
                Console.WriteLine(c);
                Console.WriteLine("-----------");
                Console.WriteLine("Menu de opções");
                Console.WriteLine("1 - Deposito");
                Console.WriteLine("2 - Saque (Obs: Taxa de R$ 5.00 por saque)");
                Console.WriteLine("3 - Alterar Dado Cadrastral (Obs: Nome)");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("-----------");
                Console.WriteLine("Digite a opção escolhida:");
                opção = int.Parse(Console.ReadLine());

                switch (opção)
                {
                    case 1:

                        Console.WriteLine("Entre com o valor depósito:");
                        double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        c.Deposito(deposito);

                        break;

                    case 2:

                        Console.WriteLine("Entre com o valor saque: (Obs:Taxa de R$ 5.00 por saque)");
                        double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        c.Saque(saque);

                        break;

                    case 3:
                        Console.WriteLine("Entre com o novo nome a ser cadastrado: ");
                        string novonome = Console.ReadLine();
                        c.Nome = novonome;
                        break;

                    case 4:

                        Console.WriteLine("Saindo...");

                        break;

                    default:

                        Console.WriteLine("Valor digitado invalido...");

                        break;
                }

                
            } while (opção != 4);
            

        }
    }

}
