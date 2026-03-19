namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndespedida_Click(object sender, EventArgs e)
        {
            lblmensaje.Text = "Adios!";
            this.Text = "Bye!";
        }

        private void btnsaludo_Click(object sender, EventArgs e)
        {
            lblmensaje.Text = "Hola a todos!";
            this.Text = "Buenas!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblmensaje.Text = "";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
