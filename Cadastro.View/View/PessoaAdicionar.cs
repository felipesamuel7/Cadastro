using Cadastro.Dal;
using Cadastro.Dal.Services.Dal;
using System;
using System.Windows.Forms;
using Wm.BI.Common.Services.Enums;

namespace Cadastro.View.View
{
    public partial class PessoaAdicionar : Form
    {
        Enums.Acoes acao;
        Pessoa p;
        public PessoaAdicionar(Enums.Acoes acao)
        {
            InitializeComponent();
            this.acao = acao;
        }

        public PessoaAdicionar(Enums.Acoes acao, Pessoa p)
        {
            InitializeComponent();
            this.acao = acao;
            this.p = p;
            this.Text = "Editar Pessoa";
            this.btAdicionar.Text = "Salvar";
            this.tbNome.Text = p.nome;
            this.tbIdade.Value = p.idade;
            this.tbDataNascimento.Value = p.data_nascimento;
        }

        private void BtAdicionarClick(object sender, EventArgs e)
        {
            if (acao.Equals(Enums.Acoes.Criando))
            {
                p = new Pessoa();
                PopulaPessoa();
                PessoaDal.Add(p);
            }
            else if (acao.Equals(Enums.Acoes.Editando))
            {
                PopulaPessoa();
                PessoaDal.Add(p);
            }

            this.Close();
        }

        private Pessoa PopulaPessoa()
        {
            p.nome = tbNome.Text;
            p.idade = Convert.ToInt32(tbIdade.Value);
            p.data_nascimento = tbDataNascimento.Value;
            return p;
        }
    }
}
