namespace InventV15

{
    partial class InvetnPov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvetnPov));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label6 = new Label();
            comboBox2 = new ComboBox();
            label7 = new Label();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            dateTimePicker3 = new DateTimePicker();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 94);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 150);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 5;
            label2.Text = "Серийный номер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 218);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "Дата поверки";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(156, 281);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 23);
            comboBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 284);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 9;
            label5.Text = "Филиал";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(156, 212);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(246, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(216, 524);
            button1.Name = "button1";
            button1.Size = new Size(102, 41);
            button1.TabIndex = 12;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 36);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 13;
            label6.Text = "Тип прибора";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(156, 36);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(246, 23);
            comboBox2.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 344);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 17;
            label7.Text = "Номер кабинета";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(156, 341);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(246, 23);
            comboBox3.TabIndex = 16;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(156, 396);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(246, 23);
            comboBox4.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 399);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 20;
            label8.Text = "Статус";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 455);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 22;
            label9.Text = "Год выпуска";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(156, 447);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(246, 23);
            dateTimePicker3.TabIndex = 23;
            // 
            // InvetnPov
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 633);
            Controls.Add(dateTimePicker3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBox4);
            Controls.Add(label7);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InvetnPov";
            Text = "Добавление";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label6;
        private ComboBox comboBox2;
        private Label label7;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label8;
        private Label label9;
        private DateTimePicker dateTimePicker3;
    }
}