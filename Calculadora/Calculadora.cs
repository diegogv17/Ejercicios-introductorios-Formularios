namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUp_Click(object sender, EventArgs e)
        {
            if (txtNumber1 == null || txtNumber2 == null)
            {
                MessageBox.Show("fill in the blanks, not is allow Leave it empty");
                return;
            }
        }
    }
}
