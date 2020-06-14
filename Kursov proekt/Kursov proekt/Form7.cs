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
    public partial class Form7 : Form
    {
        public double KcalNum = 0;
        public string Kcal = "";
        public double Weight = Form4.Weight;
        public int Height = Form3.Height;
        public int Age = 0;
        public string WeightString = "";
        public string HeightString = "";
        public string AgeString = "";
        public string namalqneMasaText = "";
        public string povishavaneMasaText = "";
        public string namalqneMazniniText = "За да намалите процента подкожни мазнини трябва \n да започнете да се храните по чисто, \n което изисква храни високи на белтъци \n и малко въглехидрати и мазнини!";
        public string povishavaneMuskulnaMasaText = "Градивната частица на мускула \n е белтъка. Точно той е виновникът \n за регулиране на мускулната маса!";


        public Form7()
        {
            InitializeComponent();
        }

        void Calculations()
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void getResults_Click(object sender, EventArgs e)
        {
            

            if (Form2.Teen)
            {
                Age = 17;
                AgeString = "Години: Teen";
            }
            else if (Form2.Person20s)
            {
                Age = 25;
                AgeString = "Години: Между 20 - 30";
            }
            else if (Form2.Person30s)
            {
                Age = 35;
                AgeString = "Години: Между 30 - 40";
            }
            else if (Form2.Person40s)
            {
                Age = 45;
                AgeString = "Години: След 40";
            }



            if (Form1.IsMan)
            {
                KcalNum = 66 + 13.8 * Weight + 5 * Height - 6.8 * Age;
            }
            else
            {
                KcalNum = 655 + 9.7 * Weight + 1.85 * Height - 4.7 * Age;
            }

            if (Form5.LightlyActive)
            {
                KcalNum = KcalNum * 1.15;
            }
            else if (Form5.ModeratelyActive)
            {
                KcalNum = KcalNum * 1.3;
            }
            else if (Form5.VeryActive)
            {
                KcalNum = KcalNum * 1.6;
            }

            Kcal = $"Kcal: {KcalNum}";
            WeightString = $"Маса: {Weight}кг";
            HeightString = $"Височина: {Height}см";

            listBox1.Items.Add(Kcal);
            listBox1.Items.Add(WeightString);
            listBox1.Items.Add(HeightString);
            listBox1.Items.Add(AgeString);

            namalqneMasaText = $"Калориите, които тялото \n ви изгаря за един ден са - {KcalNum}. Това \n означава, че трябва да си набавяте \n по-малко калории чрез храна!";
            povishavaneMasaText = $"Калориите, които тялото \n ви изгаря за един ден са - {KcalNum}.\n Това означава, че трябва да си набавяте \n повече калории чрез храна!";


            if (Form6.namalqneMasa)
            {
                label1.Text = namalqneMasaText;
            }
            if (Form6.povishavaneMasa)
            {
                if(label1.Text != "")
                {
                    label2.Text = povishavaneMasaText;
                }
                else
                {
                    label1.Text = povishavaneMasaText;
                }
            }
            if (Form6.namalqneMaznini)
            {
                if (label1.Text != "")
                {
                    if (label2.Text != "")
                    {
                        label3.Text = namalqneMazniniText;
                    }
                    else
                    {
                        label2.Text = namalqneMazniniText;
                    }
                }
                else
                {
                    label1.Text = namalqneMazniniText;
                }
            }
            if (Form6.povishavaneMuskulnaMasa)
            {
                if (label1.Text != "")
                {
                    if (label2.Text != "")
                    {
                        if (label3.Text != "")
                        {
                            label4.Text = povishavaneMuskulnaMasaText;
                        }
                        else
                        {
                            label3.Text = povishavaneMuskulnaMasaText;
                        }
                    }
                    else
                    {
                        label2.Text = povishavaneMuskulnaMasaText;
                    }
                }
                else
                {
                    label1.Text = povishavaneMuskulnaMasaText;
                }
            }


            getResults.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
