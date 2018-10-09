using System;
using System.Collections.Generic;

namespace WindowsFormsApp2.Mysql
{
    public partial class Orcamentos
    {
        public int CodOrca { get; set; }
        public DateTime DataOrca { get; set; }
        public double ValorOrca { get; set; }
        public int Cliente { get; set; }
        public DateTime DataEntrega { get; set; }
        public int StatusOrca { get; set; }
        public int AnoId { get; set; }
        public int MesId { get; set; }
        public int DiaId { get; set; }
        public int MetodoPag { get; set; }

        public Cliente ClienteNavigation { get; set; }
        public MetodoPag MetodoPagNavigation { get; set; }
        public Status StatusOrcaNavigation { get; set; }
    }
}
