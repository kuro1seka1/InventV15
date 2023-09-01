namespace InventV15
{
    partial class NewInventPov
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
            tbxName = new TextBox();
            lblInvName = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // tbxName
            // 
            tbxName.Location = new Point(81, 40);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(176, 23);
            tbxName.TabIndex = 5;
            // 
            // lblInvName
            // 
            lblInvName.AutoSize = true;
            lblInvName.Location = new Point(16, 43);
            lblInvName.Name = "lblInvName";
            lblInvName.Size = new Size(59, 15);
            lblInvName.TabIndex = 4;
            lblInvName.Text = "Название";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(130, 87);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // NewInventPov
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 150);
            Controls.Add(tbxName);
            Controls.Add(lblInvName);
            Controls.Add(btnAdd);
            Name = "NewInventPov";
            Text = "Добавление";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxName;
        private Label lblInvName;
        private Button btnAdd;
    }
}