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
using Car_Sale.DAL;
using System.Collections;

namespace Car_Sale.GUI
{
    
    public partial class Form1 : Form
    {

        Repostory Respo = new Repostory();
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Add Car";
            button2.Text = "Show Cars";
            label1.Text = "Brand";
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            Car newCar = new Car() { Brand = textBox1.Text };
            Respo.Save(newCar);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Show();
            
        }
        private void Show()
        {
            listBox1.Items.Clear();
            List<Car> FetchedList = Respo.GetList();
            foreach(Car x in FetchedList)
            {
                listBox1.Items.Add(x.Brand);
            }
        }
    }
}
