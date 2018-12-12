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
            this.BTSaveImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CBSize = new System.Windows.Forms.ComboBox();
            this.PImage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BTSaveImage
            // 
            this.BTSaveImage.Location = new System.Drawing.Point(361, 404);
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
            this.label2.Location = new System.Drawing.Point(293, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Image type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Size:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "16x16",
            "32x32",
            "64x64",
            "256x256",
            "512x512"});
            this.comboBox1.Location = new System.Drawing.Point(361, 338);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // CBSize
            // 
            this.CBSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSize.FormattingEnabled = true;
            this.CBSize.Items.AddRange(new object[] {
            "16x16",
            "32x32",
            "64x64",
            "256x256",
            "512x512"});
            this.CBSize.Location = new System.Drawing.Point(361, 298);
            this.CBSize.Name = "CBSize";
            this.CBSize.Size = new System.Drawing.Size(121, 21);
            this.CBSize.TabIndex = 10;
            // 
            // PImage
            // 
            this.PImage.Location = new System.Drawing.Point(272, 24);
            this.PImage.Name = "PImage";
            this.PImage.Size = new System.Drawing.Size(256, 256);
            this.PImage.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTSaveImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CBSize);
            this.Controls.Add(this.PImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTSaveImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox CBSize;
        private System.Windows.Forms.Panel PImage;
    }
}

