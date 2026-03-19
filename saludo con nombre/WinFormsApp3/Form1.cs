namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblmensaje.Text = "";
        }

        private void btnsaludo_Click(object sender, EventArgs e)
        {
            lblmensaje.Text = txtnombre.Text + " es el nombre, Hola!!!";
        }

        private void lblmensaje_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
