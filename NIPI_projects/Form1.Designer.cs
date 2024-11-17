namespace NIPI_projects
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OFP_WN = new System.Windows.Forms.DataGridView();
            this.S_w = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFP_water = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFP_neft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFP_GN = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.DeltaP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.k = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.muG = new System.Windows.Forms.TextBox();
            this.muW = new System.Windows.Forms.TextBox();
            this.muN = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BG = new System.Windows.Forms.TextBox();
            this.BW = new System.Windows.Forms.TextBox();
            this.BN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Rs = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.target_G = new System.Windows.Forms.TextBox();
            this.target_W = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OFP_WN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OFP_GN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // OFP_WN
            // 
            this.OFP_WN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OFP_WN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.S_w,
            this.OFP_water,
            this.OFP_neft});
            this.OFP_WN.Location = new System.Drawing.Point(12, 29);
            this.OFP_WN.MultiSelect = false;
            this.OFP_WN.Name = "OFP_WN";
            this.OFP_WN.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OFP_WN.Size = new System.Drawing.Size(385, 150);
            this.OFP_WN.TabIndex = 4;
            // 
            // S_w
            // 
            this.S_w.HeaderText = "Водонасыщенность";
            this.S_w.Name = "S_w";
            this.S_w.Width = 110;
            // 
            // OFP_water
            // 
            this.OFP_water.HeaderText = "ОФП по воде";
            this.OFP_water.Name = "OFP_water";
            this.OFP_water.Width = 110;
            // 
            // OFP_neft
            // 
            this.OFP_neft.HeaderText = "ОФП по нефти";
            this.OFP_neft.Name = "OFP_neft";
            this.OFP_neft.Width = 120;
            // 
            // OFP_GN
            // 
            this.OFP_GN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OFP_GN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.OFP_GN.Location = new System.Drawing.Point(403, 29);
            this.OFP_GN.Name = "OFP_GN";
            this.OFP_GN.Size = new System.Drawing.Size(385, 150);
            this.OFP_GN.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Газонасыщенность";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ОФП по газу";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ОФП по нефти";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeltaP
            // 
            this.DeltaP.Location = new System.Drawing.Point(180, 208);
            this.DeltaP.Name = "DeltaP";
            this.DeltaP.Size = new System.Drawing.Size(70, 20);
            this.DeltaP.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Депрессия на пласт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Безразмерный \r\nкоэффициент продуктивнсти";
            // 
            // JD
            // 
            this.JD.Location = new System.Drawing.Point(180, 243);
            this.JD.Name = "JD";
            this.JD.Size = new System.Drawing.Size(69, 20);
            this.JD.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Абсолютная\r\nпроницаемость пласта\r\n";
            // 
            // k
            // 
            this.k.Location = new System.Drawing.Point(180, 278);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(70, 20);
            this.k.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Эффективная толщина \r\nпласта";
            // 
            // h
            // 
            this.h.Location = new System.Drawing.Point(180, 316);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(70, 20);
            this.h.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.textBox17);
            this.groupBox1.Controls.Add(this.textBox18);
            this.groupBox1.Controls.Add(this.textBox19);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.muG);
            this.groupBox1.Controls.Add(this.muW);
            this.groupBox1.Controls.Add(this.muN);
            this.groupBox1.Location = new System.Drawing.Point(278, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 90);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вязкости";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(217, 170);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Газа";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(128, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Воды";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(34, 170);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "Нефти";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(200, 138);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(70, 20);
            this.textBox17.TabIndex = 26;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(111, 138);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(70, 20);
            this.textBox18.TabIndex = 25;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(21, 138);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(70, 20);
            this.textBox19.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Газа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Воды";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Нефти";
            // 
            // muG
            // 
            this.muG.Location = new System.Drawing.Point(197, 31);
            this.muG.Name = "muG";
            this.muG.Size = new System.Drawing.Size(70, 20);
            this.muG.TabIndex = 18;
            // 
            // muW
            // 
            this.muW.Location = new System.Drawing.Point(108, 31);
            this.muW.Name = "muW";
            this.muW.Size = new System.Drawing.Size(70, 20);
            this.muW.TabIndex = 17;
            // 
            // muN
            // 
            this.muN.Location = new System.Drawing.Point(18, 31);
            this.muN.Name = "muN";
            this.muN.Size = new System.Drawing.Size(70, 20);
            this.muN.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.BG);
            this.groupBox2.Controls.Add(this.BW);
            this.groupBox2.Controls.Add(this.BN);
            this.groupBox2.Location = new System.Drawing.Point(278, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 90);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Объемные коэффициенты";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Газа";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Воды";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Нефти";
            // 
            // BG
            // 
            this.BG.Location = new System.Drawing.Point(197, 31);
            this.BG.Name = "BG";
            this.BG.Size = new System.Drawing.Size(70, 20);
            this.BG.TabIndex = 18;
            // 
            // BW
            // 
            this.BW.Location = new System.Drawing.Point(108, 31);
            this.BW.Name = "BW";
            this.BW.Size = new System.Drawing.Size(70, 20);
            this.BW.TabIndex = 17;
            // 
            // BN
            // 
            this.BN.Location = new System.Drawing.Point(18, 31);
            this.BN.Name = "BN";
            this.BN.Size = new System.Drawing.Size(70, 20);
            this.BN.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Газосодержание нефти";
            // 
            // Rs
            // 
            this.Rs.Location = new System.Drawing.Point(180, 354);
            this.Rs.Name = "Rs";
            this.Rs.Size = new System.Drawing.Size(70, 20);
            this.Rs.TabIndex = 23;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.target_G);
            this.groupBox3.Controls.Add(this.target_W);
            this.groupBox3.Location = new System.Drawing.Point(589, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 198);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Целевые показатели";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Обводненность";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Газовый фактор";
            // 
            // target_G
            // 
            this.target_G.Location = new System.Drawing.Point(42, 122);
            this.target_G.Name = "target_G";
            this.target_G.Size = new System.Drawing.Size(100, 20);
            this.target_G.TabIndex = 1;
            // 
            // target_W
            // 
            this.target_W.Location = new System.Drawing.Point(42, 42);
            this.target_W.Name = "target_W";
            this.target_W.Size = new System.Drawing.Size(100, 20);
            this.target_W.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(154, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Вода-нефть";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(557, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Газ-нефть";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Rs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.h);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.k);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeltaP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OFP_GN);
            this.Controls.Add(this.OFP_WN);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OFP_WN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OFP_GN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView OFP_WN;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_w;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFP_water;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFP_neft;
        private System.Windows.Forms.DataGridView OFP_GN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DeltaP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox JD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox k;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox h;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox BG;
        private System.Windows.Forms.TextBox BW;
        private System.Windows.Forms.TextBox BN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox muG;
        private System.Windows.Forms.TextBox muW;
        private System.Windows.Forms.TextBox muN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Rs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox target_G;
        private System.Windows.Forms.TextBox target_W;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

