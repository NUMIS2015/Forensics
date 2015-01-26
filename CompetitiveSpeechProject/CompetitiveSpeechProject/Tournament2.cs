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
    public partial class Tournament1 : Form
    {
        public Tournament1()
        {
            InitializeComponent();
            dateSelection1.Format = DateTimePickerFormat.Custom;
            dateSelection1.CustomFormat = "MMMM, dd  yyyy";
        }
    }
}
