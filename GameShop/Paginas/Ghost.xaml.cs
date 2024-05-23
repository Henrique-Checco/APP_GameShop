namespace GameShop.Paginas;

public partial class Ghost : ContentPage
{
    string selectedItem;

    public Ghost(string selectedItem)
    {
        InitializeComponent();

        this.selectedItem = selectedItem;
    }

    private void btnComprar1_Clicked(object sender, EventArgs e)
    {
        string link = "https://store.playstation.com/pt-br/product/UP9000-PPSA02225_00-GHOSTDIRECTORPS5";
        Launcher.OpenAsync(new Uri(link));
    }
}
