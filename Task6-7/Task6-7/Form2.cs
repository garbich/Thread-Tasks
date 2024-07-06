using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form2 : Form
    {
        private Calculation calculation = new Calculation();
       
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = Int32.Parse(textBox1.Text);

           
            Task7(count);
        }

        public void Task7(int count)
        {
            List<int> list =  calculation.generateNums(count);
            foreach (var item in list)
            {

                listBox1.Items.Add(item);
            }

            int maxNum = calculation.maxNumber();
            int minNum = calculation.minNumber();
            double averageNum = calculation.averageNumber();


            listBox2.Items.Add("Max number: " + maxNum);
            listBox2.Items.Add("Min number: " + minNum); 
            listBox2.Items.Add("Average number: " + averageNum);

        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
