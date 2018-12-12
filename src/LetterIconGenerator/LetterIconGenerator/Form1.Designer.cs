namespace LetterIconGenerator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTSaveImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CBType = new System.Windows.Forms.ComboBox();
            this.PImage = new System.Windows.Forms.Panel();
            this.CDColor = new System.Windows.Forms.ColorDialog();
            this.TBLetter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBBackColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBLetterColor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTSaveImage
            // 
            this.BTSaveImage.Location = new System.Drawing.Point(61, 165);
            this.BTSaveImage.Name = "BTSaveImage";
            this.BTSaveImage.Size = new System.Drawing.Size(75, 23);
            this.BTSaveImage.TabIndex = 14;
            this.BTSaveImage.Text = "Save image";
            this.BTSaveImage.UseVisualStyleBackColor = true;
            this.BTSaveImage.Click += new System.EventHandler(this.BTSaveImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Image type:";
            // 
            // CBType
            // 
            this.CBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBType.FormattingEnabled = true;
            this.CBType.Items.AddRange(new object[] {
            "Icon",
            "Png",
            "Jpeg",
            "Bmp",
            "Gif"});
            this.CBType.Location = new System.Drawing.Point(78, 41);
            this.CBType.Name = "CBType";
            this.CBType.Size = new System.Drawing.Size(121, 21);
            this.CBType.TabIndex = 11;
            // 
            // PImage
            // 
            this.PImage.Location = new System.Drawing.Point(0, 0);
            this.PImage.Margin = new System.Windows.Forms.Padding(0);
            this.PImage.Name = "PImage";
            this.PImage.Size = new System.Drawing.Size(256, 256);
            this.PImage.TabIndex = 9;
            // 
            // TBLetter
            // 
            this.TBLetter.Location = new System.Drawing.Point(78, 68);
            this.TBLetter.Name = "TBLetter";
            this.TBLetter.Size = new System.Drawing.Size(121, 20);
            this.TBLetter.TabIndex = 16;
            this.TBLetter.Text = "L";
            this.TBLetter.TextChanged += new System.EventHandler(this.TBLetter_TextChanged);
            this.TBLetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBLetter_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Letter:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Back color:";
            // 
            // TBBackColor
            // 
            this.TBBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TBBackColor.Location = new System.Drawing.Point(78, 98);
            this.TBBackColor.Name = "TBBackColor";
            this.TBBackColor.ReadOnly = true;
            this.TBBackColor.Size = new System.Drawing.Size(121, 20);
            this.TBBackColor.TabIndex = 18;
            this.TBBackColor.Text = "Select color";
            this.TBBackColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBBackColor.Click += new System.EventHandler(this.TBBackColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Letter color:";
            // 
            // TBLetterColor
            // 
            this.TBLetterColor.BackColor = System.Drawing.Color.White;
            this.TBLetterColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TBLetterColor.Location = new System.Drawing.Point(78, 124);
            this.TBLetterColor.Name = "TBLetterColor";
            this.TBLetterColor.ReadOnly = true;
            this.TBLetterColor.Size = new System.Drawing.Size(121, 20);
            this.TBLetterColor.TabIndex = 20;
            this.TBLetterColor.Text = "Select color";
            this.TBLetterColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBLetterColor.Click += new System.EventHandler(this.TBLetterColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CBType);
            this.groupBox1.Controls.Add(this.TBLetterColor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TBBackColor);
            this.groupBox1.Controls.Add(this.BTSaveImage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TBLetter);
            this.groupBox1.Location = new System.Drawing.Point(262, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 229);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 256);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letter icon generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTSaveImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBType;
        private System.Windows.Forms.Panel PImage;
        private System.Windows.Forms.ColorDialog CDColor;
        private System.Windows.Forms.TextBox TBLetter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBBackColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBLetterColor;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

