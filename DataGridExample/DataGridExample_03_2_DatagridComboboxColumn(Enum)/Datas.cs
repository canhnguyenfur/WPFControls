using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridExample_03_2_DatagridComboboxColumn_Enum_
{
    public enum Sex
    {
        Male,Female,Other
    }
    public class HocSinh
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsCheck { get; set; }
        public string Info { get; set; }
        public Sex Sex { get; set; }
    }
   public class Datas
    {
        public List<HocSinh> Items { get; set; } = new List<HocSinh>()
        {
            new HocSinh(){Name="Huy1", Age=18, IsCheck=true, Info="https://api.test/Id=1",Sex= Sex.Female},
            new HocSinh(){Name="Huy2", Age=18, IsCheck=false,Info="https://api.test/Id=2",Sex= Sex.Male},
            new HocSinh(){Name="Huy3", Age=20, IsCheck=true, Info="https://api.test/Id=3",Sex= Sex.Other},
            new HocSinh(){Name="Huy4", Age=32, IsCheck=false,Info="https://api.test/Id=4",Sex= Sex.Female},
        };
    }
}
