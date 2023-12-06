using BurguerApp.Models;
using BurguerApp.Services;

namespace BurguerApp;

public partial class LoginPage : ContentPage
{
    private readonly APIService _APIService;
    public LoginPage(APIService apiservice)
	{
		InitializeComponent();
        _APIService = apiservice;
	}

    private async void OnClickLogin(object sender, EventArgs e)
    {
        string username = Username.Text;
        string password = Password.Text;


        Cliente cliente = await _APIService.InicioSesion(username, password);
        if (cliente != null)
        {
            Preferences.Set("NombreCliente", cliente.Nombre);
            Preferences.Set("IdCliente", cliente.ClienteId) ;
            await Navigation.PushModalAsync(new MainPage(_APIService, cliente.Nombre));
        }
        else
        {
            await DisplayAlert("Error", "Inicio de sesión fallido. Por favor verifica tus credenciales.", "OK");
        }
    }
}