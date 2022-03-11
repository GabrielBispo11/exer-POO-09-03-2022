using System;
using E_1.Models;

namespace E_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();

            veiculo.Ligar();
            veiculo.Acelerar();
            veiculo.Frear();
            veiculo.Abastecer(65);
            veiculo.Desligar();

        }
    }
}

// Fiquei muito tempo vendo lista e coleções e errei no teste 1 acabei apagando. Irei entregar dessa forma! mals.