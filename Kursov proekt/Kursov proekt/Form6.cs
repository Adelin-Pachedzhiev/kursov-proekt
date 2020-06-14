using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursov_proekt
{
    public partial class Form6 : Form
    {
        public static bool namalqneMasa = false;
        public static bool povishavaneMasa = false;
        public static bool namalqneMaznini = false;
        public static bool povishavaneMuskulnaMasa = false;

        public Form6()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void nextQuestion_Click(object sender, EventArgs e)
        {
            
        }

        private void result_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                namalqneMasa = true;
            }
            if (checkBox2.Checked)
            {
                povishavaneMasa = true;
            }
            if (checkBox3.Checked)
            {
                namalqneMaznini = true;
            }
            if (checkBox4.Checked)
            {
                povishavaneMuskulnaMasa = true;
            }

            Form7 seventhForm = new Form7();
            seventhForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 fifthForm = new Form5();
            fifthForm.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
