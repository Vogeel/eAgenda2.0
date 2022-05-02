namespace eAgenda2._0
{
    partial class CadastroItemForm
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
            this.textBoxNomeItem = new System.Windows.Forms.TextBox();
            this.btnInserirNomeItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNomeItem
            // 
            this.textBoxNomeItem.Location = new System.Drawing.Point(97, 21);
            this.textBoxNomeItem.Name = "textBoxNomeItem";
            this.textBoxNomeItem.Size = new System.Drawing.Size(100, 23);
            this.textBoxNomeItem.TabIndex = 0;
            // 
            // btnInserirNomeItem
            // 
            this.btnInserirNomeItem.Location = new System.Drawing.Point(203, 21);
            this.btnInserirNomeItem.Name = "btnInserirNomeItem";
            this.btnInserirNomeItem.Size = new System.Drawing.Size(75, 23);
            this.btnInserirNomeItem.TabIndex = 1;
            this.btnInserirNomeItem.Text = "Inserir";
            this.btnInserirNomeItem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do item";
            // 
            // CadastroItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(298, 74);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInserirNomeItem);
            this.Controls.Add(this.textBoxNomeItem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroItemForm";
            this.Text = "TelaCadastroItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomeItem;
        private System.Windows.Forms.Button btnInserirNomeItem;
        private System.Windows.Forms.Label label1;
    }
}