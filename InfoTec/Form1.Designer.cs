namespace InfoTec
{
    partial class Form1
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
            this.NovoProduto = new System.Windows.Forms.Label();
            this.LabelNome = new System.Windows.Forms.Label();
            this.LabelPreco = new System.Windows.Forms.Label();
            this.LabelQtd = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.qtdTxt = new System.Windows.Forms.NumericUpDown();
            this.cadastroBtn = new System.Windows.Forms.Button();
            this.LabelDescricao = new System.Windows.Forms.Label();
            this.descricaoTxt = new System.Windows.Forms.TextBox();
            this.aviso = new System.Windows.Forms.Label();
            this.precoTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.qtdTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // NovoProduto
            // 
            this.NovoProduto.AutoSize = true;
            this.NovoProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.NovoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoProduto.Location = new System.Drawing.Point(73, 38);
            this.NovoProduto.Name = "NovoProduto";
            this.NovoProduto.Size = new System.Drawing.Size(192, 31);
            this.NovoProduto.TabIndex = 0;
            this.NovoProduto.Text = "Novo Produto";
            this.NovoProduto.Click += new System.EventHandler(this.NovoProduto_Click);
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNome.Location = new System.Drawing.Point(43, 116);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(47, 16);
            this.LabelNome.TabIndex = 1;
            this.LabelNome.Text = "Nome:";
            this.LabelNome.Click += new System.EventHandler(this.LabelNome_Click);
            // 
            // LabelPreco
            // 
            this.LabelPreco.AutoSize = true;
            this.LabelPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPreco.Location = new System.Drawing.Point(44, 264);
            this.LabelPreco.Name = "LabelPreco";
            this.LabelPreco.Size = new System.Drawing.Size(46, 16);
            this.LabelPreco.TabIndex = 2;
            this.LabelPreco.Text = "Preço:";
            this.LabelPreco.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelQtd
            // 
            this.LabelQtd.AutoSize = true;
            this.LabelQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQtd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelQtd.Location = new System.Drawing.Point(44, 327);
            this.LabelQtd.Name = "LabelQtd";
            this.LabelQtd.Size = new System.Drawing.Size(80, 16);
            this.LabelQtd.TabIndex = 3;
            this.LabelQtd.Text = "Quantidade:";
            this.LabelQtd.Click += new System.EventHandler(this.label3_Click);
            // 
            // nomeTxt
            // 
            this.nomeTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nomeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTxt.Location = new System.Drawing.Point(46, 135);
            this.nomeTxt.MaxLength = 50;
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(235, 20);
            this.nomeTxt.TabIndex = 4;
            this.nomeTxt.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // qtdTxt
            // 
            this.qtdTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.qtdTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.qtdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdTxt.Location = new System.Drawing.Point(47, 346);
            this.qtdTxt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.qtdTxt.Name = "qtdTxt";
            this.qtdTxt.Size = new System.Drawing.Size(73, 20);
            this.qtdTxt.TabIndex = 6;
            this.qtdTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qtdTxt.ValueChanged += new System.EventHandler(this.qntdProd_ValueChanged);
            // 
            // cadastroBtn
            // 
            this.cadastroBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.cadastroBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroBtn.ForeColor = System.Drawing.Color.White;
            this.cadastroBtn.Location = new System.Drawing.Point(79, 410);
            this.cadastroBtn.Name = "cadastroBtn";
            this.cadastroBtn.Size = new System.Drawing.Size(180, 45);
            this.cadastroBtn.TabIndex = 7;
            this.cadastroBtn.Text = "Cadastrar";
            this.cadastroBtn.UseVisualStyleBackColor = false;
            this.cadastroBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelDescricao
            // 
            this.LabelDescricao.AutoSize = true;
            this.LabelDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescricao.Location = new System.Drawing.Point(43, 169);
            this.LabelDescricao.Name = "LabelDescricao";
            this.LabelDescricao.Size = new System.Drawing.Size(72, 16);
            this.LabelDescricao.TabIndex = 8;
            this.LabelDescricao.Text = "Descrição:";
            this.LabelDescricao.Click += new System.EventHandler(this.label1_Click);
            // 
            // descricaoTxt
            // 
            this.descricaoTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.descricaoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTxt.Location = new System.Drawing.Point(46, 188);
            this.descricaoTxt.MaxLength = 255;
            this.descricaoTxt.Multiline = true;
            this.descricaoTxt.Name = "descricaoTxt";
            this.descricaoTxt.Size = new System.Drawing.Size(235, 56);
            this.descricaoTxt.TabIndex = 9;
            this.descricaoTxt.TextChanged += new System.EventHandler(this.descricao_TextChanged);
            // 
            // aviso
            // 
            this.aviso.AutoSize = true;
            this.aviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aviso.ForeColor = System.Drawing.Color.Red;
            this.aviso.Location = new System.Drawing.Point(43, 91);
            this.aviso.Name = "aviso";
            this.aviso.Size = new System.Drawing.Size(184, 13);
            this.aviso.TabIndex = 12;
            this.aviso.Text = "Por favor, preencha todos os campos";
            this.aviso.Visible = false;
            this.aviso.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // precoTxt
            // 
            this.precoTxt.Location = new System.Drawing.Point(46, 283);
            this.precoTxt.Name = "precoTxt";
            this.precoTxt.Size = new System.Drawing.Size(100, 20);
            this.precoTxt.TabIndex = 14;
            this.precoTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(344, 561);
            this.Controls.Add(this.precoTxt);
            this.Controls.Add(this.aviso);
            this.Controls.Add(this.descricaoTxt);
            this.Controls.Add(this.LabelDescricao);
            this.Controls.Add(this.cadastroBtn);
            this.Controls.Add(this.qtdTxt);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.LabelQtd);
            this.Controls.Add(this.LabelPreco);
            this.Controls.Add(this.LabelNome);
            this.Controls.Add(this.NovoProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "TelaCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.qtdTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NovoProduto;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.Label LabelPreco;
        private System.Windows.Forms.Label LabelQtd;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.NumericUpDown qtdTxt;
        private System.Windows.Forms.Button cadastroBtn;
        private System.Windows.Forms.Label LabelDescricao;
        private System.Windows.Forms.TextBox descricaoTxt;
        private System.Windows.Forms.Label aviso;
        private System.Windows.Forms.TextBox precoTxt;
    }
}

