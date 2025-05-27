using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SfDataGridSample.Model
{
    public class ItemModel : INotifyPropertyChanged
    {
        private bool? _isChecked;
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string SKU { get; set; }
        public string Supplier { get; set; }
        public string Location { get; set; }
        public double Discount { get; set; }
        public double Rating { get; set; }

        public bool? IsChecked
        {
            get => _isChecked;
            set
            {
                if (_isChecked != value)
                {
                    _isChecked = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
