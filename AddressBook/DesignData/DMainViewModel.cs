using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using AddressBook.ViewModels;

namespace AddressBook.DesignData
{
    public class DMainViewModel : IMainViewModel
    {
        public DMainViewModel()
        {
            IsBusy = false;
            Clients = new ObservableCollection<IPersonViewModel>(
                new List<IPersonViewModel>
                {
                    new DPersonViewModel(),
                });
        }

        public ObservableCollection<IPersonViewModel> Clients { get; set; }
        public ICommand AddNewClientCommand { get; set; }
        public bool IsBusy { get; set; }
    }
}
