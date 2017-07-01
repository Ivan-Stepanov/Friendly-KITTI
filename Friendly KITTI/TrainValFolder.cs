using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Friendly_KITTI
{
    public partial class TrainValFolder : Form
    {

        public TrainValFolder()
        {
            InitializeComponent();

            // At initialisation it opens a dialog for selection of TrainVal folder 
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] directories = Directory.GetDirectories(fbd.SelectedPath);
                    Form1.trainvalFoldername = fbd.SelectedPath;
                }
            }
        }


        //OK Button click
        //
        private void buttonTrainValOK_Click(object sender, EventArgs e)
        {
            if (Form1.labeledFoldername == null || Form1.labeledFoldername == String.Empty) return;

            // Create the folders if not available yet
            System.IO.Directory.CreateDirectory(Form1.trainvalFoldername + @"\train\images"); // the folder with labeled images for training is found or created
            System.IO.Directory.CreateDirectory(Form1.trainvalFoldername + @"\train\labels"); // the folder with labels is found or created
            System.IO.Directory.CreateDirectory(Form1.trainvalFoldername + @"\val\images"); // the folder with labeled images for validation is found or created
            System.IO.Directory.CreateDirectory(Form1.trainvalFoldername + @"\val\labels"); // the folder with labels for validation is found or created

            // read paths to all labled fildes and prepare Lists for Tarin and Val collections
            string[] labledFiles = Directory.GetFiles(Form1.labeledFoldername+@"\images");            
            List<string> labledToTrainFiles = labledFiles.ToList();
            List<string> labledToValFiles = new List<string>();

            // prepare booleans for different image transformations depending on checked boxes
            bool doFlip = checkBoxMirrorHorizontally.Checked || checkBoxMirrorVertically.Checked; //should a flipped version be saved too?
            bool noFlip0deg = true; // an unflipped, unrotated Image is always saved
            bool noFlip90deg = checkBox90deg.Checked;
            bool noFlip180deg = checkBox180deg.Checked;
            bool noFlip270deg = checkBox270deg.Checked;
            bool doFlip0deg = doFlip; 
            bool doFlip90deg = doFlip & checkBox90deg.Checked;
            bool doFlip180deg = doFlip & checkBox180deg.Checked;
            bool doFlip270deg = doFlip & checkBox270deg.Checked;


            //select train or val folder randomly and save into separate lists
            Random rand = new Random();
            for (int i = 0; i < labledFiles.Length* Int32.Parse(textBoxPercentForValidation.Text)/100; i++)
            {
                int fileIndexTomove = rand.Next(0, labledToTrainFiles.Count);
                labledToValFiles.Add(labledToTrainFiles[fileIndexTomove]);
                labledToTrainFiles.RemoveAt(fileIndexTomove);
            }

            Form1.progressBarStatusStripS.Maximum = labledFiles.Length;
            Form1.progressBarStatusStripS.Step = 1;

            //########################################################################################
            // Files from the "labledFiles" folder are rotated and saved into the "trainval" folder
            //

            foreach (var file in labledFiles)
            {
                // The image is read and one of the mirrored images is prepared
                System.Drawing.Image img = System.Drawing.Image.FromFile(file);
                System.Drawing.Image imgflipped = (Image)img.Clone();
                if (checkBoxMirrorHorizontally.Checked == true) { imgflipped = (Image)img.Clone(); imgflipped.RotateFlip(RotateFlipType.RotateNoneFlipX); };
                if (checkBoxMirrorVertically.Checked == true) { imgflipped = (Image)img.Clone(); imgflipped.RotateFlip(RotateFlipType.RotateNoneFlipY); };

                // Label file is read and KITTIbox object list and the mirrored version are prepared
                string txtLabelFile = Form1.labeledFoldername + @"\labels\" + Path.GetFileNameWithoutExtension(file) + ".txt";
                string[] txtLabelFileLines = File.ReadAllLines(txtLabelFile);
                List<KITTIbox> txtLabelKITTIboxList = new List<KITTIbox>();
                foreach (var line in txtLabelFileLines) txtLabelKITTIboxList.Add(new KITTIbox(line,img.Width, img.Height));
                //List<KITTIbox> txtLabelKITTIboxListFlipped = new List<KITTIbox>(txtLabelKITTIboxList);
                List<KITTIbox> txtLabelKITTIboxListFlipped = new List<KITTIbox>(txtLabelKITTIboxList.Count);
                foreach (var item in txtLabelKITTIboxList) txtLabelKITTIboxListFlipped.Add((KITTIbox)item.Clone());
                if (checkBoxMirrorHorizontally.Checked == true) {foreach (var box in txtLabelKITTIboxListFlipped) box.FlipX();};
                if (checkBoxMirrorVertically.Checked == true)   {foreach (var box in txtLabelKITTIboxListFlipped) box.FlipY();};
                //Console.WriteLine("txtLabelKITTIboxList = " + txtLabelKITTIboxList.Count());
                //Console.WriteLine("txtLabelKITTIboxListFlipped = " + txtLabelKITTIboxListFlipped.Count());


                // the path is set to the train or val folder
                string trainOrValSubFolder = "";
                if (labledToTrainFiles.Contains(file)) trainOrValSubFolder = @"\train";
                if (labledToValFiles.Contains(file)) trainOrValSubFolder = @"\val";

                // Update the Progress Bar

                Form1.progressBarStatusStripS.PerformStep();
                if (file == labledFiles.Last()) Form1.progressBarStatusStripS.Value = 0;

#region rotate, flip and save images

                    // no flip, 0deg, this one is always true and executed
                if (noFlip0deg)
                {
                    // write the picture file
                    img.Save(Form1.trainvalFoldername + trainOrValSubFolder + @"\images\" + Path.GetFileName(file), System.Drawing.Imaging.ImageFormat.Png);

                    // write the label file
                    TextWriter tw = new StreamWriter(Form1.trainvalFoldername + trainOrValSubFolder + @"\labels\" + Path.GetFileNameWithoutExtension(file) + ".txt");
                    foreach (var line in txtLabelFileLines) { tw.WriteLine(line); }
                    tw.Close();
                }

                // no flip, 90deg
                if (noFlip90deg)
                {
                    string fileNameExtentionFlipRot = "_noFlip90deg";
                    // write the picture file
                    Image imgTemp = (Image)img.Clone();
                    imgTemp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    imgTemp.Save(Form1.trainvalFoldername + trainOrValSubFolder + @"\images\" + Path.GetFileNameWithoutExtension(file) + fileNameExtentionFlipRot + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    imgTemp.Dispose();

                    // write the label file
                    List<KITTIbox> txtLabelKITTIboxListTemp = new List<KITTIbox>(txtLabelKITTIboxList.Count);
                    foreach (var item in txtLabelKITTIboxList) txtLabelKITTIboxListTemp.Add((KITTIbox)item.Clone());
                    TextWriter tw = new StreamWriter(Form1.trainvalFoldername + trainOrValSubFolder + @"\labels\" + Path.GetFileNameWithoutExtension(file) + fileNameExtentionFlipRot + ".txt");
                    foreach (var box in txtLabelKITTIboxListTemp) {
                        box.Rotate90();
                        tw.WriteLine(box.ToString()); }
                    tw.Close();                    
                }

                if (noFlip180deg)
                {
                    string fileNameExtentionFlipRot = "_noFlip180deg";
                    // write the picture file
                    Image imgTemp = (Image)img.Clone();
                    imgTemp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    imgTemp.Save(Form1.trainvalFoldername + trainOrValSubFolder + @"\images\" + Path.GetFileNameWithoutExtension(file) + fileNameExtentionFlipRot + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    imgTemp.Dispose();

                    // write the label file

                    List<KITTIbox> txtLabelKITTIboxListTemp = new List<KITTIbox>(txtLabelKITTIboxList.Count);
                    foreach (var item in txtLabelKITTIboxList) txtLabelKITTIboxListTemp.Add((KITTIbox)item.Clone());    
                    TextWriter tw = new StreamWriter(Form1.trainvalFoldername + trainOrValSubFolder + @"\labels\" + Path.GetFileNameWithoutExtension(file) + fileNameExtentionFlipRot + ".txt");
                    foreach (var box in txtLabelKITTIboxListTemp)
                    {                        
                        box.Rotate90(); box.Rotate90();
                        tw.WriteLine(box.ToString());
                    }
                    tw.Close();
                }

                if (noFlip270deg)
                {
                    string fileNameExtentionFlipRot = "_noFlip270deg";
                    // write the picture file
                    Image imgTemp = (Image)img.Clone();
                    imgTemp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    imgTemp.Save(Form1.trainvalFoldername + trainOrValSubFolder + @"\images\" + Path.GetFileNameWithoutExtension(file) + fileNameExtentionFlipRot + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    imgTemp.Dispose();

                    // write the label file
                    List<KITTIbox> txtLabelKITTIboxListTemp = new List<KITTIbox>(txtLabelKITTIboxList.Count);
                    foreach (var item in txtLabelKITTIboxList) txtLabelKITTIboxListTemp.Add((KITTIbox)item.Clone());
                    TextWriter tw = new StreamWriter(Form1.trainvalFoldername + trainOrValSubFolder + @"\labels\" + Path.GetFileNameWithoutExtension(file) + fileNameExtentionFlipRot + ".txt");
                    foreach (var box in txtLabelKITTIboxListTemp)
                    {
                        box.Rotate90(); box.Rotate90(); box.Rotate90();
                        tw.WriteLine(box.ToString());
                    }
                    tw.Close();
                }

                // ########################
                // now the flipped versions
                // ########################

                // do flip, 0deg
                if (doFlip0deg)
                {
                    string fileNameExtentionFlipRot = "_Flip0deg";
                    // write the picture file
                    Image imgTemp = (Image)imgflipped.Clone();
                    imgTemp.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                    imgTemp.Save(Form1.trainvalFoldername + trainOrValSubFolder + @"\images\" + Path.GetFileNameWithoutExtension(file) + fileNameExtentionFlipRot + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    imgTemp.Dispose();

                    // write the label file
                    List<KITTIbox> txtLabelKITTIboxListTemp = new List<KITTIbox>(txtLabelKITTIboxListFlipped.Count);
                    foreach (var item in txtLabelKITTIboxListFlipped) txtLabelKITTIboxListTemp.Add((KITTIbox)item.Clone());
                    TextWriter tw = new StreamWriter(Form1.trainvalFoldername + trainOrValSubFolder + @"\labels\" + Path.GetFileNameWithoutExtension(file) + fileNameExtentionFlipRot + ".txt");
                    foreach (var box in txtLabelKITTIboxListTemp)
                    {                        
                        tw.WriteLine(box.ToString());
                    }
                    tw.Close();
                }

                // do flip, 90deg
                if (doFlip90deg)
                {
                    string fileNameExtentionFlipRot = "_Flip90deg";
                    // write the picture file
                    Image imgTemp = (Image)imgflipped.Clone();
                    imgTemp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    imgTemp.Save(Form1.trainvalFoldername + trainOrValSubFolder + @"\images\" + Path.GetFileNameWithoutExtension(file) + fileNameExtentionFlipRot + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    imgTemp.Dispose();

                    // write the label file
                    List<KITTIbox> txtLabelKITTIboxListTemp = new List<KITTIbox>(txtLabelKITTIboxListFlipped.Count);
                    foreach (var item in txtLabelKITTIboxListFlipped) txtLabelKITTIboxListTemp.Add((KITTIbox)item.Clone());
                    TextWriter tw = new StreamWriter(Form1.trainvalFoldername + trainOrValSubFolder + @"\labels\" + Path.GetFileNameWithoutExtension(file) + fileNameExtentionFlipRot + ".txt");
                    foreach (var box in txtLabelKITTIboxListTemp)
                    {
                        box.Rotate90();
                        tw.WriteLine(box.ToString());
                    }
                    tw.Close();
                }

                // do flip, 180deg
                if (doFlip180deg)
                {
                    string fileNameExtentionFlipRot = "_Flip180deg";
                    // write the picture file
                    Image imgTemp = (Image)imgflipped.Clone();
                    imgTemp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    imgTemp.Save(Form1.trainvalFoldername + trainOrValSubFolder + @"\images\" + Path.GetFileNameWithoutExtension(file) + fileNameExtentionFlipRot + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    imgTemp.Dispose();

                    // write the label file
                    List<KITTIbox> txtLabelKITTIboxListTemp = new List<KITTIbox>(txtLabelKITTIboxListFlipped.Count);
                    foreach (var item in txtLabelKITTIboxListFlipped) txtLabelKITTIboxListTemp.Add((KITTIbox)item.Clone());
                    TextWriter tw = new StreamWriter(Form1.trainvalFoldername + trainOrValSubFolder + @"\labels\" + Path.GetFileNameWithoutExtension(file) + fileNameExtentionFlipRot + ".txt");
                    foreach (var box in txtLabelKITTIboxListTemp)
                    {
                        box.Rotate90(); box.Rotate90();
                        tw.WriteLine(box.ToString());
                    }
                    tw.Close();
                }

                // do flip, 270deg
                if (doFlip270deg)
                {
                    string fileNameExtentionFlipRot = "_Flip270deg";
                    // write the picture file
                    Image imgTemp = (Image)imgflipped.Clone();
                    imgTemp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    imgTemp.Save(Form1.trainvalFoldername + trainOrValSubFolder + @"\images\" + Path.GetFileNameWithoutExtension(file) + fileNameExtentionFlipRot + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    imgTemp.Dispose();

                    // write the label file
                    List<KITTIbox> txtLabelKITTIboxListTemp = new List<KITTIbox>(txtLabelKITTIboxListFlipped.Count);
                    foreach (var item in txtLabelKITTIboxListFlipped) txtLabelKITTIboxListTemp.Add((KITTIbox)item.Clone());
                    TextWriter tw = new StreamWriter(Form1.trainvalFoldername + trainOrValSubFolder + @"\labels\" + Path.GetFileNameWithoutExtension(file) + fileNameExtentionFlipRot + ".txt");
                    foreach (var box in txtLabelKITTIboxListTemp)
                    {
                        box.Rotate90(); box.Rotate90(); box.Rotate90();
                        tw.WriteLine(box.ToString());
                    }
                    tw.Close();
                }

                #endregion

            }
               

            this.Close();
        }

        // Cancel Button click
        private void buttonTrainValCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // disables the othe checkbox to avoid double mirroring
        private void checkBoxMirrorHorizontally_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMirrorHorizontally.Checked) checkBoxMirrorVertically.Enabled = false;
            if (!checkBoxMirrorHorizontally.Checked) checkBoxMirrorVertically.Enabled = true;
        }
        private void checkBoxMirrorvertically_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMirrorVertically.Checked) checkBoxMirrorHorizontally.Enabled = false;
            if (!checkBoxMirrorVertically.Checked) checkBoxMirrorHorizontally.Enabled = true;
        }
    }
}
