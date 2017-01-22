using System;
using System.Windows.Forms;

namespace StringWriter
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void LinksourceLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/yahya14/StringWriter_Gecko");

        }
    }
}
