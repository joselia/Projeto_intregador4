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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormCategoria = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void LblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.AddNew();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (this.Valida())
            {
                this.categoriaBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Categoria Armazenada com Sucesso!");
            }
        }
        private bool Valida()
        {
            if (TxtCategoria.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" O Campo Categoria é Obrigatorio!");
                TxtCategoria.Focus();
                return false;

            }
            return true; ;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.RemoveCurrent();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Categoria Excluida com Sucesso!");
        }
    }
}
