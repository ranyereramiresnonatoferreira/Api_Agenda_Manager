namespace Agenda_Manager.Models.Models
{
    public class DadosBancariosModel
    {
        public int Id { get; set; }
        public int IdCadastro { get; set; }
        public string CodBancario { get; set; }
        public string Tipo { get; set; }
        public string Agencia { get; set; }
        public string? DigitoAgencia { get; set; }
        public string Conta { get; set; }
        public string? DigitoConta { get; set; }
        public string? ChavePix { get; set; }
    }
}
