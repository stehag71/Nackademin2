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


namespace Övning_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdVisaFiler_Click(object sender, EventArgs e)
        {
            //DirectoryInfo dir = new DirectoryInfo(txtFolder.Text);

            //lstFiles.DataSource = dir.GetFiles();

            string path = txtFolder.Text;
            string[] files = Directory.GetFiles(path);
            
            foreach (var file in files)
	        {
                //lstFiles.Items.Add(file);
                lstFiles.Items.Add(Path.GetFileName(file));
	        }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            StreamWriter sr = new StreamWriter();
        }
    }
}
