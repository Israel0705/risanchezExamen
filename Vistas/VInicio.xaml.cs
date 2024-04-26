namespace risanchezExamen.Vistas;

public partial class VInicio : ContentPage
{
	public VInicio()
	{
		InitializeComponent();
	}
    private readonly string[] usuarios = { "estudiante2024", "examen1", "Juan" };
    private readonly string[] contrasenas = { "uisrael2024", "parcial1", "2024" };
    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrasena = txtContrasena.Text;

        int index = Array.IndexOf(usuarios, usuario);
        if (index >= 0 && contrasenas[index] == contrasena)
        {
            // Acceso correcto
            Navigation.PushAsync(new VRegistro(txtUsuario.Text));
        }
        else
        {
            // Datos incorrectos
            DisplayAlert("Error", "Usuario o contraseña incorrectos", "Aceptar");
        }
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        
    }

    private void btnAcercaDe_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Info());
    }
}