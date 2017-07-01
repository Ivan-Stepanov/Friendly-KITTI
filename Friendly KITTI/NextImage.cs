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
    public partial class Form1 : Form
    {
        private void LoadImage(int index)
        {
            //remove event handles and pucturebox reference
            foreach (var box in displayedResizableRectangleList)
            {                
                box.UnSetPictureBox(); //remove event handles and pucturebox reference
            }
            // emty the list with currently displayer boxes
            displayedResizableRectangleList.Clear();

            // update mainimage and load new image into the picturebox
            mainimage = Image.FromFile(unlabeledfiles[index]);
            pictureBoxS.Image = mainimage;

            ReadLabelsTXT();
            updateResizableBoxes();

            // update the combobox to this image
            toolStripComboBoxSelectImage.SelectedIndex = currentImageIndex;

            // show image number in the statusbar
            toolStripStatuImageOf.Text = (currentImageIndex + 1).ToString() + "/" + unlabeledfiles.Length.ToString();
        }

        private void WriteImage()
        {
            if (labeledFoldername != null & toolStripButtonSavingSwitch.Text == "Saving")                
            {
                //copy file to the images directory
                try { File.Copy(unlabeledfiles[currentImageIndex], labeledFoldername + @"\images\" + Path.GetFileName(unlabeledfiles[currentImageIndex]), true); }
                catch { Exception ex; }

                //Write the label file  
                TextWriter tw = new StreamWriter(labeledFoldername + @"\labels\" + Path.GetFileNameWithoutExtension(unlabeledfiles[currentImageIndex]) + ".txt");
                foreach (var box in displayedResizableRectangleList)
                {
                    tw.WriteLine(box.ToString());
                    //box.UnSetPictureBox(); //remove event handles and pucturebox reference
                }
                tw.Close();
            }
        }

        private void NextImage()
        {
            if (unlabeledfiles != null && currentImageIndex != unlabeledfiles.Length)
            {
                WriteImage();
                ++currentImageIndex;
                LoadImage(currentImageIndex);
            }            
        }

        private void PreviousImage()
        {
            if (unlabeledfiles != null && currentImageIndex > 0)
            {
                WriteImage();
                --currentImageIndex;
                LoadImage(currentImageIndex);
            }
        }



        private void ReadLabelsTXT()
        {
            string txtLabelFile = Form1.labeledFoldername + @"\labels\" + Path.GetFileNameWithoutExtension(unlabeledfiles[currentImageIndex]) + ".txt";
            
            if (File.Exists(txtLabelFile))
            {
                string[] txtLabelFileLines = File.ReadAllLines(txtLabelFile);

                foreach (var line in txtLabelFileLines)
                {
                    ResizableRectangle tempResizableRectangle = new ResizableRectangle(line);
                    tempResizableRectangle.sizeNodeRect = sizeNodeRect;
                    displayedResizableRectangleList.Add(tempResizableRectangle);
                    tempResizableRectangle.SetPictureBox(pictureBoxS);                    
                    tempResizableRectangle.currentObjectClass = currentObjectClassList.Find(objectToFind => objectToFind.className == tempResizableRectangle.className);
                    
                    //create new Object Class if not yet available
                    if (tempResizableRectangle.currentObjectClass == null)
                    {
                        addannewButton();
                        Console.WriteLine(currentObjectClassList.Last().className);
                        currentObjectClassList.Last().className = tempResizableRectangle.className;
                        Console.WriteLine(currentObjectClassList.Last().className);
                        tempResizableRectangle.currentObjectClass = currentObjectClassList.Last();
                        currentObjectClassList.Last().textBox.Text = tempResizableRectangle.className;
                    }
                }
            }
        }

        private void toolStripButtonNext_Click(object sender, EventArgs e)
        {
            NextImage();
        }

        private void toolStripButtonPrevious_Click(object sender, EventArgs e)
        {
            PreviousImage();
        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {            
            if (e.Delta < 0 && unlabeledfiles != null && currentImageIndex != unlabeledfiles.Length) NextImage();
            if (e.Delta > 0 && unlabeledfiles != null && currentImageIndex > 0) PreviousImage();
        }
        
        private void toolStripComboBoxSelectImage_TextChanged(object sender, EventArgs e)
        {
            if (unlabeledfiles != null && Path.GetFileName(unlabeledfiles[currentImageIndex]) != String.Empty)
            {                
                currentImageIndex=toolStripComboBoxSelectImage.SelectedIndex;
                LoadImage(toolStripComboBoxSelectImage.SelectedIndex);
            }            
        }
    }
}
