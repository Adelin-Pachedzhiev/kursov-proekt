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
    public partial class Form2 : Form
    {
        public static bool Teen = false;
        public static bool Person20s = false;
        public static bool Person30s = false;
        public static bool Person40s = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nextQuestion_Click(object sender, EventArgs e)
        {
            //nextQuestion.Enabled = false;
            if (radioButton1.Checked)
            {
                Teen = true;
            }
            if (radioButton20.Checked)
            {
                Person20s = true;
            }
            if (radioButton30.Checked)
            {
                Person30s = true;
            }
            if (radioButton40.Checked)
            {
                Person40s = true;
            }

            Form3 thirdForm = new Form3();
            thirdForm.Show();
            this.Close();
        }

        private void previousQuestion_Click(object sender, EventArgs e)
        {
            Form1 firstForm = new Form1();
            firstForm.Show();
            this.Close();
        }
    }
}
