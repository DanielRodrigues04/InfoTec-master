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

namespace InfoTec
{
    public partial class FormMensalReport : Form
    {
      
        public FormMensalReport()
        {
            InitializeComponent();




        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportText_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

           


        }

        private void FormMensalReport_Load(object sender, EventArgs e)
        {

        }

        private void gerarRelatorioTxt_Click(object sender, EventArgs e)
        {
            GerarGraficoColunas();
        }

        private void GerarGraficoColunas()
        {
            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.ForeColor = Color.Black;
            title.Text = "Vendas Mensais";
            chart1.Titles.Add(title);

            Legend legend = new Legend();
            chart1.Legends.Add(legend);
            chart1.Legends[0].Title = "Legenda";

            //remove gradeza vertical 

            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;                 


            //vendas reais

            chart1.Series.Add("vendas");
  
            chart1.Series["vendas"].LegendText = "Vendas";

            chart1.Series["vendas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["vendas"].BorderWidth = 4;


            chart1.Series["vendas"].Points.AddXY("janeiro", 140);
            chart1.Series["vendas"].Points.AddXY("Fevereiro", 118);
            chart1.Series["vendas"].Points.AddXY("Março", 122);
            chart1.Series["vendas"].Points.AddXY("Abril", 40);
            chart1.Series["vendas"].Points.AddXY("Maio", 90);
            chart1.Series["vendas"].Points.AddXY("Julho", 170);

            //previsao de Vendas

            chart1.Series.Add("previsao");
            chart1.Series["previsao"].LegendText = "Previsão";
            chart1.Series["previsao"].BorderWidth = 4;


            chart1.Series["previsao"].Points.AddXY("Janeiro", 20);
            chart1.Series["previsao"].Points.AddXY("Feveireiro", 120);
            chart1.Series["previsao"].Points.AddXY("Março", 55);
            chart1.Series["previsao"].Points.AddXY("Abril", 95);
            chart1.Series["previsao"].Points.AddXY("Maio", 100);
            chart1.Series["previsao"].Points.AddXY("Julho", 150);



        }

    }
}
