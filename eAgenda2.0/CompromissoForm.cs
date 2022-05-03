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
    public partial class CompromissoForm : Form
    {
       
        Repositorio<Contato> _repositorioContato;
        Repositorio<Compromisso> _repositorioCompromisso;
        public CompromissoForm(Repositorio<Compromisso> repositorio, Repositorio<Contato> repositorioContato)
        {
            InitializeComponent();
            _repositorioCompromisso = repositorio;
            _repositorioContato = repositorioContato;
            CarregarPassados();
            CarregarFuturos();
        }



        private void btnInserirCompromisso_Click(object sender, EventArgs e)
        {
            CadastroComprimossosForm telaCompromisso = new(new Compromisso(), _repositorioContato!);
            DialogResult res = telaCompromisso.ShowDialog();
            if (res == DialogResult.OK)
            {
                string status = _repositorioCompromisso.Inserir(telaCompromisso.Compromisso);

                if (status == "REGISTRO_VALIDO")
                    MessageBox.Show("Compromisso inserido com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show($"{status}\nTente novamente", "Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                CarregarPassados();
                CarregarFuturos();
            }
        }

            private void btnEditarCompromisso_Click(object sender, EventArgs e)
            {

                Compromisso compromissoSelecionado = (Compromisso)listBoxCompromissosFuturos.SelectedItem;

                Compromisso novoCompromisso = new();

                novoCompromisso.id = compromissoSelecionado.id;
                novoCompromisso.Assunto = compromissoSelecionado.Assunto;
                novoCompromisso.Local = compromissoSelecionado.Local;
                novoCompromisso.DataCompromisso = compromissoSelecionado.DataCompromisso;
                novoCompromisso.HoraInicio = compromissoSelecionado.HoraInicio;
                novoCompromisso.HoraFim = compromissoSelecionado.HoraFim;
                novoCompromisso.Contato = compromissoSelecionado.Contato;

                CadastroComprimossosForm telaCadCompromisso = new(novoCompromisso, _repositorioContato!);

                DialogResult resultado = telaCadCompromisso.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    string status = _repositorioCompromisso.Editar(telaCadCompromisso.Compromisso, compromissoSelecionado);
                    if (status == "REGISTRO_VALIDO")
                        MessageBox.Show("Compromisso editado com sucesso!", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        MessageBox.Show($"{status}\nTente novamente", "Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                CarregarPassados();

                CarregarFuturos();
                }
            }
        

        private void btnExcluirCompromisso_Click(object sender, EventArgs e)
        {
            Compromisso compromissoSelecionado = (Compromisso)listBoxCompromissosFuturos.SelectedItem;

            bool temAlgo = VerificarSeTemRegistro(compromissoSelecionado, "Excluir");
            if (!temAlgo)
                return;

            DialogResult resultado = MessageBox.Show("Excluir compromisso?", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                _repositorioCompromisso.Excluir(compromissoSelecionado);
                CarregarPassados();
                CarregarFuturos();
            }
        }

        private void CarregarFuturos()
        {
            List<Compromisso> compromissosFuturos = _repositorioCompromisso.FiltrarCompromissos(x => x.DataCompromisso > DateTime.Now);
            listBoxCompromissosFuturos.Items.Clear();
            foreach (Compromisso c in compromissosFuturos)
            {
                listBoxCompromissosFuturos.Items.Add(c);
            }
        }

        private void CarregarPassados()
        {
            List<Compromisso> compromissosPassados = _repositorioCompromisso.FiltrarCompromissos(x => x.DataCompromisso <= DateTime.Now);
            listBoxCompromissosPassados.Items.Clear();
            foreach (Compromisso c in compromissosPassados)
            {
                listBoxCompromissosPassados.Items.Add(c);
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool VerificarSeTemRegistro(Compromisso compromissoSelecionado, string tipo)
        {
            bool temAlgo = _repositorioContato.RegistroExistente();
            if (!temAlgo)
            {
                MessageBox.Show($"Nenhum compromisso para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (compromissoSelecionado == null)
            {
                MessageBox.Show($"Selecione um compromisso para {tipo}", tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        
    }
}
