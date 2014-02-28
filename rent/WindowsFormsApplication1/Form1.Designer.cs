namespace WindowsFormsApplication1
{
    partial class r_auto
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
            this.l_auto = new System.Windows.Forms.Label();
            this.auto = new System.Windows.Forms.ComboBox();
            this.l_engine = new System.Windows.Forms.Label();
            this.l_power = new System.Windows.Forms.Label();
            this.diesel = new System.Windows.Forms.RadioButton();
            this.electric = new System.Windows.Forms.RadioButton();
            this.petrol = new System.Windows.Forms.RadioButton();
            this.l_options = new System.Windows.Forms.Label();
            this.windows = new System.Windows.Forms.CheckBox();
            this.airbag = new System.Windows.Forms.CheckBox();
            this.conditioner = new System.Windows.Forms.CheckBox();
            this.parktronics = new System.Windows.Forms.CheckBox();
            this.top = new System.Windows.Forms.CheckBox();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.RadioButton();
            this.p2 = new System.Windows.Forms.RadioButton();
            this.p3 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_auto
            // 
            this.l_auto.AutoSize = true;
            this.l_auto.Location = new System.Drawing.Point(12, 9);
            this.l_auto.Name = "l_auto";
            this.l_auto.Size = new System.Drawing.Size(91, 13);
            this.l_auto.TabIndex = 0;
            this.l_auto.Text = "Выберите марку";
            this.l_auto.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.l_auto.Click += new System.EventHandler(this.label1_Click);
            // 
            // auto
            // 
            this.auto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.auto.FormattingEnabled = true;
            this.auto.Items.AddRange(new object[] {
            "Эсперанто",
            "Элегия",
            "Туризмо",
            "Инфернус",
            "Оззи"});
            this.auto.Location = new System.Drawing.Point(150, 6);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(133, 21);
            this.auto.TabIndex = 1;
            this.auto.Tag = "";
            this.auto.SelectedIndexChanged += new System.EventHandler(this.auto_SelectedIndexChanged);
            // 
            // l_engine
            // 
            this.l_engine.AutoSize = true;
            this.l_engine.Location = new System.Drawing.Point(12, 39);
            this.l_engine.Name = "l_engine";
            this.l_engine.Size = new System.Drawing.Size(132, 13);
            this.l_engine.TabIndex = 0;
            this.l_engine.Text = "Выберите тип двигателя";
            this.l_engine.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.l_engine.Click += new System.EventHandler(this.label1_Click);
            // 
            // l_power
            // 
            this.l_power.AutoSize = true;
            this.l_power.Location = new System.Drawing.Point(3, 10);
            this.l_power.Name = "l_power";
            this.l_power.Size = new System.Drawing.Size(112, 13);
            this.l_power.TabIndex = 0;
            this.l_power.Text = "Выберите мощность";
            this.l_power.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.l_power.Click += new System.EventHandler(this.label1_Click);
            // 
            // diesel
            // 
            this.diesel.AutoSize = true;
            this.diesel.Enabled = false;
            this.diesel.Location = new System.Drawing.Point(150, 39);
            this.diesel.Name = "diesel";
            this.diesel.Size = new System.Drawing.Size(84, 17);
            this.diesel.TabIndex = 2;
            this.diesel.TabStop = true;
            this.diesel.Text = "Дизельный";
            this.diesel.UseVisualStyleBackColor = true;
            this.diesel.CheckedChanged += new System.EventHandler(this.diesel_CheckedChanged);
            // 
            // electric
            // 
            this.electric.AutoSize = true;
            this.electric.Enabled = false;
            this.electric.Location = new System.Drawing.Point(150, 85);
            this.electric.Name = "electric";
            this.electric.Size = new System.Drawing.Size(102, 17);
            this.electric.TabIndex = 3;
            this.electric.TabStop = true;
            this.electric.Text = "Электрический";
            this.electric.UseVisualStyleBackColor = true;
            this.electric.CheckedChanged += new System.EventHandler(this.electric_CheckedChanged);
            // 
            // petrol
            // 
            this.petrol.AutoSize = true;
            this.petrol.Enabled = false;
            this.petrol.Location = new System.Drawing.Point(150, 62);
            this.petrol.Name = "petrol";
            this.petrol.Size = new System.Drawing.Size(88, 17);
            this.petrol.TabIndex = 3;
            this.petrol.TabStop = true;
            this.petrol.Text = "Бензиновый";
            this.petrol.UseVisualStyleBackColor = true;
            this.petrol.CheckedChanged += new System.EventHandler(this.petrol_CheckedChanged);
            // 
            // l_options
            // 
            this.l_options.AutoSize = true;
            this.l_options.Location = new System.Drawing.Point(12, 189);
            this.l_options.Name = "l_options";
            this.l_options.Size = new System.Drawing.Size(131, 13);
            this.l_options.TabIndex = 0;
            this.l_options.Text = "Дополнительные опции:";
            this.l_options.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.l_options.Click += new System.EventHandler(this.label1_Click);
            // 
            // windows
            // 
            this.windows.AutoSize = true;
            this.windows.Enabled = false;
            this.windows.Location = new System.Drawing.Point(12, 214);
            this.windows.Name = "windows";
            this.windows.Size = new System.Drawing.Size(203, 17);
            this.windows.TabIndex = 4;
            this.windows.Text = "электрические стеклоподъемники";
            this.windows.UseVisualStyleBackColor = true;
            this.windows.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // airbag
            // 
            this.airbag.AutoSize = true;
            this.airbag.Enabled = false;
            this.airbag.Location = new System.Drawing.Point(12, 237);
            this.airbag.Name = "airbag";
            this.airbag.Size = new System.Drawing.Size(143, 17);
            this.airbag.TabIndex = 4;
            this.airbag.Text = "подушки безопасности";
            this.airbag.UseVisualStyleBackColor = true;
            this.airbag.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // conditioner
            // 
            this.conditioner.AutoSize = true;
            this.conditioner.Enabled = false;
            this.conditioner.Location = new System.Drawing.Point(12, 260);
            this.conditioner.Name = "conditioner";
            this.conditioner.Size = new System.Drawing.Size(92, 17);
            this.conditioner.TabIndex = 4;
            this.conditioner.Text = "кондиционер";
            this.conditioner.UseVisualStyleBackColor = true;
            this.conditioner.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // parktronics
            // 
            this.parktronics.AutoSize = true;
            this.parktronics.Enabled = false;
            this.parktronics.Location = new System.Drawing.Point(11, 283);
            this.parktronics.Name = "parktronics";
            this.parktronics.Size = new System.Drawing.Size(91, 17);
            this.parktronics.TabIndex = 4;
            this.parktronics.Text = "парктроники";
            this.parktronics.UseVisualStyleBackColor = true;
            this.parktronics.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // top
            // 
            this.top.AutoSize = true;
            this.top.Enabled = false;
            this.top.Location = new System.Drawing.Point(11, 306);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(99, 17);
            this.top.TabIndex = 4;
            this.top.Text = "откидной верх";
            this.top.UseVisualStyleBackColor = true;
            this.top.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Location = new System.Drawing.Point(11, 326);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(133, 23);
            this.save.TabIndex = 5;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.load.Location = new System.Drawing.Point(150, 326);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(133, 23);
            this.load.TabIndex = 5;
            this.load.Text = "Загрузить";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Enabled = false;
            this.p1.Location = new System.Drawing.Point(139, 10);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(34, 17);
            this.p1.TabIndex = 3;
            this.p1.TabStop = true;
            this.p1.Text = "...";
            this.p1.UseVisualStyleBackColor = true;
            this.p1.CheckedChanged += new System.EventHandler(this.electric_CheckedChanged);
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Enabled = false;
            this.p2.Location = new System.Drawing.Point(139, 33);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(34, 17);
            this.p2.TabIndex = 3;
            this.p2.TabStop = true;
            this.p2.Text = "...";
            this.p2.UseVisualStyleBackColor = true;
            this.p2.CheckedChanged += new System.EventHandler(this.electric_CheckedChanged);
            // 
            // p3
            // 
            this.p3.AutoSize = true;
            this.p3.Enabled = false;
            this.p3.Location = new System.Drawing.Point(139, 56);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(34, 17);
            this.p3.TabIndex = 3;
            this.p3.TabStop = true;
            this.p3.Text = "...";
            this.p3.UseVisualStyleBackColor = true;
            this.p3.CheckedChanged += new System.EventHandler(this.electric_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.p2);
            this.panel1.Controls.Add(this.p3);
            this.panel1.Controls.Add(this.p1);
            this.panel1.Controls.Add(this.l_power);
            this.panel1.Location = new System.Drawing.Point(11, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 84);
            this.panel1.TabIndex = 6;
            // 
            // r_auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 361);
            this.Controls.Add(this.load);
            this.Controls.Add(this.save);
            this.Controls.Add(this.top);
            this.Controls.Add(this.parktronics);
            this.Controls.Add(this.conditioner);
            this.Controls.Add(this.airbag);
            this.Controls.Add(this.windows);
            this.Controls.Add(this.petrol);
            this.Controls.Add(this.electric);
            this.Controls.Add(this.diesel);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.l_options);
            this.Controls.Add(this.l_engine);
            this.Controls.Add(this.l_auto);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(307, 400);
            this.MinimumSize = new System.Drawing.Size(307, 400);
            this.Name = "r_auto";
            this.Text = "Заказ автомобиля";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_auto;
        private System.Windows.Forms.ComboBox auto;
        private System.Windows.Forms.Label l_engine;
        private System.Windows.Forms.Label l_power;
        private System.Windows.Forms.RadioButton diesel;
        private System.Windows.Forms.RadioButton electric;
        private System.Windows.Forms.RadioButton petrol;
        private System.Windows.Forms.Label l_options;
        private System.Windows.Forms.CheckBox windows;
        private System.Windows.Forms.CheckBox airbag;
        private System.Windows.Forms.CheckBox conditioner;
        private System.Windows.Forms.CheckBox parktronics;
        private System.Windows.Forms.CheckBox top;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.RadioButton p1;
        private System.Windows.Forms.RadioButton p2;
        private System.Windows.Forms.RadioButton p3;
        private System.Windows.Forms.Panel panel1;
    }
}

