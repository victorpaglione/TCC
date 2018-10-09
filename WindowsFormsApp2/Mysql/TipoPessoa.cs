using System;
using System.Collections.Generic;

namespace WindowsFormsApp2.Mysql
{
    public partial class TipoPessoa
    {
        public TipoPessoa()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int CodTipoPessoa { get; set; }
        public string TipoPessoa1 { get; set; }

        public ICollection<Cliente> Cliente { get; set; }
    }
}
