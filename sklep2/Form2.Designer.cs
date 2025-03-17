namespace sklep2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            listBox2 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            listBox5 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            listBox6 = new ListBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Procesor_1", "Procesor_2" });
            listBox1.Location = new Point(23, 414);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(306, 79);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 387);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Procesor";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 656);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Dysk";
            label2.Click += label2_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "Dysk_1", "Dysk_2" });
            listBox2.Location = new Point(23, 681);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(306, 79);
            listBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 790);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 4;
            label3.Text = "Karta graficzna";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 522);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 5;
            label4.Text = "RAM";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 116);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 6;
            label5.Text = "Zasilacz";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Items.AddRange(new object[] { "Karta_1", "Karta_2" });
            listBox3.Location = new Point(23, 814);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(306, 79);
            listBox3.TabIndex = 7;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Items.AddRange(new object[] { "RAM_1", "RAM_2" });
            listBox4.Location = new Point(23, 548);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(306, 79);
            listBox4.TabIndex = 8;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 15;
            listBox5.Items.AddRange(new object[] { "Zasilacz_1", "Zasilacz_2" });
            listBox5.Location = new Point(23, 144);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(306, 79);
            listBox5.TabIndex = 9;
            listBox5.SelectedIndexChanged += listBox5_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(23, 962);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(254, 962);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Anuluj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 15;
            listBox6.Items.AddRange(new object[] { "Płyta_1", "Płyta_2" });
            listBox6.Location = new Point(25, 281);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(306, 79);
            listBox6.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 255);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 13;
            label6.Text = "Płyta główna";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(155, 1028);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(25, 18);
            label8.Name = "label8";
            label8.Size = new Size(207, 54);
            label8.TabIndex = 15;
            label8.Text = "Komputer:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(-48, 72);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(417, 15);
            label9.TabIndex = 16;
            label9.Text = "__________________________________________________________________________________";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(386, 623);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(listBox6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox5);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private ListBox listBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListBox listBox5;
        private Button button1;
        private Button button2;
        private ListBox listBox6;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}