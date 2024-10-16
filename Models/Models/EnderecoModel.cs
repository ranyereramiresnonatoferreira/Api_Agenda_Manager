﻿namespace Agenda_Manager.Models.Models
{
    public class EnderecoModel
    {
        public int Id { get; set; }
        public int IdCadastro { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string? Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Pais { get; set; }
    }
}
