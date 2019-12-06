using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace rename_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(DataFormats.FileDrop))
            //{
            //    e.Effect = DragDropEffects.Link;
            //}
            //else
            //{
            //    e.Effect = DragDropEffects.None;
            //}
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            //MessageBox.Show(((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString());


          

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string f in files)
                {
                    listBox1.Items.Add(f);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
