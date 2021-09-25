using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridExample_03_1_CustomizeColumns
{
    public class HocSinh
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsCheck { get; set; }
        public string Info { get; set; }
    }
   public class Datas
    {
        public List<HocSinh> Items { get; set; } = new List<HocSinh>()
        {
            new HocSinh(){Name="Huy1", Age=18, IsCheck=true, Info="https://api.test/Id=1"},
            new HocSinh(){Name="Huy2", Age=18, IsCheck=false,Info="https://api.test/Id=2"},
            new HocSinh(){Name="Huy3", Age=20, IsCheck=true, Info="https://api.test/Id=3"},
            new HocSinh(){Name="Huy4", Age=32, IsCheck=false,Info="https://api.test/Id=4"},
        };
    }
}
