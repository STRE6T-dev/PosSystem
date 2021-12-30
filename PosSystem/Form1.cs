using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class Form1 : Form
    {
        List<Stock> stock = FileOpertions.ReadFromFle();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
          //  String[] stock = FileOpertions.ReadFromFle();
            if (e.KeyCode == Keys.Enter)
            {
                
                List<Stock> stock = FileOpertions.ReadFromFle();
                foreach (var Stock1 in stock)
                {
                    if (textBox1.Text == Stock1.Name)
                    {
                        //   listView1.Items.Add( Stock1.Name + " " + Stock1.Price +" " +Stock1.Qty +" "+  Stock1.Date);
                        listView1.Items.Clear();
                        ListViewItem items = new ListViewItem(Stock1.Name);
                        items.SubItems.Add(Stock1.Price.ToString());
                        items.SubItems.Add(Stock1.Qty.ToString());
                        items.SubItems.Add(Stock1.Date);
                        listView1.Items.Add(items);

                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showStock();
        }

        private void showStock()
        {
          

            foreach (var Stock1 in stock)
            {
                ListViewItem items = new ListViewItem(Stock1.Name);
                items.SubItems.Add(Stock1.Price.ToString());
                items.SubItems.Add(Stock1.Qty.ToString());
                items.SubItems.Add(Stock1.Date);
                listView1.Items.Add(items);


            }
        }
    }
}
