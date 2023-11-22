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
    public partial class programa : Form
    {
        public programa()
        {
            InitializeComponent();
            InitlizeListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botao A");
            //Form2.InitializeComponent();
            EditItemForm form2 = new EditItemForm();
            form2.Show();
        }
        private void InitlizeListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Name", 120);
            listView1.Columns.Add("Age", 50);
            listView1.Columns.Add("Email", 200);

            AddListViewItem("jhon","26","Email");
            AddListViewItem("jhon", "26", "Email");
            AddListViewItem("jhon", "26", "Email");


        }
        private void AddListViewItem(string name, string age, string email)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(age);
            item.SubItems.Add(email);
            listView1.Items.Add(item);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 )
            {
                ListViewItem selectItem = listView1.SelectedItems[0];

                EditItemForm editForm = new EditItemForm(selectItem);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    selectItem.SubItems[0].Text = editForm.NameValue;
                    selectItem.SubItems[1].Text = editForm.AgeValue;
                   selectItem.SubItems[2].Text = editForm.EmailValue;
                }
            }    
        }
    }
   
}
