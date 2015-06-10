using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace info
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormCategoria == null)
                MeusFormularios.FormCategoria = new FrmCategoria();

            MeusFormularios.FormCategoria.Show();
            MeusFormularios.FormCategoria.Focus();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormProduto == null)
                MeusFormularios.FormProduto = new FrmProduto();

            MeusFormularios.FormProduto.Show();
            MeusFormularios.FormProduto.Focus();
        }

        private void produtoPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FormProdutosPorCategoria == null)
                MeusFormularios.FormProdutosPorCategoria = new FrmProdutosPorCategorias();

            MeusFormularios.FormProdutosPorCategoria.Show();
            MeusFormularios.FormProdutosPorCategoria.Focus();
        }
    }
}
