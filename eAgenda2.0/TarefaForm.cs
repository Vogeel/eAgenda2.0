using eAgenda.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda2._0
{
    public partial class TarefaForm : Form
    {
        Repositorio<Tarefa> _repositorioTarefa;
        public TarefaForm()
        {
            InitializeComponent();
        }

        private void btnInserirTarefa_Click(object sender, EventArgs e)
        {
            CadastroTarefaForm telaTarefa = new(new Tarefa());
            DialogResult res = telaTarefa.ShowDialog();
            if (res == DialogResult.OK)
            {
                string status = _repositorioTarefa.Inserir(telaTarefa.Tarefa);

                if (status == "REGISTRO_VALIDO")
                    MessageBox.Show("Compromisso inserido com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"{status}\nTente novamente", "Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void btnEditarTarefas_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirTarefas_Click(object sender, EventArgs e)
        {

        }

        private void btnInserirItens_Click(object sender, EventArgs e)
        {

        }

        private void btnConcluirItens_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
