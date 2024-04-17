using News_App_using_.NET_MAUI.MVVM.Views;

namespace News_App_using_.NET_MAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HomePage();
        }
    }
}
