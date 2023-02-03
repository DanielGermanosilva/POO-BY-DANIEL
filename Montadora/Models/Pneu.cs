namespace Models
{
    public class Pneu
    {
        public string Cor { get; set; } = string.Empty;
        public int Aro { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public bool TWI { get; set; }
        public int PERCENTUALBORRACHA { get; set; }
        public bool Estourado { get; set; }
        public int Velocidademaxima { get; set; }
        public int Velocidadeatual { get; set; }
        public bool Estepe { get; set; }

        public bool Furado { get; set; }
        public string Marca { get; set; } = string.Empty;


        public Pneu()
        {
            Velocidadeatual = 0;
        }

        public void Girar(int _velocidade)
        {

            if(Estourado == true)
            {
                Console.WriteLine("O Pneu esta estourado!");
                return;
            }
            if(Furado == true)
            {
                Console.WriteLine("O Pneu esta furado!");
                return;
            }

            Velocidadeatual = Velocidadeatual + _velocidade;
            PERCENTUALBORRACHA = PERCENTUALBORRACHA - 3;

            if (Velocidadeatual > Velocidademaxima || PERCENTUALBORRACHA <= 30)
            {
                Estourarpneu();
            }
        }

        public void Estourarpneu()
        {
            Estourado = true;
            Velocidadeatual = 0;
        }
        public void Frear(int _reducao)
        {
            Velocidadeatual = Velocidadeatual - _reducao;
            PERCENTUALBORRACHA = PERCENTUALBORRACHA - 5;

            if (PERCENTUALBORRACHA <= 30)
            {
                Estourarpneu();
            }

            if (Velocidadeatual < 0)
            {
                Velocidadeatual = 0;
            }
        }




        public void Exibirinfopneu()
        {

            Console.WriteLine("Aro: " + Aro);
            Console.WriteLine("Percentual Borracha: " + PERCENTUALBORRACHA);
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Velocidade Maxima: " + Velocidademaxima);
            Console.WriteLine("Estepe: " + Estepe);
            Console.WriteLine("Estourado: " + Estourado);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("TWI: " + TWI);
            Console.WriteLine("Velocidade Atual: " + Velocidadeatual);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Furado: " + Furado);







        }


    }
}