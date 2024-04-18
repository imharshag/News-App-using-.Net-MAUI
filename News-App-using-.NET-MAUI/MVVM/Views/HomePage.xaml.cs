using News_App_using_.NET_MAUI.MVVM.Models;
using News_App_using_.NET_MAUI.MVVM.ViewModels;

namespace News_App_using_.NET_MAUI.MVVM.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		CategoryView.BindingContext = new CategoryViewModel();
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
		CallAPI("general");

	}

    private async void CallAPI(string v)
    {
        ArticleList1.ItemsSource = await new NewsViewModel()
			.LoadNews(v);
    }

    private void ArticleList1_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		var selectedItem = (e.CurrentSelection.FirstOrDefault()) as Category;
		CallAPI(selectedItem.Name);
	}

	private void ArticleList1_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
	{
        var selectedItem = (e.CurrentSelection.FirstOrDefault()) as Article;
		Navigation.PushAsync(new DetailsPage(selectedItem));

    }

}