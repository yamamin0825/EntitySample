namespace EntitySample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            modelBookBindingSource1 = new BindingSource(components);
            modelBookBindingSource = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            buttonNew1 = new Button();
            modelBook2BindingSource1 = new BindingSource(components);
            modelBook2BindingSource = new BindingSource(components);
            buttonNew2 = new Button();
            buttonRead = new Button();
            buttonRead2 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            listView2 = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            buttonUpdate = new Button();
            buttonUpdate2 = new Button();
            ((System.ComponentModel.ISupportInitialize)modelBookBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelBookBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelBook2BindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modelBook2BindingSource).BeginInit();
            SuspendLayout();
            // 
            // modelBookBindingSource1
            // 
            modelBookBindingSource1.DataSource = typeof(ModelBook);
            // 
            // modelBookBindingSource
            // 
            modelBookBindingSource.DataSource = typeof(ModelBook);
            // 
            // buttonNew1
            // 
            buttonNew1.Location = new Point(12, 222);
            buttonNew1.Name = "buttonNew1";
            buttonNew1.Size = new Size(94, 29);
            buttonNew1.TabIndex = 1;
            buttonNew1.Text = "新規";
            buttonNew1.UseVisualStyleBackColor = true;
            buttonNew1.Click += buttonNew1_Click;
            // 
            // modelBook2BindingSource1
            // 
            modelBook2BindingSource1.DataSource = typeof(ModelBook2);
            // 
            // modelBook2BindingSource
            // 
            modelBook2BindingSource.DataSource = typeof(ModelBook2);
            // 
            // buttonNew2
            // 
            buttonNew2.Location = new Point(464, 222);
            buttonNew2.Name = "buttonNew2";
            buttonNew2.Size = new Size(94, 29);
            buttonNew2.TabIndex = 5;
            buttonNew2.Text = "新規";
            buttonNew2.UseVisualStyleBackColor = true;
            buttonNew2.Click += buttonNew2_Click;
            // 
            // buttonRead
            // 
            buttonRead.Location = new Point(112, 222);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(94, 29);
            buttonRead.TabIndex = 2;
            buttonRead.Text = "データ読込";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // buttonRead2
            // 
            buttonRead2.Location = new Point(564, 222);
            buttonRead2.Name = "buttonRead2";
            buttonRead2.Size = new Size(94, 29);
            buttonRead2.TabIndex = 6;
            buttonRead2.Text = "データ読込";
            buttonRead2.UseVisualStyleBackColor = true;
            buttonRead2.Click += buttonRead2_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(437, 188);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "BookName";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "カテゴリー";
            columnHeader2.Width = 200;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            listView2.Location = new Point(464, 12);
            listView2.Name = "listView2";
            listView2.Size = new Size(427, 188);
            listView2.TabIndex = 4;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "BookName";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "カテゴリー";
            columnHeader4.Width = 200;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(212, 222);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "変更";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonUpdate2
            // 
            buttonUpdate2.Location = new Point(664, 222);
            buttonUpdate2.Name = "buttonUpdate2";
            buttonUpdate2.Size = new Size(94, 29);
            buttonUpdate2.TabIndex = 7;
            buttonUpdate2.Text = "変更";
            buttonUpdate2.UseVisualStyleBackColor = true;
            buttonUpdate2.Click += buttonUpdate2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 263);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(buttonNew2);
            Controls.Add(buttonRead2);
            Controls.Add(buttonRead);
            Controls.Add(buttonUpdate2);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonNew1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)modelBookBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)modelBookBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)modelBook2BindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)modelBook2BindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource modelBookBindingSource;
        private BindingSource bindingSource1;
        private Button buttonNew1;
        private BindingSource modelBook2BindingSource;
        private Button buttonNew2;
        private BindingSource modelBookBindingSource1;
        private BindingSource modelBook2BindingSource1;
        private Button buttonRead;
        private Button buttonRead2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listView2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button buttonUpdate;
        private Button buttonUpdate2;
    }
}