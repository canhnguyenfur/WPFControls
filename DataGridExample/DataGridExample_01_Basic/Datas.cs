using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridExample_01_Basic
{
    public class HocSinh
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsCheck { get; set; }
        public bool IsCheck2 { get; set; }
        public bool IsCheck3 { get; set; }
        public bool IsCheck4 { get; set; }
        public bool IsCheck5 { get; set; }
        public bool IsCheck6 { get; set; }
        public bool IsCheck7 { get; set; }
        public bool IsCheck8 { get; set; }
        public bool IsCheck9 { get; set; }
    }
   public class Datas
    {
        public List<HocSinh> Items { get; set; } = new List<HocSinh>()
        {
            new HocSinh(){Name="Huy1", Age=18, IsCheck=true},
            new HocSinh(){Name="Huy2", Age=18, IsCheck=false},
            new HocSinh(){Name="Huy3", Age=20, IsCheck=true},
            new HocSinh(){Name="Huy4", Age=32, IsCheck=false},
        };
    }
}
