using Cadastro.Dal;
using Cadastro.Dal.Services.Dal;
using Cadastro.View.View;
using System.Windows.Forms;
using Wm.BI.Common.Services.Enums;

namespace Cadastro.View
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, System.EventArgs e)
        {
            RefreshGrid();
            this.dataGridViewPessoas.Columns[0].HeaderText = "ID";
            this.dataGridViewPessoas.Columns[0].Width = 30;
            this.dataGridViewPessoas.Columns[1].HeaderText = "NOME";
            this.dataGridViewPessoas.Columns[1].Width = 200;
            this.dataGridViewPessoas.Columns[2].HeaderText = "IDADE";
            this.dataGridViewPessoas.Columns[3].HeaderText = "DATA DE NASCIMENTO";
            this.dataGridViewPessoas.Columns[3].Width = 150;
        }

        private void BtRemoverClick(object sender, System.EventArgs e)
        {
            if (long.TryParse(dataGridViewPessoas.CurrentRow.Cells[0].Value.ToString(), out long id))
            {
                PessoaDal.DeleteById(id);
                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            this.dataGridViewPessoas.DataSource = PessoaDal.ListarPessoas();
        }

        private void BtAdicionarClick(object sender, System.EventArgs e)
        {
            ShowForm(Enums.Acoes.Criando, null);
            RefreshGrid();
        }

        private void BtEditarClick(object sender, System.EventArgs e)
        {
            if (long.TryParse(dataGridViewPessoas.CurrentRow.Cells[0].Value.ToString(), out long id))
            {
                Pessoa p = PessoaDal.FindById(id);
                ShowForm(Enums.Acoes.Editando, p);
                RefreshGrid();
            }
        }

        private void ShowForm(Enums.Acoes acao, Pessoa p)
        {
            PessoaAdicionar form;
            if (p == null)
            {
                form = new PessoaAdicionar(acao);
            }
            else
            {
                form = new PessoaAdicionar(acao, p);
            }
            form.ShowInTaskbar = false;
            form.ShowDialog(this);
        }
    }
}
