namespace info
{
    partial class FrmProduto
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label codigoCategoriaLabel;
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.textValor = new System.Windows.Forms.TextBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DtvProdutos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descricaoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            codigoCategoriaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(74, 20);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 5;
            descricaoLabel.Text = "Descrição:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(98, 56);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 7;
            valorLabel.Text = "Valor:";
            // 
            // codigoCategoriaLabel
            // 
            codigoCategoriaLabel.AutoSize = true;
            codigoCategoriaLabel.Location = new System.Drawing.Point(77, 86);
            codigoCategoriaLabel.Name = "codigoCategoriaLabel";
            codigoCategoriaLabel.Size = new System.Drawing.Size(55, 13);
            codigoCategoriaLabel.TabIndex = 9;
            codigoCategoriaLabel.Text = "Categoria:";
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(93, 117);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGravar.Location = new System.Drawing.Point(186, 117);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 1;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(277, 117);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(375, 117);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 3;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Info.DAL.Produto);
            // 
            // textDescricao
            // 
            this.textDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Descricao", true));
            this.textDescricao.Location = new System.Drawing.Point(138, 17);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(312, 20);
            this.textDescricao.TabIndex = 6;
            // 
            // textValor
            // 
            this.textValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Valor", true));
            this.textValor.Location = new System.Drawing.Point(138, 53);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(100, 20);
            this.textValor.TabIndex = 8;
            // 
            // comboCategoria
            // 
            this.comboCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtoBindingSource, "CodigoCategoria", true));
            this.comboCategoria.DataSource = this.categoriaBindingSource;
            this.comboCategoria.DisplayMember = "Descricao";
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(138, 83);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboCategoria.TabIndex = 10;
            this.comboCategoria.ValueMember = "Codigo";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Info.DAL.Categoria);
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.categoriaBindingSource;
            // 
            // DtvProdutos
            // 
            this.DtvProdutos.AllowUserToAddRows = false;
            this.DtvProdutos.AllowUserToDeleteRows = false;
            this.DtvProdutos.AutoGenerateColumns = false;
            this.DtvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.DtvProdutos.DataSource = this.produtosBindingSource;
            this.DtvProdutos.Location = new System.Drawing.Point(12, 190);
            this.DtvProdutos.Name = "DtvProdutos";
            this.DtvProdutos.ReadOnly = true;
            this.DtvProdutos.Size = new System.Drawing.Size(526, 242);
            this.DtvProdutos.TabIndex = 10;
            this.DtvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtvProdutos_CellContentClick);
            this.DtvProdutos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.produtosDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 230;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn5.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 469);
            this.Controls.Add(this.DtvProdutos);
            this.Controls.Add(codigoCategoriaLabel);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.textValor);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.BtnNovo);
            this.Name = "FrmProduto";
            this.Text = "Produtos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProduto_FormClosed);
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.DataGridView DtvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

    }
}