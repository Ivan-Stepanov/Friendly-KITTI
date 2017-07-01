using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Friendly_KITTI
{
    public partial class Form1 //: Form
    {
        public static string inputFoldername;  //Path to the folder with unlabeled images        
        public static string labeledFoldername;
        public static string trainvalFoldername; //Path to the folder with datasets for Training and valuation: /train/..., /val/...

        public static string[] unlabeledfiles; // string array with unlabeled image paths
        public static string[] unlabeledFilesNamesWithoutExtentions;


        // button-event opening the folder-dialog and finding/creating the folder with labeled images and labels
        //
        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();                

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] directories = Directory.GetDirectories(fbd.SelectedPath);
                    labeledFoldername= fbd.SelectedPath;
                    
                    System.IO.Directory.CreateDirectory(fbd.SelectedPath + @"\images"); // the folder with labeled images ist found or created
                    System.IO.Directory.CreateDirectory(fbd.SelectedPath + @"\labels"); // the folder with labeles ist found or created

                    currentImageIndex = 0;
                    if (unlabeledfiles != null && unlabeledfiles.Length > 0) ReadLabelsTXT();
                    updateResizableBoxes();

                    // Show folder name in the status bar
                    this.toolStripStatusLabelLabeledFolderSelected.Text = labeledFoldername;
                    this.toolStripStatusLabelLabeledFolderSelected.ForeColor = Color.Black;
                }
            }            
        }


        // UNLABELED images
        // button-event opening the folder-dialog and finding the folder with unlabeled images
        //
        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();                

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    unlabeledfiles = Directory.GetFiles(fbd.SelectedPath);    
                   Console.WriteLine("Files found: " + unlabeledfiles.Length.ToString(), "Message");

                    if (unlabeledfiles.Length > 0) Console.WriteLine("Firstfilepath:" + unlabeledfiles[0]);
                }
            }

            if (unlabeledfiles != null && unlabeledfiles.Length > 0)
            {
                currentImageIndex = 0;
                mainimage = Image.FromFile(unlabeledfiles[currentImageIndex]);
                pictureBox1.Image = mainimage;

                // Fill the toolStripComboBox with file names and set it to the current index
                FillToolStripComboBoxSelectImage();
                toolStripComboBoxSelectImage.SelectedIndex = currentImageIndex;
                
                // Show folder name in the status bar
                this.toolStripStatusLabelUnlabeledFolderSelected.Text = Path.GetDirectoryName(unlabeledfiles[0]);
                this.toolStripStatusLabelUnlabeledFolderSelected.ForeColor = Color.Black;
            }            
        }

        private void FillToolStripComboBoxSelectImage()
        {
            List<string> unlabeledFilesNamesWithoutExtentionsString = new List<string>();
            foreach (var item in unlabeledfiles)
            {
                unlabeledFilesNamesWithoutExtentionsString.Add(Path.GetFileNameWithoutExtension(item));                
            }
            unlabeledFilesNamesWithoutExtentions = unlabeledFilesNamesWithoutExtentionsString.ToArray();

            toolStripComboBoxSelectImage.Items.AddRange(unlabeledFilesNamesWithoutExtentions);
        }

            // calls the Folderselectdialog for the Tarin-Val folder
            private void button3_Click(object sender, EventArgs e)
        {
            TrainValFolder tvf = new TrainValFolder();
            tvf.ShowDialog();
        }
    }
}
