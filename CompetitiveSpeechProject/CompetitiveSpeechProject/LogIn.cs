using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetitiveSpeechProject
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogInSubmit_Click(object sender, EventArgs e)
      {
            //Code to test password and username to confirm login
          string WelcomeMsg = "Welcome" + " " + this.tbxLogInUsername.Text + "!";
    MessageBox.Show (WelcomeMsg);

            
    
        }

        
    }
}
