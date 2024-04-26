namespace rvargasExamen.Examen;

public partial class Login1 : ContentPage
{

    // Datos de usuarios y contrase�as
    string[] users = { "estudiante2024", "examen1" };
    string[] passwords = { "uisrael2024", "parcial1" };

    public Login1()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrase�a = txtContrasena.Text;

        bool usuarioValido = false;

        for (int i = 0; i < users.Length; i++)
        {
            if (usuario == users[i] && contrase�a == passwords[i])
            {
                usuarioValido = true;
                break;
            }
        }

        if (usuarioValido)
        {
            DisplayAlert("Usuario Conectado", $"Usuario Conectado {usuario}!", "OK");
            // Aqu� podr�as navegar a la p�gina principal de tu aplicaci�n
            Navigation.PushAsync(new Registro(usuario));
        }
        else
        {
            DisplayAlert("Error", "Usuario o contrase�a incorrectos", "OK");
        }
    }
}