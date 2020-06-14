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
    public partial class Form5 : Form
    {
        public static bool LightlyActive = false;
        public static bool ModeratelyActive = false;
        public static bool VeryActive = false;

        public Form5()
        {
            InitializeComponent();
        }


        private void pictureBoxLightly_Click(object sender, EventArgs e)
        {
            LightlyActive = true;
            Form6 sixthForm = new Form6();
            sixthForm.Show();
            this.Close();
        }

        private void pictureBoxModerately_Click(object sender, EventArgs e)
        {
            ModeratelyActive = true;
            Form6 sixthForm = new Form6();
            sixthForm.Show();
            this.Close();
        }

        private void pictureBoxVery_Click(object sender, EventArgs e)
        {
            VeryActive = true;
            Form6 sixthForm = new Form6();
            sixthForm.Show();
            this.Close();
        }

        

        private void nextQuestion_Click_1(object sender, EventArgs e)
        {
            Form6 sixthForm = new Form6();
            sixthForm.Show();
            this.Close();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            Form4 fourthForm = new Form4();
            fourthForm.Show();
            this.Close();
        }
    }
}
