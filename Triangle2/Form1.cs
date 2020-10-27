using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle2
{
    public partial class Form1 : Form
    {
        Graphics gp;
        Pen p = new Pen(Brushes.Black, 2);
       
        public Form1()
        {
            InitializeComponent();
            gp = panel1.CreateGraphics();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void TextBoxIsClicked(object sender, MouseEventArgs e)
        {
            TextBox box = sender as TextBox;
            box.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double h = 0;

            if (txtA.Text != "Основание" && txtB.Text != "Сторона 1" && txtC.Text != "Сторона 2" && txtH.Text != "Высота")
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
                h = Convert.ToDouble(txtH.Text);
            }

            if (a != 0 && b != 0 && c != 0 && h != 0)
            {
                Triangle triangle = new Triangle(a, b, c, h);
                listView1.Items.Add("Сторона a");
                listView1.Items.Add("Сторона b");
                listView1.Items.Add("Сторона c");
                listView1.Items.Add("Высота");
                listView1.Items.Add("Периметр");
                listView1.Items.Add("Площадь");
                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputB());
                listView1.Items[2].SubItems.Add(triangle.outputC());
                listView1.Items[3].SubItems.Add(triangle.outputH());
                listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Perimeter()));
                listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Surface()));
            }
            else
            {
                MessageBox.Show("Текстовые поля пустые!!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(5, 90);
            Point p2 = new Point(150, 90);
            Point p3 = new Point(75, 1);

            gp.DrawLine(p, p1, p2);
            gp.DrawLine(p, p2, p3);
            gp.DrawLine(p, p3, p1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
