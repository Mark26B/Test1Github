using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1Github
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TheButton_Click(object sender, EventArgs e)
        {
            TheButton.BackColor = Color.Green;
            MessageBox.Show("Now the form is green. :))))");
        }
    }
}
