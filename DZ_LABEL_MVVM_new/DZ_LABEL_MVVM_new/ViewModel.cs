using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace DZ_LABEL_MVVM
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Label selectedLabel;
        public ObservableCollection<Label> Labels { get; set; }

        public Label SelectedLabel
        {
            get { return selectedLabel; }
            set
            {
                selectedLabel = value;
                OnPropertyChanged();
            }
        }

        public ViewModel()
        {
            Labels = new ObservableCollection<Label>
            {
               new Label {Background = Colors.Violet, Fontsize = 22, Fontfamily="Algerian", Height = 150, Width = 250 },
               new Label {Background = Colors.Pink, Fontsize = 20, Height = 175, Fontfamily="Tahoma", Width = 305},
               new Label {Background = Colors.Green, Fontsize = 13, Height = 130, Fontfamily = "Segoe Print", Width = 190},
               new Label {Background = Colors.Red, Fontsize = 15, Fontfamily = "Comic Sans Ms", Height = 115, Width = 185},
            };
        }



        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
