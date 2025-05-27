# How to implement select all checkbox column in .NET MAUI DataGrid(SfDataGrid) ?
This sample demonstrates how to implement a **Select All** checkbox column in the Syncfusion [.NET MAUI DataGrid](https://help.syncfusion.com/maui/datagrid/overview) (`SfDataGrid`). It allows users to select or deselect all rows using a single checkbox in the header, while also enabling individual row selection.

## Xaml
```
   <ContentPage.BindingContext>
       <local:SampleViewModel x:Name="viewModel" />
   </ContentPage.BindingContext>

       <syncfusion:SfDataGrid x:Name="SampleGrid"
                              HeaderGridLinesVisibility="Both"
                              GridLinesVisibility="Both"
                              ItemsSource="{Binding Items}"
                              ColumnWidthMode="Auto"
                              AutoGenerateColumnsMode="None">
           <syncfusion:SfDataGrid.Columns>
               <syncfusion:DataGridTemplateColumn HeaderText="Select All">
                   <syncfusion:DataGridTemplateColumn.HeaderTemplate>
                       <DataTemplate>
                           <buttons:SfCheckBox x:Name="checkBox"
                                             BindingContext="{Binding Source={x:Reference MyPage},Path=BindingContext}"
                                             IsThreeState="True"
                                             IsChecked="{Binding SelectAllChecked,Mode=TwoWay}"
                                             StateChanged="SfCheckBox_StateChanged_1" />
                       </DataTemplate>
                   </syncfusion:DataGridTemplateColumn.HeaderTemplate>
                   <syncfusion:DataGridTemplateColumn.CellTemplate>
                       <DataTemplate>
                           <buttons:SfCheckBox IsChecked="{Binding IsChecked}" StateChanged="SfCheckBox_StateChanged" />
                       </DataTemplate>
                   </syncfusion:DataGridTemplateColumn.CellTemplate>
               </syncfusion:DataGridTemplateColumn>
               <syncfusion:DataGridCheckBoxColumn MappingName="SelectAllChecked"
                                                    HeaderText="SelectAll" />
               <syncfusion:DataGridTextColumn HeaderText="Name"
                                          MappingName="Name" />
               <syncfusion:DataGridTextColumn HeaderText="Description"
                                          MappingName="Description" />
               <syncfusion:DataGridTextColumn HeaderText="Category"
                                          MappingName="Category" />
               <syncfusion:DataGridTextColumn HeaderText="Price"
                                          MappingName="Price" />
           </syncfusion:SfDataGrid.Columns>
       </syncfusion:SfDataGrid>
```

   ## Xaml.cs
```
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
```

### ScreenShot
<img src="https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjQwNjY0Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9._kkYJ5p5hPQUfYUfJ9Tbpuq3TZDI6S2xwqSCG5dzUKs" width=800/>

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-implement-select-all-checkbox-column-in-.NET-MAUI-DataGrid-SfDataGrid)

 Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).

### Conclusion
I hope you enjoyed learning about How to implement select all checkbox column in SfDataGrid.

You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.

If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums),[Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!
