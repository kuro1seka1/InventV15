namespace InventV15
{
    partial class NewFilial
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
            btnAdd = new Button();
            label1 = new Label();
            tbxAdr = new TextBox();
            label2 = new Label();
            numFilNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numFilNum).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(204, 197);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 67);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 1;
            label1.Text = "Номер филиала";
            // 
            // tbxAdr
            // 
            tbxAdr.Location = new Point(153, 121);
            tbxAdr.Name = "tbxAdr";
            tbxAdr.Size = new Size(182, 23);
            tbxAdr.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 124);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 3;
            label2.Text = "Адрес филиал";
            // 
            // numFilNum
            // 
            numFilNum.Location = new Point(153, 65);
            numFilNum.Name = "numFilNum";
            numFilNum.Size = new Size(182, 23);
            numFilNum.TabIndex = 5;
            // 
            // NewFilial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 250);
            Controls.Add(numFilNum);
            Controls.Add(tbxAdr);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "NewFilial";
            Text = "Добавление";
            ((System.ComponentModel.ISupportInitialize)numFilNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private TextBox tbxAdr;
        private Label label2;
        private NumericUpDown numFilNum;
    }
}