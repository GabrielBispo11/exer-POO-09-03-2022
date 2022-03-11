namespace E_1.Models
{
    public class Veiculo
    {
        public string Marca{get; set;}
        public string Modelo{get; set;}
        public string Placa{get; set;}
        public string Cor{get; set;}
        public double Km{get; set;}
        public bool isLigado{get; set;}
        public int litrosCombustivel{get; set;}
        public int Velocidade{get; set;}
        public double Preco{get; set;}

        public Veiculo (string Marca, string Modelo, string Placa, string Cor, double Preco)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Placa = Placa;
            this.Cor = Cor;
            this.Preco = Preco;
        }

        public Veiculo(){

        }

        public void Acelerar(){
            Velocidade += 20;
            if(Velocidade>120){
                System.Console.WriteLine("Velocidade excedida, penalidade de mais 20km/h");
                Velocidade -= 20;
            }
        }


        // Não consegui implementar o método desligar e nem validar o combustível, cor e ligar (sorry);














        
    }
}
