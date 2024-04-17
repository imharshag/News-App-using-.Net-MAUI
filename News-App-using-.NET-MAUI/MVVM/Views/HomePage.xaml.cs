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
		ArticleList1.ItemsSource = await new NewsViewModel().LoadNews();

	}

}