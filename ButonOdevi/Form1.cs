using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButonOdevi
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                Button Button1 = new Button();
                Button1.Text = i.ToString();
                this.Controls.Add(Button1);
                Button1.Location = new Point(20, (25 * i) - 25);
                Button1.Click += button1_Click;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button numaralar = (Button)sender;
            label1.Text = numaralar.Text.ToString();
        }
    }
}
