namespace TabletopAid
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
            imageList1 = new ImageList(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listView1 = new ListView();
            preview = new Button();
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            numericUpDown7 = new NumericUpDown();
            numericUpDown8 = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            numericUpDown5 = new NumericUpDown();
            numericUpDown6 = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            richTextBox2 = new RichTextBox();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            button6 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            tabPage3 = new TabPage();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1491, 1026);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(preview);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(numericUpDown2);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1483, 998);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(6, 299);
            listView1.Name = "listView1";
            listView1.Size = new Size(386, 98);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // preview
            // 
            preview.Location = new Point(279, 92);
            preview.Name = "preview";
            preview.Size = new Size(92, 23);
            preview.TabIndex = 10;
            preview.Text = "Preview Cut";
            preview.UseVisualStyleBackColor = true;
            preview.Click += button4_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(243, 129);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(149, 97);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // button3
            // 
            button3.Location = new Point(279, 68);
            button3.Name = "button3";
            button3.Size = new Size(93, 23);
            button3.TabIndex = 8;
            button3.Text = "Cut";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(279, 39);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(52, 23);
            numericUpDown2.TabIndex = 7;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(279, 12);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(52, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 45);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 5;
            label3.Text = "Rows";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 14);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "Columns";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 63);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // button2
            // 
            button2.Location = new Point(8, 37);
            button2.Name = "button2";
            button2.Size = new Size(118, 23);
            button2.TabIndex = 2;
            button2.Text = "Select Save Folder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(8, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Pick Sheett";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSlateGray;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Location = new Point(398, 3);
            pictureBox1.MaximumSize = new Size(3000, 3000);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1082, 992);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(numericUpDown7);
            tabPage2.Controls.Add(numericUpDown8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(numericUpDown5);
            tabPage2.Controls.Add(numericUpDown6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(richTextBox2);
            tabPage2.Controls.Add(numericUpDown3);
            tabPage2.Controls.Add(numericUpDown4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(button4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1483, 998);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown7
            // 
            numericUpDown7.Location = new Point(370, 120);
            numericUpDown7.Maximum = new decimal(new int[] { 2500, 0, 0, 0 });
            numericUpDown7.Name = "numericUpDown7";
            numericUpDown7.Size = new Size(52, 23);
            numericUpDown7.TabIndex = 20;
            numericUpDown7.Value = new decimal(new int[] { 740, 0, 0, 0 });
            // 
            // numericUpDown8
            // 
            numericUpDown8.Location = new Point(370, 93);
            numericUpDown8.Maximum = new decimal(new int[] { 3500, 0, 0, 0 });
            numericUpDown8.Name = "numericUpDown8";
            numericUpDown8.Size = new Size(52, 23);
            numericUpDown8.TabIndex = 19;
            numericUpDown8.Value = new decimal(new int[] { 1042, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(428, 126);
            label9.Name = "label9";
            label9.Size = new Size(98, 15);
            label9.TabIndex = 18;
            label9.Text = "Hor Size (std 740)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(428, 95);
            label10.Name = "label10";
            label10.Size = new Size(84, 15);
            label10.TabIndex = 17;
            label10.Text = "Vert size (1042)";
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(159, 118);
            numericUpDown5.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(52, 23);
            numericUpDown5.TabIndex = 16;
            numericUpDown5.Value = new decimal(new int[] { 65, 0, 0, 0 });
            numericUpDown5.ValueChanged += numericUpDown5_ValueChanged;
            // 
            // numericUpDown6
            // 
            numericUpDown6.Location = new Point(159, 91);
            numericUpDown6.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(52, 23);
            numericUpDown6.TabIndex = 15;
            numericUpDown6.Value = new decimal(new int[] { 95, 0, 0, 0 });
            numericUpDown6.ValueChanged += numericUpDown6_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(217, 124);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 14;
            label7.Text = "Hor Margin (std 65)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(217, 93);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 13;
            label8.Text = "Vert Margin (std 95)";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(114, 647);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(398, 99);
            richTextBox2.TabIndex = 12;
            richTextBox2.Text = "";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(20, 91);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(52, 23);
            numericUpDown3.TabIndex = 11;
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(20, 118);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(52, 23);
            numericUpDown4.TabIndex = 10;
            numericUpDown4.ValueChanged += numericUpDown4_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 122);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 9;
            label5.Text = "Rows";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 95);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 8;
            label6.Text = "Columns";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 59);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // button6
            // 
            button6.Location = new Point(272, 26);
            button6.Name = "button6";
            button6.Size = new Size(103, 23);
            button6.TabIndex = 4;
            button6.Text = "PreparePrintt";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(181, 26);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 3;
            button5.Text = "Dest Folder";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(724, 428);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Silver;
            pictureBox2.Location = new Point(764, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(719, 990);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(18, 26);
            button4.Name = "button4";
            button4.Size = new Size(145, 23);
            button4.TabIndex = 0;
            button4.Text = "Select All Images";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1483, 998);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Multiselect = true;
            openFileDialog1.ValidateNames = false;
            openFileDialog1.FileOk += openFileDialog1_FileOk_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1491, 1026);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown8).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button1;
        private PictureBox pictureBox1;
        private TabPage tabPage2;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Button button3;
        private RichTextBox richTextBox1;
        private Button preview;
        private ListView listView1;
        private PictureBox pictureBox2;
        private Button button4;
        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;
        private Button button6;
        private Button button5;
        private TabPage tabPage3;
        private Label label4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private Label label5;
        private Label label6;
        private RichTextBox richTextBox2;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
        private Label label7;
        private Label label8;
        private NumericUpDown numericUpDown7;
        private NumericUpDown numericUpDown8;
        private Label label9;
        private Label label10;
    }
}
