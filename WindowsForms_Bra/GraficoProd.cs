using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsForms_Bra
{
    public partial class GraficoProd : Form
    {
        public GraficoProd()
        {
            InitializeComponent();
        }

        private void GraficoProd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'estoqueDataSet.tbprodutos' table. You can move, or remove it, as needed.
            this.tbprodutosTableAdapter.Fill(this.estoqueDataSet.tbprodutos);

        }
    }
}
