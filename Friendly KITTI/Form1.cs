using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Friendly_KITTI
{
    public partial class Form1 : Form
    {
        // static references to Control elements for easy Access
        public static PictureBox pictureBoxS;
        public static GroupBox groupBoxObjectClassesS;
        public static Panel panelObjectClassesS;
        public static Form Form1S;
        public static ColorDialog colorDialog1S;
        public static ToolStripProgressBar progressBarStatusStripS;

        public Form1()
        {
            InitializeComponent();            

            pictureBoxS =this.pictureBox1; // a reference to the static instance of the pictureBox
            groupBoxObjectClassesS = this.groupBoxObjectClasses;
            Form1S = this;
            colorDialog1S = colorDialog1;
            panelObjectClassesS = panelObjectClasses;
            progressBarStatusStripS = progressBarStatusStrip;

            //Fill the DropDown ComboBox for quick Truncated selection
            for (int i = 0; i < 10; i++) { toolStripComboBoxTruncated.Items.Add(i * 10); }
            //           
            for (int i = 1; i < 21; i++) {toolStripComboBoxhandleSize.Items.Add(i); }


            // in the status bar we indicate that no folders are selected yet
            this.toolStripStatusLabelUnlabeledFolderSelected.Text = "no folder selected!";
            this.toolStripStatusLabelUnlabeledFolderSelected.ForeColor = Color.Red;
            this.toolStripStatusLabelLabeledFolderSelected.Text = "no folder selected!";
            this.toolStripStatusLabelLabeledFolderSelected.ForeColor = Color.Red;

            // add the first object class to the list
            addannewButton();            
        }
              
        private void button4_Click(object sender, EventArgs e)
        {
            addannewButton();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            KeyboardFocus.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            HelpWindow tvf = new HelpWindow();
            tvf.ShowDialog();
        }

        private void toolStripButtonSavingSwitch_Click(object sender, EventArgs e)
        {
            ToolStripButton thisButton = sender as ToolStripButton;
            if (thisButton.Text == "Saving") { thisButton.Text = "Not Saving"; return; }
            if (thisButton.Text == "Not Saving") thisButton.Text = "Saving";
        }
    }
}

// NICE TO HAVE
// konsistente Variablenbenennung
// mehr kommentieren
// flip-rot images fixen

//FINAL:
//TODO Github veröffentlichen
//TODO monodevelop für Linux