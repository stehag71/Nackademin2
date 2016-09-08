using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class LoggedIn : Form
    {
        public LoggedIn()
        {
            InitializeComponent();
        }

        private void LoggedIn_Load(object sender, EventArgs e)
        {           
           
        }

        public void Welcome(string username)
        {
            lblWelcome.Text = "Welcome " + username;
        }
    }
}
