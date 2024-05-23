

namespace GameShop.Paginas;

public partial class Perfil : ContentPage
{
	public Perfil()
	{
		InitializeComponent();

        fotoPerfil.Clicked += async (sender, e) =>
        {
            if (MediaPicker.IsCaptureSupported)
            {
                var file = await MediaPicker.PickPhotoAsync();
                if (file != null)
                {
                    var stream = await file.OpenReadAsync();

                    // Converta a imagem para um stream de bytes
                    byte[] imageData;
                    using (var memoryStream = new MemoryStream())
                    {
                        await stream.CopyToAsync(memoryStream);
                        imageData = memoryStream.ToArray();
                    }

                    // Crie uma ImageSource a partir do stream de bytes
                    ImageSource imageSource = ImageSource.FromStream(() => new MemoryStream(imageData));

                    // Defina a fonte da imagem
                    fotoPerfil.Source = imageSource;
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