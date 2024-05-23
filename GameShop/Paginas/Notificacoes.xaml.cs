namespace GameShop.Paginas;

public partial class Notificacoes : ContentPage
{
	public Notificacoes()
	{
		InitializeComponent();
	}

    private void btnComprarNotificacao_Clicked(object sender, EventArgs e)
    {
        string link = "https://store.playstation.com/pt-br/product/UP9000-PPSA01467_00-MARVELSSPIDERMAN";
        Launcher.OpenAsync(new Uri(link));
    }
}