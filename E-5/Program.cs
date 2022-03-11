using System;
using System.Collections.Generic;
using System.Linq;
using E_5.Models;

namespace E_5
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

             individuos.Excluir(pessoas);
             System.Console.WriteLine("----------------------------------------------------------------------");

            System.Console.WriteLine("");
            System.Console.WriteLine("Pessoas remanecentes após a exclusão (idade inferior a 18 anos): ");
            System.Console.WriteLine("");
            foreach(var item in pessoas)
            {
                System.Console.WriteLine($"Nome: {item.Nome}: | Idade: {item.Idade} ");
            }



        }
      
    } 
}