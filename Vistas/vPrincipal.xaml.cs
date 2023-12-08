namespace aaguirreS2.Vistas;

public partial class vPrincipal : ContentPage
{
	public vPrincipal(string usuario)
	{
		InitializeComponent();
		lblUsuario.Text = "Bienvenido "+usuario;
	}

    private void btnMostrar_Clicked(object sender, EventArgs e)
    {
		string dato = pkPaises.Items[pkPaises.SelectedIndex];
		lblSeleccionado.Text = "El elemento seleccionado es: " + dato;
		//DisplayAlert("Elemento seleccionado", dato.ToString(), "Cancel");
    }

    private void btnFecha_Clicked(object sender, EventArgs e)
    {
		string fecha = dpFechas.Date.ToString();
        DisplayAlert("Fecha Seleccionada", fecha.ToString(), "Cancel");
    }
}