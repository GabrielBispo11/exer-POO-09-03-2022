namespace E_7.Models
{
    public class Vendedor
    {
        public double salario { get; set; }

        public Vendedor(double salario)
        {
            this.salario = salario;
        }

        public double Bonificacao(double salario)
        {
            salario = salario + 3000;
            return salario;
        }

    }
}