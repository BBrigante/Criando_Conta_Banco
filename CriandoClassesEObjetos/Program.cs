using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contas;

namespace CriandoClassesEObjetos
{
    public class Program
    {
        static void Main (String[] args)
        {
            var conta  = new Conta();
            Console.WriteLine(conta.ExibirExtrato());
            conta.Depositar(1000);
            conta.Sacar(130);
            conta.RealizarEmprestimo(300,10);
            Console.WriteLine(conta.ExibirExtrato());


            var conta2  = new Conta("A0002", DateTime.Now, 100);
            Console.WriteLine(conta2.ExibirExtrato());
            conta2.Depositar(5000);
            conta2.Sacar(330);
            conta2.RealizarEmprestimo(1500,10);
            Console.WriteLine(conta2.ExibirExtrato());
        }
    }
}