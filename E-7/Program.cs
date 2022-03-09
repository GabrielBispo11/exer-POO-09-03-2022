using System;
using E_7.Models;

namespace E_7
{
    class Program
    {
        static void Main(string[] args)
        {

            double GerenteSalario = 3000;
            Gerente gerenteSalario = new Gerente(3000);
            gerenteSalario.Bonificacao(GerenteSalario);
            System.Console.WriteLine($"Salário do Gerente: {gerenteSalario.Bonificacao(GerenteSalario)}");

            double SupervisorSalario = 2000;
            Supervisor supervisorSalario = new Supervisor(2000);
            supervisorSalario.Bonificacao(SupervisorSalario);
            System.Console.WriteLine($"Salário do Supervisor: {supervisorSalario.Bonificacao(SupervisorSalario)} ");
            
            
            double VendedorSalario = 1500;
            Vendedor vendedorSalario = new Vendedor(1500);
            vendedorSalario.Bonificacao(VendedorSalario);
            System.Console.WriteLine($"Salário do Vendedor: {vendedorSalario.Bonificacao(VendedorSalario)}");






        }
    }
}
