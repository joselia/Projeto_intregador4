namespace info
{
    partial class FrmProdutosPorCategorias
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
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Info.DAL.Produto);
            // 
            // produtoDataGridView
            // 
            this.produtoDataGridView.AllowUserToAddRows = false;
            this.produtoDataGridView.AllowUserToDeleteRows = false;
            this.produtoDataGridView.AutoGenerateColumns = false;
            this.produtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.produtoDataGridView.DataSource = this.produtoBindingSource;
            this.produtoDataGridView.Location = new System.Drawing.Point(12, 143);
            this.produtoDataGridView.Name = "produtoDataGridView";
            this.produtoDataGridView.ReadOnly = true;
            this.produtoDataGridView.Size = new System.Drawing.Size(478, 220);
            this.produtoDataGridView.TabIndex = 1;
            this.produtoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produtoDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Produtos";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria:";
            // 
            // CboCategoria
            // 
            this.CboCategoria.DataSource = this.categoriaBindingSource;
            this.CboCategoria.DisplayMember = "Descricao";
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(84, 44);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(266, 21);
            this.CboCategoria.TabIndex = 3;
            this.CboCategoria.ValueMember = "Codigo";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Info.DAL.Categoria);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(380, 42);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 4;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // FrmProdutosPorCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 375);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.CboCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.produtoDataGridView);
            this.Name = "FrmProdutosPorCategorias";
            this.Text = ".: Produtos por Categorias :.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProdutosPorCategorias_FormClosed);
            this.Load += new System.EventHandler(this.FrmProdutosPorCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void produtoDataGridView_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
           
        }

        #endregion

        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridView produtoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.Button BtnPesquisar;
    }
}