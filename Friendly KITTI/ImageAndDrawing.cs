using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Friendly_KITTI
{
    public partial class Form1 : Form
    {
        static Image mainimage;
        ResizableRectangle currentResizableRectangle;
        ResizableRectangle selectedResizableRectangle;
        static int currentImageIndex;
        Point mouseDownCoordinates;
        static List<ResizableRectangle> displayedResizableRectangleList = new List<ResizableRectangle>();
        static int sizeNodeRect = 8;


        bool draw = false;
        //Color color = Color.Blue;
        bool isAnyWindowSelected = false;   //if true: an existing window will be resized; if false: a new window will be created


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(pictureBox1.Image==null) return;
            
            // all existing boxes are checked if any handle node is selected
            isAnyWindowSelected = false;
            foreach (ResizableRectangle item in displayedResizableRectangleList) if (item.nodeSelected != ResizableRectangle.PosSizableRect.None)
                {
                    isAnyWindowSelected = true;
                    selectedResizableRectangle = item;
                    toolStripTextBoxTruncated.Text = selectedResizableRectangle.truncated.ToString();
                }

            //mouse down coordinates are remembered
            draw = true;
            mouseDownCoordinates.X = e.X;
            mouseDownCoordinates.Y = e.Y;

            // if no box is selected, a new one is created
            if (!isAnyWindowSelected)
            {            
                CurrentObjectClass selectedObjectClass = currentObjectClassList.Find(objectToFind => objectToFind.radioButton.Checked == true);

                currentResizableRectangle = new ResizableRectangle(new Rectangle(e.X, e.Y, 0, 0));
                currentResizableRectangle.className = selectedObjectClass.className;
                currentResizableRectangle.boxColor = selectedObjectClass.color;
                currentResizableRectangle.currentObjectClass = selectedObjectClass;
                currentResizableRectangle.sizeNodeRect = sizeNodeRect;
                currentResizableRectangle.SetPictureBox(this.pictureBox1);

                selectedResizableRectangle = currentResizableRectangle;
                toolStripTextBoxTruncated.Text = selectedResizableRectangle.truncated.ToString();

                // makes sure that this mouseButton-Event is executed last, after all ResizableRectangles are checked for selected nodes
                pictureBox1.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
                pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            }
        }

                
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null) return;

            pictureBox1.Refresh(); //the display is refreshed

            if (draw & !isAnyWindowSelected)
            {
                // mouse coordinates to own variables in oderer to make them accessible
                int positionX = e.X;
                int positionY = e.Y;

                // limit the tracked positionX/Y if mouse leaves the image
                if (e.X < 0) positionX = 0;
                if (e.Y < 0) positionY = 0;
                if (e.X > mainimage.Width) positionX = mainimage.Width;
                if (e.Y > mainimage.Height) positionY = mainimage.Height;

                currentResizableRectangle.rect.X = Math.Min(mouseDownCoordinates.X, positionX);
                currentResizableRectangle.rect.Y = Math.Min(mouseDownCoordinates.Y, positionY);
                currentResizableRectangle.rect.Width = Math.Abs(positionX - mouseDownCoordinates.X);
                currentResizableRectangle.rect.Height = Math.Abs(positionY - mouseDownCoordinates.Y);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null) return;

            draw = false;

            // if no box was selected, but a new one created, it will be added to the List of displayed boxes
            if (!isAnyWindowSelected)
            {
                displayedResizableRectangleList.Add(currentResizableRectangle);
            }            
            
            // changes the box selection status back to false
            isAnyWindowSelected = false;
        }

        

        public void updateResizableBoxes()
        {
            foreach (ResizableRectangle displayedResizableRectangle in displayedResizableRectangleList)
            {
                displayedResizableRectangle.boxColor = displayedResizableRectangle.currentObjectClass.color;
                displayedResizableRectangle.className = displayedResizableRectangle.currentObjectClass.className;
            }
            pictureBoxS.Refresh();

            // makes sure that this mouseButton-Event is executed last, after all ResizableRectangles are checked for selected nodes
            pictureBox1.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
        }

        private void toolStripTextBoxTruncated_TextChanged(object sender, EventArgs e)
        {
            ToolStripTextBox thisTextBox = sender as ToolStripTextBox;
            
            if (thisTextBox.Text!= String.Empty && Regex.IsMatch(thisTextBox.Text, @"^-*[0-9,\.]+$") && float.Parse(thisTextBox.Text, CultureInfo.InvariantCulture.NumberFormat)<100)
            {
                selectedResizableRectangle.truncated = float.Parse(thisTextBox.Text, CultureInfo.InvariantCulture.NumberFormat);
            }            
        }    

        private void toolStripComboBoxTruncated_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox cmb = (ToolStripComboBox)sender;
            int selectedValue = (int)cmb.SelectedItem;
            selectedResizableRectangle.truncated = (float)selectedValue / 100;
            toolStripTextBoxTruncated.Text = cmb.SelectedItem.ToString();
        }


        // the dropdownbox changes the size of Box-Resizing handles
        private void toolStripComboBoxhandleSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox cmb = (ToolStripComboBox)sender;
            int selectedValue = (int)cmb.SelectedItem;
            sizeNodeRect = selectedValue;
            foreach (var rect in displayedResizableRectangleList) rect.sizeNodeRect = sizeNodeRect;           

            updateResizableBoxes();
        }

        private void buttonDeleteSelectedRectangle_Click(object sender, EventArgs e)
        {
            if (displayedResizableRectangleList.Count>0)
            {
                int indexOfSelectedRectangle = displayedResizableRectangleList.Count - 1;
                for (int i = 0; i < displayedResizableRectangleList.Count; i++)
                {
                    if (Object.ReferenceEquals(displayedResizableRectangleList[i], selectedResizableRectangle))
                        indexOfSelectedRectangle = i;
                }

                displayedResizableRectangleList[indexOfSelectedRectangle].UnSetPictureBox();
                displayedResizableRectangleList.RemoveAt(indexOfSelectedRectangle);
                
            }
            updateResizableBoxes();
        }

       
    }
}