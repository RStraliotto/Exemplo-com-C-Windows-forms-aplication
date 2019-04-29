namespace WindowsForms_Bra
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apontamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.produçãoToolStripMenuItem,
            this.fiscalToolStripMenuItem,
            this.contabilidadeToolStripMenuItem,
            this.manutençãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.estoqueToolStripMenuItem.Text = "Comercial";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // produçãoToolStripMenuItem
            // 
            this.produçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem1,
            this.apontamentoToolStripMenuItem});
            this.produçãoToolStripMenuItem.Name = "produçãoToolStripMenuItem";
            this.produçãoToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.produçãoToolStripMenuItem.Text = "Produção";
            // 
            // fiscalToolStripMenuItem
            // 
            this.fiscalToolStripMenuItem.Name = "fiscalToolStripMenuItem";
            this.fiscalToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fiscalToolStripMenuItem.Text = "Fiscal";
            // 
            // contabilidadeToolStripMenuItem
            // 
            this.contabilidadeToolStripMenuItem.Name = "contabilidadeToolStripMenuItem";
            this.contabilidadeToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.contabilidadeToolStripMenuItem.Text = "Contabilidade";
            // 
            // estoqueToolStripMenuItem1
            // 
            this.estoqueToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeProdutoToolStripMenuItem,
            this.gráficoDeProdutosToolStripMenuItem});
            this.estoqueToolStripMenuItem1.Name = "estoqueToolStripMenuItem1";
            this.estoqueToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.estoqueToolStripMenuItem1.Text = "Estoque";
            this.estoqueToolStripMenuItem1.Click += new System.EventHandler(this.estoqueToolStripMenuItem1_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // apontamentoToolStripMenuItem
            // 
            this.apontamentoToolStripMenuItem.Name = "apontamentoToolStripMenuItem";
            this.apontamentoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.apontamentoToolStripMenuItem.Text = "Apontamento";
            // 
            // cadastroDeProdutoToolStripMenuItem
            // 
            this.cadastroDeProdutoToolStripMenuItem.Name = "cadastroDeProdutoToolStripMenuItem";
            this.cadastroDeProdutoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDeProdutoToolStripMenuItem.Text = "Cadastro de produtos";
            this.cadastroDeProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProdutoToolStripMenuItem_Click);
            // 
            // gráficoDeProdutosToolStripMenuItem
            // 
            this.gráficoDeProdutosToolStripMenuItem.Name = "gráficoDeProdutosToolStripMenuItem";
            this.gráficoDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.gráficoDeProdutosToolStripMenuItem.Text = "Gráfico de produtos";
            this.gráficoDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.gráficoDeProdutosToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(546, 411);
            this.ClientSize = new System.Drawing.Size(874, 401);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "BOLT ERP";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contabilidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apontamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficoDeProdutosToolStripMenuItem;
    }
}