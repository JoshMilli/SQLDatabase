using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAct2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //adds the 3 items from the textboxs to the listboxes
            //create lists per textbox
            List<string> productname = new List<string>();
            List<int> price = new List<int>();
            List<int> quantity = new List<int>();

            //add string values to list
            productname.Add(textBox1.Text);




            //Product Name
            //add string values
            listBox1.Items.Add(textBox1.Text);
            productname.Add(textBox1.Text);




            //Price
           //validation for incorrect data inputed
            if (textBox2.Text == "")
            {
                MessageBox.Show("Enter valid information");
            }
            else
            {
                listBox2.Items.Add(textBox2.Text);
                price.Add(int.Parse(textBox2.Text));
            }


            //Quantity
            listBox3.Items.Add(textBox3.Text);
            quantity.Add(int.Parse(textBox3.Text));



        }

        private void button3_Click(object sender, EventArgs e)
        {

            //removes items

            listBox1.Items.Remove(textBox1.Text);
            listBox2.Items.Remove(textBox2.Text);
            listBox3.Items.Remove(textBox3.Text);
            //display items being deleted
            MessageBox.Show("Items:"+"\n"+textBox1.Text+"\n"+textBox2.Text+"\n"+textBox3.Text+"\n"+ "have been deleted");



        }

        private void button4_Click(object sender, EventArgs e)
        {
             //clearing all fields containing text
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            //clearing listboxes
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
          


        }






    }
}
