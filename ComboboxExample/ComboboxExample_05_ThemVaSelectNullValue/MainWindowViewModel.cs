using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ComboboxExample_05_ThemVaSelectNullValue
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

        private HocSinh _SelectedItem;
        public HocSinh SelectedItem
        {
            get => _SelectedItem; set
            {
                _SelectedItem = value;
                OnPropertyChanged();
            }
        }


        public ICommand Click { get; set; }
        public MainWindowViewModel()
        {
            Lst = new List<HocSinh>()
            {
                null,
                new HocSinh(){Name="Name 1", Age=1},
                new HocSinh(){Name="Name 2", Age=2},
                new HocSinh(){Name="Name 3", Age=3},
            };
            Click = new RelayCommand<object>((q) =>
            {
                return true;
            }, (q) =>
            {
                var selec = this.SelectedItem;
            });
        }
    }
}
