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

        public void Abastecer(int combustivel){
            litrosCombustivel += combustivel;
            if(litrosCombustivel>60){
                int sobraCombustivel = litrosCombustivel - (60);
                litrosCombustivel -= sobraCombustivel;
            }
        }

        public void Frear(){
            if(Velocidade == 0){
                System.Console.WriteLine("O veículo encontra-se parado (0 km/h)");
            }else{
                Velocidade -= 20;
                System.Console.WriteLine("A velocidade atual do veículo é de: " + Velocidade);
            }
        }

        public void Pintar(string Cor)
        {
            this.Cor = Cor;
        }

        public void Ligar()
        {
            if(!isLigado){
                isLigado = true;
                System.Console.WriteLine("Ligando o carro");
            }else{
                 System.Console.WriteLine("O carro encontra-se ligado");
            }
        }

        public void Desligar()
        {
        
        }

        // Não consegui implementar o método desligar e nem validar o combustível, cor e ligar (sorry);














        
    }
}
