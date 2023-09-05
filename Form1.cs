namespace Aula_05_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            janela Tela = new janela();
            Tela.Show();
            this.Hide();
            // this.Hide() a tela fica inacessivel
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            janela Tela = new janela();
            Tela.Show();
            this.WindowState = FormWindowState.Minimized; // minimizar a tela principal
           //O estado dessa janela = estado da janela do formulario minimizado
        }

        private void carregarFotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaFoto Tela = new TelaFoto();
            Tela.Show();
            this.Hide();
        }
    }
}