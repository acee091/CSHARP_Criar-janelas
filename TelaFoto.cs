using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_05_09
{
    public partial class TelaFoto : Form
    {
        public TelaFoto()
        {
            InitializeComponent();
        }

        private void btnEscolherImagem_Click(object sender, EventArgs e)
        {
            string imagem;
            openFileDialog1.ShowDialog();
            imagem = openFileDialog1.FileName;
            pictImagem.ImageLocation = imagem;
        }

        private void TelaFoto_Load(object sender, EventArgs e)
        {

        }

        private void TelaFoto_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit(); // Fecha o programa se não houver mais janelas abertas
            }
            else
            {
                foreach (Form FormAberto in Application.OpenForms) // Verificar todos os forms abertos
//Form --> janela/caixa de dialogo // FormAberto --> nome da variavel // Application --> Programa // OpenForms --> Formulários abertos
                {
                    if(FormAberto is Form1) // Se form1 ainda estiver aberto, reexibir
                    {
                        FormAberto.Show();
                        break;
                    }
                }
            }
        }
    }
}
