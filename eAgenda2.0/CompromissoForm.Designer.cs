namespace eAgenda2._0
{
    partial class CompromissoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExcluirCompromisso = new System.Windows.Forms.Button();
            this.btnEditarCompromisso = new System.Windows.Forms.Button();
            this.listBoxCompromissosFuturos = new System.Windows.Forms.ListBox();
            this.btnInserirCompromisso = new System.Windows.Forms.Button();
            this.listBoxCompromissosPassados = new System.Windows.Forms.ListBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExcluirCompromisso
            // 
            this.btnExcluirCompromisso.Location = new System.Drawing.Point(300, 13);
            this.btnExcluirCompromisso.Name = "btnExcluirCompromisso";
            this.btnExcluirCompromisso.Size = new System.Drawing.Size(138, 45);
            this.btnExcluirCompromisso.TabIndex = 7;
            this.btnExcluirCompromisso.Text = "Excluir";
            this.btnExcluirCompromisso.UseVisualStyleBackColor = true;
            this.btnExcluirCompromisso.Click += new System.EventHandler(this.btnExcluirCompromisso_Click);
            // 
            // btnEditarCompromisso
            // 
            this.btnEditarCompromisso.Location = new System.Drawing.Point(156, 13);
            this.btnEditarCompromisso.Name = "btnEditarCompromisso";
            this.btnEditarCompromisso.Size = new System.Drawing.Size(138, 45);
            this.btnEditarCompromisso.TabIndex = 6;
            this.btnEditarCompromisso.Text = "Editar";
            this.btnEditarCompromisso.UseVisualStyleBackColor = true;
            this.btnEditarCompromisso.Click += new System.EventHandler(this.btnEditarCompromisso_Click);
            // 
            // listBoxCompromissosFuturos
            // 
            this.listBoxCompromissosFuturos.FormattingEnabled = true;
            this.listBoxCompromissosFuturos.ItemHeight = 15;
            this.listBoxCompromissosFuturos.Location = new System.Drawing.Point(5, 95);
            this.listBoxCompromissosFuturos.Name = "listBoxCompromissosFuturos";
            this.listBoxCompromissosFuturos.Size = new System.Drawing.Size(505, 94);
            this.listBoxCompromissosFuturos.TabIndex = 5;
            // 
            // btnInserirCompromisso
            // 
            this.btnInserirCompromisso.Location = new System.Drawing.Point(12, 13);
            this.btnInserirCompromisso.Name = "btnInserirCompromisso";
            this.btnInserirCompromisso.Size = new System.Drawing.Size(138, 45);
            this.btnInserirCompromisso.TabIndex = 4;
            this.btnInserirCompromisso.Text = "Inseir";
            this.btnInserirCompromisso.UseVisualStyleBackColor = true;
            this.btnInserirCompromisso.Click += new System.EventHandler(this.btnInserirCompromisso_Click);
            // 
            // listBoxCompromissosPassados
            // 
            this.listBoxCompromissosPassados.FormattingEnabled = true;
            this.listBoxCompromissosPassados.ItemHeight = 15;
            this.listBoxCompromissosPassados.Location = new System.Drawing.Point(5, 195);
            this.listBoxCompromissosPassados.Name = "listBoxCompromissosPassados";
            this.listBoxCompromissosPassados.Size = new System.Drawing.Size(505, 94);
            this.listBoxCompromissosPassados.TabIndex = 8;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(358, 310);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(149, 28);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "COMPROMISSOS FUTUROS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "COMPROMISSOS PASSADOS";
            // 
            // CompromissoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(519, 344);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.listBoxCompromissosPassados);
            this.Controls.Add(this.btnExcluirCompromisso);
            this.Controls.Add(this.btnEditarCompromisso);
            this.Controls.Add(this.listBoxCompromissosFuturos);
            this.Controls.Add(this.btnInserirCompromisso);
            this.Name = "CompromissoForm";
            this.Text = "CompromissoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirCompromisso;
        private System.Windows.Forms.Button btnEditarCompromisso;
        private System.Windows.Forms.ListBox listBoxCompromissosFuturos;
        private System.Windows.Forms.Button btnInserirCompromisso;
        private System.Windows.Forms.ListBox listBoxCompromissosPassados;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}