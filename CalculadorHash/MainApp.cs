using CalculadorHash.Services;
using System.Text;

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

                // Verifica se é arquivo .174 e pergunta se quer gerar novo arquivo
                if (openFileDialog1.FileName.ToLower().EndsWith(".174"))
                {
                    DialogResult resultado = MessageBox.Show(
                        $"Hash calculado: {novoHash}\n\n" +
                        "Deseja gerar um novo arquivo com o hash atualizado?\n" +
                        "(O hash será inserido nas posições 12-43 do registro 998)",
                        "Gerar Arquivo com Hash Atualizado",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        GerarArquivoComHashAtualizado(openFileDialog1.FileName, novoHash);
                    }
                }
            }
        }

        private static void GerarArquivoComHashAtualizado(string caminhoArquivoOriginal, string novoHash)
        {
            try
            {
                // Lê todas as linhas do arquivo original
                string[] linhas = File.ReadAllLines(caminhoArquivoOriginal, Encoding.GetEncoding("ISO-8859-1"));

                // Procura pela linha do registro 998 (última linha normalmente)
                for (int i = linhas.Length - 1; i >= 0; i--)
                {
                    var tipoRegistro = linhas[i].Substring(8, 3);

                    if (tipoRegistro == "998")
                    {
                        // Atualiza o hash nas posições 12-43 (32 caracteres do hash MD5)
                        if (linhas[i].Length >= 43)
                        {
                            string linhaSemHash = linhas[i][..11]; // Posições 1-11
                            string restoLinha = linhas[i].Length > 43 ? linhas[i][43..] : ""; // Após posição 43
                            linhas[i] = linhaSemHash + novoHash + restoLinha;
                        }
                        break;
                    }
                }

                // Gera nome do novo arquivo
                string diretorio = Path.GetDirectoryName(caminhoArquivoOriginal) ?? "";
                string nomeArquivo = Path.GetFileNameWithoutExtension(caminhoArquivoOriginal);
                string extensao = Path.GetExtension(caminhoArquivoOriginal);
                string novoNomeArquivo = Path.Combine(diretorio, $"{nomeArquivo}_com_hash{extensao}");

                // Salva o novo arquivo
                File.WriteAllLines(novoNomeArquivo, linhas, Encoding.GetEncoding("ISO-8859-1"));

                MessageBox.Show($"Arquivo gerado com sucesso!\n\nLocal: {novoNomeArquivo}",
                    "Arquivo Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar arquivo:\n{ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
