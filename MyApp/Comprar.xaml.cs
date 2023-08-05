using MyApp;

namespace Lacteo;

public partial class Comprar : ContentPage
{
	public Comprar()
	{
		InitializeComponent();
	}

    private void Regresar_Clicked(object sender, EventArgs e)
    {
        var pedidos = new Pedidos();
        Application.Current.MainPage.Navigation.PushModalAsync(pedidos);
    }
}