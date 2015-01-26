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
    public partial class Tournament : Form
    {
        public Tournament()
        {
            InitializeComponent();
            dateSelection.Format = DateTimePickerFormat.Custom;
            dateSelection.CustomFormat = "MMMM, dd  yyyy";
        }

        private void teamPlacementLabel_Click(object sender, EventArgs e)
        {

        }

        private void goalLabel_Click(object sender, EventArgs e)
        {

        }
     
        }
    }

