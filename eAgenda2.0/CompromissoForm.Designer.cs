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
            this.listBoxCompromissos = new System.Windows.Forms.ListBox();
            this.btnInserirCompromisso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExcluirCompromisso
            // 
            this.btnExcluirCompromisso.Location = new System.Drawing.Point(252, 13);
            this.btnExcluirCompromisso.Name = "btnExcluirCompromisso";
            this.btnExcluirCompromisso.Size = new System.Drawing.Size(85, 45);
            this.btnExcluirCompromisso.TabIndex = 7;
            this.btnExcluirCompromisso.Text = "Excluir";
            this.btnExcluirCompromisso.UseVisualStyleBackColor = true;
            // 
            // btnEditarCompromisso
            // 
            this.btnEditarCompromisso.Location = new System.Drawing.Point(132, 13);
            this.btnEditarCompromisso.Name = "btnEditarCompromisso";
            this.btnEditarCompromisso.Size = new System.Drawing.Size(85, 45);
            this.btnEditarCompromisso.TabIndex = 6;
            this.btnEditarCompromisso.Text = "Editar";
            this.btnEditarCompromisso.UseVisualStyleBackColor = true;
            // 
            // listBoxCompromissos
            // 
            this.listBoxCompromissos.FormattingEnabled = true;
            this.listBoxCompromissos.ItemHeight = 15;
            this.listBoxCompromissos.Location = new System.Drawing.Point(5, 80);
            this.listBoxCompromissos.Name = "listBoxCompromissos";
            this.listBoxCompromissos.Size = new System.Drawing.Size(326, 229);
            this.listBoxCompromissos.TabIndex = 5;
            // 
            // btnInserirCompromisso
            // 
            this.btnInserirCompromisso.Location = new System.Drawing.Point(12, 13);
            this.btnInserirCompromisso.Name = "btnInserirCompromisso";
            this.btnInserirCompromisso.Size = new System.Drawing.Size(85, 45);
            this.btnInserirCompromisso.TabIndex = 4;
            this.btnInserirCompromisso.Text = "Inseir";
            this.btnInserirCompromisso.UseVisualStyleBackColor = true;
            // 
            // CompromissoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(343, 321);
            this.Controls.Add(this.btnExcluirCompromisso);
            this.Controls.Add(this.btnEditarCompromisso);
            this.Controls.Add(this.listBoxCompromissos);
            this.Controls.Add(this.btnInserirCompromisso);
            this.Name = "CompromissoForm";
            this.Text = "CompromissoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirCompromisso;
        private System.Windows.Forms.Button btnEditarCompromisso;
        private System.Windows.Forms.ListBox listBoxCompromissos;
        private System.Windows.Forms.Button btnInserirCompromisso;
    }
}