namespace DiskHacker
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
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(720, 452);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 490);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(95, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 467);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 2;
            label1.Text = "Select Drive";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(496, 470);
            button1.Name = "button1";
            button1.Size = new Size(236, 38);
            button1.TabIndex = 3;
            button1.Text = "Read Sector from Disk";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(496, 514);
            button2.Name = "button2";
            button2.Size = new Size(236, 38);
            button2.TabIndex = 4;
            button2.Text = "Write Sector to Disk";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(496, 559);
            button3.Name = "button3";
            button3.Size = new Size(236, 38);
            button3.TabIndex = 5;
            button3.Text = "Load Sector from Disk";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(496, 603);
            button4.Name = "button4";
            button4.Size = new Size(236, 38);
            button4.TabIndex = 6;
            button4.Text = "Save Sector to Disk";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 468);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 8;
            label2.Text = "Select Sector";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(113, 491);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(95, 27);
            numericUpDown1.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(12, 552);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(196, 27);
            numericUpDown2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 529);
            label3.Name = "label3";
            label3.Size = new Size(191, 20);
            label3.TabIndex = 11;
            label3.Text = "Continuous Sectors to Read";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 470);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 12;
            label4.Text = "Sectors on Disk";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(256, 493);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(191, 20);
            textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 671);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "DiskHacker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
    }
}
