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
    public partial class Form3 : Form
    {
        public static int Height = 0;

        public Form3()
        {
            InitializeComponent();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Height = int.Parse(textBox1.Text);
        }

   

        private void nextQuestion_Click_1(object sender, EventArgs e)
        {
            Form4 fourthForm = new Form4();
            fourthForm.Show();
            this.Close();
        }

        private void previousQuestion_Click_1(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
            this.Close();

        }
    }
}
