using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ITEC.controller;
using System.Windows.Forms;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace ITEC.view
{
    class ChartGenerator
    {
        private bool chartLoaded = false;
        private int total = 0;
        private int budget;
        private int catId;
        private Chart chart;
        public ChartGenerator()
        {
        }
        public void run(Controller ctr, int catId, int budget, Chart chart)
        {
            total = 0;
            this.chart = chart;
            this.budget = budget;
            LinkedList<item> items = new LinkedList<item>();
            if (catId != -1)
            {
                category cat = ctr.getCategory(catId);
                foreach (item it in cat.items)
                {
                    items.AddLast(it);
                }
            }
            else
            {
                items = ctr.getItems();
            }

            chart.Series.Clear();
            foreach (item it in items)
            {
                total += (int)it.points;
            }
            foreach (item it in items)
            {
                chart.Series.Add(it.name);
                //chart.Series[it.name].Points.AddY(budget * getProcentage(total, (int)it.points) / 100);
                chart.Series[it.name].Points.AddY(it.points * budget / total);
                chart.Series[it.name].IsValueShownAsLabel = true;
                chart.Series[it.name].SmartLabelStyle.IsMarkerOverlappingAllowed = false;
            }
            chartLoaded = true;
        }

        public decimal getProcentage(int total, int part)
        {
            return total * part / 100;
        }

        public void exportAsPicture(Chart chart)
        {
            if (!chartLoaded)
            {
                MessageBox.Show("Chart not generated");
                return;
            }
            string path = "";
            SaveFileDialog diag = new SaveFileDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                path = diag.FileName;
            }

            chart.SaveImage(path, ChartImageFormat.Jpeg);
        }


        public void exportCSV(Controller ctr)
        {
            if(!chartLoaded)
            {
                MessageBox.Show("Report not generated");
                return;
            }
            String item = "";
            String points = "";
            String path = "";

            SaveFileDialog diag = new SaveFileDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                path = diag.FileName;
            }

            foreach (Series ser in chart.Series)
            {
                item += ser.Name + ",";
                points += "\"" + ser.Points[0].YValues[0].ToString() + "\",";
            }

            System.IO.StreamWriter file = new System.IO.StreamWriter(path);
            file.WriteLine(item);
            file.WriteLine(points);
            file.Close();
        }
    }
}
