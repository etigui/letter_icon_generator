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
            this.button1 = new System.Windows.Forms.Button();
            this.WB_html = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WB_html
            // 
            this.WB_html.Location = new System.Drawing.Point(181, 92);
            this.WB_html.MinimumSize = new System.Drawing.Size(20, 20);
            this.WB_html.Name = "WB_html";
            this.WB_html.ScriptErrorsSuppressed = true;
            this.WB_html.Size = new System.Drawing.Size(1197, 835);
            this.WB_html.TabIndex = 1;
            this.WB_html.Url = new System.Uri("http://localhost:7070/", System.UriKind.Absolute);
            this.WB_html.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WB_html_DocumentCompleted);
            this.WB_html.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WB_html_Navigated);
            this.WB_html.RegionChanged += new System.EventHandler(this.WB_html_RegionChanged);
            this.WB_html.ParentChanged += new System.EventHandler(this.WB_html_ParentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 966);
            this.Controls.Add(this.WB_html);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Letter Icon Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser WB_html;
    }
}

