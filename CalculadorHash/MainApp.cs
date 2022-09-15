using CalculadorHash.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CalculadorHash
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPesquisarArquivo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                XDocument xDoc = XDocument.Load(openFileDialog1.FileName);

                ICalculadorHash calculadorHash = new SibService();

                String hash = calculadorHash.CalcularHash(xDoc.ToString());

                txtHashCalculado.Text = hash;
            }
        }
    }
}
