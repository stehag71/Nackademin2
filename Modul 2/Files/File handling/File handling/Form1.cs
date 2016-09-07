using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_handling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveToFile(textBox1.Text);
        }

        public static void SaveToFile(string text)
        {
            //string text = "Kurt Andersson";
            
            StreamWriter sw = new StreamWriter(Constants.FilePath, false);

            using(sw)
            {
                sw.Write(text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = ReadFromFile();
            textBox2.Text = text;
        }

        public static string ReadFromFile()
        {
            StreamReader sr = new StreamReader(Constants.FilePath);
            string myText;

            using (sr)
            {
                myText = sr.ReadToEnd();
                return myText;
            }
            
        }
    }
}
