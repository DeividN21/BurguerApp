using BurguerApp.Services;

namespace BurguerApp;

public partial class ContactoPage : ContentPage
{
    private readonly APIService _APIService;
    private readonly string _nombreUsuario;
    public ContactoPage(APIService apiservice, string nombreUsuario)
	{
		InitializeComponent();
        _APIService = apiservice;
        _nombreUsuario = nombreUsuario;
        Username.Text = $"Cliente: {_nombreUsuario}";
    }

    private async void OnClickInicio(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MainPage(_APIService, _nombreUsuario));
    }

    private async void OnClickAcerca(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AcercaDePage(_APIService, _nombreUsuario));
    }

    private async void OnClickContacto(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ContactoPage(_APIService, _nombreUsuario));
    }

    private async void OnClickMenu(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MenuPage(_APIService, _nombreUsuario));
    }

    private async void OnClickTestimonio(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new TestimoniosPage(_APIService, _nombreUsuario));
    }

    private async void OnClickLogout(object sender, EventArgs e)
    {
        bool respuesta = await DisplayAlert("Confirmar", "¿Está seguro de cerrar sesión?", "Sí", "No");

        if (respuesta)
        {
            // Si el usuario eligió "Sí", entonces se cierra la sesión.
            await Navigation.PushModalAsync(new LoginPage(_APIService));
        }
    }
}