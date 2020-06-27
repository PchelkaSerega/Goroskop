namespace WindowsFormsApp1
{
    partial class Frm2
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
            this.components = new System.ComponentModel.Container();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.cntxtMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.очисткаTlStrpMnItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnGor2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.mnStrp = new System.Windows.Forms.MenuStrip();
            this.ещеTlStrpMnItem = new System.Windows.Forms.ToolStripMenuItem();
            this.здоровьеTlStrpMnItem = new System.Windows.Forms.ToolStripMenuItem();
            this.любовьTlStrpMnItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.lnkLbl = new System.Windows.Forms.LinkLabel();
            this.pctrBox2 = new System.Windows.Forms.PictureBox();
            this.cntxtMenu.SuspendLayout();
            this.grpBox.SuspendLayout();
            this.mnStrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose2
            // 
            this.btnClose2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose2.Location = new System.Drawing.Point(381, 319);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(87, 38);
            this.btnClose2.TabIndex = 2;
            this.btnClose2.Text = "Выход";
            this.btnClose2.UseVisualStyleBackColor = false;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // txt
            // 
            this.txt.ContextMenuStrip = this.cntxtMenu;
            this.txt.Location = new System.Drawing.Point(12, 42);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(280, 148);
            this.txt.TabIndex = 3;
            // 
            // cntxtMenu
            // 
            this.cntxtMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очисткаTlStrpMnItem});
            this.cntxtMenu.Name = "cntxtMenu";
            this.cntxtMenu.Size = new System.Drawing.Size(121, 26);
            this.cntxtMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cntxtMenu_Opening);
            // 
            // очисткаTlStrpMnItem
            // 
            this.очисткаTlStrpMnItem.Name = "очисткаTlStrpMnItem";
            this.очисткаTlStrpMnItem.Size = new System.Drawing.Size(120, 22);
            this.очисткаTlStrpMnItem.Text = "Очистка";
            this.очисткаTlStrpMnItem.Click += new System.EventHandler(this.очисткаTlStrpMnItem_Click);
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.lstBox);
            this.grpBox.Controls.Add(this.lbl2);
            this.grpBox.Location = new System.Drawing.Point(326, 42);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(200, 183);
            this.grpBox.TabIndex = 4;
            this.grpBox.TabStop = false;
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Items.AddRange(new object[] {
            "Овен",
            "Телец",
            "Близнецы",
            "Рак",
            "Лев",
            "Дева",
            "Весы",
            "Скорпион",
            "Стрелец",
            "Козерог",
            "Водолей",
            "Рыбы"});
            this.lstBox.Location = new System.Drawing.Point(41, 53);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(120, 95);
            this.lstBox.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(58, 26);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(87, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Выберите знак:";
            // 
            // btnGor2
            // 
            this.btnGor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGor2.Location = new System.Drawing.Point(367, 231);
            this.btnGor2.Name = "btnGor2";
            this.btnGor2.Size = new System.Drawing.Size(114, 38);
            this.btnGor2.TabIndex = 5;
            this.btnGor2.Text = "Посмотреть гороскоп";
            this.tlTip2.SetToolTip(this.btnGor2, "Можно посмотреть гороскоп\r\n");
            this.btnGor2.UseVisualStyleBackColor = false;
            this.btnGor2.Click += new System.EventHandler(this.btnGor2_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(381, 275);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 38);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Очистка";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // mnStrp
            // 
            this.mnStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ещеTlStrpMnItem});
            this.mnStrp.Location = new System.Drawing.Point(0, 0);
            this.mnStrp.Name = "mnStrp";
            this.mnStrp.Size = new System.Drawing.Size(538, 24);
            this.mnStrp.TabIndex = 7;
            this.mnStrp.Text = "menuStrip1";
            // 
            // ещеTlStrpMnItem
            // 
            this.ещеTlStrpMnItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.здоровьеTlStrpMnItem,
            this.любовьTlStrpMnItem});
            this.ещеTlStrpMnItem.Name = "ещеTlStrpMnItem";
            this.ещеTlStrpMnItem.Size = new System.Drawing.Size(51, 20);
            this.ещеTlStrpMnItem.Text = "Еще...";
            // 
            // здоровьеTlStrpMnItem
            // 
            this.здоровьеTlStrpMnItem.Name = "здоровьеTlStrpMnItem";
            this.здоровьеTlStrpMnItem.Size = new System.Drawing.Size(180, 22);
            this.здоровьеTlStrpMnItem.Text = "Здоровье";
            this.здоровьеTlStrpMnItem.Click += new System.EventHandler(this.здоровьеTlStrpMnItem_Click);
            // 
            // любовьTlStrpMnItem
            // 
            this.любовьTlStrpMnItem.Name = "любовьTlStrpMnItem";
            this.любовьTlStrpMnItem.Size = new System.Drawing.Size(180, 22);
            this.любовьTlStrpMnItem.Text = "Любовь";
            this.любовьTlStrpMnItem.Click += new System.EventHandler(this.любовьTlStrpMnItem_Click);
            // 
            // tlTip2
            // 
            this.tlTip2.Tag = "";
            this.tlTip2.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // lnkLbl
            // 
            this.lnkLbl.AutoSize = true;
            this.lnkLbl.Location = new System.Drawing.Point(119, 332);
            this.lnkLbl.Name = "lnkLbl";
            this.lnkLbl.Size = new System.Drawing.Size(60, 13);
            this.lnkLbl.TabIndex = 9;
            this.lnkLbl.TabStop = true;
            this.lnkLbl.Text = "Сохранить";
            this.lnkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLbl_LinkClicked);
            // 
            // pctrBox2
            // 
            this.pctrBox2.Location = new System.Drawing.Point(64, 196);
            this.pctrBox2.Name = "pctrBox2";
            this.pctrBox2.Size = new System.Drawing.Size(175, 127);
            this.pctrBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBox2.TabIndex = 8;
            this.pctrBox2.TabStop = false;
            // 
            // Frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(538, 381);
            this.Controls.Add(this.lnkLbl);
            this.Controls.Add(this.pctrBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGor2);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnClose2);
            this.Controls.Add(this.mnStrp);
            this.MainMenuStrip = this.mnStrp;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm2";
            this.Text = "Гороскоп 2020";
            this.cntxtMenu.ResumeLayout(false);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.mnStrp.ResumeLayout(false);
            this.mnStrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnGor2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip mnStrp;
        private System.Windows.Forms.ToolStripMenuItem ещеTlStrpMnItem;
        private System.Windows.Forms.ToolStripMenuItem здоровьеTlStrpMnItem;
        private System.Windows.Forms.ToolStripMenuItem любовьTlStrpMnItem;
        private System.Windows.Forms.PictureBox pctrBox2;
        private System.Windows.Forms.ToolTip tlTip2;
        private System.Windows.Forms.ContextMenuStrip cntxtMenu;
        private System.Windows.Forms.ToolStripMenuItem очисткаTlStrpMnItem;
        private System.Windows.Forms.LinkLabel lnkLbl;
    }
}