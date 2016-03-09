# XAMLListviewFontSize
Xamarin XAML Listview Custom Font Size and Styles

```xaml
<?xml version="1.0" encoding="UTF-8"?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms" xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml" x:Class="XAMLListviewFontSize.ListviewDemo" Padding="0,20,0,0">
	<ContentPage.Content>
		<ListView x:Name="listViewCustom" HasUnevenRows="true">
			<ListView.ItemTemplate>
				<DataTemplate>
					<ViewCell>
						<StackLayout BackgroundColor="Lime" Orientation="Vertical">
							<Label Text="{Binding name}" FontSize="50" TextColor="Blue" />
							<Label Text="{Binding comment}" TextColor="#503026" />
						</StackLayout>
					</ViewCell>
				</DataTemplate>
			</ListView.ItemTemplate>
		</ListView>
	</ContentPage.Content>
</ContentPage>
```


![image](https://cloud.githubusercontent.com/assets/8008527/13641609/1971d860-e5e7-11e5-8f98-15c4ee20fb8a.png)


**Based on** 
Xamarin.Forms - User Interface - ListView - Cell Appearance
- https://developer.xamarin.com/guides/xamarin-forms/user-interface/listview/customizing-cell-appearance/#Custom_Cells

Xamarin.Forms ListView Sample: Custom Cells
- https://developer.xamarin.com/samples/xamarin-forms/UserInterface/ListView/CustomCells/
