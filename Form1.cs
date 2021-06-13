using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Upr6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fillGrid();
        }

        private void fillGrid()
        {
            List<List<double>> list = new List<List<double>> {
                new List<double> { 5, 4, 3, 5, 3, 4, 3, 4, 5, 3, 5 },
                new List<double> { 2, 4, 1, 5, 3, 1, 5, 1, 2, 3, 5},
                new List<double> { 3, 5, 3, 4, 1, 5, 4, 2, 3, 4, 2},
                new List<double> { 4, 1, 3, 5, 2, 4, 2, 2, 5, 3, 2},
                new List<double> { 5, 5, 3, 5, 4, 5, 4, 5, 4, 3, 5}
            };
            for (int i = 0; i < numericUpDownCriteries.Value; i++)
            {
                dataGridView1.Columns.Add(i.ToString(), i.ToString());
                dataGridView1.Columns[i].DefaultCellStyle.NullValue = "0";
            }
            for (int i = 0; i < numericUpDownElements.Value; i++)
            {
                dataGridView1.Rows.Add();
            }
        }

        private void numericUpDownCriteries_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(((UpDownBase)sender).Text) < numericUpDownCriteries.Value)
            {
                dataGridView1.Columns.Add((dataGridView1.Columns.Count).ToString(), (dataGridView1.Columns.Count).ToString());
                dataGridView1.Columns[dataGridView1.Columns.Count - 1].DefaultCellStyle.NullValue = "0";
            }
            else
            {
                dataGridView1.Columns.Remove((Convert.ToInt32(((UpDownBase)sender).Text) - 1).ToString());
            }
        }

        private void numericUpDownElements_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(((UpDownBase)sender).Text) < numericUpDownElements.Value)
            {
                dataGridView1.Rows.Add();
            }
            else
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
            }
        }

        private static List<List<double>> dgwTo2dListOfDouble(DataGridView dataGridView)
        {
            List<List<double>> list = new List<List<double>>();
            for (int i2 = 0; i2 < dataGridView.Rows.Count; i2++)
            {
                list.Add(new List<double>());
                for (int j2 = 0; j2 < dataGridView.Columns.Count; j2++)
                {
                    list[i2].Add(Convert.ToDouble(dataGridView.Rows[i2].Cells[j2].Value));
                }
            }
            return list;
        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = rnd.Next(0, 3).ToString();
                }
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs ev)
        {
            var matrix = dgwTo2dListOfDouble(dataGridView1);

            List<double> result = new List<double>();
            for (int i = 0; i < matrix.Count; i++)
            {
                double minmax = 99999999;
                foreach (var elem in matrix[i])
                {
                    minmax = elem < minmax ? elem : minmax;
                }
                result.Add(minmax);
            }

            richTextBox1.Text = "Результат критерия минимакса: \n";

            foreach (var item in result)
            {
                richTextBox1.Text += item.ToString() + " ";
            }

            richTextBox1.Text += "\n";

            result = new List<double>();
            for (int i = 0; i < matrix.Count; i++)
            {
                double bl = 0;
                matrix[i].ForEach(e => bl += e);
                result.Add(bl);
            }

            richTextBox1.Text += "Результат критерия B-L: \n";

            foreach (var item in result)
            {
                richTextBox1.Text += item.ToString() + " ";
            }

            richTextBox1.Text += "\n";

            result = new List<double>();
            for (int i = 0; i < matrix.Count; i++)
            {
                double gurvic = 0;
                double c = 0.5;
                matrix[i].Sort();
                double min = matrix[i][0];
                matrix[i].Reverse();
                double max = matrix[i][0];
                gurvic = c * min + (1 - c) * max;
                result.Add(gurvic);
            }

            richTextBox1.Text += "Результат критерия Гурвица: \n";

            foreach (var item in result)
            {
                richTextBox1.Text += item.ToString() + " ";
            }

            richTextBox1.Text += "\n";

            result = new List<double>();
            for (int i = 0; i < matrix.Count; i++)
            {
                double leman = 0;
                double q = 1.0 / matrix.Count;
                double v = 0.5;
                matrix[i].Sort();
                double min = matrix[i][0];
                double sum = 0;
                matrix[i].ForEach(e => sum += e);
                leman = Math.Round(v * q * sum + (1 - v) * min, 2);
                result.Add(leman);
            }

            richTextBox1.Text += "Результат критерия Ходжа-Лемана/минимакса: \n";

            foreach (var item in result)
            {
                richTextBox1.Text += item.ToString() + " ";
            }

            richTextBox1.Text += "\n";
        }
    }
}
