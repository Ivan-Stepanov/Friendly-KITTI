using System.Windows.Forms;

namespace Friendly_KITTI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxObjectClasses = new System.Windows.Forms.GroupBox();
            this.panelObjectClasses = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.KeyboardFocus = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSavingSwitch = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxSelectImage = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPrevious = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatuImageOf = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxTruncated = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxTruncated = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxhandleSize = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBarStatusStrip = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelUnlabeledFolderSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLabeledFolderSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTipUlabeledButton = new System.Windows.Forms.ToolTip(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBoxObjectClasses.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxObjectClasses
            // 
            this.groupBoxObjectClasses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxObjectClasses.Controls.Add(this.panelObjectClasses);
            this.groupBoxObjectClasses.Location = new System.Drawing.Point(0, 1049);
            this.groupBoxObjectClasses.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBoxObjectClasses.Name = "groupBoxObjectClasses";
            this.groupBoxObjectClasses.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBoxObjectClasses.Size = new System.Drawing.Size(629, 565);
            this.groupBoxObjectClasses.TabIndex = 6;
            this.groupBoxObjectClasses.TabStop = false;
            this.groupBoxObjectClasses.Text = "Object Classes";
            // 
            // panelObjectClasses
            // 
            this.panelObjectClasses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelObjectClasses.AutoScroll = true;
            this.panelObjectClasses.BackColor = System.Drawing.SystemColors.Control;
            this.panelObjectClasses.Location = new System.Drawing.Point(16, 41);
            this.panelObjectClasses.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelObjectClasses.Name = "panelObjectClasses";
            this.panelObjectClasses.Size = new System.Drawing.Size(597, 510);
            this.panelObjectClasses.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button4.Location = new System.Drawing.Point(0, 940);
            this.button4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(629, 95);
            this.button4.TabIndex = 7;
            this.button4.Text = "New Object Class";
            this.toolTipUlabeledButton.SetToolTip(this.button4, "Add a new object class which can be then labeled in the image.");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // KeyboardFocus
            // 
            this.KeyboardFocus.AutoSize = true;
            this.KeyboardFocus.Location = new System.Drawing.Point(413, 940);
            this.KeyboardFocus.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.KeyboardFocus.Name = "KeyboardFocus";
            this.KeyboardFocus.Size = new System.Drawing.Size(214, 32);
            this.KeyboardFocus.TabIndex = 9;
            this.KeyboardFocus.Text = "KeyboardFocus";
            this.KeyboardFocus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSavingSwitch,
            this.toolStripLabel2,
            this.toolStripComboBoxSelectImage,
            this.toolStripSeparator3,
            this.toolStripButtonPrevious,
            this.toolStripStatuImageOf,
            this.toolStripButtonNext,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripTextBoxTruncated,
            this.toolStripButton2,
            this.toolStripComboBoxTruncated,
            this.toolStripLabel4,
            this.toolStripComboBoxhandleSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(3547, 60);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSavingSwitch
            // 
            this.toolStripButtonSavingSwitch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripButtonSavingSwitch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSavingSwitch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSavingSwitch.Image")));
            this.toolStripButtonSavingSwitch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSavingSwitch.Name = "toolStripButtonSavingSwitch";
            this.toolStripButtonSavingSwitch.Size = new System.Drawing.Size(109, 57);
            this.toolStripButtonSavingSwitch.Text = "Saving";
            this.toolStripButtonSavingSwitch.Click += new System.EventHandler(this.toolStripButtonSavingSwitch_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(101, 57);
            this.toolStripLabel2.Text = "Image";
            // 
            // toolStripComboBoxSelectImage
            // 
            this.toolStripComboBoxSelectImage.DropDownWidth = 600;
            this.toolStripComboBoxSelectImage.Name = "toolStripComboBoxSelectImage";
            this.toolStripComboBoxSelectImage.Size = new System.Drawing.Size(793, 60);
            this.toolStripComboBoxSelectImage.TextChanged += new System.EventHandler(this.toolStripComboBoxSelectImage_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 60);
            // 
            // toolStripButtonPrevious
            // 
            this.toolStripButtonPrevious.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripButtonPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonPrevious.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrevious.Image")));
            this.toolStripButtonPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrevious.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonPrevious.Name = "toolStripButtonPrevious";
            this.toolStripButtonPrevious.Size = new System.Drawing.Size(283, 57);
            this.toolStripButtonPrevious.Text = "<< Previous Image ";
            this.toolStripButtonPrevious.ToolTipText = resources.GetString("toolStripButtonPrevious.ToolTipText");
            this.toolStripButtonPrevious.Click += new System.EventHandler(this.toolStripButtonPrevious_Click);
            // 
            // toolStripStatuImageOf
            // 
            this.toolStripStatuImageOf.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripStatuImageOf.Name = "toolStripStatuImageOf";
            this.toolStripStatuImageOf.Size = new System.Drawing.Size(62, 57);
            this.toolStripStatuImageOf.Text = "0/0";
            // 
            // toolStripButtonNext
            // 
            this.toolStripButtonNext.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripButtonNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonNext.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNext.Image")));
            this.toolStripButtonNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNext.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonNext.Name = "toolStripButtonNext";
            this.toolStripButtonNext.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripButtonNext.Size = new System.Drawing.Size(245, 57);
            this.toolStripButtonNext.Text = "Next Image >>";
            this.toolStripButtonNext.ToolTipText = resources.GetString("toolStripButtonNext.ToolTipText");
            this.toolStripButtonNext.Click += new System.EventHandler(this.toolStripButtonNext_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 60);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(204, 57);
            this.toolStripLabel3.Text = "Bounding Box";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(44, 57);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Deletes the bounding box which was created or modified last.\r\nHint: it can also b" +
    "e done by using the \"D\" Key.";
            this.toolStripButton1.Click += new System.EventHandler(this.buttonDeleteSelectedRectangle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(195, 57);
            this.toolStripLabel1.Text = "truncated(%):";
            // 
            // toolStripTextBoxTruncated
            // 
            this.toolStripTextBoxTruncated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxTruncated.Margin = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.toolStripTextBoxTruncated.Name = "toolStripTextBoxTruncated";
            this.toolStripTextBoxTruncated.Size = new System.Drawing.Size(75, 60);
            this.toolStripTextBoxTruncated.ToolTipText = "Please enter the \"truncated\" value of the bounding box which was created or modif" +
    "ied last.\r\n";
            this.toolStripTextBoxTruncated.TextChanged += new System.EventHandler(this.toolStripTextBoxTruncated_TextChanged);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.BackColor = System.Drawing.SystemColors.Info;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(84, 57);
            this.toolStripButton2.Text = "Help";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripComboBoxTruncated
            // 
            this.toolStripComboBoxTruncated.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.toolStripComboBoxTruncated.Name = "toolStripComboBoxTruncated";
            this.toolStripComboBoxTruncated.Size = new System.Drawing.Size(75, 60);
            this.toolStripComboBoxTruncated.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxTruncated_SelectedIndexChanged);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripLabel4.Size = new System.Drawing.Size(190, 57);
            this.toolStripLabel4.Text = "Handle Size:";
            // 
            // toolStripComboBoxhandleSize
            // 
            this.toolStripComboBoxhandleSize.Name = "toolStripComboBoxhandleSize";
            this.toolStripComboBoxhandleSize.Size = new System.Drawing.Size(75, 60);
            this.toolStripComboBoxhandleSize.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxhandleSize_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBarStatusStrip,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelUnlabeledFolderSelected,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelLabeledFolderSelected});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1628);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 37, 0);
            this.statusStrip1.Size = new System.Drawing.Size(3547, 46);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBarStatusStrip
            // 
            this.progressBarStatusStrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBarStatusStrip.Name = "progressBarStatusStrip";
            this.progressBarStatusStrip.Size = new System.Drawing.Size(267, 40);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(246, 41);
            this.toolStripStatusLabel1.Text = "Unlabeled folder:";
            // 
            // toolStripStatusLabelUnlabeledFolderSelected
            // 
            this.toolStripStatusLabelUnlabeledFolderSelected.Name = "toolStripStatusLabelUnlabeledFolderSelected";
            this.toolStripStatusLabelUnlabeledFolderSelected.Size = new System.Drawing.Size(266, 41);
            this.toolStripStatusLabelUnlabeledFolderSelected.Text = "no folder selected!";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(215, 41);
            this.toolStripStatusLabel2.Text = "Labeled folder:";
            // 
            // toolStripStatusLabelLabeledFolderSelected
            // 
            this.toolStripStatusLabelLabeledFolderSelected.Name = "toolStripStatusLabelLabeledFolderSelected";
            this.toolStripStatusLabelLabeledFolderSelected.Size = new System.Drawing.Size(266, 41);
            this.toolStripStatusLabelLabeledFolderSelected.Text = "no folder selected!";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(648, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2867, 1548);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(791, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.pictureBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseWheel);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(0, 649);
            this.button3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(632, 277);
            this.button3.TabIndex = 5;
            this.button3.Text = "/train /val";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTipUlabeledButton.SetToolTip(this.button3, resources.GetString("button3.ToolTip"));
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(632, 277);
            this.button1.TabIndex = 4;
            this.button1.TabStop = false;
            this.button1.Text = "Unlabeled";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTipUlabeledButton.SetToolTip(this.button1, "Select the folder with unlabeled images.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(0, 358);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(632, 277);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.Text = "Labeled";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTipUlabeledButton.SetToolTip(this.button2, resources.GetString("button2.ToolTip"));
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(3547, 1674);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBoxObjectClasses);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.KeyboardFocus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Friendly KITTI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBoxObjectClasses.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBoxObjectClasses;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label KeyboardFocus;
        private ColorDialog colorDialog1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelUnlabeledFolderSelected;
        private Panel panelObjectClasses;
        private Panel panel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBoxTruncated;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButtonPrevious;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButtonNext;
        private ToolTip toolTipUlabeledButton;
        private ToolStripButton toolStripButton2;
        private ToolStripComboBox toolStripComboBoxSelectImage;
        private ToolStripComboBox toolStripComboBoxTruncated;
        private ToolStripProgressBar progressBarStatusStrip;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel toolStripLabel3;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabelLabeledFolderSelected;
        private ToolStripLabel toolStripStatuImageOf;
        private ToolStripComboBox toolStripComboBoxhandleSize;
        private ToolStripLabel toolStripLabel4;
        private ToolStripButton toolStripButtonSavingSwitch;
    }
}

