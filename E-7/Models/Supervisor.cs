namespace E_7.Models
{
    public class Supervisor
    {
        public double salario { get; set; }

        public Supervisor(double salario)
        {
            this.salario = salario;
        }

        public double Bonificacao(double salario)
        {
            salario = salario + 5000;
            return salario;
        }


    }


}