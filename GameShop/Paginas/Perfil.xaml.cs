using GameShop.Model;

namespace GameShop.Paginas;


public partial class Perfil : ContentPage
{
    private Usuario _usuario;
	public Perfil()
	{
		InitializeComponent();

        _usuario = App.Usuario;
        this.BindingContext = _usuario;

        fotoPerfil.Clicked += async (sender, e) =>
        {
            if (MediaPicker.IsCaptureSupported)
            {
                var file = await MediaPicker.PickPhotoAsync();
                if (file != null)
                {
                    var filePath = file.FullPath;

                    fotoPerfil.Source = ImageSource.FromFile(filePath);

                    _usuario.Foto = filePath;
                    await App.BancoDados.UsuarioDataTable.SalvarUsuario(_usuario);
                }
            }
        };
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

    private async void btnLogout_Clicked(object sender, EventArgs e)
    {
        App.Usuario = null;
        await Navigation.PopToRootAsync();
    }
}