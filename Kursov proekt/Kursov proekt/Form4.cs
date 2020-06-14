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
    public partial class Form4 : Form
    {
        public static double Weight = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void nextQuestion_Click(object sender, EventArgs e)
        {
            Form5 fifthForm = new Form5();
            fifthForm.Show();
            this.Close();
        }


        private void weightTextBox1_TextChanged(object sender, EventArgs e)
        {
            Weight = double.Parse(weightTextBox1.Text);
        }

        private void nextQuestion_Click_1(object sender, EventArgs e)
        {
            Form5 fifthForm = new Form5();
            fifthForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 thirdForm = new Form3();
            thirdForm.Show();
            this.Close();
        }
    }
}
