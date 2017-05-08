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

        private void btRemoverClick(object sender, System.EventArgs e)
        {
            long id;
            if (long.TryParse(dataGridViewPessoas.CurrentRow.Cells[0].Value.ToString(), out id))
            {
                PessoaDal.DeleteById(id);
                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            this.dataGridViewPessoas.DataSource = PessoaDal.ListarPessoas();
        }

        private void btAdicionarClick(object sender, System.EventArgs e)
        {
            PessoaAdicionar form = new PessoaAdicionar(Enums.Acoes.Criando);
            form.ShowInTaskbar = false;
            form.ShowDialog(this);
            RefreshGrid();
        }

        private void btEditarClick(object sender, System.EventArgs e)
        {
            long id;
            if (long.TryParse(dataGridViewPessoas.CurrentRow.Cells[0].Value.ToString(), out id))
            {
                Pessoa p = PessoaDal.FindById(id);
                PessoaAdicionar form = new PessoaAdicionar(Enums.Acoes.Editando, p);
                form.ShowInTaskbar = false;
                form.ShowDialog(this);
                RefreshGrid();
            }
        }
    }
}
