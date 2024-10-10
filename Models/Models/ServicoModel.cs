namespace Agenda_Manager.Models.Models
{
    public class ServicoModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int? IdCadastro { get; set; }
        public DateTime? DataHora { get; set; }
    }
}
