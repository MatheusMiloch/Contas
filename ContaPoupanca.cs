using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    public class ContaPoupanca : Conta, IConta
    {
        public string segurado { get; set; }

        protected override void GerarChavePix(string chave)
        {

        }

        public void SolicitarEmprestimo(float valorPretendido)
        {

        }

        public void SolicitarAumentoLimite(float valorAtual, float valorPretendido)
        {

        }

        public ContaPoupanca()
        {

        }

        public ContaPoupanca(string agencia, string numeroConta, Cliente cliente, float saldo, string segurado) : base(agencia, numeroConta, cliente, saldo)
        {
            this.segurado = segurado;
        }

        public override void Depositar(float valorDeposito)
        {           
            base.Depositar(valorDeposito);
            this.saldo += 0.10f;
        }
    }
}
