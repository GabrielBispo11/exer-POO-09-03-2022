
using System;
using System.Collections.Generic;
using E_4.Models;

namespace E_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa individuos = new Pessoa();
            List<Pessoa> P = new List<Pessoa>();
            
            System.Console.WriteLine("--------------------------------------------------------");
            P.Add(new Pessoa("João", 15));
            P.Add(new Pessoa("Leandro", 21));
            P.Add(new Pessoa("Paulo", 17)); 
            P.Add(new Pessoa("Jessica", 18));
    

            System.Console.WriteLine("Os indivíduos presentes separados por Nome e Idade são:");
            individuos.Exibir(P);  
            System.Console.WriteLine("--------------------------------------------------------");
            System.Console.WriteLine("Já a pessoa mais velha entre o grupo:");   
            
            System.Console.WriteLine("--------------------------------------------------------");

        }
    }
}
