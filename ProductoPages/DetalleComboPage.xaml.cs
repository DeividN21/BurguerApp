using BurguerApp.Models;
using BurguerApp.Services;

namespace BurguerApp.ProductoPages;

public partial class DetalleComboPage : ContentPage
{
    private Combo _combo;
    private readonly APIService _APIService;
    private readonly string _nombreUsuario;
    public DetalleComboPage(APIService apiService, string nombreUsuario)
	{
		InitializeComponent();
        _APIService = apiService;
        _nombreUsuario = nombreUsuario;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _combo = BindingContext as Combo;
        NombreCombo.Text = _combo.Nombre;
        Descuento.Text = _combo.Descuento.ToString();
        DescripcionCombo.Text = _combo.Descripcion;

    }

    private async void OnClickRegresarMenu(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MenuPage(_APIService, _nombreUsuario));
    }
}