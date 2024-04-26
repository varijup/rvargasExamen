namespace rvargasExamen.Examen;

public partial class Registro : ContentPage
{
	public Registro(string usuario)
	{
		InitializeComponent();
        lblUsuarioConectado.Text = "Usuario conectado" + usuario;

        }

        private void btnMensual_Clicked(object sender, EventArgs e)
        {
            double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
            if (txtMontoInicial.Text == "")
            {
                DisplayAlert("Alerta", "Monto incial no se encuentra registrado", "cerrar");
            }
            else
            {
                double pagoMensual = ((1500 - montoInicial) / 4) + (1500 / 1.04);
                txtMontoMensual.Text = pagoMensual.ToString();
            }
        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            string ciudad = pkCiudades.Items[pkCiudades.SelectedIndex].ToString();
            string pais = pkCiudades.Items[pkCiudades.SelectedIndex].ToString();
            string fecha = dpFecha.Date.ToString();
            double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
            double pagoMensual = ((1500 - montoInicial) / 4) + (1500 / 1.04);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string edad = txtEdad.Text;
            double pagoTotal = pagoMensual + montoInicial;
            Navigation.PushAsync(new Resumen(nombre, apellido, edad, fecha, ciudad, pais, montoInicial, pagoMensual, pagoTotal));
        }
}



