using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sklep2
{
    public partial class Form2 : Form
    {
        Form1 parent;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 sth)
        {
            InitializeComponent();
            parent = sth;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] proc_prices = { 100, 200 };
            int[] drive_prices = { 50, 70 };
            int[] card_prices = { 100, 200 };
            int[] ram_prices = { 20, 30 };
            int[] power_prices = { 80, 65 };
            int[] mboard_prices = { 160, 125 };


            GlobalVars.suma = 0;

            int proc_ind = listBox1.SelectedIndex >= 0 ? listBox1.SelectedIndex : 1;
            int drive_ind = listBox2.SelectedIndex >= 0 ? listBox2.SelectedIndex : 1;
            int card_ind = listBox3.SelectedIndex >= 0 ? listBox3.SelectedIndex : 1;
            int ram_ind = listBox4.SelectedIndex >= 0 ? listBox4.SelectedIndex : 1;
            int power_ind = listBox5.SelectedIndex >= 0 ? listBox5.SelectedIndex : 1;
            int mboard_ind = listBox5.SelectedIndex >= 0 ? listBox5.SelectedIndex : 1;


            if (proc_ind >= 0 && proc_ind < proc_prices.Length)
            {
                GlobalVars.suma += proc_prices[proc_ind];
            }
            if (drive_ind >= 0 && drive_ind < proc_prices.Length)
            {
                GlobalVars.suma += drive_prices[drive_ind];
            }
            if (card_ind >= 0 && card_ind < proc_prices.Length)
            {
                GlobalVars.suma += card_prices[card_ind];
            }
            if (ram_ind >= 0 && ram_ind < proc_prices.Length)
            {
                GlobalVars.suma += ram_prices[ram_ind];
            }
            if (power_ind >= 0 && power_ind < proc_prices.Length)
            {
                GlobalVars.suma += power_prices[power_ind];
            }
            if (mboard_ind >= 0 && mboard_ind < mboard_prices.Length)
            {
                GlobalVars.suma += mboard_prices[mboard_ind];
            }

            parent.UpdateTextBox();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
