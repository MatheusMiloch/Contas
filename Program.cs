using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor;
            int opcao = 0;
            string cpfCliente;
            Conta conta;
            Conta contaDestino;
            int tipoConta = 0;

            string ag;
            string numC;
            string seg;
            string nomeDepositante;

            List<ContaPoupanca> ListaContasBancarias = new List<ContaPoupanca>();

            do
            {
                Console.Clear();
                conta = null;
                contaDestino = null;

                Console.WriteLine("Sistema de Contas Bancárias \n\n");

                Console.WriteLine("1 - Criar Conta");
                Console.WriteLine("2 - Depósito");
                Console.WriteLine("3 - Saque");
                Console.WriteLine("4 - Transferência");
                Console.WriteLine("5 - Sair");

                Console.WriteLine("\n");

                Console.Write("Digite a opção: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("\nCriação de Conta \n");

                    Cliente cli = new Cliente();

                    Console.WriteLine("Você deseja criar uma 1 - Conta Corrente ou 2 - Conta Poupança");
                    tipoConta = int.Parse(Console.ReadLine());

                    Console.Write("Digite a agência: ");
                    ag = Console.ReadLine();

                    Console.Write("Digite a numero da conta: ");
                    numC = Console.ReadLine();

                    Console.Write("Digite o Cpf do cliente: ");
                    cli.cpf = Console.ReadLine();

                    Console.Write("Digite o nome do cliente: ");
                    cli.nome = Console.ReadLine();

                    if (tipoConta == 1)
                    {
                        //Conta c = new Conta(ag, numC, cli, 0);

                        //ListaContasBancarias.Add(c);
                    }
                    else
                    {
                        Console.Write("Digite o nome do segurado: ");
                        seg = Console.ReadLine();

                        ContaPoupanca cp = new ContaPoupanca(ag, numC, cli, 0, seg);

                        ListaContasBancarias.Add(cp);
                    }

                    Console.Write("\nConta criada com sucesso!");

                    Console.ReadKey();
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("\nDepósito \n");

                    Console.Write("Digite o Cpf do cliente para depósito: ");
                    cpfCliente = Console.ReadLine();

                    foreach (ContaPoupanca c in ListaContasBancarias)
                    {
                        if (c.cliente.cpf == cpfCliente)
                        {
                            conta = c;
                            break;
                        }
                    }

                    if (conta == null)
                    {
                        Console.WriteLine("Cliente não existe!");
                    }
                    else
                    {
                        Console.WriteLine(conta.SaldoSimplificado());

                        Console.Write("Digite o valor do Depósito: R$ ");
                        valor = float.Parse(Console.ReadLine());

                        Console.Write("Digite o o nome do Depositante: ");
                        nomeDepositante = Console.ReadLine();

                        if (nomeDepositante == "")
                        {
                            conta.Depositar(valor);
                        }
                        else
                        {
                            conta.Depositar(valor, nomeDepositante);
                        }

                        Console.Write("\nDepósito realizado com sucesso!\n");

                        Console.WriteLine(conta.SaldoSimplificado());
                    }

                    Console.ReadKey();
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("\nSaque \n");

                    Console.Write("Digite o Cpf do cliente para saque: ");
                    cpfCliente = Console.ReadLine();

                    foreach (Conta c in ListaContasBancarias)
                    {
                        if (c.cliente.cpf == cpfCliente)
                        {
                            conta = c;
                            break;
                        }
                    }

                    if (conta == null)
                    {
                        Console.WriteLine("Cliente não existe!");
                    }
                    else
                    {
                        Console.WriteLine(conta.SaldoSimplificado());

                        Console.Write("Digite o valor do Saque: R$ ");
                        valor = float.Parse(Console.ReadLine());

                        conta.Sacar(valor);

                        Console.Write("\nSaque realizado com sucesso!\n");

                        Console.WriteLine(conta.SaldoSimplificado());
                    }

                    Console.ReadKey();
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("\nTransferência \n");

                    Console.Write("Digite o Cpf do cliente de origem: ");
                    cpfCliente = Console.ReadLine();

                    foreach (Conta c in ListaContasBancarias)
                    {
                        if (c.cliente.cpf == cpfCliente)
                        {
                            conta = c;
                            break;
                        }
                    }

                    Console.Write("Digite o Cpf do cliente de destino: ");
                    cpfCliente = Console.ReadLine();

                    foreach (Conta c in ListaContasBancarias)
                    {
                        if (c.cliente.cpf == cpfCliente)
                        {
                            contaDestino = c;
                            break;
                        }
                    }

                    if ((conta == null) || (contaDestino == null))
                    {
                        Console.WriteLine("Cliente Origem ou Destino não existe!");
                    }
                    else
                    {
                        Console.WriteLine("Cliente origem:");
                        Console.WriteLine(conta.SaldoSimplificado() + "\n");

                        Console.WriteLine("Cliente destino:");
                        Console.WriteLine(contaDestino.SaldoSimplificado());

                        Console.Write("Digite o valor da Transferência: R$ ");
                        valor = float.Parse(Console.ReadLine());

                        conta.Transferir(valor, contaDestino);

                        Console.Write("\nTransferência realizada com sucesso!\n");

                        Console.WriteLine("Cliente origem:");
                        Console.WriteLine(conta.SaldoSimplificado() + "\n");

                        Console.WriteLine("Cliente destino:");
                        Console.WriteLine(contaDestino.SaldoSimplificado());
                    }

                    Console.ReadKey();
                }

            } while (opcao != 5);

        }
    }
}