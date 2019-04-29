namespace WindowsForms_Bra
{
    partial class GraficoProd
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.estoqueDataSet = new WindowsForms_Bra.EstoqueDataSet();
            this.estoqueDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbprodutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbprodutosTableAdapter = new WindowsForms_Bra.EstoqueDataSetTableAdapters.tbprodutosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "Produtos";
            chartArea1.AxisY.Title = "Quantidades";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.tbprodutosBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Estoque ";
            series1.XValueMember = "nome";
            series1.YValueMembers = "quantidade";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(553, 406);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // estoqueDataSet
            // 
            this.estoqueDataSet.DataSetName = "EstoqueDataSet";
            this.estoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoqueDataSetBindingSource
            // 
            this.estoqueDataSetBindingSource.DataSource = this.estoqueDataSet;
            this.estoqueDataSetBindingSource.Position = 0;
            // 
            // tbprodutosBindingSource
            // 
            this.tbprodutosBindingSource.DataMember = "tbprodutos";
            this.tbprodutosBindingSource.DataSource = this.estoqueDataSetBindingSource;
            // 
            // tbprodutosTableAdapter
            // 
            this.tbprodutosTableAdapter.ClearBeforeFill = true;
            // 
            // GraficoProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 430);
            this.Controls.Add(this.chart1);
            this.Name = "GraficoProd";
            this.Text = "Gráfico de Produtos";
            this.TransparencyKey = System.Drawing.Color.DarkTurquoise;
            this.Load += new System.EventHandler(this.GraficoProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbprodutosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource estoqueDataSetBindingSource;
        private EstoqueDataSet estoqueDataSet;
        private System.Windows.Forms.BindingSource tbprodutosBindingSource;
        private EstoqueDataSetTableAdapters.tbprodutosTableAdapter tbprodutosTableAdapter;
    }
}

