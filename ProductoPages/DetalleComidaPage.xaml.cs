using BurguerApp.Models;
using BurguerApp.Services;
using Windows.Services.Maps;

namespace BurguerApp.ProductoPages;

public partial class DetalleComidaPage : ContentPage
{
    private Comida _comida;
    private readonly APIService _APIService;
    private readonly string _nombreUsuario;
    public DetalleComidaPage(APIService apiService, string nombreUsuario)
    {
		InitializeComponent();
        _APIService = apiService;
        _nombreUsuario = nombreUsuario;
    }


    protected override void OnAppearing()
    {
        base.OnAppearing();
        _comida = BindingContext as Comida;
        NombreComida.Text = _comida.Nombre;
        Precio.Text = _comida.Precio.ToString();
        DescripcionComida.Text = _comida.Descripcion;

    }

    private async void OnClickRegresarMenu(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MenuPage(_APIService, _nombreUsuario));
    }
}