using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line = textBox1.Text;
            char[] ch = new char[] { ' ', '\n', '\r' };

            string[] slovo = line.Split(ch);

            int number_column = 0;
            int number_row = 0;

            dataGridView1.Rows.Add(textBox1.Lines.Count());

            foreach (string c in slovo) {


                if (c.Length > 0)
                {
                    dataGridView1.Rows[number_row].Cells[number_column].Value = c;
                    number_column++;
                    if (number_column == 3)
                    {
                        number_column = 0;
                        number_row++;
                    }
                }
             }        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}