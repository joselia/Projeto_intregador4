using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Info.DAL;

namespace info
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormProduto = null;
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;


        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.AddNew();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            DtvProdutos.Refresh();
            MessageBox.Show("Produto Armazenado com Sucesso!");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.CancelEdit();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.RemoveCurrent();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Produto Excluido com Sucesso!");

        }

        private void produtosDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
                e.Value = ((Categoria)e.Value).Descricao;
        }

        private void DtvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = DtvProdutos.CurrentRow.Index;
            textDescricao.Text = DtvProdutos[1, row].Value.ToString();
            textValor.Text = DtvProdutos[2, row].Value.ToString();
            comboCategoria.Text = DtvProdutos[3, row].Value.ToString();
            
        }
    }
}
