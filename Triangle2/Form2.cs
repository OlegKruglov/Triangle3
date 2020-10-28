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
        ListView lv = new ListView();
        TextBox txt1 = new TextBox();
        TextBox txt2 = new TextBox();

        public Form2()
        {
            InitializeComponent();
            this.BackColor = Color.RosyBrown;
            btn.Location = new Point(500, 320);
            btn.Text = "Построить треугольник";
            btn.Height = 100;
            btn.Width = 150;
            btn.BackColor = Color.Beige;
            btn.Font = new Font(btn.Font.FontFamily, 12);
            btn.Click += new EventHandler(btn_Click);
            lv.Location = new Point(500,50);
            lv.Height = 200;
            lv.Width = 250;
            lv.View = View.Details;
            lv.Columns.Add("Поле", -2,HorizontalAlignment.Left);
            lv.Columns.Add("Значение", -2, HorizontalAlignment.Left);            
            txt2.Location = new Point(500,260);
            txt1.Location = new Point(500, 290);
            txt2.Text = "Сторона 2";
            txt1.Text = "Сторона 1";
            txt1.MouseClick += new MouseEventHandler(this.TextBoxIsClicked);
            txt2.MouseClick += new MouseEventHandler(this.TextBoxIsClicked);




            Point ulCorner = new Point(100, 100);
            Controls.Add(btn);
            Controls.Add(lv);
            Controls.Add(txt1);
            Controls.Add(txt2);
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
