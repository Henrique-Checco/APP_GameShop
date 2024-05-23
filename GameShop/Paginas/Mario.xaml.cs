namespace GameShop.Paginas;

public partial class Mario : ContentPage
{
	string selectedItem;
	public Mario(string selectedItem)
	{
		InitializeComponent();

        this.selectedItem = selectedItem;
    }

    private void btnComprar2_Clicked(object sender, EventArgs e)
    {
        string link = "https://www.nintendo.com/pt-br/store/products/super-mario-odyssey-switch/";
        Launcher.OpenAsync(new Uri(link));
    }
}