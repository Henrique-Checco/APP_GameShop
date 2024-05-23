namespace GameShop.Paginas;

public partial class God : ContentPage
{
	string selectedItem;
	public God(string selectedItem)
	{
		InitializeComponent();

		this.selectedItem = selectedItem;
	}

    private void btnComprar4_Clicked(object sender, EventArgs e)
    {
        string link = "https://store.playstation.com/pt-br/product/UP9000-CUSA01623_00-0000GODOFWAR3PS4";
        Launcher.OpenAsync(new Uri(link));
    }
}