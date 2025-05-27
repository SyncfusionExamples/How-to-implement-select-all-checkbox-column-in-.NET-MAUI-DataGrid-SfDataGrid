using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SfDataGridSample.Model;
using Syncfusion.Maui.Data;

namespace SfDataGridSample.ViewModel
{
    public class SampleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool? _selectAllChecked;
        public bool _isUpdating;
        private ObservableCollection<ItemModel> _items;

        public SampleViewModel()
        {
            Items = new ObservableCollection<ItemModel>
            {
                new ItemModel { Name = "Item 1", Description = "Description 1", Category = "Category A", Price = 10.0, Stock = 100, SKU = "SKU001", Supplier = "Supplier 1", Location = "Location A", Discount = 5, Rating = 4.5, IsChecked = false },
                new ItemModel { Name = "Item 2", Description = "Description 2", Category = "Category B", Price = 15.5, Stock = 200, SKU = "SKU002", Supplier = "Supplier 2", Location = "Location B", Discount = 10, Rating = 4.0, IsChecked = false },
                new ItemModel { Name = "Item 3", Description = "Description 3", Category = "Category C", Price = 20.0, Stock = 150, SKU = "SKU003", Supplier = "Supplier 3", Location = "Location C", Discount = 0, Rating = 3.5, IsChecked = false },
                new ItemModel { Name = "Item 4", Description = "Description 4", Category = "Category D", Price = 30.0, Stock = 50, SKU = "SKU004", Supplier = "Supplier 4", Location = "Location D", Discount = 15, Rating = 4.8, IsChecked = false },
                new ItemModel { Name = "Item 5", Description = "Description 5", Category = "Category E", Price = 12.0, Stock = 180, SKU = "SKU005", Supplier = "Supplier 5", Location = "Location E", Discount = 8, Rating = 4.3, IsChecked = false },
                new ItemModel { Name = "Item 6", Description = "Description 6", Category = "Category F", Price = 18.0, Stock = 70, SKU = "SKU006", Supplier = "Supplier 6", Location = "Location F", Discount = 12, Rating = 4.1, IsChecked = false },
                new ItemModel { Name = "Item 7", Description = "Description 7", Category = "Category G", Price = 22.0, Stock = 130, SKU = "SKU007", Supplier = "Supplier 7", Location = "Location G", Discount = 7, Rating = 3.9, IsChecked = false },
                new ItemModel { Name = "Item 8", Description = "Description 8", Category = "Category H", Price = 25.0, Stock = 90, SKU = "SKU008", Supplier = "Supplier 8", Location = "Location H", Discount = 5, Rating = 4.6, IsChecked = false },
                new ItemModel { Name = "Item 9", Description = "Description 9", Category = "Category I", Price = 28.0, Stock = 120, SKU = "SKU009", Supplier = "Supplier 9", Location = "Location I", Discount = 10, Rating = 4.2, IsChecked = false },
                new ItemModel { Name = "Item 10", Description = "Description 10", Category = "Category J", Price = 35.0, Stock = 60, SKU = "SKU010", Supplier = "Supplier 10", Location = "Location J", Discount = 20, Rating = 4.9, IsChecked = false }
				//new ItemModel { Name = "Item 11", Description = "Description 11", Category = "Category K", Price = 11.0, Stock = 110, SKU = "SKU011", Supplier = "Supplier 11", Location = "Location K", Discount = 3, Rating = 4.0, IsChecked = false },
				//new ItemModel { Name = "Item 12", Description = "Description 12", Category = "Category L", Price = 16.0, Stock = 140, SKU = "SKU012", Supplier = "Supplier 12", Location = "Location L", Discount = 9, Rating = 3.8, IsChecked = false },
				//new ItemModel { Name = "Item 13", Description = "Description 13", Category = "Category M", Price = 19.0, Stock = 160, SKU = "SKU013", Supplier = "Supplier 13", Location = "Location M", Discount = 2, Rating = 4.4, IsChecked = false },
				//new ItemModel { Name = "Item 14", Description = "Description 14", Category = "Category N", Price = 24.0, Stock = 130, SKU = "SKU014", Supplier = "Supplier 14", Location = "Location N", Discount = 11, Rating = 4.7, IsChecked = false },
				//new ItemModel { Name = "Item 15", Description = "Description 15", Category = "Category O", Price = 27.0, Stock = 140, SKU = "SKU015", Supplier = "Supplier 15", Location = "Location O", Discount = 6, Rating = 4.1, IsChecked = false },
				//new ItemModel { Name = "Item 16", Description = "Description 16", Category = "Category P", Price = 29.0, Stock = 100, SKU = "SKU016", Supplier = "Supplier 16", Location = "Location P", Discount = 9, Rating = 3.7, IsChecked = false },
				//new ItemModel { Name = "Item 17", Description = "Description 17", Category = "Category Q", Price = 32.0, Stock = 170, SKU = "SKU017", Supplier = "Supplier 17", Location = "Location Q", Discount = 13, Rating = 4.8, IsChecked = false },
				//new ItemModel { Name = "Item 18", Description = "Description 18", Category = "Category R", Price = 34.0, Stock = 80, SKU = "SKU018", Supplier = "Supplier 18", Location = "Location R", Discount = 4, Rating = 4.3, IsChecked = false },
				//new ItemModel { Name = "Item 19", Description = "Description 19", Category = "Category S", Price = 31.0, Stock = 90, SKU = "SKU019", Supplier = "Supplier 19", Location = "Location S", Discount = 1, Rating = 4.0, IsChecked = false },
				//new ItemModel { Name = "Item 20", Description = "Description 20", Category = "Category T", Price = 36.0, Stock = 110, SKU = "SKU020", Supplier = "Supplier 20", Location = "Location T", Discount = 18, Rating = 4.5, IsChecked = false }
			};
            this.SelectAllChecked = false;
        }

        public ObservableCollection<ItemModel> Items
        {
            get => _items;
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }

        public bool? SelectAllChecked
        {
            get => _selectAllChecked;
            set
            {
                if (_selectAllChecked != value)
                {
                    _selectAllChecked = value;
                    OnPropertyChanged();
                }
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
