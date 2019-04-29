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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_de_Produtos varcadproduto = new Cadastro_de_Produtos();
            varcadproduto.ShowDialog();
        }

        private void gráficoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraficoProd vargraf = new GraficoProd();
            vargraf.ShowDialog();
        }
    }
}
