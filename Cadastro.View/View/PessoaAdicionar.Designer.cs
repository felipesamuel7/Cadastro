namespace Cadastro.View.View
{
    partial class PessoaAdicionar
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbIdade = new System.Windows.Forms.Label();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbIdade = new System.Windows.Forms.NumericUpDown();
            this.tbDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbNome, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbIdade, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbDataNascimento, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbNome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbIdade, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbDataNascimento, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btAdicionar, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 124);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNome.Location = new System.Drawing.Point(3, 26);
            this.lbNome.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 21);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.Location = new System.Drawing.Point(3, 52);
            this.lbIdade.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(37, 13);
            this.lbIdade.TabIndex = 1;
            this.lbIdade.Text = "Idade:";
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Location = new System.Drawing.Point(212, 52);
            this.lbDataNascimento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lbDataNascimento.TabIndex = 2;
            this.lbDataNascimento.Text = "Data de Nascimento:";
            // 
            // tbNome
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbNome, 3);
            this.tbNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNome.Location = new System.Drawing.Point(47, 24);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(438, 20);
            this.tbNome.TabIndex = 3;
            // 
            // tbIdade
            // 
            this.tbIdade.Location = new System.Drawing.Point(47, 50);
            this.tbIdade.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.tbIdade.Name = "tbIdade";
            this.tbIdade.Size = new System.Drawing.Size(100, 20);
            this.tbIdade.TabIndex = 4;
            this.tbIdade.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // tbDataNascimento
            // 
            this.tbDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbDataNascimento.Location = new System.Drawing.Point(325, 50);
            this.tbDataNascimento.Name = "tbDataNascimento";
            this.tbDataNascimento.Size = new System.Drawing.Size(160, 20);
            this.tbDataNascimento.TabIndex = 5;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdicionar.Location = new System.Drawing.Point(410, 97);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 6;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionarClick);
            // 
            // PessoaAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 124);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PessoaAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Pessoa";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbIdade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbIdade;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.NumericUpDown tbIdade;
        private System.Windows.Forms.DateTimePicker tbDataNascimento;
        private System.Windows.Forms.Button btAdicionar;
    }
}