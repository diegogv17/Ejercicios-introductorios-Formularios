namespace Calculadora_2
{
    public partial class Fcalculator : Form
    {
        public Fcalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnAddUp_Click(object sender, EventArgs e)
        {
            try
            {
                double Num1 = Convert.ToDouble(TxtNumber1.Text);
                double Num2 = Convert.ToDouble(TxtNumber2.Text);
                double Result = Num1 + Num2;
                MessageBox.Show($"el resultado es: {Result}");
            }
            catch
            {
                MessageBox.Show("Please enter only valid numbers.", "Format error");
            }
        }

        private void BtnToDeduct_Click(object sender, EventArgs e)
        {
            try
            {
                double Num1 = Convert.ToDouble(TxtNumber1.Text);
                double Num2 = Convert.ToDouble(TxtNumber2.Text);
                double Result = Num1 - Num2;
                MessageBox.Show($"el resultado es: {Result}");
            }
            catch
            {
                MessageBox.Show("Please enter only valid numbers.", "Format error");
            }
        }

        private void BtnToMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                double Num1 = Convert.ToDouble(TxtNumber1.Text);
                double Num2 = Convert.ToDouble(TxtNumber2.Text);
                double Result = Num1 * Num2;
                MessageBox.Show($"el resultado es: {Result}");
            }
            catch
            {
                MessageBox.Show("Please enter only valid numbers.", "Format error");
            }
        }

        private void BtnDivided_Click(object sender, EventArgs e)
        {
            try
            {
                double Num1 = Convert.ToDouble(TxtNumber1.Text);
                double Num2 = Convert.ToDouble(TxtNumber2.Text);

                if (Num2 == 0)
                {
                    MessageBox.Show($"Dividing by zero is not permitted");
                }
                else
                {
                    double Result = Num1 / Num2;
                    MessageBox.Show($"el resultado es: {Result}");
                }
            }
            catch
            {
                MessageBox.Show("Please enter only valid numbers.", "Format error");
            }
        }
    }
}
