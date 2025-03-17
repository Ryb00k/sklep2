using System.Runtime.InteropServices;

namespace sklep2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(this);
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text =  GlobalVars.suma.ToString() + " $";
        }

        public void UpdateTextBox()
        {
            textBox1.Text = GlobalVars.suma.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public static class GlobalVars
    {
        public static int suma = 0;
    }


}