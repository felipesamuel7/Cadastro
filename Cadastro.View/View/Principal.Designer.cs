namespace Cadastro.View
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewPessoas = new System.Windows.Forms.DataGridView();
            this.gbGrid = new System.Windows.Forms.GroupBox();
            this.gbAcoes = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoas)).BeginInit();
            this.gbGrid.SuspendLayout();
            this.gbAcoes.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPessoas
            // 
            this.dataGridViewPessoas.AllowUserToAddRows = false;
            this.dataGridViewPessoas.AllowUserToDeleteRows = false;
            this.dataGridViewPessoas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPessoas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPessoas.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewPessoas.Name = "dataGridViewPessoas";
            this.dataGridViewPessoas.ReadOnly = true;
            this.dataGridViewPessoas.Size = new System.Drawing.Size(524, 155);
            this.dataGridViewPessoas.TabIndex = 1;
            // 
            // gbGrid
            // 
            this.gbGrid.Controls.Add(this.dataGridViewPessoas);
            this.gbGrid.Location = new System.Drawing.Point(12, 12);
            this.gbGrid.Name = "gbGrid";
            this.gbGrid.Size = new System.Drawing.Size(530, 174);
            this.gbGrid.TabIndex = 2;
            this.gbGrid.TabStop = false;
            this.gbGrid.Text = "Pessoas Cadastradas";
            // 
            // gbAcoes
            // 
            this.gbAcoes.Controls.Add(this.flowLayoutPanel1);
            this.gbAcoes.Location = new System.Drawing.Point(15, 192);
            this.gbAcoes.Name = "gbAcoes";
            this.gbAcoes.Size = new System.Drawing.Size(527, 52);
            this.gbAcoes.TabIndex = 3;
            this.gbAcoes.TabStop = false;
            this.gbAcoes.Text = "Ações";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btAdicionar);
            this.flowLayoutPanel1.Controls.Add(this.btEditar);
            this.flowLayoutPanel1.Controls.Add(this.btRemover);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(521, 33);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(3, 3);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(100, 23);
            this.btAdicionar.TabIndex = 0;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.BtAdicionarClick);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(109, 3);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(100, 23);
            this.btEditar.TabIndex = 1;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.BtEditarClick);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(215, 3);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(100, 23);
            this.btRemover.TabIndex = 2;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.BtRemoverClick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 256);
            this.Controls.Add(this.gbAcoes);
            this.Controls.Add(this.gbGrid);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoas";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoas)).EndInit();
            this.gbGrid.ResumeLayout(false);
            this.gbAcoes.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPessoas;
        private System.Windows.Forms.GroupBox gbGrid;
        private System.Windows.Forms.GroupBox gbAcoes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btRemover;
    }
}

