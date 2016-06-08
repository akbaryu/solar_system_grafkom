using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaSolar
{
    public partial class quiz : Form
    {
        float nilai = 0;
        float hasil = 0;

        public quiz()
        {
            InitializeComponent();
            panel2.Hide(); panel3.Hide(); panel4.Hide(); panel5.Hide(); panel6.Hide(); panel7.Hide(); panel8.Hide(); panel9.Hide(); panel10.Hide();
            panel11.Hide(); panel12.Hide(); panel13.Hide(); panel14.Hide(); panel15.Hide(); panel16.Hide(); panel17.Hide(); panel18.Hide(); panel19.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel8.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel14.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nilai = nilai + 1;
            panel2.Hide();
            panel3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nilai = nilai + 1;
            panel3.Hide();
            panel4.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            panel5.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            nilai = nilai + 1;
            panel4.Hide();
            panel5.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            nilai = nilai + 1;
            panel5.Hide();
            panel6.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            panel6.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel6.Hide();
            panel7.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            nilai = nilai + 1;
            panel6.Hide();
            panel7.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hasil = (nilai / 5) * 100;
            button15.Text =hasil.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            nilai = nilai + 1;
            panel8.Hide();
            panel9.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            panel9.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu a = new Menu();
            a.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu a = new Menu();
            a.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            nilai = nilai + 1;
            panel9.Hide();
            panel10.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel9.Hide();
            panel10.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            nilai = nilai + 1;
            panel10.Hide();
            panel11.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel10.Hide();
            panel11.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            panel11.Hide();
            panel12.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            nilai = nilai + 1;
            panel11.Hide();
            panel12.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel12.Hide();
            panel13.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            nilai = nilai + 1;
            panel12.Hide();
            panel13.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            hasil = (nilai / 5) * 100;
            button28.Text = hasil.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu a = new Menu();
            a.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            nilai = nilai + 1;
            panel14.Hide();
            panel15.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            panel14.Hide();
            panel15.Show();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            panel15.Hide();
            panel16.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            nilai = nilai + 1;
            panel15.Hide();
            panel16.Show();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            nilai = nilai + 1;
            panel16.Hide();
            panel17.Show();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            panel16.Hide();
            panel17.Show();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            nilai = nilai + 1;
            panel17.Hide();
            panel18.Show();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            panel17.Hide();
            panel18.Show();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            nilai = nilai + 1;
            panel18.Hide();
            panel19.Show();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            panel18.Hide();
            panel19.Show();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            hasil = (nilai / 5) * 100;
            button40.Text = hasil.ToString();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu a = new Menu();
            a.Show();
        }
    }
}
