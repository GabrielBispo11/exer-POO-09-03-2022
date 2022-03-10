using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace E_4.Models
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Velho;

        public String getNome(string Nome)
        {
            return Nome;
        }

        public int getIdade()
        {
            return Idade;
        }
        public void setIdade(int Idade)
        {
            this.Idade = Idade;
        }
        public Pessoa()
        {

        }

        public Pessoa(string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }
    }
}