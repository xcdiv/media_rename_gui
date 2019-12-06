namespace rename_gui
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ischangeNum = new System.Windows.Forms.CheckBox();
            this.fileEXchange = new System.Windows.Forms.CheckBox();
            this.fileEX = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Undo_changes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(891, 484);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "改名";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(20, 18);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(702, 454);
            this.listBox1.TabIndex = 4;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // ischangeNum
            // 
            this.ischangeNum.AutoSize = true;
            this.ischangeNum.Checked = true;
            this.ischangeNum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ischangeNum.Location = new System.Drawing.Point(746, 18);
            this.ischangeNum.Name = "ischangeNum";
            this.ischangeNum.Size = new System.Drawing.Size(205, 22);
            this.ischangeNum.TabIndex = 6;
            this.ischangeNum.Text = "修改文件名从1到累加";
            this.ischangeNum.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ischangeNum.UseVisualStyleBackColor = true;
            // 
            // fileEXchange
            // 
            this.fileEXchange.AutoSize = true;
            this.fileEXchange.Location = new System.Drawing.Point(746, 57);
            this.fileEXchange.Name = "fileEXchange";
            this.fileEXchange.Size = new System.Drawing.Size(178, 22);
            this.fileEXchange.TabIndex = 6;
            this.fileEXchange.Text = "修改文件名后缀为";
            this.fileEXchange.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.fileEXchange.UseVisualStyleBackColor = true;
            this.fileEXchange.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fileEX
            // 
            this.fileEX.Enabled = false;
            this.fileEX.Location = new System.Drawing.Point(743, 89);
            this.fileEX.Margin = new System.Windows.Forms.Padding(4);
            this.fileEX.Name = "fileEX";
            this.fileEX.Size = new System.Drawing.Size(231, 28);
            this.fileEX.TabIndex = 2;
            this.fileEX.Text = ".ts";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1469, -338);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(178, 22);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "修改文件名后缀为";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Undo_changes
            // 
            this.Undo_changes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Undo_changes.Location = new System.Drawing.Point(892, 438);
            this.Undo_changes.Margin = new System.Windows.Forms.Padding(4);
            this.Undo_changes.Name = "Undo_changes";
            this.Undo_changes.Size = new System.Drawing.Size(112, 34);
            this.Undo_changes.TabIndex = 3;
            this.Undo_changes.Text = "撤销修改";
            this.Undo_changes.UseVisualStyleBackColor = true;
            this.Undo_changes.Click += new System.EventHandler(this.Undo_changes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 561);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.fileEXchange);
            this.Controls.Add(this.ischangeNum);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.fileEX);
            this.Controls.Add(this.Undo_changes);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "河南有线节目注入批量改名软件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox ischangeNum;
        private System.Windows.Forms.CheckBox fileEXchange;
        private System.Windows.Forms.TextBox fileEX;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button Undo_changes;


    }
}

