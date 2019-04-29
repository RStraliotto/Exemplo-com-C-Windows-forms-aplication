using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Bra
{
    public partial class Cadastro_de_Produtos : Form
    {
        public Cadastro_de_Produtos()
        {
            InitializeComponent();
        }

        private void tbprodutosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbprodutosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.estoqueDataSet);

        }

        private void Cadastro_de_Produtos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueDataSet.tbprodutos' table. You can move, or remove it, as needed.
            this.tbprodutosTableAdapter.Fill(this.estoqueDataSet.tbprodutos);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbprodutosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
