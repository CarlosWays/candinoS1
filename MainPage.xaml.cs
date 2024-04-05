namespace candinoS1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private string strNombre, strApellido;
    private int intEdad;
    private float flSalario, decTotalCalculado;


    private void btnSaludoClicked(object sender, EventArgs e)
    {
        strNombre = txtNombre.Text;
        strApellido = txtApellido.Text;
        intEdad = int.Parse(txtEdad.Text);
        flSalario = float.Parse(txtSalario.Text);
        decTotalCalculado = (flSalario * 9.45f) / 100;
        DisplayAlert("Resultados", "Bienvenido, " + strNombre + " " + strApellido + "\nTienes " + intEdad + " años" + 
            "\nTu aporte mensual es " + decTotalCalculado, "Salir");
        LimpiarDatos();
    }

    private void LimpiarDatos()
    {
        txtNombre.Text = string.Empty;
        txtApellido.Text = string.Empty;
        txtSalario.Text = string.Empty;
        txtEdad.Text = string.Empty;

    }
}

