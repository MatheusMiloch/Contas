using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    public abstract class Conta
    {
        public string agencia { get; set; }
        public string numeroConta { get; set; }
        public Cliente cliente { get; set; }
        public float saldo { get; set; }

        protected abstract void GerarChavePix(string chave);

        public Conta()
        {

        }

        public Conta(string agencia, string numeroConta, Cliente cliente, float saldo)
        {
            this.agencia = agencia;
            this.numeroConta = numeroConta;
            this.cliente = cliente;
            this.saldo = saldo;
        }

        public virtual void Depositar(float valorDeposito)
        {
            this.saldo += valorDeposito;
        }

        public virtual void Depositar(float valorDeposito, string nomeDepositante)
        {
            this.saldo += valorDeposito;
        }

        public void Sacar(float valorSaque)
        {
            this.saldo -= valorSaque;
        }

        public string SaldoSimplificado()
        {
            string texto = "Nome: " + this.cliente.nome + "\n" +
                           "Cpf: " + this.cliente.cpf+ "\n" +
                           "Saldo em Conta: R$" + this.saldo.ToString("F2");

            return texto;
        }

        public void Transferir(float valor, Conta contaDestino)
        {
            Sacar(valor);
            contaDestino.Depositar(valor);
        }
    }
}