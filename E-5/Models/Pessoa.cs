using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_5.Models
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
        
        public void Excluir(List<Pessoa>pessoas)
        {
            for(int i = 0; i < pessoas.Count; i++)
            {
                if(pessoas[i].Idade < 18)
                {
                    pessoas.Remove(pessoas[i]);
                }
            } 
        }



        // Encontrar a Jessica;


    }
}