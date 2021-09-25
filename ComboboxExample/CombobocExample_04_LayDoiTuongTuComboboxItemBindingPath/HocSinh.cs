using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboboxExample_04_LayDoiTuongTuComboboxItemBindingPath
{
    public class HocSinh
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int RandomNum()
        {
            var rand = new Random();
            return rand.Next();
        }
    }
}
