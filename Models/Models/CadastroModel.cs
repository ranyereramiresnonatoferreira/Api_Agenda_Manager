namespace Agenda_Manager.Models.Models
{
    public class CadastroModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? IdResponsavel { get; set; }
        public string Cpf { get; set; }
        public char Sexo { get; set; }
        public string Identidade { get; set; }
        public string OrgaoExpedidor { get; set; }
        public string UfExpedicao { get; set; }
        public DateTime DataExpedicao { get; set; }
        public string Email { get; set; }
        public string Telefone1 { get; set; }
        public string? Telefone2 { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
