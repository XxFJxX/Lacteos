using MyApp;

namespace Lacteo;

public partial class Carrito : ContentPage
{
	public Carrito()
	{
		InitializeComponent();
	}

    private void Regresar_Clicked(object sender, EventArgs e)
    {
        var pedidos = new Pedidos();
        Application.Current.MainPage.Navigation.PushModalAsync(pedidos);
    }

    private void Productos_Clicked(object sender, EventArgs e)
    {
        var productocompra = new Productocompra();
        Application.Current.MainPage.Navigation.PushModalAsync(productocompra);
    }
       
    private void Carrito1_Clicked(object sender, EventArgs e)
    {
            var carrito = new Carrito();
            Application.Current.MainPage.Navigation.PushModalAsync(carrito);
        
    }
}