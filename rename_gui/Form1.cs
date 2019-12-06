using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        List<names> filenameList = new List<names>();

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
                listBox1.Items.Clear();
                foreach (string f in files)
                {
                    if (!listBox1.Items.Contains(f))
                    {
                        listBox1.Items.Add(f);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 1;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                names item = new names();

                item.oldname = listBox1.Items[i].ToString();

                FileInfo fi = new FileInfo(item.oldname);


                string ext = fi.Extension;

                if (fileEXchange.Checked && fileEX.Text.Trim() != "" && fileEX.Text[0] == '.')
                {

                    ext = fileEX.Text;
                }

                if (ischangeNum.Checked)
                {

                    item.newname = fi.Directory.FullName + "\\" + (i + 1) + "" + ext;
                }

                if (!filenameList.Exists(ex => ex.oldname == item.oldname))
                {
                    filenameList.Add(item);
                }

                if (fi.Exists)
                {
                    fi.MoveTo(item.newname);
                    filenameList[i].status = "成功";
                    count++;
                }
                else
                {

                    if (MessageBox.Show(item.oldname + "不存在，导致更名" + item.newname + " 失败，是否继续？", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    {
                        filenameList[i].status = "失败";

                        break;
                    }
                }


            }




            MessageBox.Show("更名" + count + "文件");

        }

        private void save_log()
        {


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (fileEXchange.Checked)
            {
                this.fileEX.Enabled = true;
            }
            else
            {
                this.fileEX.Enabled = false;
            }
        }

        private void Undo_changes_Click(object sender, EventArgs e)
        {
            int count = 1;

            for (int i = 0; i < filenameList.Count; i++)
            {
                names fn = filenameList[i];

                filenameList[i].status = "未执行";
                FileInfo fi = new FileInfo(fn.newname);

                if (fi.Exists)
                {
                    fi.MoveTo(fn.oldname);
                    filenameList[i].status = "成功";
                    count++;
                }
                else
                {
                    if (MessageBox.Show(fn.newname + "不存在，导致更名" + fn.oldname + " 失败，是否继续？", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    {
                        filenameList[i].status = "失败";
                        break;
                    }
                }

            }
            MessageBox.Show("还原" + count + "文件");
        }
    }

    public class names
    {

        public string oldname = "";
        public string newname = "";

        public string status = "未执行";
    }
}
