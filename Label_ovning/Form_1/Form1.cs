using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_1
{
    public partial class Form1 : Form
    {
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Magenta;
            label1.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            score++;
            this.Text = score.ToString();


            int x, y;

            Random random = new Random();
            x = random.Next(0, 800);
            y = random.Next(0, 500);

            label2.Left = x;
            label2.Top = y;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            int x, y;

            Random random = new Random();
            x = random.Next(0, 800);
            y = random.Next(0, 500);

            label2.Left = x;
            label2.Top = y;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            string name;
            name = label3.Text;
            label3.BackColor = Color.FromName(name);
        }
    }
}
