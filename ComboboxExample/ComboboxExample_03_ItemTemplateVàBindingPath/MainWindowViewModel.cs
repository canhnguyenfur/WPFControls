using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboboxExample_03_ItemTemplateVàBindingPath
{
    public class MainWindowViewModel : BaseViewModel
    {
        private List<HocSinh> _Lst;
        public List<HocSinh> Lst
        {
            get => _Lst; set
            {
                _Lst = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            Lst = new List<HocSinh>()
            {
                new HocSinh(){Name="Name 1", Age=1},
                new HocSinh(){Name="Name 2", Age=2},
                new HocSinh(){Name="Name 3", Age=3},
            };
        }
    }
}
