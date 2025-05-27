using SfDataGridSample.ViewModel;
using Syncfusion.Maui.Buttons;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SfCheckBox_StateChanged(object sender, Syncfusion.Maui.Buttons.StateChangedEventArgs e)
		{
			var viewModel = BindingContext as SampleViewModel;
			
				if (viewModel != null && !viewModel._isUpdating)
				{
					viewModel._isUpdating = true;
					if (viewModel.Items.All(x => x.IsChecked == true))
					{
						viewModel.SelectAllChecked = true;
					}
					else if (viewModel.Items.All(x => x.IsChecked == false))
					{
						viewModel.SelectAllChecked = false;
					}
					else
					{					
						viewModel.SelectAllChecked = null;
					}
					viewModel._isUpdating = false;
				}			
			}

		private void SfCheckBox_StateChanged_1(object sender, StateChangedEventArgs e)
		{
			var viewModel = BindingContext as SampleViewModel;
			if (viewModel != null)
			{
				if (!viewModel._isUpdating)
				{
					viewModel._isUpdating = true;
					foreach (var item in viewModel.Items)
					{
						item.IsChecked = viewModel.SelectAllChecked;
					}
					viewModel._isUpdating = false;
				}
			}
		}
    }

}
