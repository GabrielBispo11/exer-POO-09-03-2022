using System;
using System.Collections.Generic;
using System.Linq;
using E_4.Models;

namespace E_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoas = new Pessoa();
            List<Pessoa> P = new List<Pessoa>();
            
            P.Add(new Pessoa("João", 15));
            P.Add(new Pessoa("Leandro", 21));
            P.Add(new Pessoa("Paulo", 17)); 
            P.Add(new Pessoa("Jessica", 18));

            System.Console.WriteLine($"Pessoa mais velha: {Velho(P).getNome()}");






        





            
        }
    }
}
