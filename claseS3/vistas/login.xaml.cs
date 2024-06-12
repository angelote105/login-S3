namespace claseS3.vistas;

public partial class login : ContentPage
{
    public login()
    {
        InitializeComponent();
    }

    string user;
    string password;

    public login(string usuario, string pass)
    {
        InitializeComponent();

        user = usuario;
        password = pass;

    }

    

    private void Inicio_Clicked(object sender, EventArgs e)
    {


        if( user==txtUsuario.Text && password ==txtContraseña.Text){

            Navigation.PushAsync(new home(txtUsuario.Text));

        }
        else
        {

            DisplayAlert("Alerta", "Error ", "Cerrar");
        }
        



    }

    private void Registro_Clicked(object sender, EventArgs e)
    {


        Navigation.PushAsync(new registrar());

    }
}