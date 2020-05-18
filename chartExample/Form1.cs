using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace chartExample
{
    public partial class Form1 : Form
    {
        int k = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Series rand = new Series();
            rand.ChartType = (SeriesChartType)k++;
            Random rnd = new Random();
            for (int x = 0; x < 10; x++)
            {
                rand.Points.AddXY(x, rnd.Next(100));
            }

            chart1.Series.Add(rand);

        }

        List<int> a;
        List<MyData> list;
        private void button2_Click(object sender, EventArgs e)
        {
            list = new List<MyData>();
            list.Add(new MyData(10, 5.7));
            list.Add(new MyData(100, 3.2));
            list.Add(new MyData(1000, 10.0));
            chart1.Series[0].XValueMember = "Count";
            chart1.Series[0].YValueMembers = "Time";
            chart1.DataSource = list;
            chart1.DataBind();
        }
  
        private void button3_Click(object sender, EventArgs e)
        {

            list.Add(new MyData(200, 7.3));
            chart1.DataBind();
        }
    }
    class MyData
    {
        public int Count { get; set; }
        public double Time { get; set; }

        public MyData(int n, double t)
        {
            Count = n;
            Time = t;
        }
    }

}
