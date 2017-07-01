using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Friendly_KITTI
{
    public partial class HelpWindow : Form
    {
        public HelpWindow()
        {
            InitializeComponent();
            richTextBox1.LoadFile(@"help.rtf", RichTextBoxStreamType.RichText);
        }

        private void buttonHelpBoxOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            
            System.Diagnostics.Process.Start(e.LinkText);
        }        
    }
}
