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
            this.beginpic = new System.Windows.Forms.PictureBox();
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.inv = new System.Windows.Forms.PictureBox();
            this.shrp = new System.Windows.Forms.PictureBox();
            this.blr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.beginpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blr)).BeginInit();
            this.SuspendLayout();
            // 
            // hi
            // 
            this.hi.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.hi.Location = new System.Drawing.Point(0, 22);
            this.hi.Name = "hi";
            this.hi.Size = new System.Drawing.Size(683, 118);
            this.hi.TabIndex = 1;
            this.hi.Text = "Приветствую в программе One Click Image Editor! Для продолжения просто нажмите \"Н" +
    "ачать\", а затем выберите изображение, которое хотите обработать.";
            this.hi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hi.Click += new System.EventHandler(this.hi_Click);
            // 
            // begin
            // 
            this.begin.AutoSize = true;
            this.begin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.begin.Location = new System.Drawing.Point(300, 276);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(99, 29);
            this.begin.TabIndex = 2;
            this.begin.Text = "Начать!";
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // beginpic
            // 
            this.beginpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beginpic.Image = global::one_click.Properties.Resources.begin;
            this.beginpic.Location = new System.Drawing.Point(225, 164);
            this.beginpic.Name = "beginpic";
            this.beginpic.Size = new System.Drawing.Size(250, 250);
            this.beginpic.TabIndex = 0;
            this.beginpic.TabStop = false;
            this.beginpic.Click += new System.EventHandler(this.beginpic_Click_1);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(12, 12);
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
            this.save.Location = new System.Drawing.Point(411, 12);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(261, 23);
            this.save.TabIndex = 4;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picture.Location = new System.Drawing.Point(-1, -1);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(684, 539);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 5;
            this.picture.TabStop = false;
            this.picture.Visible = false;
            // 
            // inv
            // 
            this.inv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inv.Location = new System.Drawing.Point(5, 475);
            this.inv.Name = "inv";
            this.inv.Size = new System.Drawing.Size(88, 50);
            this.inv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inv.TabIndex = 6;
            this.inv.TabStop = false;
            this.inv.WaitOnLoad = true;
            this.inv.Click += new System.EventHandler(this.inv_Click);
            // 
            // shrp
            // 
            this.shrp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.shrp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shrp.Location = new System.Drawing.Point(99, 475);
            this.shrp.Name = "shrp";
            this.shrp.Size = new System.Drawing.Size(88, 50);
            this.shrp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shrp.TabIndex = 7;
            this.shrp.TabStop = false;
            this.shrp.WaitOnLoad = true;
            this.shrp.Click += new System.EventHandler(this.shrp_Click);
            // 
            // blr
            // 
            this.blr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.blr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blr.Location = new System.Drawing.Point(193, 475);
            this.blr.Name = "blr";
            this.blr.Size = new System.Drawing.Size(88, 50);
            this.blr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blr.TabIndex = 8;
            this.blr.TabStop = false;
            this.blr.Click += new System.EventHandler(this.blur_Click);
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 537);
            this.Controls.Add(this.blr);
            this.Controls.Add(this.shrp);
            this.Controls.Add(this.inv);
            this.Controls.Add(this.save);
            this.Controls.Add(this.open);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.beginpic);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.hi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "mainwindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.beginpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shrp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox beginpic;
        private System.Windows.Forms.Label hi;
        private System.Windows.Forms.Label begin;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox inv;
        private System.Windows.Forms.PictureBox shrp;
        private System.Windows.Forms.PictureBox blr;
    }
}

