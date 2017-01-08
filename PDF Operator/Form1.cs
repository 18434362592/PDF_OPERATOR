using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PDF_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CrtButon_Click(object sender, EventArgs e)
        {
            if(PathTxt.Text==""||txtPath.Text=="")
            {
                MessageBox.Show("There are noting legal path!");
            }
            else
            {
                Functionality functionality = new Functionality(PathTxt.Text,txtPath.Text);
            }
        }
    }
}
