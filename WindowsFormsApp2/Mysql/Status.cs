using System;
using System.Collections.Generic;

namespace WindowsFormsApp2.Mysql
{
    public partial class Status
    {
        public Status()
        {
            Orcamentos = new HashSet<Orcamentos>();
        }

        public int CodStatus { get; set; }
        public string Status1 { get; set; }

        public ICollection<Orcamentos> Orcamentos { get; set; }
    }
}
