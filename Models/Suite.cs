namespace DioHotelPottencial.Models
{
    public class Suite
    {
        public Suite() {
            TipoSuite = "";
            Capacidade = 0;
            ValorDiaria = 0;
        }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public Suite(string tipoSuite, decimal valorDiaria) 
        {
            this.TipoSuite = tipoSuite;
            this.ValorDiaria = valorDiaria;
        }

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}