using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace DZ_LABEL_MVVM
{
    public class Label : INotifyPropertyChanged
    {
        private Color background;
        private double fontsize;
        private string fontfamily;
        private double height;
        private double width;



        public Color Background
        {
            get { return background; }
            set
            {
                background = value;
                OnPropertyChanged();
            }
        }

        public double Fontsize
        {
            get { return fontsize; }
            set
            {
                fontsize = value;
                OnPropertyChanged();
            }
        }

        public string Fontfamily
        {
            get { return fontfamily; }
            set
            {
                fontfamily = value;
                OnPropertyChanged();
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                height = value;
                OnPropertyChanged();

            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                width = value;
                OnPropertyChanged();
            }
        }

        public string ColorName
        {
            get
            {
                var colorName = typeof(Colors)
                    .GetProperties()
                    .FirstOrDefault(f => f.GetValue(null).ToString() == background.ToString());

                return colorName != null ? colorName.Name : background.ToString();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
