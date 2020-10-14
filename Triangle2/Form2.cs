using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.BackColor = Color.RosyBrown;
            Button btn = new Button();
            btn.Location = new Point(500, 300);
            btn.Text = "Построить треугольник";
            btn.Height = 100;
            btn.Width = 150;
            btn.BackColor = Color.Beige;
            btn.Font = new Font(btn.Font.FontFamily, 16);
            Controls.Add(btn);
        }
    }
}
