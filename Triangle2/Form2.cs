using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle2
{
    public partial class Form2 : Form
    {
        Button btn = new Button();
        Button btn1 = new Button();
        ListView lv = new ListView();
        TextBox txt1 = new TextBox();
        TextBox txt2 = new TextBox();
        Graphics gp;
        Pen p = new Pen(Brushes.Black, 2);
        Panel panel1;

        public Form2()
        {
            InitializeComponent();
            this.Height = 400;
            this.Width = 500;
            Panel panel1 = new Panel();
            gp = panel1.CreateGraphics();
            panel1.Location = new Point(50, 110);
            panel1.Height = 100;
            panel1.Width = 160;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BackColor = Color.RosyBrown;
            btn.Location = new Point(300, 220);
            btn1.Location = new Point(50,220);
            btn.Text = "Построить треугольник";
            btn1.Text = "Нарисовать треугольник";
            btn1.Height = 100;
            btn1.Width = 160;
            btn.Height = 100;
            btn.Width = 150;
            btn.BackColor = Color.Beige;
            btn1.BackColor = Color.Bisque;
            btn.Font = new Font(btn.Font.FontFamily, 12);
            btn1.Font = new Font(btn.Font.FontFamily, 12);
            btn.Click += new EventHandler(btn_Click);
            btn1.Click += Btn1_Click;
            lv.Location = new Point(300,60);
            lv.Height = 90;
            lv.Width = 150;
            lv.View = View.Details;
            lv.Columns.Add("Данные     ", -2,HorizontalAlignment.Left);
            lv.Columns.Add("Значение", -2, HorizontalAlignment.Left);            
            txt2.Location = new Point(300,160);
            txt1.Location = new Point(300,190);
            txt2.Text = "Сторона 2";
            txt1.Text = "Сторона 1";
            txt1.MouseClick += new MouseEventHandler(this.TextBoxIsClicked);
            txt2.MouseClick += new MouseEventHandler(this.TextBoxIsClicked);




            Point ulCorner = new Point(100, 100);
            Controls.Add(btn);
            Controls.Add(lv);
            Controls.Add(txt1);
            Controls.Add(txt2);
            Controls.Add(btn1);
            Controls.Add(panel1);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(5, 90);
            Point p2 = new Point(150, 90);
            Point p3 = new Point(75, 1);

            gp.DrawLine(p, p1, p2);
            gp.DrawLine(p, p2, p3);
            gp.DrawLine(p, p3, p1);
        }

        private void TextBoxIsClicked(object sender, MouseEventArgs e)
        {
            TextBox box = sender as TextBox;
            box.Text = String.Empty;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            lv.Items.Clear();


            if (txt1.Text != "Сторона 1" && txt2.Text != "Сторона 2")
            {
                a = Convert.ToDouble(txt1.Text);
                b = Convert.ToDouble(txt2.Text);
                
            }

            if (a != 0 && b != 0)
            {
                Triangle2 triangle = new Triangle2(a, b);
                lv.Items.Add("Сторона a");
                lv.Items.Add("Сторона b");
                lv.Items.Add("Сторона с");
                lv.Items[0].SubItems.Add(triangle.outputA());
                lv.Items[1].SubItems.Add(triangle.outputB());
                lv.Items[2].SubItems.Add(Convert.ToString(triangle.CSide()));
            }
            else
            {
                MessageBox.Show("Текстовые поля пустые!!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
