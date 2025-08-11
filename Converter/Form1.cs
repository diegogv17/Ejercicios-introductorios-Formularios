namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            //https://vm.tiktok.com/ZMAJ5GLYw/ Me Salio esto en recomendados de TikTok y como no se como se utiliza el IsNullOrWhiteSpace, aplique la alternativa que esta en la descripcion para adaptarla a mi codigo, Gracias por confiar, estoy Tratando de aprender y no usar IA :).

            if (TxtTempeture.Text == null || TxtTempeture.Text.Trim() == " ")
            {
                errorProvider1.SetError(TxtTempeture, "Ingrese una temperatura");
                return;

            }

            double temp;
            if (!double.TryParse(TxtTempeture.Text, out temp))
            {
                errorProvider1.SetError(TxtTempeture, "Ingrese un valor numérico válido");
                return;
            }

            if (CbxSelect.SelectedIndex == -1)
            {
                errorProvider1.SetError(CbxSelect, "Seleccione una opcion a convertir");
            }

            double resultado = 0;
            if (CbxSelect.Text == "Celsius to Fahrenheit")
            {
                resultado = (temp * 9 / 5) + 32;
                lblResult.Text = $"Resultado: {resultado:F2} °F";
            }
            else if(CbxSelect.Text == "Fahrenheit to Celsius")
            {
                resultado = (temp - 32) * 5 / 9;
                lblResult.Text = $"Resultado: {resultado:F2} °C";
            }

        }




        

        private void TxtTempeture_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
