namespace InventV15
{
    partial class InventNotPov
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
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            btnAdd = new Button();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label9 = new Label();
            comboBox5 = new ComboBox();
            dtpYearOfMan = new DateTimePicker();
            lblYearOfMan = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 146);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 9;
            label2.Text = "Серийный номер";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 90);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 8;
            label1.Text = "Название";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 23);
            textBox1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 199);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 11;
            label5.Text = "Филиал";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(180, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 23);
            comboBox1.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Location = new Point(232, 427);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 41);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(180, 250);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(240, 23);
            comboBox2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 253);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 15;
            label3.Text = "Номер кабинета";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(50, 309);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 25;
            label9.Text = "Обслуживание";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(180, 306);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(240, 23);
            comboBox5.TabIndex = 23;
            // 
            // dtpYearOfMan
            // 
            dtpYearOfMan.Location = new Point(180, 361);
            dtpYearOfMan.Name = "dtpYearOfMan";
            dtpYearOfMan.Size = new Size(240, 23);
            dtpYearOfMan.TabIndex = 26;
            // 
            // lblYearOfMan
            // 
            lblYearOfMan.AutoSize = true;
            lblYearOfMan.Location = new Point(65, 367);
            lblYearOfMan.Name = "lblYearOfMan";
            lblYearOfMan.Size = new Size(75, 15);
            lblYearOfMan.TabIndex = 27;
            lblYearOfMan.Text = "Год выпуска";
            // 
            // InventNotPov
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 496);
            Controls.Add(lblYearOfMan);
            Controls.Add(dtpYearOfMan);
            Controls.Add(label9);
            Controls.Add(comboBox5);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "InventNotPov";
            Text = "Добавление";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private ComboBox comboBox1;
        private Button btnAdd;
        private ComboBox comboBox2;
        private Label label3;
        private Label label9;
        private ComboBox comboBox5;
        private DateTimePicker dtpYearOfMan;
        private Label lblYearOfMan;
    }
}