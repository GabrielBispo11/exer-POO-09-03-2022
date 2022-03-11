using System;
using System.Collections.Generic;
using System.Linq;

namespace E_4.Models
{
    public class Pessoa
    {
        public string Nome {get; set; }
        public int Idade {get; set; }

        public Pessoa(){

        }
        public Pessoa(string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }
        
        public void Exibir(List<Pessoa>P){
            var consulta = from consul in P
                           orderby consul.Idade
                           select new {consul.Nome, consul.Idade};
                            
        foreach (var item in consulta)
        {
            System.Console.WriteLine($"{item.Nome} {item.Idade}");
        }

        }
        
        // Criar o método para reconhecer a pessoa mais velha;
        // Excluir da lista pessoa maior de idade (olhar Fessor bruno (C#) - exe. similar)
        // for (int i = 0; i < P.Count; i++)  .....
        // Encontrar a Jessica;


    }
}