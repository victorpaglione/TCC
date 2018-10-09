using System;
using System.Collections.Generic;

namespace WindowsFormsApp2.Mysql
{
    public partial class Avaliacao
    {
        public Avaliacao()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int CodAva { get; set; }
        public string Avaliacao1 { get; set; }

        public ICollection<Cliente> Cliente { get; set; }
    }
}
