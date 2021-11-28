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

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            chtWykres.Titles.Clear();

            chtWykres.Series.Clear();

            chtWykres.Series.Add("Zmiana ceny");

            chtWykres.ChartAreas[0].AxisX.Title = "Data";
            
            chtWykres.ChartAreas[0].AxisX.Interval = 5;
            chtWykres.ChartAreas[0].AxisY.Title = "Cena";
            chtWykres.ChartAreas[0].AxisY.Interval = 150;
            
            chtWykres.ChartAreas[0].Name = "Wykres zmiany ceny";
            chtWykres.Series[0].ChartType = SeriesChartType.Line;
            chtWykres.Series[0].Color = Color.Green;
            chtWykres.Series[0].BorderDashStyle = ChartDashStyle.Solid;
            chtWykres.Series[0].BorderWidth = 2;
            chtWykres.Series[0].IsVisibleInLegend = true;
            chtWykres.Legends.FindByName("Legend1").Docking = Docking.Bottom;
            foreach (var item in Program.items)
                chtWykres.Series[0].Points.AddXY(item.date, item.price);
            

            chtWykres.Visible = true;
            button1.Visible = false;
        }

    }
}
