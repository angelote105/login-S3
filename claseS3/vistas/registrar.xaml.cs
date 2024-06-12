namespace claseS3.vistas;

public partial class registrar : ContentPage
{
	public registrar()
	{
		InitializeComponent();
	}


	private void btnregistrarUsu_Clicked(object sender, EventArgs e)
	{

		string usuario = txtNusuario.Text;
		string pass = txtNPass.Text;
		string confir = txtPconfirmar.Text;

		if (pass == confir)
		{

			DisplayAlert("Alerta", " Usuario Guardado", "cerrar");
			Navigation.PushAsync(new login(usuario, pass));
		}
        else
        {
			DisplayAlert("Alerta", "valide la contraseña", "cerrar");
        }

    }
}