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
    
    public partial class frmLogin : Form
    {
        const string username = "user";
        const string password = "abc123";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string myUser = txtUser.Text, myPassword = txtPassword.Text;

            if (myUser == username && myPassword == password)
            {
                MessageBox.Show("Du är inloggad");

                LoggedIn formLoggedIn = new LoggedIn();
                formLoggedIn.Welcome(myUser);
                //formLoggedIn.Visible = true;
                //formLoggedIn.Activate();
                formLoggedIn.Show();
            }        
            else
                MessageBox.Show("Felaktig login");
        }
    }
}
