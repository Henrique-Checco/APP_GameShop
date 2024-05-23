using GameShop.Model;

namespace GameShop.Paginas;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();

        var items = new List<CollectionItem>
        {
            new CollectionItem {Image = "play.svg", Name = "PlayStation 5"},
            new CollectionItem {Image = "x.svg", Name = "Xbox Series X"},
            new CollectionItem {Image = "nin.svg", Name = "Nintendo Switch"}
        };
        carouselView.ItemsSource = items;
	}

    private async void btnPesquisa_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pesquisa());
    }

    private async void btnCart_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Carrinho());
    }

    private async void btnPerson_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Perfil());
    }

    private async void btnHome_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Home());
    }

    private void btnPlayStation_Clicked(object sender, EventArgs e)
    {
        string link = "https://store.playstation.com/pt-br/pages/latest";
        Launcher.OpenAsync(new Uri(link));
    }

    private void btnXbox_Clicked(object sender, EventArgs e)
    {
        string link = "https://www.xbox.com/pt-BR";
        Launcher.OpenAsync(new Uri(link));
    }

    private void btnNintendo_Clicked(object sender, EventArgs e)
    {
        string link = "https://www.nintendo.com/pt-br/?gad_source=1&gclid=EAIaIQobChMIpImy6paVhgMVQ2JIAB3xKg6DEAAYASAAEgL2XfD_BwE";
        Launcher.OpenAsync(new Uri(link));
    }

    private async void btnNotificacao_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Notificacoes());
    }
}