using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
namespace DJChusinS2.Vistas;

public partial class vGrid : ContentPage
  
{
    string usuario1;
    string contrasena1;
    string[] users = { "Carlos", "Ana", "Jose" };
    string[] passwords = { "carlos123", "ana123", "jose123" };
    public vGrid()
	{
		InitializeComponent();
	}
    public vGrid(string usuario, string contrasena) { 
    
        InitializeComponent();
        usuario1 = usuario;
        contrasena1 = contrasena;
    }
    private void Button_Clicked(object sender, EventArgs e)
    {

        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        bool isAuthenticated = false;

        for (int i = 0; i < users.Length; i++)
        {
            if (username == users[i] && password == passwords[i])
            {
                isAuthenticated = true;
                DisplayAlert("¡Bienvenido!", $"¡Bienvenido {username}!", "OK");
                Navigation.PushAsync(new vInicio(username));
                break;
                
            }
        }

        if (!isAuthenticated)
        {
            DisplayAlert("Error", "Nombre de usuario o contraseña incorrectos", "OK");
        }
    

}

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vRegistro());

    }
}