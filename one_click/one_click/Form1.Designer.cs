namespace one_click
{
    partial class mainwindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.hi = new System.Windows.Forms.Label();
            this.begin = new System.Windows.Forms.Label();
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.TrackBar();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.wlw = new System.Windows.Forms.PictureBox();
            this.nshv = new System.Windows.Forms.PictureBox();
            this.hp = new System.Windows.Forms.PictureBox();
            this.cld = new System.Windows.Forms.PictureBox();
            this.blr = new System.Windows.Forms.PictureBox();
            this.shrp = new System.Windows.Forms.PictureBox();
            this.inv = new System.Windows.Forms.PictureBox();
            this.beginpic = new System.Windows.Forms.PictureBox();
            this.fon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.power)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wlw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nshv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fon)).BeginInit();
            this.SuspendLayout();
            // 
            // hi
            // 
            this.hi.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.hi.Location = new System.Drawing.Point(0, 22);
            this.hi.Name = "hi";
            this.hi.Size = new System.Drawing.Size(815, 118);
            this.hi.TabIndex = 1;
            this.hi.Text = "Приветствую в программе One Click Image Editor! Для продолжения просто нажмите \"Н" +
    "ачать\", а затем выберите изображение, которое хотите обработать.";
            this.hi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hi.Click += new System.EventHandler(this.hi_Click);
            // 
            // begin
            // 
            this.begin.AutoSize = true;
            this.begin.BackColor = System.Drawing.Color.Transparent;
            this.begin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.begin.Location = new System.Drawing.Point(376, 255);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(99, 29);
            this.begin.TabIndex = 2;
            this.begin.Text = "Начать!";
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(-1, -4);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(243, 23);
            this.open.TabIndex = 3;
            this.open.Text = "Открыть";
            this.open.UseVisualStyleBackColor = true;
            this.open.Visible = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(554, -4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(261, 23);
            this.save.TabIndex = 4;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // power
            // 
            this.power.AutoSize = false;
            this.power.BackColor = System.Drawing.Color.DimGray;
            this.power.Location = new System.Drawing.Point(12, 422);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(300, 19);
            this.power.TabIndex = 10;
            this.power.TickStyle = System.Windows.Forms.TickStyle.None;
            this.power.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(593, 530);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(78, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.cld_Click);
            // 
            // wlw
            // 
            this.wlw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.wlw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wlw.Location = new System.Drawing.Point(509, 530);
            this.wlw.Name = "wlw";
            this.wlw.Size = new System.Drawing.Size(78, 50);
            this.wlw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.wlw.TabIndex = 9;
            this.wlw.TabStop = false;
            this.wlw.Click += new System.EventHandler(this.wlw_Click);
            // 
            // nshv
            // 
            this.nshv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.nshv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nshv.Location = new System.Drawing.Point(425, 530);
            this.nshv.Name = "nshv";
            this.nshv.Size = new System.Drawing.Size(78, 50);
            this.nshv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.nshv.TabIndex = 9;
            this.nshv.TabStop = false;
            this.nshv.Click += new System.EventHandler(this.nshv_Click);
            // 
            // hp
            // 
            this.hp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hp.Location = new System.Drawing.Point(341, 530);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(78, 50);
            this.hp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hp.TabIndex = 9;
            this.hp.TabStop = false;
            this.hp.Click += new System.EventHandler(this.hp_Click);
            // 
            // cld
            // 
            this.cld.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cld.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cld.Location = new System.Drawing.Point(257, 530);
            this.cld.Name = "cld";
            this.cld.Size = new System.Drawing.Size(78, 50);
            this.cld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cld.TabIndex = 9;
            this.cld.TabStop = false;
            this.cld.Click += new System.EventHandler(this.cld_Click);
            // 
            // blr
            // 
            this.blr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.blr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blr.Location = new System.Drawing.Point(173, 530);
            this.blr.Name = "blr";
            this.blr.Size = new System.Drawing.Size(78, 50);
            this.blr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.blr.TabIndex = 8;
            this.blr.TabStop = false;
            this.blr.Click += new System.EventHandler(this.blur_Click);
            // 
            // shrp
            // 
            this.shrp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.shrp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shrp.Location = new System.Drawing.Point(89, 530);
            this.shrp.Name = "shrp";
            this.shrp.Size = new System.Drawing.Size(78, 50);
            this.shrp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.shrp.TabIndex = 7;
            this.shrp.TabStop = false;
            this.shrp.WaitOnLoad = true;
            this.shrp.Click += new System.EventHandler(this.shrp_Click);
            // 
            // inv
            // 
            this.inv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.inv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inv.Location = new System.Drawing.Point(5, 530);
            this.inv.Name = "inv";
            this.inv.Size = new System.Drawing.Size(78, 50);
            this.inv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.inv.TabIndex = 6;
            this.inv.TabStop = false;
            this.inv.WaitOnLoad = true;
            this.inv.Click += new System.EventHandler(this.inv_Click);
            // 
            // beginpic
            // 
            this.beginpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beginpic.Image = global::one_click.Properties.Resources.begin;
            this.beginpic.Location = new System.Drawing.Point(300, 143);
            this.beginpic.Name = "beginpic";
            this.beginpic.Size = new System.Drawing.Size(250, 250);
            this.beginpic.TabIndex = 0;
            this.beginpic.TabStop = false;
            this.beginpic.Click += new System.EventHandler(this.beginpic_Click_1);
            // 
            // fon
            // 
            this.fon.BackColor = System.Drawing.Color.Gray;
            this.fon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fon.Image = global::one_click.Properties.Resources.fon;
            this.fon.InitialImage = null;
            this.fon.Location = new System.Drawing.Point(-1, 526);
            this.fon.Name = "fon";
            this.fon.Size = new System.Drawing.Size(816, 59);
            this.fon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fon.TabIndex = 11;
            this.fon.TabStop = false;
            this.fon.Visible = false;
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(814, 583);
            this.Controls.Add(this.power);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.wlw);
            this.Controls.Add(this.nshv);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.cld);
            this.Controls.Add(this.blr);
            this.Controls.Add(this.shrp);
            this.Controls.Add(this.inv);
            this.Controls.Add(this.save);
            this.Controls.Add(this.open);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.beginpic);
            this.Controls.Add(this.hi);
            this.Controls.Add(this.fon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mainwindow";
            this.Text = "One Click Editor";
            ((System.ComponentModel.ISupportInitialize)(this.power)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wlw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nshv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox beginpic;
        private System.Windows.Forms.Label hi;
        private System.Windows.Forms.Label begin;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.PictureBox inv;
        private System.Windows.Forms.PictureBox shrp;
        private System.Windows.Forms.PictureBox blr;
        private System.Windows.Forms.PictureBox cld;
        private System.Windows.Forms.PictureBox hp;
        private System.Windows.Forms.PictureBox nshv;
        private System.Windows.Forms.PictureBox wlw;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TrackBar power;
        private System.Windows.Forms.PictureBox fon;
    }
}

