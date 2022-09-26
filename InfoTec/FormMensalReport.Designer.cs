namespace InfoTec
{
    partial class FormMensalReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.label2 = new System.Windows.Forms.Label();
            this.NovoProduto = new System.Windows.Forms.Label();
            this.gerarRelatorioTxt = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 8;
            // 
            // NovoProduto
            // 
            this.NovoProduto.AutoSize = true;
            this.NovoProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.NovoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoProduto.Location = new System.Drawing.Point(122, 9);
            this.NovoProduto.Name = "NovoProduto";
            this.NovoProduto.Size = new System.Drawing.Size(271, 31);
            this.NovoProduto.TabIndex = 9;
            this.NovoProduto.Text = "Rendimento Mensal";
            // 
            // gerarRelatorioTxt
            // 
            this.gerarRelatorioTxt.BackColor = System.Drawing.Color.Orange;
            this.gerarRelatorioTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gerarRelatorioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerarRelatorioTxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gerarRelatorioTxt.Location = new System.Drawing.Point(211, 271);
            this.gerarRelatorioTxt.Name = "gerarRelatorioTxt";
            this.gerarRelatorioTxt.Size = new System.Drawing.Size(100, 57);
            this.gerarRelatorioTxt.TabIndex = 10;
            this.gerarRelatorioTxt.Text = "Gerar Relatorio";
            this.gerarRelatorioTxt.UseVisualStyleBackColor = false;
            this.gerarRelatorioTxt.Click += new System.EventHandler(this.gerarRelatorioTxt_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(17, 42);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chart1.Size = new System.Drawing.Size(470, 224);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // FormMensalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 561);
            this.Controls.Add(this.gerarRelatorioTxt);
            this.Controls.Add(this.NovoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMensalReport";
            this.Text = "Rendimento Mensal";
            this.Load += new System.EventHandler(this.FormMensalReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NovoProduto;
        private System.Windows.Forms.Button gerarRelatorioTxt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}