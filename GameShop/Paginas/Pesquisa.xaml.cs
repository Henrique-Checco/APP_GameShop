using CommunityToolkit.Maui.Converters;

namespace GameShop.Paginas;

public partial class Pesquisa : ContentPage
{
    List<string> resultados = new List<string>
    {
        "Ghost Of Tsushima",
        "Super Mario Odyssey",
        "Halo 4",
        "God Of War III",
        "Infamous",
        "Forza Horizon 5"
    };

    ListView listView;

    public Pesquisa()
    {
        InitializeComponent();

        var searchBar = new SearchBar
        {
            Placeholder = "Pesquisar...",
            HorizontalOptions = LayoutOptions.FillAndExpand,
            TextColor = Color.FromHex("#FFFFFF"),
            PlaceholderColor = Color.FromHex("#FFFFFF"),
            BackgroundColor = Color.FromHex("#282727"),
        };

        searchBar.TextChanged += (sender, e) =>
        {
            // Lógica para filtrar os resultados conforme o texto digitado na barra de pesquisa
            var resultadoFiltrado = resultados.FindAll(item => item.ToLower().Contains(e.NewTextValue.ToLower()));

            // Atualizar a lista com os resultados filtrados
            AtualizarLista(resultadoFiltrado);
        };

        listView = new ListView(); // Instanciação movida para o construtor

        listView = new ListView
        {
            ItemTemplate = new DataTemplate(() =>
            {
                var label = new Label();
                label.SetBinding(Label.TextProperty, ".");
                label.TextColor = Color.FromHex("#ffffff");
                return new ViewCell { View = label };
            })
        };

        listView.ItemTapped += async (sender, e) =>
        {
            if (e.Item != null)
            {
                string selectedItem = e.Item.ToString();
                Page nextPage = null;

                // Determinar qual página abrir com base no valor selecionado
                if (selectedItem == "Ghost Of Tsushima")
                {
                    nextPage = new Ghost(selectedItem);
                }
                else if (selectedItem == "Super Mario Odyssey")
                {
                    nextPage = new Mario(selectedItem);
                }
                else if (selectedItem == "God Of War III")
                {
                    nextPage = new God(selectedItem);
                }
                else if (selectedItem == "Halo 4")
                {
                    nextPage = new Halo(selectedItem);
                }
                else if (selectedItem == "Infamous")
                {
                    nextPage = new Infamous(selectedItem);
                }
                else if (selectedItem == "Forza Horizon 5")
                {
                    nextPage = new Forza(selectedItem);
                }

                if (nextPage != null)
                {
                    await Navigation.PushAsync(nextPage);
                    ((ListView)sender).SelectedItem = null; // Deselecionar item
                }
            }
        };

        //Gambiarra para tirar o background Laranja
        listView.ItemTapped += async (sender, e) =>
        {
            if (e.Item != null)
            {
                if (e.Item is ViewCell selectedCell)
                {
                    string selectedItem = (selectedCell.View.BindingContext as string);

                }
            }

            ((ListView)sender).SelectedItem = null;
        };

        Content = new StackLayout
        {
            Children = { searchBar, listView }
        };
    }

    void AtualizarLista(List<string> itens)
    {
        listView.ItemsSource = itens;
    }

    private async void btnHome_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Home());
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
}