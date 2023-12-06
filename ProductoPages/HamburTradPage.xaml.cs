using BurguerApp.Services;

namespace BurguerApp;

public partial class HamburTradPage : ContentPage
{
    private readonly APIService _APIService;
    private readonly string _nombreUsuario;
    public HamburTradPage(APIService apiservice, string nombreUsuario)
	{
		InitializeComponent();
        _APIService = apiservice;
        _nombreUsuario = nombreUsuario;
        Username.Text = $"Cliente: {_nombreUsuario}";
    }

    //Navegacion entre paginas principales
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

    //Boton para cerrar sesion

    private async void OnClickLogout(object sender, EventArgs e)
    {
        bool respuesta = await DisplayAlert("Confirmar", "¿Está seguro de cerrar sesión?", "Sí", "No");

        if (respuesta)
        {
            // Si el usuario eligió "Sí", entonces se cierra la sesión.
            await Navigation.PushModalAsync(new LoginPage(_APIService));
        }
    }

    //Navegacion entre paginas de productos

    private async void OnClickHamburguesas(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new HamburTradPage(_APIService, _nombreUsuario));
    }

    private async void OnClickAcompaniamientos(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AcompaniaPage(_APIService, _nombreUsuario));
    }

    private async void OnClickBebidas(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new BebidasPage(_APIService, _nombreUsuario));
    }

    private async void OnClickPostres(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new PostresPage(_APIService, _nombreUsuario));
    }

    private async void OnClickCombos(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new CombosPage(_APIService, _nombreUsuario));
    }

    private async void OnClickCarrito(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new HamburTradPage(_APIService, _nombreUsuario));
    }
}