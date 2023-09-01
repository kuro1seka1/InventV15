namespace InventV15
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            ToolStripMenuItem1 = new ToolStripMenuItem();
            ToolStripMenuItemAdd = new ToolStripMenuItem();
            PovToolStripMenuItem = new ToolStripMenuItem();
            NotPovToolStripMenuItem = new ToolStripMenuItem();
            NewInventPovToolStripMenuItem = new ToolStripMenuItem();
            filialtoolStripMenuItem2 = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            textBox1 = new TextBox();
            lblService = new Label();
            lblStatus = new Label();
            cbxService = new ComboBox();
            cbxStatus = new ComboBox();
            lblCabnum = new Label();
            cbxCabnum = new ComboBox();
            cbxTypename = new ComboBox();
            lblTypename = new Label();
            dtpDatenextpov = new DateTimePicker();
            dtpDatepov = new DateTimePicker();
            lblFilial = new Label();
            cbxFilial = new ComboBox();
            lblDatenextpov = new Label();
            lblDatepov = new Label();
            lblSerialnum = new Label();
            lblname = new Label();
            tbxSerialnum = new TextBox();
            tbxName = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            checkBox1 = new CheckBox();
            searchByFilial = new ComboBox();
            dtpYearOfMan = new DateTimePicker();
            lblYearOfMan = new Label();
            btnHome = new Button();
            HistiryMovToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ButtonHighlight;
            dataGridView1.Location = new Point(10, 75);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(923, 687);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem1, оПрограммеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1280, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem1
            // 
            ToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemAdd });
            ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            ToolStripMenuItem1.Size = new Size(72, 20);
            ToolStripMenuItem1.Text = "Приборы";
            // 
            // ToolStripMenuItemAdd
            // 
            ToolStripMenuItemAdd.DropDownItems.AddRange(new ToolStripItem[] { PovToolStripMenuItem, NotPovToolStripMenuItem, NewInventPovToolStripMenuItem, filialtoolStripMenuItem2, HistiryMovToolStripMenuItem });
            ToolStripMenuItemAdd.Name = "ToolStripMenuItemAdd";
            ToolStripMenuItemAdd.Size = new Size(180, 22);
            ToolStripMenuItemAdd.Text = "Добавить";
            ToolStripMenuItemAdd.Click += ToolStripMenuItemAdd_Click;
            // 
            // PovToolStripMenuItem
            // 
            PovToolStripMenuItem.Name = "PovToolStripMenuItem";
            PovToolStripMenuItem.Size = new Size(302, 22);
            PovToolStripMenuItem.Text = "Прибор подлежащий поверке";
            PovToolStripMenuItem.Click += PovToolStripMenuItem_Click;
            // 
            // NotPovToolStripMenuItem
            // 
            NotPovToolStripMenuItem.Name = "NotPovToolStripMenuItem";
            NotPovToolStripMenuItem.Size = new Size(302, 22);
            NotPovToolStripMenuItem.Text = "Прибор не подлежащий поверке";
            NotPovToolStripMenuItem.Click += NotPovToolStripMenuItem_Click;
            // 
            // NewInventPovToolStripMenuItem
            // 
            NewInventPovToolStripMenuItem.Name = "NewInventPovToolStripMenuItem";
            NewInventPovToolStripMenuItem.Size = new Size(302, 22);
            NewInventPovToolStripMenuItem.Text = "В раздел приборов подлежащих поверке";
            NewInventPovToolStripMenuItem.Click += NewInventPovToolStripMenuItem_Click;
            // 
            // filialtoolStripMenuItem2
            // 
            filialtoolStripMenuItem2.Name = "filialtoolStripMenuItem2";
            filialtoolStripMenuItem2.Size = new Size(302, 22);
            filialtoolStripMenuItem2.Text = "Филиал";
            filialtoolStripMenuItem2.Click += filialtoolStripMenuItem2_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(94, 20);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 41);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 8;
            label3.Text = "Поиск";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(388, 23);
            textBox1.TabIndex = 10;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // lblService
            // 
            lblService.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblService.AutoSize = true;
            lblService.Location = new Point(952, 548);
            lblService.Name = "lblService";
            lblService.Size = new Size(90, 15);
            lblService.TabIndex = 39;
            lblService.Text = "Обслуживание";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(956, 494);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(43, 15);
            lblStatus.TabIndex = 38;
            lblStatus.Text = "Статус";
            // 
            // cbxService
            // 
            cbxService.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cbxService.FormattingEnabled = true;
            cbxService.Location = new Point(1064, 548);
            cbxService.Name = "cbxService";
            cbxService.Size = new Size(204, 23);
            cbxService.TabIndex = 37;
            cbxService.Click += cbxService_Click;
            // 
            // cbxStatus
            // 
            cbxStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Location = new Point(1064, 491);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(204, 23);
            cbxStatus.TabIndex = 36;
            cbxStatus.Click += cbxStatus_Click;
            // 
            // lblCabnum
            // 
            lblCabnum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblCabnum.AutoSize = true;
            lblCabnum.Location = new Point(952, 429);
            lblCabnum.Name = "lblCabnum";
            lblCabnum.Size = new Size(98, 15);
            lblCabnum.TabIndex = 35;
            lblCabnum.Text = "Номер кабинета";
            // 
            // cbxCabnum
            // 
            cbxCabnum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cbxCabnum.FormattingEnabled = true;
            cbxCabnum.Location = new Point(1064, 429);
            cbxCabnum.Name = "cbxCabnum";
            cbxCabnum.Size = new Size(204, 23);
            cbxCabnum.TabIndex = 34;
            // 
            // cbxTypename
            // 
            cbxTypename.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cbxTypename.FormattingEnabled = true;
            cbxTypename.Location = new Point(1064, 82);
            cbxTypename.Name = "cbxTypename";
            cbxTypename.Size = new Size(204, 23);
            cbxTypename.TabIndex = 33;
            cbxTypename.Click += cbxTypename_Click;
            // 
            // lblTypename
            // 
            lblTypename.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblTypename.AutoSize = true;
            lblTypename.Location = new Point(952, 85);
            lblTypename.Name = "lblTypename";
            lblTypename.Size = new Size(78, 15);
            lblTypename.TabIndex = 32;
            lblTypename.Text = "Тип прибора";
            // 
            // dtpDatenextpov
            // 
            dtpDatenextpov.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dtpDatenextpov.Location = new Point(1064, 314);
            dtpDatenextpov.Name = "dtpDatenextpov";
            dtpDatenextpov.Size = new Size(204, 23);
            dtpDatenextpov.TabIndex = 31;
            // 
            // dtpDatepov
            // 
            dtpDatepov.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dtpDatepov.Location = new Point(1064, 258);
            dtpDatepov.Name = "dtpDatepov";
            dtpDatepov.Size = new Size(204, 23);
            dtpDatepov.TabIndex = 30;
            // 
            // lblFilial
            // 
            lblFilial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblFilial.AutoSize = true;
            lblFilial.Location = new Point(956, 373);
            lblFilial.Name = "lblFilial";
            lblFilial.Size = new Size(50, 15);
            lblFilial.TabIndex = 29;
            lblFilial.Text = "Филиал";
            // 
            // cbxFilial
            // 
            cbxFilial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cbxFilial.FormattingEnabled = true;
            cbxFilial.Location = new Point(1064, 369);
            cbxFilial.Name = "cbxFilial";
            cbxFilial.Size = new Size(204, 23);
            cbxFilial.TabIndex = 28;
            cbxFilial.Click += cbxFilial_Click;
            // 
            // lblDatenextpov
            // 
            lblDatenextpov.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblDatenextpov.AutoSize = true;
            lblDatenextpov.Location = new Point(956, 317);
            lblDatenextpov.Name = "lblDatenextpov";
            lblDatenextpov.Size = new Size(97, 15);
            lblDatenextpov.TabIndex = 27;
            lblDatenextpov.Text = "Дата сл.поверки";
            // 
            // lblDatepov
            // 
            lblDatepov.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblDatepov.AutoSize = true;
            lblDatepov.Location = new Point(952, 262);
            lblDatepov.Name = "lblDatepov";
            lblDatepov.Size = new Size(81, 15);
            lblDatepov.TabIndex = 26;
            lblDatepov.Text = "Дата поверки";
            // 
            // lblSerialnum
            // 
            lblSerialnum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblSerialnum.AutoSize = true;
            lblSerialnum.Location = new Point(952, 197);
            lblSerialnum.Name = "lblSerialnum";
            lblSerialnum.Size = new Size(104, 15);
            lblSerialnum.TabIndex = 25;
            lblSerialnum.Text = "Серийный номер";
            // 
            // lblname
            // 
            lblname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblname.AutoSize = true;
            lblname.Location = new Point(952, 140);
            lblname.Name = "lblname";
            lblname.Size = new Size(59, 15);
            lblname.TabIndex = 24;
            lblname.Text = "Название";
            // 
            // tbxSerialnum
            // 
            tbxSerialnum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tbxSerialnum.Location = new Point(1064, 193);
            tbxSerialnum.Name = "tbxSerialnum";
            tbxSerialnum.Size = new Size(204, 23);
            tbxSerialnum.TabIndex = 23;
            // 
            // tbxName
            // 
            tbxName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tbxName.Location = new Point(1064, 137);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(204, 23);
            tbxName.TabIndex = 22;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(956, 721);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 40);
            btnUpdate.TabIndex = 40;
            btnUpdate.TabStop = false;
            btnUpdate.Text = "Обновить";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(1184, 721);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 40);
            btnDelete.TabIndex = 41;
            btnDelete.Text = "Удалить";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(691, 42);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(130, 19);
            checkBox1.TabIndex = 43;
            checkBox1.Text = "Поиск по филиалу";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // searchByFilial
            // 
            searchByFilial.FormattingEnabled = true;
            searchByFilial.Location = new Point(499, 38);
            searchByFilial.Name = "searchByFilial";
            searchByFilial.Size = new Size(172, 23);
            searchByFilial.TabIndex = 44;
            searchByFilial.SelectedValueChanged += searchByFilial_SelectedValueChanged;
            // 
            // dtpYearOfMan
            // 
            dtpYearOfMan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dtpYearOfMan.Location = new Point(1064, 605);
            dtpYearOfMan.Name = "dtpYearOfMan";
            dtpYearOfMan.Size = new Size(204, 23);
            dtpYearOfMan.TabIndex = 45;
            // 
            // lblYearOfMan
            // 
            lblYearOfMan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblYearOfMan.AutoSize = true;
            lblYearOfMan.Location = new Point(952, 611);
            lblYearOfMan.Name = "lblYearOfMan";
            lblYearOfMan.Size = new Size(75, 15);
            lblYearOfMan.TabIndex = 46;
            lblYearOfMan.Text = "Год выпуска";
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHome.Location = new Point(1074, 721);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(87, 40);
            btnHome.TabIndex = 47;
            btnHome.TabStop = false;
            btnHome.Text = "Домой";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // HistiryMovToolStripMenuItem
            // 
            HistiryMovToolStripMenuItem.Name = "HistiryMovToolStripMenuItem";
            HistiryMovToolStripMenuItem.Size = new Size(302, 22);
            HistiryMovToolStripMenuItem.Text = "История перемещений";
            HistiryMovToolStripMenuItem.Click += HistiryMovToolStripMenuItem_Click;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1280, 773);
            Controls.Add(btnHome);
            Controls.Add(lblYearOfMan);
            Controls.Add(dtpYearOfMan);
            Controls.Add(searchByFilial);
            Controls.Add(checkBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(lblService);
            Controls.Add(lblStatus);
            Controls.Add(cbxService);
            Controls.Add(cbxStatus);
            Controls.Add(lblCabnum);
            Controls.Add(cbxCabnum);
            Controls.Add(cbxTypename);
            Controls.Add(lblTypename);
            Controls.Add(dtpDatenextpov);
            Controls.Add(dtpDatepov);
            Controls.Add(lblFilial);
            Controls.Add(cbxFilial);
            Controls.Add(lblDatenextpov);
            Controls.Add(lblDatepov);
            Controls.Add(lblSerialnum);
            Controls.Add(lblname);
            Controls.Add(tbxSerialnum);
            Controls.Add(tbxName);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "StartPage";
            Text = "Оборудование";
            Activated += StartPage_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItem1;
        private ToolStripMenuItem ToolStripMenuItemAdd;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem PovToolStripMenuItem;
        private ToolStripMenuItem NotPovToolStripMenuItem;
        private Label label3;
        private TextBox textBox1;
        private Label lblService;
        private Label lblStatus;
        private ComboBox cbxService;
        private ComboBox cbxStatus;
        private Label lblCabnum;
        private ComboBox cbxCabnum;
        private ComboBox cbxTypename;
        private Label lblTypename;
        private Label lblFilial;
        private ComboBox cbxFilial;
        private Label lblDatenextpov;
        private Label lblDatepov;
        private Label lblSerialnum;
        private Label lblname;
        private TextBox tbxSerialnum;
        private TextBox tbxName;
        private Button btnUpdate;
        private Button btnDelete;
        public DateTimePicker dtpDatenextpov;
        public DateTimePicker dtpDatepov;
        private ToolStripMenuItem NewInventPovToolStripMenuItem;
        private ToolStripMenuItem filialtoolStripMenuItem2;
        private CheckBox checkBox1;
        private ComboBox searchByFilial;
        public DateTimePicker dtpYearOfMan;
        private Label lblYearOfMan;
        private Button btnHome;
        private ToolStripMenuItem HistiryMovToolStripMenuItem;
    }
}