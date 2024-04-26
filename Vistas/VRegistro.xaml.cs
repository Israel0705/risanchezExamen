namespace risanchezExamen.Vistas;

public partial class VRegistro : ContentPage
{
    private string usuarioConectado;
    private const double CostoCurso = 1500;
    public VRegistro(string usuario)
	{
		InitializeComponent();
        usuarioConectado = usuario;
        lblUsuarioConectado.Text = $"Usuario Conectado: {usuarioConectado}";  
        pkPais.Items.Add("Ecuador");
        pkPais.Items.Add("Colombia");
        pkCiudad.Items.Add("Guayaquil");
        pkCiudad.Items.Add("Bogotá");
    }
    private void btnCalcularPago_Clicked(object sender, EventArgs e)
    {
        double montoInicial = double.Parse(entMontoInicial.Text);
        double montoRestante = CostoCurso - montoInicial;
        double pagoMensual = (montoRestante / 4)+60; 
        entPagoMensual.Text = pagoMensual.ToString("F2");
    }
    private void btnVerResumen_Clicked(object sender, EventArgs e)
    {
        
        Navigation.PushAsync(new VResumen(usuarioConectado, entNombre.Text, entApellido.Text, dpFecha.Date, pkPais.SelectedItem.ToString(), pkCiudad.SelectedItem.ToString(), double.Parse(entMontoInicial.Text), double.Parse(entPagoMensual.Text)));
    }
}