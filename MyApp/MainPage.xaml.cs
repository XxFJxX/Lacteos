namespace MyApp;

public partial class MainPage : ContentPage
{
	public MainPage()
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

    private void Pedidos_Clicked(object sender, EventArgs e)
    {
        var pedidos = new Pedidos();
        Application.Current.MainPage.Navigation.PushModalAsync(pedidos);
    }
}

