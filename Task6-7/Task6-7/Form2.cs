using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form2 : Form
    {
        private Calculation calculation = new Calculation();
       private List<int> list = new List<int>();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int count = Int32.Parse(textBox1.Text);
            list.Clear();
           
            Task7(count);
        }

        public void Task7(int count)
        {
            list =  calculation.generateNums(count);
            listBox1.Items.Add("All numbers:");
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
