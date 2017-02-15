using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hhf1
{
    public partial class Form1 : Form
    {
        Double jelenlegi_ertek = 0;    // utoljára beutott szám 
        String muvelet_jel = "";
        bool muvelet_jel_megnyomva = false;
        Double elojel = 0;

        public Form1()
        {
            InitializeComponent();
        }

       
        private void butten_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (muvelet_jel_megnyomva))
                textBox1.Clear();

            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void muvelet_gomb(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            muvelet_jel = b.Text;
            jelenlegi_ertek = Double.Parse(textBox1.Text);
            muvelet_jel_megnyomva = true;
        
        }

        private void button14_Click(object sender, EventArgs e)
        {
            


        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            jelenlegi_ertek = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
           
            textBox1.Text = "-" + textBox1.Text;
            //elojel = true;
            
            //textBox1.Text =  textBox1.Text;
        }
    }
}
