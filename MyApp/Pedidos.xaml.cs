using Lacteo;

namespace MyApp;

public partial class Pedidos : ContentPage
{
	public Pedidos()
	{
		InitializeComponent();
	}

    private void Nosotros_Clicked(object sender, EventArgs e)
    {
        var nosotros = new MainPage();
        Application.Current.MainPage.Navigation.PushModalAsync(nosotros);
    }

    private void Productos_Clicked(object sender, EventArgs e)
    {
        var producto = new Productos();
        Application.Current.MainPage.Navigation.PushModalAsync(producto);
    }

    private void Pedidos1_Clicked(object sender, EventArgs e)
    {
        var pedidos = new Pedidos();
        Application.Current.MainPage.Navigation.PushModalAsync(pedidos);
    }

    private void Comprar_Clicked(object sender, EventArgs e)
    {
        var comprar = new Productocompra();
        Application.Current.MainPage.Navigation.PushModalAsync(comprar);
    }
}