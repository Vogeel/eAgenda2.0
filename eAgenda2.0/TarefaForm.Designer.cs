namespace eAgenda2._0
{
    partial class TarefaForm
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
            this.btnInserirTarefa = new System.Windows.Forms.Button();
            this.btnEditarTarefas = new System.Windows.Forms.Button();
            this.btnExcluirTarefas = new System.Windows.Forms.Button();
            this.btnInserirItens = new System.Windows.Forms.Button();
            this.btnConcluirItens = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxTarefas = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInserirTarefa
            // 
            this.btnInserirTarefa.Location = new System.Drawing.Point(4, 9);
            this.btnInserirTarefa.Name = "btnInserirTarefa";
            this.btnInserirTarefa.Size = new System.Drawing.Size(112, 47);
            this.btnInserirTarefa.TabIndex = 0;
            this.btnInserirTarefa.Text = "Inserir";
            this.btnInserirTarefa.UseVisualStyleBackColor = true;
            this.btnInserirTarefa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditarTarefas
            // 
            this.btnEditarTarefas.Location = new System.Drawing.Point(122, 9);
            this.btnEditarTarefas.Name = "btnEditarTarefas";
            this.btnEditarTarefas.Size = new System.Drawing.Size(112, 47);
            this.btnEditarTarefas.TabIndex = 1;
            this.btnEditarTarefas.Text = "Editar";
            this.btnEditarTarefas.UseVisualStyleBackColor = true;
            // 
            // btnExcluirTarefas
            // 
            this.btnExcluirTarefas.Location = new System.Drawing.Point(240, 9);
            this.btnExcluirTarefas.Name = "btnExcluirTarefas";
            this.btnExcluirTarefas.Size = new System.Drawing.Size(112, 47);
            this.btnExcluirTarefas.TabIndex = 2;
            this.btnExcluirTarefas.Text = "Excluir";
            this.btnExcluirTarefas.UseVisualStyleBackColor = true;
            // 
            // btnInserirItens
            // 
            this.btnInserirItens.Location = new System.Drawing.Point(398, 38);
            this.btnInserirItens.Name = "btnInserirItens";
            this.btnInserirItens.Size = new System.Drawing.Size(112, 47);
            this.btnInserirItens.TabIndex = 3;
            this.btnInserirItens.Text = "Inserir";
            this.btnInserirItens.UseVisualStyleBackColor = true;
            // 
            // btnConcluirItens
            // 
            this.btnConcluirItens.Location = new System.Drawing.Point(516, 38);
            this.btnConcluirItens.Name = "btnConcluirItens";
            this.btnConcluirItens.Size = new System.Drawing.Size(112, 47);
            this.btnConcluirItens.TabIndex = 4;
            this.btnConcluirItens.Text = "Concluir itens";
            this.btnConcluirItens.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(390, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 65);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnEditarTarefas);
            this.panel2.Controls.Add(this.btnExcluirTarefas);
            this.panel2.Controls.Add(this.btnInserirTarefa);
            this.panel2.Location = new System.Drawing.Point(2, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 65);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(157, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tarefas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(495, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Itens";
            // 
            // listBoxTarefas
            // 
            this.listBoxTarefas.FormattingEnabled = true;
            this.listBoxTarefas.ItemHeight = 15;
            this.listBoxTarefas.Location = new System.Drawing.Point(2, 113);
            this.listBoxTarefas.Name = "listBoxTarefas";
            this.listBoxTarefas.Size = new System.Drawing.Size(634, 319);
            this.listBoxTarefas.TabIndex = 9;
            // 
            // TarefaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 436);
            this.Controls.Add(this.listBoxTarefas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConcluirItens);
            this.Controls.Add(this.btnInserirItens);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "TarefaForm";
            this.Text = "TarefaForm";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserirTarefa;
        private System.Windows.Forms.Button btnEditarTarefas;
        private System.Windows.Forms.Button btnExcluirTarefas;
        private System.Windows.Forms.Button btnInserirItens;
        private System.Windows.Forms.Button btnConcluirItens;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxTarefas;
    }
}