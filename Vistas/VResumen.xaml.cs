namespace risanchezExamen.Vistas;

public partial class VResumen : ContentPage
{
    private string usuarioConectado;
    public VResumen(string usuarioConectado, string nombre, string apellido, DateTime fecha, string ciudad, string pais, double montoInicial, double pagoMensual)
	{
		InitializeComponent();
        this.usuarioConectado = usuarioConectado;
        lblUsuarioConectado.Text = $"Usuario Conectado: {usuarioConectado}";

        lblNombre.Text = nombre;
        lblApellido.Text = apellido;
        lblFecha.Text = fecha.ToString("dd/MM/yyyy");
        lblCiudad.Text = ciudad;
        lblPais.Text = pais;
        
        lblMontoInicial.Text = montoInicial.ToString();
        lblPagoMensual.Text = pagoMensual.ToString();
        
        lblPagoTotal.Text = (montoInicial + (pagoMensual * 12)).ToString();
    }
    private void btnCerrarSesion_Clicked(object sender, EventArgs e)
    {
        int edad;
        if (int.TryParse(entEdad.Text, out edad))
        {
            // Cerrar sesión y borrar datos
            Navigation.PopToRootAsync();
        }
        else
        {
            DisplayAlert("Error", "Ingrese una edad válida", "Aceptar");
        }
    }

}