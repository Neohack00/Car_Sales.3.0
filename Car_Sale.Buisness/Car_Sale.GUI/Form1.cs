using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car_Sale.Business;
using System.Collections;

namespace Car_Sale.GUI
{
    
    public partial class Form1 : Form
    {
        List<Car> MyCars = new List<Car>();

        public Form1()
        {
            InitializeComponent();
            button1.Text = "Add Car";
            button2.Text = "Show Cars";
            label1.Text = "Brand";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyCars.Add(new Car() { Brand = textBox1.Text });
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Car x in MyCars)
            {               
                listBox1.Items.Add(x.Brand);
            }
        }
    }
}
