using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIRSTMEDICALAPPLICATION
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 20;
            int b = 40;
            int x = Pay(a, b);
                MessageBox.Show("Paid successfully the amount:"+x);
        }
        public int Pay(int a, int b)
        {
             int c = a + b;
            return c;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a= 20;
            int b = 40;
            Price(a,b);

        }
        public void Price(int a,int b)
        {
            int c = a + b;
            MessageBox.Show("amount to be paid is:" + "  " + c);
        }
    }
}
