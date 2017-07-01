using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Friendly_KITTI
{
    public partial class Form1 : Form
    {

        static List<CurrentObjectClass> currentObjectClassList = new List<CurrentObjectClass>();

        

        public void addannewButton()
        {
            // a new object class ist instantiated
            CurrentObjectClass newCurrentObjectClass = new CurrentObjectClass();

            // name of the new object class is given by the class number
            newCurrentObjectClass.className = "Class" + currentObjectClassList.Count;

            // a random color is chosen for the new button
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            newCurrentObjectClass.color = Color.FromKnownColor(randomColorName);
            
            // new UI elelments are added to the groupBoxObjectClasses
            addNewGroupBoxObjectClasse(newCurrentObjectClass);
            // new ObjectClass is added to the List
            currentObjectClassList.Add(newCurrentObjectClass);

            
        }

        public void addNewGroupBoxObjectClasse(CurrentObjectClass newCurrentObjectClass)
        {
            //groupBoxObjectClassesS.Height += 30; //more space for new UI elements

            // new ColorButton is added to the groupBox
            Button newClassColorButton = new Button();
            newClassColorButton.Text = String.Empty;
            newClassColorButton.Name = "ColorButton";
            newClassColorButton.Size = new Size(20, 20);
            newClassColorButton.Location = new Point(185, 15 + currentObjectClassList.Count * 30);
            newClassColorButton.BackColor = newCurrentObjectClass.color;
            newClassColorButton.Click += new System.EventHandler(button1_Click); //Click-Event for color changing
            newCurrentObjectClass.colorButton = newClassColorButton; // reference to this colorButton is connected to the currentObjectClass
            // Tooltip is added to the button
            this.toolTipUlabeledButton.SetToolTip(newClassColorButton, "Set the color of the bounding box for this class.");


            // new TextBox with the name of the Class is added to the groupBox
            TextBox newClassTextBox = new TextBox();
            newCurrentObjectClass.textBox = newClassTextBox;
            newClassTextBox.Location = new Point(25, 15 + currentObjectClassList.Count * 30);
            newClassTextBox.Size = new Size(140, 25);
            newClassTextBox.Text = newCurrentObjectClass.className;
            newClassTextBox.ReadOnly = false;
            newClassTextBox.TextChanged += new EventHandler(newClassTextBox_TextChanged);
            // Tooltip is added to the button
            this.toolTipUlabeledButton.SetToolTip(newClassTextBox, "Enter the name for this class. This name will be save into the label file.");

            // new bulletButton is added to the groupBox
            RadioButton newClassRadioButton = new RadioButton();
            newCurrentObjectClass.radioButton = newClassRadioButton;
            newClassRadioButton.Name = "RadioButton";
            newClassRadioButton.Text = String.Empty;
            newClassRadioButton.Location = new Point(5, 13 + currentObjectClassList.Count * 30);
            if (currentObjectClassList.Count == 0) newClassRadioButton.Checked = true; //the first bulletBox ist checked
            // Tooltip is added to the button
            this.toolTipUlabeledButton.SetToolTip(newClassRadioButton, "Select an object class. This class name and color will be used when you draw a new bounding box onto the image.");

            // eventHandler for changes in the class names
            void newClassTextBox_TextChanged(object sender, EventArgs e)
            {
                TextBox changedTextBox = sender as TextBox;
                CurrentObjectClass findObjectClass = currentObjectClassList.Find(objectToFind => objectToFind.textBox == changedTextBox);
                findObjectClass.className = changedTextBox.Text;
                this.updateResizableBoxes();
            }

            // eventHandler for changes in the class color
            void button1_Click(object sender, System.EventArgs e)
            {
                Button klickedbutton = sender as Button;
                if (colorDialog1S.ShowDialog() == DialogResult.OK)
                {
                    newClassColorButton.BackColor = colorDialog1S.Color;
                    CurrentObjectClass findObjectClass = currentObjectClassList.Find(objectToFind => objectToFind.colorButton == klickedbutton);
                    findObjectClass.color = newClassColorButton.BackColor;
                    updateResizableBoxes();
                }
                
            }            

            panelObjectClassesS.Controls.Add(newClassTextBox);
            panelObjectClassesS.Controls.Add(newClassRadioButton);
            panelObjectClassesS.Controls.Add(newClassColorButton);

        }       
    }
}