using System.Windows.Input;
using AddressBook.ViewModels;

namespace AddressBook.DesignData
{
    public class DPersonViewModel : IPersonViewModel
    {
        public DPersonViewModel()
        {
            Name = "Joe";
            Surname = "Bloggs";
            Age = 40;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand CloseCommand { get; set; }
    }
}
