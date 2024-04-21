namespace DJChusinS2.Vistas;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        string usuario = UsernameEntry.Text;
        String contrasena = PasswordEntry.Text;
        Navigation.PushAsync(new vGrid(usuario, contrasena));

    }

    private void btnCancelar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vGrid());
    }
}