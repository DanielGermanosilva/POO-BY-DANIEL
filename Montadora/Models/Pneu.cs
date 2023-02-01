namespace Models
{
    public class Pneu
    {
        public string Cor { get; set; }
        public int Aro { get; set; }
        public string Tipo { get; set; }
        public bool TWI { get; set; }
        public int PERCENTUALBORRACHA { get; set; }
        public bool Estourado { get; set; }
        public int velocidademaxima { get; set; }
        public int velocidadeatual { get; set; }
        public bool estepe { get; set; }

        public void Girar(int _velocidade)
        {
            velocidadeatual = velocidadeatual + _velocidade;
            PERCENTUALBORRACHA = PERCENTUALBORRACHA - 3;
            
            if (velocidadeatual > velocidademaxima || PERCENTUALBORRACHA <=30)
            {
                estourarpneu();
            }
        }

        public void estourarpneu()
        {
            Estourado = true;
            velocidadeatual = 0;
        }
        public void Frear(int _reducao)
        {
            velocidadeatual = velocidadeatual - _reducao;
            PERCENTUALBORRACHA = PERCENTUALBORRACHA - 5;

            if (PERCENTUALBORRACHA <=30)
            {
                estourarpneu();
            }

            if (velocidadeatual < 0)
            {
                velocidadeatual = 0;
            }
        }







    }
}