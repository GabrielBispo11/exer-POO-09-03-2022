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
