namespace WaterMeter
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numInitial = new System.Windows.Forms.NumericUpDown();
            this.numFinal = new System.Windows.Forms.NumericUpDown();
            this.numI1 = new System.Windows.Forms.NumericUpDown();
            this.numI2 = new System.Windows.Forms.NumericUpDown();
            this.numI3 = new System.Windows.Forms.NumericUpDown();
            this.numI4 = new System.Windows.Forms.NumericUpDown();
            this.numF1 = new System.Windows.Forms.NumericUpDown();
            this.numF2 = new System.Windows.Forms.NumericUpDown();
            this.numF3 = new System.Windows.Forms.NumericUpDown();
            this.numF4 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLiters = new System.Windows.Forms.Label();
            this.lblCubic = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtChargeRate = new System.Windows.Forms.TextBox();
            this.txtChargeLiters = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numI3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numI4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 208);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // numInitial
            // 
            this.numInitial.BackColor = System.Drawing.Color.Black;
            this.numInitial.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numInitial.ForeColor = System.Drawing.Color.Cyan;
            this.numInitial.Location = new System.Drawing.Point(77, 254);
            this.numInitial.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numInitial.Name = "numInitial";
            this.numInitial.Size = new System.Drawing.Size(120, 35);
            this.numInitial.TabIndex = 2;
            this.numInitial.ThousandsSeparator = true;
            this.numInitial.ValueChanged += new System.EventHandler(this.numInitial_ValueChanged);
            this.numInitial.Click += new System.EventHandler(this.numInitial_Click);
            // 
            // numFinal
            // 
            this.numFinal.BackColor = System.Drawing.Color.Black;
            this.numFinal.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFinal.ForeColor = System.Drawing.Color.Cyan;
            this.numFinal.Location = new System.Drawing.Point(306, 254);
            this.numFinal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFinal.Name = "numFinal";
            this.numFinal.Size = new System.Drawing.Size(120, 35);
            this.numFinal.TabIndex = 3;
            this.numFinal.ThousandsSeparator = true;
            this.numFinal.ValueChanged += new System.EventHandler(this.numFinal_ValueChanged);
            this.numFinal.Click += new System.EventHandler(this.numFinal_Click);
            // 
            // numI1
            // 
            this.numI1.BackColor = System.Drawing.Color.Black;
            this.numI1.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numI1.ForeColor = System.Drawing.Color.Cyan;
            this.numI1.Location = new System.Drawing.Point(166, 295);
            this.numI1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numI1.Name = "numI1";
            this.numI1.Size = new System.Drawing.Size(31, 27);
            this.numI1.TabIndex = 4;
            this.numI1.ValueChanged += new System.EventHandler(this.numI1_ValueChanged);
            this.numI1.Click += new System.EventHandler(this.numI1_Click);
            // 
            // numI2
            // 
            this.numI2.BackColor = System.Drawing.Color.Black;
            this.numI2.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numI2.ForeColor = System.Drawing.Color.Cyan;
            this.numI2.Location = new System.Drawing.Point(129, 307);
            this.numI2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numI2.Name = "numI2";
            this.numI2.Size = new System.Drawing.Size(31, 27);
            this.numI2.TabIndex = 5;
            this.numI2.ValueChanged += new System.EventHandler(this.numI2_ValueChanged);
            this.numI2.Click += new System.EventHandler(this.numI2_Click);
            // 
            // numI3
            // 
            this.numI3.BackColor = System.Drawing.Color.Black;
            this.numI3.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numI3.ForeColor = System.Drawing.Color.Cyan;
            this.numI3.Location = new System.Drawing.Point(92, 319);
            this.numI3.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numI3.Name = "numI3";
            this.numI3.Size = new System.Drawing.Size(31, 27);
            this.numI3.TabIndex = 6;
            this.numI3.ValueChanged += new System.EventHandler(this.numI3_ValueChanged);
            this.numI3.Click += new System.EventHandler(this.numI3_Click);
            // 
            // numI4
            // 
            this.numI4.BackColor = System.Drawing.Color.Black;
            this.numI4.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numI4.ForeColor = System.Drawing.Color.Cyan;
            this.numI4.Location = new System.Drawing.Point(55, 332);
            this.numI4.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numI4.Name = "numI4";
            this.numI4.Size = new System.Drawing.Size(31, 27);
            this.numI4.TabIndex = 7;
            this.numI4.ValueChanged += new System.EventHandler(this.numI4_ValueChanged);
            this.numI4.Click += new System.EventHandler(this.numI4_Click);
            // 
            // numF1
            // 
            this.numF1.BackColor = System.Drawing.Color.Black;
            this.numF1.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numF1.ForeColor = System.Drawing.Color.Cyan;
            this.numF1.Location = new System.Drawing.Point(395, 295);
            this.numF1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numF1.Name = "numF1";
            this.numF1.Size = new System.Drawing.Size(31, 27);
            this.numF1.TabIndex = 8;
            this.numF1.ValueChanged += new System.EventHandler(this.numF1_ValueChanged);
            this.numF1.Click += new System.EventHandler(this.numF1_Click);
            // 
            // numF2
            // 
            this.numF2.BackColor = System.Drawing.Color.Black;
            this.numF2.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numF2.ForeColor = System.Drawing.Color.Cyan;
            this.numF2.Location = new System.Drawing.Point(358, 307);
            this.numF2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numF2.Name = "numF2";
            this.numF2.Size = new System.Drawing.Size(31, 27);
            this.numF2.TabIndex = 9;
            this.numF2.ValueChanged += new System.EventHandler(this.numF2_ValueChanged);
            this.numF2.Click += new System.EventHandler(this.numF2_Click);
            // 
            // numF3
            // 
            this.numF3.BackColor = System.Drawing.Color.Black;
            this.numF3.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numF3.ForeColor = System.Drawing.Color.Cyan;
            this.numF3.Location = new System.Drawing.Point(321, 319);
            this.numF3.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numF3.Name = "numF3";
            this.numF3.Size = new System.Drawing.Size(31, 27);
            this.numF3.TabIndex = 10;
            this.numF3.ValueChanged += new System.EventHandler(this.numF3_ValueChanged);
            this.numF3.Click += new System.EventHandler(this.numF3_Click);
            // 
            // numF4
            // 
            this.numF4.BackColor = System.Drawing.Color.Black;
            this.numF4.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numF4.ForeColor = System.Drawing.Color.Cyan;
            this.numF4.Location = new System.Drawing.Point(284, 332);
            this.numF4.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numF4.Name = "numF4";
            this.numF4.Size = new System.Drawing.Size(31, 27);
            this.numF4.TabIndex = 11;
            this.numF4.ValueChanged += new System.EventHandler(this.numF4_ValueChanged);
            this.numF4.Click += new System.EventHandler(this.numF4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Liters:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cubic Meter:";
            // 
            // lblLiters
            // 
            this.lblLiters.AutoSize = true;
            this.lblLiters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiters.ForeColor = System.Drawing.Color.Lime;
            this.lblLiters.Location = new System.Drawing.Point(89, 429);
            this.lblLiters.Name = "lblLiters";
            this.lblLiters.Size = new System.Drawing.Size(24, 25);
            this.lblLiters.TabIndex = 14;
            this.lblLiters.Text = "0";
            // 
            // lblCubic
            // 
            this.lblCubic.AutoSize = true;
            this.lblCubic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCubic.ForeColor = System.Drawing.Color.Lime;
            this.lblCubic.Location = new System.Drawing.Point(164, 463);
            this.lblCubic.Name = "lblCubic";
            this.lblCubic.Size = new System.Drawing.Size(24, 25);
            this.lblCubic.TabIndex = 15;
            this.lblCubic.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Initial Reading";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Final Reading";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 515);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Amount";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Red;
            this.lblAmount.Location = new System.Drawing.Point(109, 515);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(25, 25);
            this.lblAmount.TabIndex = 19;
            this.lblAmount.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtChargeRate
            // 
            this.txtChargeRate.Location = new System.Drawing.Point(125, 382);
            this.txtChargeRate.Name = "txtChargeRate";
            this.txtChargeRate.Size = new System.Drawing.Size(35, 20);
            this.txtChargeRate.TabIndex = 21;
            this.txtChargeRate.Text = "20";
            this.txtChargeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChargeRate.Click += new System.EventHandler(this.txtChargeRate_Click);
            this.txtChargeRate.TextChanged += new System.EventHandler(this.txtChargeRate_TextChanged);
            // 
            // txtChargeLiters
            // 
            this.txtChargeLiters.Location = new System.Drawing.Point(194, 382);
            this.txtChargeLiters.Name = "txtChargeLiters";
            this.txtChargeLiters.Size = new System.Drawing.Size(53, 20);
            this.txtChargeLiters.TabIndex = 22;
            this.txtChargeLiters.Text = "200";
            this.txtChargeLiters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChargeLiters.Click += new System.EventHandler(this.txtChargeLiters_Click);
            this.txtChargeLiters.TextChanged += new System.EventHandler(this.txtChargeLiters_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Charge Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "per";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "liters";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(504, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(55, 17);
            this.statusStrip.Text = "statusBar";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 573);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtChargeLiters);
            this.Controls.Add(this.txtChargeRate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCubic);
            this.Controls.Add(this.lblLiters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numF4);
            this.Controls.Add(this.numF3);
            this.Controls.Add(this.numF2);
            this.Controls.Add(this.numF1);
            this.Controls.Add(this.numI4);
            this.Controls.Add(this.numI3);
            this.Controls.Add(this.numI2);
            this.Controls.Add(this.numI1);
            this.Controls.Add(this.numFinal);
            this.Controls.Add(this.numInitial);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Maynilad Water Meter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.LocationChanged += new System.EventHandler(this.frmMain_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numI3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numI4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numF4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numInitial;
        private System.Windows.Forms.NumericUpDown numFinal;
        private System.Windows.Forms.NumericUpDown numI1;
        private System.Windows.Forms.NumericUpDown numI2;
        private System.Windows.Forms.NumericUpDown numI3;
        private System.Windows.Forms.NumericUpDown numI4;
        private System.Windows.Forms.NumericUpDown numF1;
        private System.Windows.Forms.NumericUpDown numF2;
        private System.Windows.Forms.NumericUpDown numF3;
        private System.Windows.Forms.NumericUpDown numF4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLiters;
        private System.Windows.Forms.Label lblCubic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtChargeRate;
        private System.Windows.Forms.TextBox txtChargeLiters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip;
    }
}

