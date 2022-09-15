
namespace CalculadorHash
{
    partial class MainApp
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtHashCalculado = new System.Windows.Forms.TextBox();
            this.btnPesquisarArquivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Arquivo SIB|*.sbx";
            // 
            // txtHashCalculado
            // 
            this.txtHashCalculado.Location = new System.Drawing.Point(103, 12);
            this.txtHashCalculado.Name = "txtHashCalculado";
            this.txtHashCalculado.Size = new System.Drawing.Size(511, 20);
            this.txtHashCalculado.TabIndex = 0;
            // 
            // btnPesquisarArquivo
            // 
            this.btnPesquisarArquivo.Location = new System.Drawing.Point(620, 10);
            this.btnPesquisarArquivo.Name = "btnPesquisarArquivo";
            this.btnPesquisarArquivo.Size = new System.Drawing.Size(150, 23);
            this.btnPesquisarArquivo.TabIndex = 1;
            this.btnPesquisarArquivo.Text = "Pesquisar Arquivo";
            this.btnPesquisarArquivo.UseVisualStyleBackColor = true;
            this.btnPesquisarArquivo.Click += new System.EventHandler(this.btnPesquisarArquivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hash Calculado:";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 50);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisarArquivo);
            this.Controls.Add(this.txtHashCalculado);
            this.Name = "MainApp";
            this.Text = "Calculador de Hash";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtHashCalculado;
        private System.Windows.Forms.Button btnPesquisarArquivo;
        private System.Windows.Forms.Label label1;
    }
}

