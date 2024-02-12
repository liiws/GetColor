namespace GetColor
{
    partial class fmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
			this.pnColor = new System.Windows.Forms.Panel();
			this.cbAlwaysOnTop = new System.Windows.Forms.CheckBox();
			this.pnZoom = new System.Windows.Forms.Panel();
			this.rbtn2x = new System.Windows.Forms.RadioButton();
			this.rbtn4x = new System.Windows.Forms.RadioButton();
			this.rbtn8x = new System.Windows.Forms.RadioButton();
			this.rbtn16x = new System.Windows.Forms.RadioButton();
			this.rbtn0x = new System.Windows.Forms.RadioButton();
			this.tbColor = new System.Windows.Forms.TextBox();
			this.cbHash = new System.Windows.Forms.CheckBox();
			this.btnColor = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbB = new System.Windows.Forms.Label();
			this.lbG = new System.Windows.Forms.Label();
			this.lbR = new System.Windows.Forms.Label();
			this.cdColor = new System.Windows.Forms.ColorDialog();
			this.lbHexR = new System.Windows.Forms.Label();
			this.lbHexG = new System.Windows.Forms.Label();
			this.lbHexB = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lbCyan = new System.Windows.Forms.Label();
			this.lbMagenta = new System.Windows.Forms.Label();
			this.lbYellow = new System.Windows.Forms.Label();
			this.lbBlack = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pnColor
			// 
			this.pnColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnColor.Location = new System.Drawing.Point(191, 12);
			this.pnColor.Name = "pnColor";
			this.pnColor.Size = new System.Drawing.Size(80, 80);
			this.pnColor.TabIndex = 2;
			// 
			// cbAlwaysOnTop
			// 
			this.cbAlwaysOnTop.AutoSize = true;
			this.cbAlwaysOnTop.Checked = true;
			this.cbAlwaysOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbAlwaysOnTop.Location = new System.Drawing.Point(233, 171);
			this.cbAlwaysOnTop.Name = "cbAlwaysOnTop";
			this.cbAlwaysOnTop.Size = new System.Drawing.Size(92, 17);
			this.cbAlwaysOnTop.TabIndex = 3;
			this.cbAlwaysOnTop.Text = "Always on top";
			this.cbAlwaysOnTop.UseVisualStyleBackColor = true;
			this.cbAlwaysOnTop.Click += new System.EventHandler(this.cbAlwaysOnTop_Click);
			// 
			// pnZoom
			// 
			this.pnZoom.Location = new System.Drawing.Point(12, 12);
			this.pnZoom.Name = "pnZoom";
			this.pnZoom.Size = new System.Drawing.Size(128, 128);
			this.pnZoom.TabIndex = 4;
			this.pnZoom.Paint += new System.Windows.Forms.PaintEventHandler(this.pnZoom_Paint);
			this.pnZoom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnZoom_MouseClick);
			// 
			// rbtn2x
			// 
			this.rbtn2x.AutoSize = true;
			this.rbtn2x.Location = new System.Drawing.Point(146, 35);
			this.rbtn2x.Name = "rbtn2x";
			this.rbtn2x.Size = new System.Drawing.Size(39, 17);
			this.rbtn2x.TabIndex = 5;
			this.rbtn2x.TabStop = true;
			this.rbtn2x.Text = "2 x";
			this.rbtn2x.UseVisualStyleBackColor = true;
			this.rbtn2x.Click += new System.EventHandler(this.rbtn2x_Click);
			// 
			// rbtn4x
			// 
			this.rbtn4x.AutoSize = true;
			this.rbtn4x.Location = new System.Drawing.Point(146, 58);
			this.rbtn4x.Name = "rbtn4x";
			this.rbtn4x.Size = new System.Drawing.Size(39, 17);
			this.rbtn4x.TabIndex = 7;
			this.rbtn4x.TabStop = true;
			this.rbtn4x.Text = "4 x";
			this.rbtn4x.UseVisualStyleBackColor = true;
			this.rbtn4x.Click += new System.EventHandler(this.rbtn4x_Click);
			// 
			// rbtn8x
			// 
			this.rbtn8x.AutoSize = true;
			this.rbtn8x.Checked = true;
			this.rbtn8x.Location = new System.Drawing.Point(146, 81);
			this.rbtn8x.Name = "rbtn8x";
			this.rbtn8x.Size = new System.Drawing.Size(39, 17);
			this.rbtn8x.TabIndex = 8;
			this.rbtn8x.TabStop = true;
			this.rbtn8x.Text = "8 x";
			this.rbtn8x.UseVisualStyleBackColor = true;
			this.rbtn8x.Click += new System.EventHandler(this.rbtn8x_Click);
			// 
			// rbtn16x
			// 
			this.rbtn16x.AutoSize = true;
			this.rbtn16x.Location = new System.Drawing.Point(146, 104);
			this.rbtn16x.Name = "rbtn16x";
			this.rbtn16x.Size = new System.Drawing.Size(45, 17);
			this.rbtn16x.TabIndex = 9;
			this.rbtn16x.TabStop = true;
			this.rbtn16x.Text = "16 x";
			this.rbtn16x.UseVisualStyleBackColor = true;
			this.rbtn16x.Click += new System.EventHandler(this.rbtn16x_Click);
			// 
			// rbtn0x
			// 
			this.rbtn0x.AutoSize = true;
			this.rbtn0x.Location = new System.Drawing.Point(146, 12);
			this.rbtn0x.Name = "rbtn0x";
			this.rbtn0x.Size = new System.Drawing.Size(39, 17);
			this.rbtn0x.TabIndex = 10;
			this.rbtn0x.TabStop = true;
			this.rbtn0x.Text = "Off";
			this.rbtn0x.UseVisualStyleBackColor = true;
			this.rbtn0x.Click += new System.EventHandler(this.rbtn0x_Click);
			// 
			// tbColor
			// 
			this.tbColor.Location = new System.Drawing.Point(73, 147);
			this.tbColor.Name = "tbColor";
			this.tbColor.Size = new System.Drawing.Size(252, 20);
			this.tbColor.TabIndex = 11;
			this.tbColor.TextChanged += new System.EventHandler(this.tbColor_TextChanged);
			// 
			// cbHash
			// 
			this.cbHash.AutoSize = true;
			this.cbHash.Checked = true;
			this.cbHash.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbHash.Location = new System.Drawing.Point(12, 172);
			this.cbHash.Name = "cbHash";
			this.cbHash.Size = new System.Drawing.Size(71, 17);
			this.cbHash.TabIndex = 12;
			this.cbHash.Text = "Add hash";
			this.cbHash.UseVisualStyleBackColor = true;
			this.cbHash.Click += new System.EventHandler(this.cbHash_Click);
			// 
			// btnColor
			// 
			this.btnColor.Location = new System.Drawing.Point(12, 144);
			this.btnColor.Name = "btnColor";
			this.btnColor.Size = new System.Drawing.Size(55, 23);
			this.btnColor.TabIndex = 13;
			this.btnColor.Text = "Color...";
			this.btnColor.UseVisualStyleBackColor = true;
			this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(239, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "R:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(239, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(18, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "G:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(239, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 13);
			this.label3.TabIndex = 17;
			this.label3.Text = "B:";
			// 
			// lbB
			// 
			this.lbB.AutoSize = true;
			this.lbB.Location = new System.Drawing.Point(263, 121);
			this.lbB.Name = "lbB";
			this.lbB.Size = new System.Drawing.Size(13, 13);
			this.lbB.TabIndex = 20;
			this.lbB.Text = "0";
			// 
			// lbG
			// 
			this.lbG.AutoSize = true;
			this.lbG.Location = new System.Drawing.Point(263, 108);
			this.lbG.Name = "lbG";
			this.lbG.Size = new System.Drawing.Size(13, 13);
			this.lbG.TabIndex = 19;
			this.lbG.Text = "0";
			// 
			// lbR
			// 
			this.lbR.AutoSize = true;
			this.lbR.Location = new System.Drawing.Point(263, 95);
			this.lbR.Name = "lbR";
			this.lbR.Size = new System.Drawing.Size(13, 13);
			this.lbR.TabIndex = 18;
			this.lbR.Text = "0";
			// 
			// lbHexR
			// 
			this.lbHexR.AutoSize = true;
			this.lbHexR.Location = new System.Drawing.Point(296, 95);
			this.lbHexR.Name = "lbHexR";
			this.lbHexR.Size = new System.Drawing.Size(19, 13);
			this.lbHexR.TabIndex = 21;
			this.lbHexR.Text = "00";
			// 
			// lbHexG
			// 
			this.lbHexG.AutoSize = true;
			this.lbHexG.Location = new System.Drawing.Point(296, 108);
			this.lbHexG.Name = "lbHexG";
			this.lbHexG.Size = new System.Drawing.Size(19, 13);
			this.lbHexG.TabIndex = 22;
			this.lbHexG.Text = "00";
			// 
			// lbHexB
			// 
			this.lbHexB.AutoSize = true;
			this.lbHexB.Location = new System.Drawing.Point(296, 121);
			this.lbHexB.Name = "lbHexB";
			this.lbHexB.Size = new System.Drawing.Size(19, 13);
			this.lbHexB.TabIndex = 23;
			this.lbHexB.Text = "00";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::GetColor.Properties.Resources.question;
			this.pictureBox1.Location = new System.Drawing.Point(158, 172);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(16, 16);
			this.pictureBox1.TabIndex = 24;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(277, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 13);
			this.label4.TabIndex = 25;
			this.label4.Text = "C:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(277, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(19, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = "M:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(277, 36);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 13);
			this.label6.TabIndex = 27;
			this.label6.Text = "Y:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(277, 49);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(17, 13);
			this.label7.TabIndex = 28;
			this.label7.Text = "K:";
			// 
			// lbCyan
			// 
			this.lbCyan.AutoSize = true;
			this.lbCyan.Location = new System.Drawing.Point(300, 10);
			this.lbCyan.Name = "lbCyan";
			this.lbCyan.Size = new System.Drawing.Size(13, 13);
			this.lbCyan.TabIndex = 29;
			this.lbCyan.Text = "0";
			// 
			// lbMagenta
			// 
			this.lbMagenta.AutoSize = true;
			this.lbMagenta.Location = new System.Drawing.Point(300, 23);
			this.lbMagenta.Name = "lbMagenta";
			this.lbMagenta.Size = new System.Drawing.Size(13, 13);
			this.lbMagenta.TabIndex = 30;
			this.lbMagenta.Text = "0";
			// 
			// lbYellow
			// 
			this.lbYellow.AutoSize = true;
			this.lbYellow.Location = new System.Drawing.Point(300, 36);
			this.lbYellow.Name = "lbYellow";
			this.lbYellow.Size = new System.Drawing.Size(13, 13);
			this.lbYellow.TabIndex = 31;
			this.lbYellow.Text = "0";
			// 
			// lbBlack
			// 
			this.lbBlack.AutoSize = true;
			this.lbBlack.Location = new System.Drawing.Point(300, 49);
			this.lbBlack.Name = "lbBlack";
			this.lbBlack.Size = new System.Drawing.Size(13, 13);
			this.lbBlack.TabIndex = 32;
			this.lbBlack.Text = "0";
			// 
			// fmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 195);
			this.Controls.Add(this.lbBlack);
			this.Controls.Add(this.lbYellow);
			this.Controls.Add(this.lbMagenta);
			this.Controls.Add(this.lbCyan);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lbHexB);
			this.Controls.Add(this.lbHexG);
			this.Controls.Add(this.lbHexR);
			this.Controls.Add(this.lbB);
			this.Controls.Add(this.lbG);
			this.Controls.Add(this.lbR);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnColor);
			this.Controls.Add(this.cbHash);
			this.Controls.Add(this.tbColor);
			this.Controls.Add(this.rbtn0x);
			this.Controls.Add(this.rbtn16x);
			this.Controls.Add(this.rbtn8x);
			this.Controls.Add(this.rbtn4x);
			this.Controls.Add(this.rbtn2x);
			this.Controls.Add(this.pnZoom);
			this.Controls.Add(this.cbAlwaysOnTop);
			this.Controls.Add(this.pnColor);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "fmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GetColor v1.1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnColor;
        private System.Windows.Forms.CheckBox cbAlwaysOnTop;
        private System.Windows.Forms.Panel pnZoom;
        private System.Windows.Forms.RadioButton rbtn2x;
        private System.Windows.Forms.RadioButton rbtn4x;
        private System.Windows.Forms.RadioButton rbtn8x;
        private System.Windows.Forms.RadioButton rbtn16x;
        private System.Windows.Forms.RadioButton rbtn0x;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.CheckBox cbHash;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbG;
        private System.Windows.Forms.Label lbR;
        private System.Windows.Forms.ColorDialog cdColor;
        private System.Windows.Forms.Label lbHexR;
        private System.Windows.Forms.Label lbHexG;
        private System.Windows.Forms.Label lbHexB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCyan;
        private System.Windows.Forms.Label lbMagenta;
        private System.Windows.Forms.Label lbYellow;
        private System.Windows.Forms.Label lbBlack;
    }
}

