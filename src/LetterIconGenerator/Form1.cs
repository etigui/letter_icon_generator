using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetterIconGenerator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private string default_name_html = "DefaultName";

        public string SendResponse(HttpListenerRequest request) {
            return File.ReadAllText(Path.Combine(GetExecutingDirectoryName(), "web", "index.html"), Encoding.UTF8).Replace(default_name_html, "Rss");
        }

        public string GetExecutingDirectoryName() {
            var location = new Uri(Assembly.GetEntryAssembly().GetName().CodeBase);
            return new FileInfo(location.AbsolutePath).Directory.FullName.ToString();
        }


        private void button1_Click(object sender, EventArgs e) {
            xssx();
           /* try {

                SaveImage("xx", ImageFormat.Png);

            } catch (Exception ex) { }*/
            //Something is wrong with Format -- Maybe required Format is not 
            // applicable here


            //Console.WriteLine("A simple webserver. Press a key to quit.");
            //Console.ReadKey();
            //ws.Stop();
        }

        private void Form1_Load(object sender, EventArgs e) {
            WebServer ws = new WebServer(SendResponse, "http://localhost:7070/");
            ws.Run();

      
        }


        private void xssx() {
            /*List<string> images = new List<string>();
            WebClient client = new WebClient();
            string site = "http://localhost:7070/";
            var htmlText = client.DownloadString(site);*/
            string site = "http://localhost:7070";
            WB_html.Navigate(site);



            
            /*

          
            HtmlDocument htmlDoc = new HtmlDocument() {

                OptionFixNestedTags = true,
                OptionAutoCloseOnEnd = true
            };

            htmlDoc.LoadHtml(htmlText);

            foreach (HtmlNode img in htmlDoc.DocumentNode.SelectNodes("//img")) {
                HtmlAttribute att = img.Attributes["src"];
                images.Add(att.Value);
            }*/
        }


        public void SaveImage(string filename, ImageFormat format) {

            WebClient client = new WebClient();
            Stream stream = client.OpenRead("http://localhost:7070/");
            Bitmap bitmap; bitmap = new Bitmap(stream);

            if (bitmap != null)
                bitmap.Save(filename, format);

            stream.Flush();
            stream.Close();
            client.Dispose();
        }

        private void WB_html_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {

            WB_html.Navigate("javascript: window.external.CallServerSideCode();");
            string matchString = Regex.Match(WB_html.DocumentText, "<img.+?src=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value;
            Console.WriteLine(matchString);

        }

        private void WB_html_Navigated(object sender, WebBrowserNavigatedEventArgs e) {
            HtmlDocument X =  WB_html.Document;
            string matchString = Regex.Match(WB_html.DocumentText, "<img.+?src=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value;
            Console.WriteLine(matchString);
        }

        private void WB_html_ParentChanged(object sender, EventArgs e) {
            HtmlDocument X = WB_html.Document;
            string matchString = Regex.Match(WB_html.DocumentText, "<img.+?src=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value;
            Console.WriteLine(matchString);

        }

        private void WB_html_RegionChanged(object sender, EventArgs e) {
            HtmlDocument X = WB_html.Document;
            string matchString = Regex.Match(WB_html.DocumentText, "<img.+?src=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value;
            Console.WriteLine(matchString);
        }
    }
}
