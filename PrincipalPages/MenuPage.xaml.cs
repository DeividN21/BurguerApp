using BurguerApp.Models;
using BurguerApp.Models.Catalogos;
using BurguerApp.ProductoPages;
using BurguerApp.Services;
using BurguerApp.Utils.Catalogos;
using CommunityToolkit.Maui.Core;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BurguerApp;

public partial class MenuPage : ContentPage
{
    private readonly APIService _APIService;
    private readonly string _nombreUsuario;

    public ObservableCollection<CategoriaComida> CategoriasComida { get; set; }

    public ObservableCollection<CategoriaCombo> CategoriasCombo { get; set; }

    public ICommand NavegarCategoriaCommand { get; }

    public ICommand NavegarCategoriaCommand1 { get; }
    public MenuPage(APIService apiservice, string nombreUsuario)
	{
		InitializeComponent();
        _APIService = apiservice;
        _nombreUsuario = nombreUsuario;
        Username.Text = $"Cliente: {_nombreUsuario}";

        CategoriasComida = new ObservableCollection<CategoriaComida>(new ListaCategoriasComida().categoriasComida);
        CategoriasCombo = new ObservableCollection<CategoriaCombo>(new ListaCategoriasCombo().categoriasCombo);

       /* NavegarCategoriaCommand = new Command<CategoriaComida>(NavegarCategoria);
        NavegarCategoriaCommand1 = new Command<CategoriaCombo>(NavegarCategoria1);*/
        BindingContext = this;
    }

    /*private async void NavegarCategoria(CategoriaComida categoria)
    {
        var productos = await _APIService.ObtenerCategoriaComida(categoria.CategoriaId_Comida);

        // Navegar a la página correspondiente
        switch (categoria.CategoriaId_Comida)
        {
            case 1: // Hamburguesas
                await Navigation.PushModalAsync(new HamburTradPage(_APIService, _nombreUsuario));
                break;
            case 2: // Acompanamientos
                await Navigation.PushModalAsync(new AcompaniaPage(_APIService, _nombreUsuario));
                break;
            case 3: // Bebidas
                await Navigation.PushModalAsync(new BebidasPage(_APIService, _nombreUsuario));
                break;
            case 4: // Postres
                await Navigation.PushModalAsync(new PostresPage(_APIService, _nombreUsuario));
                break;

            default:
                break;
        }
    }

    private async void NavegarCategoria1(CategoriaCombo categoria)
    {
        var productos = await _APIService.ObtenerCategoriaCombo(categoria.CategoriaId_Combo);

        // Navegar a la página correspondiente
        switch (categoria.CategoriaId_Combo)
        {
            case 1: // Combos Familiares
                await Navigation.PushModalAsync(new CombosPage(_APIService, _nombreUsuario));
                break;
            case 2: // Combos Individuales
                await Navigation.PushModalAsync(new CombosPage(_APIService, _nombreUsuario));
                break;
            case 3: // Combos Infantiles
                await Navigation.PushModalAsync(new CombosPage(_APIService, _nombreUsuario));
                break;

            default:
                break;
        }
    }*/

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        List<Comida> ListaComida = await _APIService.ObtenerComidas();
        var comidas = new ObservableCollection<Comida>(ListaComida);
        ListaComidas.ItemsSource = comidas;
        List<Combo> ListaCombo = await _APIService.ObtenerCombos();
        var combos = new ObservableCollection<Combo>(ListaCombo);
        ListaCombos.ItemsSource = combos;
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


    private async void OnClickShowDetalleComida(object sender, SelectedItemChangedEventArgs e)
    {
        Comida comida = e.SelectedItem as Comida;
        await Navigation.PushModalAsync(new DetalleComidaPage(_APIService, _nombreUsuario)
        {
            BindingContext = comida,
        });
    }

    private async void OnClickShowDetalleCombo(object sender, SelectedItemChangedEventArgs e)
    {
        Combo combo = e.SelectedItem as Combo;
        await Navigation.PushModalAsync(new DetalleComidaPage(_APIService, _nombreUsuario)
        {
            BindingContext = combo,
        });
    }



    //Navegacion a pagina de carrito

    /* 
     private async void OnClickCarrito(object sender, EventArgs e)
     {
         await Navigation.PushModalAsync(new HamburTradPage(_APIService, _nombreUsuario));
     }*/
}