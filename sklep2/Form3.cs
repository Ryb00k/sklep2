using sklep2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sklep2
{
    public partial class Form3 : Form
    {
        Form1 parent;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 sth)
        {
            InitializeComponent();
            parent = sth;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] screen_prices = { 200, 190 };
            int screen_ind = listBox1.SelectedIndex >= 0 ? listBox1.SelectedIndex : 1;

            if (screen_ind >= 0 && screen_ind < screen_prices.Length)
            {
                GlobalVars.suma += screen_prices[screen_ind];
            }

            parent.UpdateTextBox();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}