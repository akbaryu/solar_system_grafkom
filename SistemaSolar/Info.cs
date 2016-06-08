using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaSolar
{
    public partial class Info : Form
    {
        int n = 0;
        public Info()
        {
            InitializeComponent();
            pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide();
            pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide();
            pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide();
            pictureBox18.Hide(); pictureBox19.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n++;
            
            if (n == 1)
            {
                pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide();
                pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide();
                pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide();
                pictureBox18.Hide(); pictureBox19.Hide();

                pictureBox2.Show(); pictureBox12.Show();
            }
            if (n == 2)
            {
                pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide();
                pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide();
                pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide();
                pictureBox18.Hide(); pictureBox19.Hide();

                pictureBox3.Show(); pictureBox13.Show();
            }
            if (n == 3)
            {
                pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide();
                pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide();
                pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide();
                pictureBox18.Hide(); pictureBox19.Hide();

                pictureBox4.Show(); pictureBox14.Show();
            }
            if (n == 4)
            {
                pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide();
                pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide();
                pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide();
                pictureBox18.Hide(); pictureBox19.Hide();

                pictureBox5.Show(); pictureBox15.Show();
            }
            if (n == 5)
            {
                pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide();
                pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide();
                pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide();
                pictureBox18.Hide(); pictureBox19.Hide();

                pictureBox6.Show(); pictureBox16.Show();
            }
            if (n == 6)
            {
                pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide();
                pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide();
                pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide();
                pictureBox18.Hide(); pictureBox19.Hide();

                pictureBox7.Show(); pictureBox17.Show();
            }
            if (n == 7)
            {
                pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide();
                pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide();
                pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide();
                pictureBox18.Hide(); pictureBox19.Hide();

                pictureBox8.Show(); pictureBox18.Show();
            }
            if (n == 8)
            {
                pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide();
                pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide();
                pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide();
                pictureBox18.Hide(); pictureBox19.Hide();

                pictureBox9.Show(); pictureBox19.Show();
            }
            if (n > 8) 
            {
                pictureBox1.Hide(); pictureBox2.Hide(); pictureBox3.Hide(); pictureBox4.Hide(); pictureBox5.Hide(); pictureBox6.Hide(); pictureBox7.Hide();
                pictureBox8.Hide(); pictureBox9.Hide(); pictureBox10.Hide();
                pictureBox11.Hide(); pictureBox12.Hide(); pictureBox13.Hide(); pictureBox14.Hide(); pictureBox15.Hide(); pictureBox16.Hide(); pictureBox17.Hide();
                pictureBox18.Hide(); pictureBox19.Hide();

                pictureBox1.Show(); pictureBox11.Show();
                n = 0;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu a = new Menu();
            a.Show();
        }
    }
}
