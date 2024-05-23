namespace GameShop.Paginas;

public partial class Forza : ContentPage
{
    string selectedItem;
    public Forza(string selectedItem)
	{
		InitializeComponent();

		this.selectedItem = selectedItem;
	}

    private void btnComprar5_Clicked(object sender, EventArgs e)
    {
        string link = "https://www.xbox.com/pt-br/games/store/forza-horizon-5-edicao-padrao/9nkx70bbcdrn";
        Launcher.OpenAsync(new Uri(link));
    }
}