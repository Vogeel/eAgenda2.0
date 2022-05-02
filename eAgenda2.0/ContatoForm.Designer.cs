namespace eAgenda2._0
{
    partial class ContatoForm
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
            this.btnInserirContato = new System.Windows.Forms.Button();
            this.listBoxContatos = new System.Windows.Forms.ListBox();
            this.btnEditarContato = new System.Windows.Forms.Button();
            this.btnExcluirContato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInserirContato
            // 
            this.btnInserirContato.Location = new System.Drawing.Point(12, 41);
            this.btnInserirContato.Name = "btnInserirContato";
            this.btnInserirContato.Size = new System.Drawing.Size(85, 45);
            this.btnInserirContato.TabIndex = 0;
            this.btnInserirContato.Text = "Inseir";
            this.btnInserirContato.UseVisualStyleBackColor = true;
            // 
            // listBoxContatos
            // 
            this.listBoxContatos.FormattingEnabled = true;
            this.listBoxContatos.ItemHeight = 15;
            this.listBoxContatos.Location = new System.Drawing.Point(12, 112);
            this.listBoxContatos.Name = "listBoxContatos";
            this.listBoxContatos.Size = new System.Drawing.Size(326, 229);
            this.listBoxContatos.TabIndex = 1;
            // 
            // btnEditarContato
            // 
            this.btnEditarContato.Location = new System.Drawing.Point(132, 41);
            this.btnEditarContato.Name = "btnEditarContato";
            this.btnEditarContato.Size = new System.Drawing.Size(85, 45);
            this.btnEditarContato.TabIndex = 2;
            this.btnEditarContato.Text = "Editar";
            this.btnEditarContato.UseVisualStyleBackColor = true;
            // 
            // btnExcluirContato
            // 
            this.btnExcluirContato.Location = new System.Drawing.Point(252, 41);
            this.btnExcluirContato.Name = "btnExcluirContato";
            this.btnExcluirContato.Size = new System.Drawing.Size(85, 45);
            this.btnExcluirContato.TabIndex = 3;
            this.btnExcluirContato.Text = "Excluir";
            this.btnExcluirContato.UseVisualStyleBackColor = true;
            // 
            // ContatoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(349, 350);
            this.Controls.Add(this.btnExcluirContato);
            this.Controls.Add(this.btnEditarContato);
            this.Controls.Add(this.listBoxContatos);
            this.Controls.Add(this.btnInserirContato);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContatoForm";
            this.Text = "ContatoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInserirContato;
        private System.Windows.Forms.ListBox listBoxContatos;
        private System.Windows.Forms.Button btnEditarContato;
        private System.Windows.Forms.Button btnExcluirContato;
    }
}