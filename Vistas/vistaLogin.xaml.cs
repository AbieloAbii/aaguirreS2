namespace aaguirreS2.Vistas;

public partial class vistaLogin : ContentPage
{
	public vistaLogin()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
		string usuario = "aaguirre";
		string contrasena = "1234";

		if (txtUsuario.Text == usuario && txtContraseña.Text==contrasena)
		{
			Navigation.PushAsync(new vPrincipal(usuario));
		}
		else 
		{
			DisplayAlert("Alerta", "Usuario/Contraseña incorrectos", "Cancel");
		}

    }
}