using BurguerApp.Services;

namespace BurguerApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            APIService apiservice = new APIService();
            MainPage = new LoginPage(apiservice);
            /*MainPage = new NavigationPage(new LoginPage(apiservice));*/
        }
    }
}
