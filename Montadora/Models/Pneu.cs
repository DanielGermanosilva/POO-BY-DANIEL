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

        public void Girar(int _velocidade)
        {
            Velocidadeatual = Velocidadeatual + _velocidade;
            PERCENTUALBORRACHA = PERCENTUALBORRACHA - 3;
            
            if (Velocidadeatual > Velocidademaxima || PERCENTUALBORRACHA <=30)
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

            if (PERCENTUALBORRACHA <=30)
            {
                Estourarpneu();
            }

            if (Velocidadeatual < 0)
            {
                Velocidadeatual = 0;
            }
        }







    }
}