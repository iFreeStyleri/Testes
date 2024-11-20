using System.Windows.Input;
using Testes.Common;
using Testes.Implementations.Commands;
using Testes.Utils;

namespace Testes.ViewModels
{
    public class SomeViewModel : ViewModelBase
    {
        private string _data;

        public string Data
        {
            get => _data;
            set => SetField(ref _data, value);
        }

        public ICommand GetDataCommand
        {
            get
            {
                return new RelayCommand(async () =>
                {
                    var ds = new SomeSource();
                    Data = await ds.GetData();
                    ds.Close();
                });
            }
        }
    }
}
