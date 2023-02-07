

using System.Net;

namespace Models
{
    internal class Motor
    {
        public int QuantidadeCilindros { get; set; } // 3 , 4 , 6 , 8 , 10 , 12
        public string? Disposicaocilindros { get; set; } // V , W , EM LINHA , OPOSTOS
        public float Litragem { get; set; } // 2.0 , 3.0 , 1.0
        public int QntVauvulas { get; set; } // 16 , 32 
        public string? ConfMotor { get; set; } // OHC , OHV
        public string? CursoCilindro { get; set; } // subquadrado , quadrado , superquadrado
        public string? Admissao { get; set; } // Aspirado, Naturalmente Aspirado , Turbo, Twin Turbo, Super chager
        public string? PesoMotor { get; set; } // 1000 kilos
        public string? TaxaCompressao { get; set; } //  ex 8,5:1
        public string? RotacaoMaxima { get; set; } // 7000 rpm
        public int PotenciaMotor { get; set; } // 1000 cv no eixo do motor
        public string? SistemaInjecao { get; set; } // semi injetado , injetado , Carburado
        public bool MotorLigado { get; set; } // Partida do motor


        public void LigarMotor()
        {

        }


    }
}
