using News_App_using_.NET_MAUI.MVVM.Models;

namespace News_App_using_.NET_MAUI.MVVM.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(Article article)
	{
		InitializeComponent();
		ImageNews.Source = article.Image;
		Titlelbl.Text= article.Title;
		description.Text= article.Description;	

	}
}