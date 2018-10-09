using System;
using System.Collections.Generic;

namespace WindowsFormsApp2.Mysql
{
    public partial class MetodoPag
    {
        public MetodoPag()
        {
            Orcamentos = new HashSet<Orcamentos>();
        }

        public int CodMetodo { get; set; }
        public string MPag { get; set; }

        public ICollection<Orcamentos> Orcamentos { get; set; }
    }
}
