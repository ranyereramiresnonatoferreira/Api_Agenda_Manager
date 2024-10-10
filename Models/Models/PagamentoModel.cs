namespace Agenda_Manager.Models.Models
{
    public class PagamentoModel
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public int IdServico { get; set; }
        public int FormaPagamento { get; set; }
    }
}
