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
    public partial class TelaInicial : Form
    {

        ContatoForm? contatoForm;
        TarefaForm? tarefaForm;
        CompromissoForm? compromissoForm;
        public TelaInicial()
        {
            InitializeComponent();
        }


       

        private void btnContatos_Click(object sender, EventArgs e)
        {
            contatoForm = new ContatoForm(repositorioContato);
            contatoForm.Show();
        }

        private void btnCompromisso_Click(object sender, EventArgs e)
        {

        }


        private void btnTarefas_Click(object sender, EventArgs e)
        {

        }
    }
}
