using CalculadorHash.Services;
using System;
using System.Windows.Forms;

namespace CalculadorHash
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void BtnPesquisarArquivo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                ICalculadorHash? calculador = CalculadorHashFactory.CriarInstancia(openFileDialog1.FileName);

                if (calculador == null)
                {
                    MessageBox.Show("O arquivo não é suportado!");
                    return;
                }

                string novoHash = calculador.CalcularHash(openFileDialog1.FileName);

                txtHashCalculado.Text = novoHash;
            }
        }
    }
}
