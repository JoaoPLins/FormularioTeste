using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditItemForm : Form
    {
        public string NameValue { get; set; }
        public string AgeValue { get; set; }
        public string EmailValue { get; set; }

        public EditItemForm(ListViewItem selectedItem)
        {
            InitializeComponent();

            NomeTextBox.Text = selectedItem.SubItems[0].Text;
            AgeTextBox.Text = selectedItem.SubItems[1].Text;
            EmailTextBox.Text = selectedItem.SubItems[2].Text;
        }
        public EditItemForm()
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NameValue = NomeTextBox.Text;
            AgeValue = AgeTextBox.Text;
            EmailValue = EmailTextBox.Text;

            DialogResult = DialogResult.OK; // Set DialogResult to OK

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
