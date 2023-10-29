namespace ort_hesapla
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelort = new Label();
            labelDurum = new Label();
            button1 = new Button();
            label6 = new Label();
            textBox3 = new TextBox();
            listBilgi = new ListBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 225);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(21, 169);
            label1.Name = "label1";
            label1.Size = new Size(47, 23);
            label1.TabIndex = 2;
            label1.Text = "Vize:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(21, 229);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 3;
            label2.Text = "Final:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(21, 338);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 4;
            label3.Text = "Ortalama:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(33, 381);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 5;
            label4.Text = "Durum:";
            // 
            // labelort
            // 
            labelort.AutoSize = true;
            labelort.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelort.Location = new Point(147, 338);
            labelort.Name = "labelort";
            labelort.Size = new Size(55, 23);
            labelort.TabIndex = 6;
            labelort.Text = "label5";
            // 
            // labelDurum
            // 
            labelDurum.AutoSize = true;
            labelDurum.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelDurum.Location = new Point(147, 381);
            labelDurum.Name = "labelDurum";
            labelDurum.Size = new Size(55, 23);
            labelDurum.TabIndex = 7;
            labelDurum.Text = "label6";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(122, 277);
            button1.Name = "button1";
            button1.Size = new Size(100, 33);
            button1.TabIndex = 8;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(21, 104);
            label6.Name = "label6";
            label6.Size = new Size(36, 23);
            label6.TabIndex = 10;
            label6.Text = "No:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(112, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 11;
            // 
            // listBilgi
            // 
            listBilgi.FormattingEnabled = true;
            listBilgi.ItemHeight = 20;
            listBilgi.Location = new Point(300, 100);
            listBilgi.Name = "listBilgi";
            listBilgi.Size = new Size(521, 304);
            listBilgi.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(21, 52);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 9;
            label5.Text = "Ad-Soyad:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(112, 52);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(463, 46);
            button2.Name = "button2";
            button2.Size = new Size(130, 29);
            button2.TabIndex = 15;
            button2.Text = "Bilgileri Aktar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 450);
            Controls.Add(button2);
            Controls.Add(listBilgi);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(labelDurum);
            Controls.Add(labelort);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelort;
        private Label labelDurum;
        private Button button1;
        private Label label6;
        private TextBox textBox3;
        private ListBox listBilgi;
        private Label label5;
        private TextBox textBox4;
        private Button button2;
    }
}