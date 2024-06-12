namespace claseS3.vistas;

public partial class home : ContentPage
{
	public home( string nombre)
	{
		InitializeComponent();

		lblNombre.Text = "Bienvenido: "+nombre;
	}
}