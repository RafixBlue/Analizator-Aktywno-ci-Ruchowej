namespace Analizator_Aktywności_Ruchowej
{
    partial class Okno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Okno));
            this.panel1 = new System.Windows.Forms.Panel();
            this.But_Mini = new System.Windows.Forms.PictureBox();
            this.But_Exit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.But_Zarz_Dan = new System.Windows.Forms.Button();
            this.But_Analiza_Danych = new System.Windows.Forms.Button();
            this.But_Zarz_Prof = new System.Windows.Forms.Button();
            this.Panel_Profili = new System.Windows.Forms.Panel();
            this.But_Usun_Prof = new System.Windows.Forms.Button();
            this.But_Edyt_Prof = new System.Windows.Forms.Button();
            this.But_Dod_Prof = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Panel_Analizy = new System.Windows.Forms.Panel();
            this.But_Month = new System.Windows.Forms.Button();
            this.But_Week = new System.Windows.Forms.Button();
            this.But_Day = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Panel_Danych = new System.Windows.Forms.Panel();
            this.But_Usun_Dane = new System.Windows.Forms.Button();
            this.But_Dod_Dane = new System.Windows.Forms.Button();
            this.Textbox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Wiek = new System.Windows.Forms.TextBox();
            this.textBox_Waga = new System.Windows.Forms.TextBox();
            this.textBox_Wzrost = new System.Windows.Forms.TextBox();
            this.textBox_Dl_Kroku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_Nazwa = new System.Windows.Forms.ComboBox();
            this.Panel_Akcji_Profili = new System.Windows.Forms.Panel();
            this.Panel_Akcji_Bazy = new System.Windows.Forms.Panel();
            this.comboBox_day = new System.Windows.Forms.ComboBox();
            this.comboBox_month = new System.Windows.Forms.ComboBox();
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.comboBox_Bazy_Profil = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.But_Mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.But_Exit)).BeginInit();
            this.panel2.SuspendLayout();
            this.Panel_Profili.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Panel_Analizy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.Panel_Danych.SuspendLayout();
            this.Panel_Akcji_Profili.SuspendLayout();
            this.Panel_Akcji_Bazy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.But_Mini);
            this.panel1.Controls.Add(this.But_Exit);
            this.panel1.Location = new System.Drawing.Point(1157, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 30);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // But_Mini
            // 
            this.But_Mini.Image = ((System.Drawing.Image)(resources.GetObject("But_Mini.Image")));
            this.But_Mini.Location = new System.Drawing.Point(33, 0);
            this.But_Mini.Name = "But_Mini";
            this.But_Mini.Size = new System.Drawing.Size(30, 30);
            this.But_Mini.TabIndex = 1;
            this.But_Mini.TabStop = false;
            this.But_Mini.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // But_Exit
            // 
            this.But_Exit.Image = ((System.Drawing.Image)(resources.GetObject("But_Exit.Image")));
            this.But_Exit.Location = new System.Drawing.Point(92, 0);
            this.But_Exit.Name = "But_Exit";
            this.But_Exit.Size = new System.Drawing.Size(30, 30);
            this.But_Exit.TabIndex = 1;
            this.But_Exit.TabStop = false;
            this.But_Exit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.But_Zarz_Dan);
            this.panel2.Controls.Add(this.But_Analiza_Danych);
            this.panel2.Controls.Add(this.But_Zarz_Prof);
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 640);
            this.panel2.TabIndex = 1;
            // 
            // But_Zarz_Dan
            // 
            this.But_Zarz_Dan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("But_Zarz_Dan.BackgroundImage")));
            this.But_Zarz_Dan.FlatAppearance.BorderSize = 0;
            this.But_Zarz_Dan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Zarz_Dan.Image = ((System.Drawing.Image)(resources.GetObject("But_Zarz_Dan.Image")));
            this.But_Zarz_Dan.Location = new System.Drawing.Point(0, 305);
            this.But_Zarz_Dan.Name = "But_Zarz_Dan";
            this.But_Zarz_Dan.Size = new System.Drawing.Size(185, 76);
            this.But_Zarz_Dan.TabIndex = 3;
            this.But_Zarz_Dan.UseVisualStyleBackColor = true;
            this.But_Zarz_Dan.Click += new System.EventHandler(this.But_Zarz_Dan_Click);
            // 
            // But_Analiza_Danych
            // 
            this.But_Analiza_Danych.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.But_Analiza_Danych.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("But_Analiza_Danych.BackgroundImage")));
            this.But_Analiza_Danych.FlatAppearance.BorderSize = 0;
            this.But_Analiza_Danych.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Analiza_Danych.Image = ((System.Drawing.Image)(resources.GetObject("But_Analiza_Danych.Image")));
            this.But_Analiza_Danych.Location = new System.Drawing.Point(0, 178);
            this.But_Analiza_Danych.Name = "But_Analiza_Danych";
            this.But_Analiza_Danych.Size = new System.Drawing.Size(185, 76);
            this.But_Analiza_Danych.TabIndex = 1;
            this.But_Analiza_Danych.UseVisualStyleBackColor = false;
            this.But_Analiza_Danych.Click += new System.EventHandler(this.But_Analiza_Danych_Click);
            // 
            // But_Zarz_Prof
            // 
            this.But_Zarz_Prof.BackColor = System.Drawing.SystemColors.ControlText;
            this.But_Zarz_Prof.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("But_Zarz_Prof.BackgroundImage")));
            this.But_Zarz_Prof.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.But_Zarz_Prof.FlatAppearance.BorderSize = 0;
            this.But_Zarz_Prof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Zarz_Prof.Image = ((System.Drawing.Image)(resources.GetObject("But_Zarz_Prof.Image")));
            this.But_Zarz_Prof.Location = new System.Drawing.Point(0, 51);
            this.But_Zarz_Prof.Name = "But_Zarz_Prof";
            this.But_Zarz_Prof.Size = new System.Drawing.Size(185, 76);
            this.But_Zarz_Prof.TabIndex = 0;
            this.But_Zarz_Prof.UseVisualStyleBackColor = false;
            this.But_Zarz_Prof.Click += new System.EventHandler(this.But_Zarz_Prof_Click);
            // 
            // Panel_Profili
            // 
            this.Panel_Profili.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Panel_Profili.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Profili.BackgroundImage")));
            this.Panel_Profili.Controls.Add(this.But_Usun_Prof);
            this.Panel_Profili.Controls.Add(this.But_Edyt_Prof);
            this.Panel_Profili.Controls.Add(this.But_Dod_Prof);
            this.Panel_Profili.Location = new System.Drawing.Point(0, 0);
            this.Panel_Profili.Name = "Panel_Profili";
            this.Panel_Profili.Size = new System.Drawing.Size(1132, 88);
            this.Panel_Profili.TabIndex = 3;
            this.Panel_Profili.Visible = false;
            // 
            // But_Usun_Prof
            // 
            this.But_Usun_Prof.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("But_Usun_Prof.BackgroundImage")));
            this.But_Usun_Prof.FlatAppearance.BorderSize = 0;
            this.But_Usun_Prof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Usun_Prof.Location = new System.Drawing.Point(634, 3);
            this.But_Usun_Prof.Name = "But_Usun_Prof";
            this.But_Usun_Prof.Size = new System.Drawing.Size(124, 82);
            this.But_Usun_Prof.TabIndex = 6;
            this.But_Usun_Prof.UseVisualStyleBackColor = true;
            this.But_Usun_Prof.Click += new System.EventHandler(this.But_Usun_Prof_Click);
            // 
            // But_Edyt_Prof
            // 
            this.But_Edyt_Prof.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("But_Edyt_Prof.BackgroundImage")));
            this.But_Edyt_Prof.FlatAppearance.BorderSize = 0;
            this.But_Edyt_Prof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Edyt_Prof.Location = new System.Drawing.Point(443, 3);
            this.But_Edyt_Prof.Name = "But_Edyt_Prof";
            this.But_Edyt_Prof.Size = new System.Drawing.Size(124, 82);
            this.But_Edyt_Prof.TabIndex = 5;
            this.But_Edyt_Prof.UseVisualStyleBackColor = true;
            this.But_Edyt_Prof.Click += new System.EventHandler(this.But_Edyt_Prof_Click);
            // 
            // But_Dod_Prof
            // 
            this.But_Dod_Prof.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("But_Dod_Prof.BackgroundImage")));
            this.But_Dod_Prof.FlatAppearance.BorderSize = 0;
            this.But_Dod_Prof.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Dod_Prof.Image = ((System.Drawing.Image)(resources.GetObject("But_Dod_Prof.Image")));
            this.But_Dod_Prof.Location = new System.Drawing.Point(252, 3);
            this.But_Dod_Prof.Name = "But_Dod_Prof";
            this.But_Dod_Prof.Size = new System.Drawing.Size(124, 82);
            this.But_Dod_Prof.TabIndex = 4;
            this.But_Dod_Prof.UseVisualStyleBackColor = true;
            this.But_Dod_Prof.Click += new System.EventHandler(this.But_Dod_Prof_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1140, 46);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 39);
            this.button8.TabIndex = 4;
            this.button8.Text = "Space tameplate 2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1222, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 74);
            this.button5.TabIndex = 4;
            this.button5.Text = "Space tameplate 1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(183, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(2, 700);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // Panel_Analizy
            // 
            this.Panel_Analizy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Panel_Analizy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Analizy.BackgroundImage")));
            this.Panel_Analizy.Controls.Add(this.But_Month);
            this.Panel_Analizy.Controls.Add(this.But_Week);
            this.Panel_Analizy.Controls.Add(this.But_Day);
            this.Panel_Analizy.Location = new System.Drawing.Point(0, 0);
            this.Panel_Analizy.Name = "Panel_Analizy";
            this.Panel_Analizy.Size = new System.Drawing.Size(1132, 88);
            this.Panel_Analizy.TabIndex = 7;
            this.Panel_Analizy.Visible = false;
            // 
            // But_Month
            // 
            this.But_Month.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("But_Month.BackgroundImage")));
            this.But_Month.FlatAppearance.BorderSize = 0;
            this.But_Month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Month.Location = new System.Drawing.Point(634, 3);
            this.But_Month.Name = "But_Month";
            this.But_Month.Size = new System.Drawing.Size(124, 82);
            this.But_Month.TabIndex = 6;
            this.But_Month.UseVisualStyleBackColor = true;
            // 
            // But_Week
            // 
            this.But_Week.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("But_Week.BackgroundImage")));
            this.But_Week.FlatAppearance.BorderSize = 0;
            this.But_Week.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Week.Location = new System.Drawing.Point(443, 3);
            this.But_Week.Name = "But_Week";
            this.But_Week.Size = new System.Drawing.Size(124, 82);
            this.But_Week.TabIndex = 5;
            this.But_Week.UseVisualStyleBackColor = true;
            // 
            // But_Day
            // 
            this.But_Day.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("But_Day.BackgroundImage")));
            this.But_Day.FlatAppearance.BorderSize = 0;
            this.But_Day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Day.Image = ((System.Drawing.Image)(resources.GetObject("But_Day.Image")));
            this.But_Day.Location = new System.Drawing.Point(252, 3);
            this.But_Day.Name = "But_Day";
            this.But_Day.Size = new System.Drawing.Size(124, 82);
            this.But_Day.TabIndex = 4;
            this.But_Day.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(26, 91);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1220, 2);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // Panel_Danych
            // 
            this.Panel_Danych.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Panel_Danych.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Danych.BackgroundImage")));
            this.Panel_Danych.Controls.Add(this.But_Usun_Dane);
            this.Panel_Danych.Controls.Add(this.But_Dod_Dane);
            this.Panel_Danych.Location = new System.Drawing.Point(0, 0);
            this.Panel_Danych.Name = "Panel_Danych";
            this.Panel_Danych.Size = new System.Drawing.Size(1132, 88);
            this.Panel_Danych.TabIndex = 8;
            this.Panel_Danych.Visible = false;
            // 
            // But_Usun_Dane
            // 
            this.But_Usun_Dane.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("But_Usun_Dane.BackgroundImage")));
            this.But_Usun_Dane.FlatAppearance.BorderSize = 0;
            this.But_Usun_Dane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Usun_Dane.Location = new System.Drawing.Point(443, 3);
            this.But_Usun_Dane.Name = "But_Usun_Dane";
            this.But_Usun_Dane.Size = new System.Drawing.Size(124, 82);
            this.But_Usun_Dane.TabIndex = 5;
            this.But_Usun_Dane.UseVisualStyleBackColor = true;
            this.But_Usun_Dane.Click += new System.EventHandler(this.But_Usun_Dane_Click);
            // 
            // But_Dod_Dane
            // 
            this.But_Dod_Dane.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("But_Dod_Dane.BackgroundImage")));
            this.But_Dod_Dane.FlatAppearance.BorderSize = 0;
            this.But_Dod_Dane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Dod_Dane.Image = ((System.Drawing.Image)(resources.GetObject("But_Dod_Dane.Image")));
            this.But_Dod_Dane.Location = new System.Drawing.Point(252, 3);
            this.But_Dod_Dane.Name = "But_Dod_Dane";
            this.But_Dod_Dane.Size = new System.Drawing.Size(124, 82);
            this.But_Dod_Dane.TabIndex = 4;
            this.But_Dod_Dane.UseVisualStyleBackColor = true;
            this.But_Dod_Dane.Click += new System.EventHandler(this.But_Dod_Dane_Click);
            // 
            // Textbox_Name
            // 
            this.Textbox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Textbox_Name.Location = new System.Drawing.Point(295, 100);
            this.Textbox_Name.Name = "Textbox_Name";
            this.Textbox_Name.Size = new System.Drawing.Size(134, 30);
            this.Textbox_Name.TabIndex = 0;
            // 
            // textBox_Wiek
            // 
            this.textBox_Wiek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Wiek.Location = new System.Drawing.Point(295, 168);
            this.textBox_Wiek.Name = "textBox_Wiek";
            this.textBox_Wiek.Size = new System.Drawing.Size(134, 30);
            this.textBox_Wiek.TabIndex = 1;
            // 
            // textBox_Waga
            // 
            this.textBox_Waga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Waga.Location = new System.Drawing.Point(295, 239);
            this.textBox_Waga.Name = "textBox_Waga";
            this.textBox_Waga.Size = new System.Drawing.Size(134, 30);
            this.textBox_Waga.TabIndex = 2;
            // 
            // textBox_Wzrost
            // 
            this.textBox_Wzrost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Wzrost.Location = new System.Drawing.Point(295, 310);
            this.textBox_Wzrost.Name = "textBox_Wzrost";
            this.textBox_Wzrost.Size = new System.Drawing.Size(134, 30);
            this.textBox_Wzrost.TabIndex = 3;
            // 
            // textBox_Dl_Kroku
            // 
            this.textBox_Dl_Kroku.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Dl_Kroku.Location = new System.Drawing.Point(295, 381);
            this.textBox_Dl_Kroku.Name = "textBox_Dl_Kroku";
            this.textBox_Dl_Kroku.Size = new System.Drawing.Size(134, 30);
            this.textBox_Dl_Kroku.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(217, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nazwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(232, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wiek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(224, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Waga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(217, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wzrost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(151, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Długość Kroku";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 62);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_Nazwa
            // 
            this.comboBox_Nazwa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Nazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Nazwa.FormattingEnabled = true;
            this.comboBox_Nazwa.Location = new System.Drawing.Point(295, 100);
            this.comboBox_Nazwa.Name = "comboBox_Nazwa";
            this.comboBox_Nazwa.Size = new System.Drawing.Size(134, 33);
            this.comboBox_Nazwa.TabIndex = 11;
            this.comboBox_Nazwa.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Nazwa_SelectionChangeCommitted);
            // 
            // Panel_Akcji_Profili
            // 
            this.Panel_Akcji_Profili.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Akcji_Profili.BackgroundImage")));
            this.Panel_Akcji_Profili.Controls.Add(this.comboBox_Nazwa);
            this.Panel_Akcji_Profili.Controls.Add(this.button1);
            this.Panel_Akcji_Profili.Controls.Add(this.label5);
            this.Panel_Akcji_Profili.Controls.Add(this.label4);
            this.Panel_Akcji_Profili.Controls.Add(this.label3);
            this.Panel_Akcji_Profili.Controls.Add(this.label2);
            this.Panel_Akcji_Profili.Controls.Add(this.label1);
            this.Panel_Akcji_Profili.Controls.Add(this.textBox_Dl_Kroku);
            this.Panel_Akcji_Profili.Controls.Add(this.textBox_Wzrost);
            this.Panel_Akcji_Profili.Controls.Add(this.textBox_Waga);
            this.Panel_Akcji_Profili.Controls.Add(this.textBox_Wiek);
            this.Panel_Akcji_Profili.Controls.Add(this.Textbox_Name);
            this.Panel_Akcji_Profili.Location = new System.Drawing.Point(184, 91);
            this.Panel_Akcji_Profili.Name = "Panel_Akcji_Profili";
            this.Panel_Akcji_Profili.Size = new System.Drawing.Size(1093, 625);
            this.Panel_Akcji_Profili.TabIndex = 9;
            this.Panel_Akcji_Profili.Visible = false;
            // 
            // Panel_Akcji_Bazy
            // 
            this.Panel_Akcji_Bazy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Akcji_Bazy.BackgroundImage")));
            this.Panel_Akcji_Bazy.Controls.Add(this.comboBox_day);
            this.Panel_Akcji_Bazy.Controls.Add(this.comboBox_month);
            this.Panel_Akcji_Bazy.Controls.Add(this.comboBox_year);
            this.Panel_Akcji_Bazy.Controls.Add(this.comboBox_Bazy_Profil);
            this.Panel_Akcji_Bazy.Controls.Add(this.button3);
            this.Panel_Akcji_Bazy.Location = new System.Drawing.Point(186, 94);
            this.Panel_Akcji_Bazy.Name = "Panel_Akcji_Bazy";
            this.Panel_Akcji_Bazy.Size = new System.Drawing.Size(1093, 625);
            this.Panel_Akcji_Bazy.TabIndex = 12;
            this.Panel_Akcji_Bazy.Visible = false;
            // 
            // comboBox_day
            // 
            this.comboBox_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_day.FormattingEnabled = true;
            this.comboBox_day.Location = new System.Drawing.Point(257, 291);
            this.comboBox_day.Name = "comboBox_day";
            this.comboBox_day.Size = new System.Drawing.Size(134, 33);
            this.comboBox_day.TabIndex = 7;
            // 
            // comboBox_month
            // 
            this.comboBox_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_month.FormattingEnabled = true;
            this.comboBox_month.Location = new System.Drawing.Point(257, 228);
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(134, 33);
            this.comboBox_month.TabIndex = 6;
            this.comboBox_month.SelectionChangeCommitted += new System.EventHandler(this.comboBox_month_SelectionChangeCommitted);
            // 
            // comboBox_year
            // 
            this.comboBox_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Location = new System.Drawing.Point(257, 168);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(134, 33);
            this.comboBox_year.TabIndex = 5;
            this.comboBox_year.SelectionChangeCommitted += new System.EventHandler(this.comboBox_year_SelectionChangeCommitted);
            // 
            // comboBox_Bazy_Profil
            // 
            this.comboBox_Bazy_Profil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Bazy_Profil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_Bazy_Profil.FormattingEnabled = true;
            this.comboBox_Bazy_Profil.Location = new System.Drawing.Point(257, 110);
            this.comboBox_Bazy_Profil.Name = "comboBox_Bazy_Profil";
            this.comboBox_Bazy_Profil.Size = new System.Drawing.Size(134, 33);
            this.comboBox_Bazy_Profil.TabIndex = 1;
            this.comboBox_Bazy_Profil.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Bazy_Profil_SelectionChangeCommitted);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(279, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 36);
            this.button3.TabIndex = 0;
            this.button3.Text = "Dodaj/Usun";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel_Danych);
            this.Controls.Add(this.Panel_Analizy);
            this.Controls.Add(this.Panel_Profili);
            this.Controls.Add(this.Panel_Akcji_Bazy);
            this.Controls.Add(this.Panel_Akcji_Profili);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Okno";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.But_Mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.But_Exit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.Panel_Profili.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Panel_Analizy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.Panel_Danych.ResumeLayout(false);
            this.Panel_Akcji_Profili.ResumeLayout(false);
            this.Panel_Akcji_Profili.PerformLayout();
            this.Panel_Akcji_Bazy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox But_Exit;
        private System.Windows.Forms.PictureBox But_Mini;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Panel_Profili;
        private System.Windows.Forms.Button But_Zarz_Dan;
        private System.Windows.Forms.Button But_Analiza_Danych;
        private System.Windows.Forms.Button But_Zarz_Prof;
        private System.Windows.Forms.Button But_Usun_Prof;
        private System.Windows.Forms.Button But_Edyt_Prof;
        private System.Windows.Forms.Button But_Dod_Prof;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel Panel_Analizy;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button But_Month;
        private System.Windows.Forms.Button But_Week;
        private System.Windows.Forms.Button But_Day;
        private System.Windows.Forms.Panel Panel_Danych;
        private System.Windows.Forms.Button But_Usun_Dane;
        private System.Windows.Forms.Button But_Dod_Dane;
        private System.Windows.Forms.TextBox Textbox_Name;
        private System.Windows.Forms.TextBox textBox_Wiek;
        private System.Windows.Forms.TextBox textBox_Waga;
        private System.Windows.Forms.TextBox textBox_Wzrost;
        private System.Windows.Forms.TextBox textBox_Dl_Kroku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_Nazwa;
        private System.Windows.Forms.Panel Panel_Akcji_Profili;
        private System.Windows.Forms.Panel Panel_Akcji_Bazy;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox_Bazy_Profil;
        private System.Windows.Forms.ComboBox comboBox_day;
        private System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.ComboBox comboBox_year;
    }
}

