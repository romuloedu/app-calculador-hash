
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
            this.BtnPesquisarArquivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Arquivo SIB|*.sbx|Arquivo SIP|*.xsip";
            // 
            // txtHashCalculado
            // 
            this.txtHashCalculado.Location = new System.Drawing.Point(103, 12);
            this.txtHashCalculado.Name = "txtHashCalculado";
            this.txtHashCalculado.Size = new System.Drawing.Size(346, 20);
            this.txtHashCalculado.TabIndex = 0;
            // 
            // BtnPesquisarArquivo
            // 
            this.BtnPesquisarArquivo.Location = new System.Drawing.Point(455, 10);
            this.BtnPesquisarArquivo.Name = "BtnPesquisarArquivo";
            this.BtnPesquisarArquivo.Size = new System.Drawing.Size(150, 23);
            this.BtnPesquisarArquivo.TabIndex = 1;
            this.BtnPesquisarArquivo.Text = "Pesquisar Arquivo";
            this.BtnPesquisarArquivo.UseVisualStyleBackColor = true;
            this.BtnPesquisarArquivo.Click += new System.EventHandler(this.BtnPesquisarArquivo_Click);
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
            this.ClientSize = new System.Drawing.Size(617, 50);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPesquisarArquivo);
            this.Controls.Add(this.txtHashCalculado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainApp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador de Hash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtHashCalculado;
        private System.Windows.Forms.Button BtnPesquisarArquivo;
        private System.Windows.Forms.Label label1;
    }
}

