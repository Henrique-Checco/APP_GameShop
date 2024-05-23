namespace GameShop.Paginas;

public partial class Carrinho : ContentPage
{
	public Carrinho()
	{
		InitializeComponent();
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

    private async void btnGhost_Clicked(object sender, EventArgs e)
    {

        string selectedItem = "Ghost of Tsushima";

        Ghost ghostPage = new Ghost(selectedItem);

        Navigation.PushAsync(ghostPage);
    }

    private async void btnMario_Clicked(object sender, EventArgs e)
    {
        string selectedItem = "Super Mario Odyssey";

        Mario marioPage = new Mario(selectedItem);

        Navigation.PushAsync(marioPage);
    }

    private async void btnHalo_Clicked(object sender, EventArgs e)
    {
        string selectedItem = "Halo 4";

        Halo haloPage = new Halo(selectedItem);

        Navigation.PushAsync(haloPage);
    }

    private async void btnGod_Clicked(object sender, EventArgs e)
    {
        string selectedItem = "God Of War III";

        God godPage = new God(selectedItem);

        Navigation.PushAsync(godPage);
    }

    private async void btnInfamous_Clicked(object sender, EventArgs e)
    {
        string selectedItem = "Infamous";

        Infamous infamousPage = new Infamous(selectedItem);

        Navigation.PushAsync(infamousPage);
    }

    private async void btnForza_Clicked(object sender, EventArgs e)
    {
        string selectedItem = "Forza Horizon 5";

        Forza forzaPage = new Forza(selectedItem);

        Navigation.PushAsync(forzaPage);
    }
}