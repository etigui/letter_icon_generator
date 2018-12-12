using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetterIconGenerator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void BTSaveImage_Click(object sender, EventArgs e) {
            int size = 256;
            String letter = "L";
            Color myColor = System.Drawing.ColorTranslator.FromHtml("#9b59b6");


            //int rest_width = 256- sizeOfText.Width;
            //int rest_height = 256 - sizeOfText.Height;

            Size rectangleSize = new Size(PImage.Width, PImage.Height);

            Size letterSize = TextRenderer.MeasureText(letter, new Font("Arial", 128, FontStyle.Bold));
            int letterWidth = (PImage.Width / 2) - (letterSize.Width / 2) + PImage.Location.X;
            int letterHeight = (PImage.Height / 2) - (letterSize.Height / 2) + PImage.Location.Y;


            Graphics g = PImage.CreateGraphics();
            Rectangle rect = new Rectangle(new Point(PImage.Location.X, PImage.Location.Y), rectangleSize);
            g.FillRectangle(new SolidBrush(Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B)), rect);
            g.DrawString(letter, new Font("Arial", 128, FontStyle.Bold), Brushes.White, new Point(letterWidth, letterHeight));
            //g.Dispose();


            //Graphics gr1 = panel1.CreateGraphics();
            //Bitmap bmp1 = new Bitmap(panel1.Width, panel1.Height);
            //panel1.DrawToBitmap(bmp1, new Rectangle(0, 0, panel1.Width, panel1.Height));

            string x = Application.StartupPath + @"\\xx.ico";
            //bmp1.Save(x);

            Image bmp = new Bitmap(PImage.Width, PImage.Height);
            var gg = Graphics.FromImage(bmp);
            var rects = PImage.RectangleToScreen(PImage.ClientRectangle);
            gg.CopyFromScreen(rects.Location, Point.Empty, PImage.Size);


            bmp.Save(x, ImageFormat.Icon);

            //bmp.Save(x);
            //Process.Start(x);


            /*Bitmap newImage2 = new Bitmap(panel1.Width, panel1.Height, g);
            newImage2.Save(x);
            g.Dispose();*/

            /*Graphics g = panel1.CreateGraphics();
            Color myColor = System.Drawing.ColorTranslator.FromHtml("#9b59b6");
            Pen p = new Pen(Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B));
            Rectangle r = new Rectangle(1, 1, 256, 256);
            g.DrawRectangle(p, r);

            using (Brush brush = new SolidBrush(Color.FromArgb(myColor.A, myColor.R, myColor.G, myColor.B)))    // specify color here and brush type here
            {
                g.FillRectangle(brush, r);
            }
            label1.BackColor = Color.Transparent;
            label1.BringToFront();*/



            //panel1.Refresh();
        }
    }
}
