
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
            Pessoa individuos = new Pessoa();
            List <Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa("João", 15));
            pessoas.Add(new Pessoa("Leandro", 21));
            pessoas.Add(new Pessoa("Paulo", 17));
            pessoas.Add(new Pessoa("Jessica", 18));

            var pessoaMaisVelha =  pessoas.OrderByDescending(a=> a.Idade).ToList()[0];
            
            foreach(Pessoa p in pessoas){
                System.Console.WriteLine($"Os indivíduos presentes estão separados por Nome e Idade são: {p.Nome + " " + p.Idade}");
            }

            System.Console.WriteLine("");
            System.Console.Write($"Já a pessoa mais velha presente no grupo: {pessoaMaisVelha.Nome} com ");   
            System.Console.WriteLine($"{pessoaMaisVelha.Idade} anos");
        }
      
    } 
}
