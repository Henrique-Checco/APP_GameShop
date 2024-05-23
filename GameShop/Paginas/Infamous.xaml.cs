namespace GameShop.Paginas;

public partial class Infamous : ContentPage
{
    string selectedItem;
    public Infamous(string selectedItem)
	{
		InitializeComponent();

		this.selectedItem = selectedItem;
	}
}