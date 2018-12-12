using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace LetterIconGenerator {
    public partial class Form1 : Form {

        #region Init

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            CBType.SelectedIndex = 0;
            TBBackColor.BackColor = Color.FromArgb(22, 160, 133);
        }

        private void Form1_Shown(object sender, EventArgs e) {
            DrawImage(false);
        }

        #endregion

        #region Controls

        private void BTSaveImage_Click(object sender, EventArgs e) {
            DrawImage(true);
        }

        private void TBBackColor_Click(object sender, EventArgs e) {
            CDColor.Color = TBBackColor.BackColor;
            if (CDColor.ShowDialog() == DialogResult.OK) {
                TBBackColor.BackColor = CDColor.Color;
                DrawImage(false);
            }
        }

        private void TBLetterColor_Click(object sender, EventArgs e) {
            CDColor.Color = TBLetterColor.BackColor;
            if (CDColor.ShowDialog() == DialogResult.OK) {
                TBLetterColor.BackColor = CDColor.Color;
                DrawImage(false);
            }
        }

        /// <summary>
        /// Check letter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TBLetter_KeyPress(object sender, KeyPressEventArgs e) {
            
            // Check if not backspace
            if (e.KeyChar == '\u0008') {
            } else {

                e.KeyChar = char.Parse((e.KeyChar.ToString().ToUpper()));

                // Check letter and number
                if (!char.IsLetter(e.KeyChar)) {
                    e.Handled = true;
                }

                // Only one char is allowed
                if (TBLetter.Text.Count() > 0) {
                    e.Handled = true;
                }
            }
        }

        private void CBSize_SelectedIndexChanged(object sender, EventArgs e) {
            DrawImage(false);
        }

        private void TBLetter_TextChanged(object sender, EventArgs e) {
            DrawImage(false);
        }

        #endregion

        #region Image

        /// <summary>
        /// Create icon image
        /// </summary>
        /// <param name="filePathTmp"></param>
        /// <param name="letter"></param>
        private void SaveIcon(string filePathTmp, string letter) {

            // Create icon with png image
            using (FileStream stream = File.OpenWrite(Path.Combine(Application.StartupPath, $"{letter}_{DateTime.Now.Ticks}.ico"))) {
                Bitmap bitmap = (Bitmap)Image.FromFile(filePathTmp);
                Icon.FromHandle(bitmap.GetHicon()).Save(stream);
                bitmap.Dispose();
            }

            // Delete png image temp
            try {
                if (File.Exists(filePathTmp)) {
                    File.Delete(filePathTmp);
                }
            } catch { }
        }

        /// <summary>
        /// Create image
        /// </summary>
        /// <param name="letter"></param>
        /// <param name="icon"></param>
        /// <returns></returns>
        private string SaveImage(string letter, bool icon) {
            // Save panel as image
            string filePath = String.Empty;
            Image bmp = new Bitmap(PImage.Width, PImage.Height);
            Graphics gImage = Graphics.FromImage(bmp);
            Rectangle rects = PImage.RectangleToScreen(PImage.ClientRectangle);
            gImage.CopyFromScreen(rects.Location, Point.Empty, PImage.Size);
            if (icon) {
                filePath = Path.Combine(Application.StartupPath, $"{letter}_{DateTime.Now.Ticks}.png");
                bmp.Save(filePath, ImageFormat.Png);
            } else {
                filePath = Path.Combine(Application.StartupPath, $"{letter}_{DateTime.Now.Ticks}.{CBType.Text.ToLower()}");
                bmp.Save(filePath, ParseImageFormat(CBType.Text));
            }
            return filePath;
        }

        /// <summary>
        /// Draw image on panel
        /// </summary>
        /// <param name="save"></param>
        private void DrawImage(bool save) {

            // Check if letter
            string letter = TBLetter.Text;
            if (letter != "") {

                // Image info
                int size = PImage.Width;
                int location = PImage.Location.X;
                Color letterColor = TBLetterColor.BackColor;
                Color backColor = TBBackColor.BackColor;
                Font font = new Font("Arial", size / 2, FontStyle.Bold);
                Size letterSize = TextRenderer.MeasureText(letter, font);
                int letterWidth = (size / 2) - (letterSize.Width / 2);
                int letterHeight = (size / 2) - (letterSize.Height / 2);

                // Create image on panel (backgroud and letter)
                Graphics gPanel = PImage.CreateGraphics();
                Rectangle rect = new Rectangle(new Point(location, location), new Size(size, size));
                gPanel.FillRectangle(new SolidBrush(Color.FromArgb(backColor.A, backColor.R, backColor.G, backColor.B)), rect);
                gPanel.DrawString(letter, font, new SolidBrush(letterColor), new Point(letterWidth + 10, letterHeight));
                if (save) {

                    // Save as icon
                    if (CBType.Text.EndsWith("n")) {
                        SaveIcon(SaveImage(letter, true), letter);
                    }
                }
            }
        }

        #endregion

        /// <summary>
        /// Convert string extension to image format
        /// </summary>
        /// <param name="imageFormat"></param>
        /// <returns></returns>
        public static ImageFormat ParseImageFormat(string imageFormat) {
            return (ImageFormat)typeof(ImageFormat).GetProperty(imageFormat, BindingFlags.Public | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
        }
    }
}
