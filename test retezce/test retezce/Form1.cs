using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_retezce
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            string abeceda = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
            string[] abc = abeceda.Split(' ');
            foreach (string abec in abc)
            {

                foreach (char abeced in abec)
                {
                    listBox1.Items.Add(abeced);
                 }

            }

            short poceta=0,pocete=0,poceti=0,poceto=0,pocetu=0;
            string vstup = textBox1.Text;
            vstup=vstup.Trim();
            vstup = vstup.ToLower();
            while (vstup.Contains("  "))
            {
               vstup = vstup.Replace("  ", " ");
                
            }
            label4.Text = vstup;
            string[] slovo = vstup.Split(' ');
            
            foreach(string slova in slovo)
            {

                foreach(char pismeno in slova)
                {
                    if (pismeno == '.' || pismeno == '_' || pismeno == '"'|| pismeno =='“' ||pismeno == '!' || pismeno == '?')
                    {

                    }
                    else
                    {
                        if(listBox2.Items.Contains(pismeno))
                        {

                        }
                        else
                        {
                            listBox2.Items.Add(pismeno);
                        }
                       if(pismeno=='a')
                        {
                            poceta++;
                        }
                        if (pismeno == 'e')
                        {
                            pocete++;
                        }
                        if (pismeno == 'i')
                        {
                            poceti++;
                        }
                        if (pismeno == 'o')
                        {
                            poceto++;
                        }
                        if (pismeno == 'u')
                        {
                            pocetu++;
                        }

                    }
                    
                    if(listBox1.Items.Contains(pismeno))
                    {
                        listBox1.Items.Remove(pismeno);
                    }

                }

            }
            label6.Text=""+poceta;
            label7.Text="" + pocete;
            label9.Text = "" + poceti;
            label11.Text = "" + poceto;
            label13.Text = "" + pocetu;

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Vybraný Znak: " + listBox1.SelectedItem);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        long clicker = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            clicker++;
            label16.Text = "" + clicker;
            if(clicker == 15)
            {
                MessageBox.Show("Dobrá práce vyhrál jsi klikací hru!", "VÝHRA", MessageBoxButtons.OK, MessageBoxIcon.Information) ;

            }
            if(clicker==30)
            {
                MessageBox.Show("Zadrž klikáš až moc!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
