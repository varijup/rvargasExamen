namespace rvargasExamen.Examen;

public partial class Resumen : ContentPage
{
    public Resumen(string nombre, string apellido, string edad, string fecha, string ciudad, string pais, double montoInicial, double pagoMensual, double pagoTotal)
    {
        InitializeComponent();
        txtNombreR.Text = nombre;
        txtApellidoR.Text = apellido;
        txtEdadR.Text = edad;
        txtFechaR.Text = fecha;
        txtCiudadR.Text = ciudad;
        txtPaisR.Text = pais;
        txtMontoIniR.Text = Convert.ToString(montoInicial.ToString("F2"));
        txtMontoMenR.Text = Convert.ToString(pagoMensual.ToString("F2"));
        txtTotalR.Text = Convert.ToString(pagoTotal.ToString("F2"));
    }
}