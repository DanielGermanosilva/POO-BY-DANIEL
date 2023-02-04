

namespace Models
{
    internal class Carro
    {
        public string? Fabricante { get; set; }  // ex. ford , audi etc
        public int Potencia { get; set; } // potencia na roda 
        public string? Cor { get; set; } // cor do veiculo
        public string? Modelo { get; set; } // ex. onix, supra , gtr , polo
        public string? Categoria { get; set; } // ex. esportivo , hypersportivo, offroad
        public string? TipoCombustivel { get; set; } // flex, gasolina, alcool
        public string? Tipo { get; set; } // sedan / conversivel
        public int Odometro { get; set; } // 10000
        public int Ano { get; set; } // 2022
        public string? Placa { get; set; } // qgb 6652
        public int VelocidadeMaxima { get; set; } // 300 km/h
        public bool CambioManual { get; set; } // true / false
        public string? Qtd_Acentos { get; set; } // 2,5,7,9
        public string? PesoCarro { get; set; } // 1000 kilos
        public bool ArCondicionado { get; set; } // true / false
        public int NivelCombustivel { get; set; } // 100
        public bool CarroLigado { get; set; } // ligado bateria
        public int VelocidadeAtual { get; set; }


        public Pneu PneuDianteiroEsquerdo { get; set; }
        public Pneu PneuDianteiroDireito { get; set; }
        public Pneu PneuTraseiroDireito { get; set; }
        public Pneu PneuTraseiroEsquerdo { get; set; }
        public Pneu PneuEstepe { get; set; }
        public Motor Motor { get; set; }





        public Carro(String _marca, string _Modelo, int _ano, int _velocidadeMaxima, string _placa)
        {
            Fabricante = _marca;
            Modelo = _Modelo;
            Ano = _ano;
            VelocidadeMaxima = _velocidadeMaxima;
            VelocidadeAtual = 0
            Placa = _placa;
            Odometro = 0;
            CarroLigado = false;
            NivelCombustivel = 0;

            PneuDianteiroDireito = new Pneu(16, 150, "Carro Passeio");
            PneuDianteiroEsquerdo = new Pneu(16, 150, "Carro Passeio");
            PneuTraseiroDireito = new Pneu(16, 150, "Carro Passeio");
            PneuTraseiroDireito = new Pneu(16, 150, "Carro Passeio");
            PneuEstepe = new Pneu(16, 70, "Espete", true);

        }

        public void Ligar()
        {
            if (CarroLigado == true)
            {
                Console.WriteLine("O carro esta ligado");
                return;
            }
            else
            {
                if (NivelCombustivel > 0)
                {
                    CarroLigado = true;
                }
            }
        }

        public void Deligar()
        {

            CarroLigado = false;
            VelocidadeAtual = 0;
            PneuDianteiroDireito.Velocidadeatual = 0;
            PneuDianteiroEsquerdo.Velocidadeatual = 0;
            PneuTraseiroDireito.Velocidadeatual = 0;
            PneuTraseiroEsquerdo.Velocidadeatual = 0;
        }
        public void Acelerar()
        {

        }

        public void Frear()
        {


        }


        public void Abastecer()
        {

        }












    }
}
