namespace GameShop.Paginas;

public partial class Halo : ContentPage
{
	string selectedItem;
	public Halo(string selectedItem)
	{
		InitializeComponent();

        this.selectedItem = selectedItem;
    }

    private void btnComprar3_Clicked(object sender, EventArgs e)
    {
        string link = "https://www.xbox.com/pt-BR/games/store/halo-4/9P8CFXZH93CK/0010";
        Launcher.OpenAsync(new Uri(link));
    }
}