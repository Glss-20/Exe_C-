using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExContaBancaria
{
    public class Conta
    {
        int NumeroConta;
        string Titular;
        double Saldo;

        public Conta(int numeroConta, string titular, double saldo)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Deposito de R${valor} realizado com sucesso para a conta {NumeroConta}!");
        }

        public void Sacar(double valor)
        {
            if (Saldo - valor < 0)
            {
                Console.WriteLine("Operção recusada - Saldo insuficiente");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R${valor} realizado com sucesso para a conta {NumeroConta}!");
            }
        }
        public void ChecarSaldo()
        {
            Console.WriteLine($"Conta {NumeroConta} - Saldo: R${Saldo}");
        }
        
    }
}
