using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contas
{
    public class Conta
    {
        public string Numero = "";

        public DateTime DataAbertura;
        public decimal Saldo = 0;



        // Construtores

        public Conta()
        {
            Numero = DateTime.Now.ToString("A0001");
            DataAbertura = DateTime.Now;
            Saldo = 0;
        }
        
        public Conta(string numero, DateTime dataAbertura, decimal saldo)
        {
            Numero = numero;
            DataAbertura = dataAbertura;
            Saldo = saldo;
        }




        // Metodos
        
        public String ExibirExtrato()
        {
            return "\n_____________________________ = EXTRATO DA CONTA =  _________________________\n\n" + 
                    $"                    Conta Nº:                   { Numero }{Environment.NewLine}" + 
                    $"                    Data da Abertura:           { DataAbertura.ToString("dd/mm/yyyy") }{Environment.NewLine}" + 
                    $"                    Saldo:                      { Saldo.ToString("C") }{Environment.NewLine}" + 
                    "_____________________________________________________________________________\n\n";
        }

        public void Depositar(decimal valor)
        {
            decimal SaldoAnterior = Saldo;
            Saldo += valor;

            Console.WriteLine("\n_____________________________ + DEPÓSITO NA CONTA +  __________________________\n");
            Console.WriteLine($"                    Conta Nº:                   { Numero }");
            Console.WriteLine($"                    Data:                       {DateTime.Now.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"                    Hora:                       {DateTime.Now.ToString("HH:mm:ss")}");
            Console.WriteLine($"                    Saldo Anterior:             {SaldoAnterior.ToString("C")}");
            Console.WriteLine($"                    Valor do Deposito:          {valor.ToString("C")}");
            Console.WriteLine($"                    Saldo Atual:                {Saldo.ToString("C")}");
            Console.Write("_____________________________________________________________________________\n\n");

        }
        
        public void Sacar (decimal valor)
        {
            decimal SaldoAnterior = Saldo;
            Saldo -= valor;

            Console.WriteLine("\n_____________________________ - SAQUE NA CONTA - ____________________________\n");
            Console.WriteLine($"                    Conta Nº:                   { Numero }");
            Console.WriteLine($"                    Data:                       {DateTime.Now.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"                    Hora:                       {DateTime.Now.ToString("HH:mm:ss")}");
            Console.WriteLine($"                    Saldo Anterior:             {SaldoAnterior.ToString("C")}");
            Console.WriteLine($"                    Valor do Saque:             {valor.ToString("C")}");
            Console.WriteLine($"                    Saldo Atual:                {Saldo.ToString("C")}");
            Console.Write("_____________________________________________________________________________\n\n");

        }

        public void RealizarEmprestimo(decimal valor)
        {
            decimal SaldoAnterior = Saldo;
            Saldo += valor;

            Console.WriteLine("\n_______________________________ $ EMPRESTIMO $ ______________________________\n");
            Console.WriteLine($"                    Conta Nº:                   { Numero }");
            Console.WriteLine($"                    Data:                       {DateTime.Now.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"                    Hora:                       {DateTime.Now.ToString("HH:mm:ss")}");
            Console.WriteLine($"                    Saldo Anterior:             {SaldoAnterior.ToString("C")}");
            Console.Write("             -----------------------------------------------------\n");
            Console.WriteLine($"                    Valor do Emprestimo:        {valor.ToString("C")}");
            Console.WriteLine($"\n                 * O EMPRESTIMO SERÁ DEBITADO APÓS 30 DIAS CORRIDOS *\n");
            Console.WriteLine($"                    Saldo Atual:                {Saldo.ToString("C")}");
            Console.Write("______________________________________________________________________________\n\n");

        }

        // Sobrecarga 

        public void RealizarEmprestimo(decimal valor, int qtdeParcelas)
        {
            decimal SaldoAnterior = Saldo;            
            decimal valorParcela = valor / qtdeParcelas;
            Saldo += valor;

            Console.WriteLine("\n_______________________________ $ EMPRESTIMO $ ______________________________\n");
            Console.WriteLine($"                    Conta Nº:                   { Numero }");
            Console.WriteLine($"                    Data:                       {DateTime.Now.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"                    Hora:                       {DateTime.Now.ToString("HH:mm:ss")}");
            Console.WriteLine($"                    Saldo Anterior:             {SaldoAnterior.ToString("C")}");
            Console.Write("             -----------------------------------------------------\n");
            Console.WriteLine($"                    Valor do Emprestimo:        {valor.ToString("C")}");
            Console.WriteLine($"                    { qtdeParcelas } parcelas de:              {valorParcela.ToString("C")}");
            Console.WriteLine($"\n              * A 1º PARCELA DO EMPRESTIMO SERÁ DEBITADO APÓS 30 DIAS CORRIDOS *\n");
            Console.WriteLine($"                    Saldo Atual:                {Saldo.ToString("C")}");
            Console.Write("_____________________________________________________________________________\n\n");
            
        }
    }
}