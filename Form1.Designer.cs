using System.Windows.Forms;

namespace Lb1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            richTextBox = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(57, 880);
            button1.Name = "button1";
            button1.Size = new Size(120, 50);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.Text = "выбрать файл";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, -3);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 2;
            label1.Text = "шрифт";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(91, -1);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 5;
            label2.Text = "страница";
            // 
            // richTextBox
            // 
            tableLayoutPanel1.SetColumnSpan(richTextBox, 5);
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.ImeMode = ImeMode.NoControl;
            richTextBox.Location = new Point(3, 3);
            richTextBox.Name = "richTextBox";
            richTextBox.ReadOnly = true;
            richTextBox.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox.Size = new Size(776, 851);
            richTextBox.TabIndex = 4;
            richTextBox.Text = "";
            richTextBox.WordWrap = false;
            richTextBox.Resize += richTextBox_Resize;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(richTextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(782, 953);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.AutoSize = true;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(258, 877);
            panel2.Name = "panel2";
            panel2.Size = new Size(264, 55);
            panel2.TabIndex = 6;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Enabled = false;
            button3.Location = new Point(231, 22);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Enabled = false;
            button2.Location = new Point(195, 22);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 26);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 7;
            label3.Text = "из 0";
            // 
            // textBox1
            //
            textBox1.Enabled = false;
            textBox1.Location = new Point(0, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(85, 27);
            textBox1.TabIndex = 6;
            textBox1.Text = "0";
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.Leave += textBox1_Leave;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.AutoSize = true;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(630, 879);
            panel1.Name = "panel1";
            panel1.Size = new Size(67, 51);
            panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "32", "48", "72" });
            comboBox1.Location = new Point(3, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(61, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 953);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(700, 700);
            Name = "Form1";
            Text = "Лабораторная №1, вариант 1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
    }
}