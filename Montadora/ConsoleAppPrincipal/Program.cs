﻿using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneu1 = new Pneu();
            pneu1.Aro = 16;
            pneu1.PERCENTUALBORRACHA = 100;
            pneu1.Cor = "Preto";
            pneu1.Velocidademaxima = 150;
            pneu1.Estepe = false;
            pneu1.Estourado = false;
            pneu1.Tipo = "Rua";
            pneu1.TWI = false;
            pneu1.Furado = false;
            pneu1.Marca = "Michelin";

            Pneu pneu2 = new Pneu();
            pneu2.Aro = 16;
            pneu2.PERCENTUALBORRACHA = 100;
            pneu2.Cor = "Preto";
            pneu2.Velocidademaxima = 70;
            pneu2.Estepe = false;
            pneu2.Estourado = false;
            pneu2.Tipo = "Rua";
            pneu2.TWI = false;
            pneu2.Furado = false;
            pneu2.Marca = "Michelin";




            pneu1.Girar(20);
            pneu1.Frear(1); ;
            pneu1.Exibirinfopneu();

            Console.WriteLine("\n\n");

            pneu2.Girar(6);
            pneu2.Frear(3); ;
            pneu2.Exibirinfopneu();
        }
    }
}