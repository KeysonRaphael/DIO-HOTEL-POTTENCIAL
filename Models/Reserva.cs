namespace DioHotelPottencial.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() {
            DiasReservados = 0;
            Suite = new Suite();
            Hospedes = new List<Pessoa>();
        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Suite = new Suite();
            Hospedes = new List<Pessoa>();
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade da suite é menor que o número de hóspedes recebidos.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                valor -= (valor*10)/100;
            }
            return valor;
        }
    }
}