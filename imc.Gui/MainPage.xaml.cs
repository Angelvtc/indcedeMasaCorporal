using Microsoft.Maui;

namespace imc.Gui
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            Limpiar();
        }

        private void OnCalcularButtonClicked(object sender, EventArgs e)
        {
            decimal peso = Convert.ToDecimal(PesoEntry.Text);
            decimal estatura = Convert.ToDecimal(EstaturaEntry.Text);
            decimal imc = peso / (estatura * estatura);
            ImcLabel.Text = imc.ToString("G6");
            SituacionNutricionalLabel.Text = DeterminaEstadoNutricional(imc);
        }

        private void OnLimpiarButtonClicked(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            EstaturaEntry.Text = string.Empty;
            PesoEntry.Text = string.Empty;
            SituacionNutricionalLabel.Text = string.Empty;
            ImcLabel.Text = string.Empty;


        }
        private decimal IndiceDemasaCorporal(decimal peso, decimal estatura)
        {
            return peso / (estatura * estatura);
        }

        private string DeterminaEstadoNutricional(decimal imc)
        {
            if (imc < 18.5m)
            {
                return "peso bajo";
            }
            else if (imc < 25.00m)
            {
                return "peso normal";
            }
            else if (imc < 30.0m)
            {
                return "sobre peso";
            }
            else if (imc < 40.00m)
            {
                return "obesidad";
            }
            else
            {
                return "obesidad extrema";
            }
        }
    }
}