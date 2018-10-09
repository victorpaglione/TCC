using System;
using System.Collections.Generic;

namespace WindowsFormsApp2.Mysql
{
    public partial class Cliente
    {
        public Cliente()
        {
            Orcamentos = new HashSet<Orcamentos>();
        }

        public int CodCliente { get; set; }
        public string NomeCliente { get; set; }
        public int TipoPessoa { get; set; }
        public int CpfCnpj { get; set; }
        public int TelFixo { get; set; }
        public int TelCel { get; set; }
        public string EmailCliete { get; set; }
        public int Uf { get; set; }
        public string Cidade { get; set; }
        public int CepCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public int AvaliacaoCliente { get; set; }
        public int OrcamentosFeitos { get; set; }

        public Avaliacao AvaliacaoClienteNavigation { get; set; }
        public TipoPessoa TipoPessoaNavigation { get; set; }
        public Estado UfNavigation { get; set; }
        public ICollection<Orcamentos> Orcamentos { get; set; }
    }
}
