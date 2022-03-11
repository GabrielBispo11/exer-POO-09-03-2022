namespace E_2.Models
{
    public abstract class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public Produto()
        {

        }

        public Produto (string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public double getPreco()
        {
            return this.preco;
        }
        public void setPreco(double preco)
        {
            this.preco = preco;
        }
        public int getQuantidade()
        {
            return this.quantidade;
        }
        // public void setQuantidade()
        // {
            // this.quantidade = quantidade;
        // }







    }
}