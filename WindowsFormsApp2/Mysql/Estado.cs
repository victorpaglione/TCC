using System;
using System.Collections.Generic;

namespace WindowsFormsApp2.Mysql
{
    public partial class Estado
    {
        public Estado()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int CodEstao { get; set; }
        public string Estado1 { get; set; }

        public ICollection<Cliente> Cliente { get; set; }
    }
}
