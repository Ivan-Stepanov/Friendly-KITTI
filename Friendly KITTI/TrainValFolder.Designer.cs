namespace Friendly_KITTI
{
    partial class TrainValFolder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonTrainValOK = new System.Windows.Forms.Button();
            this.buttonTrainValCancel = new System.Windows.Forms.Button();
            this.textBoxPercentForValidation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxMirrorHorizontally = new System.Windows.Forms.CheckBox();
            this.checkBox90deg = new System.Windows.Forms.CheckBox();
            this.checkBox180deg = new System.Windows.Forms.CheckBox();
            this.checkBox270deg = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxMirrorVertically = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTrainValOK
            // 
            this.buttonTrainValOK.Location = new System.Drawing.Point(77, 211);
            this.buttonTrainValOK.Name = "buttonTrainValOK";
            this.buttonTrainValOK.Size = new System.Drawing.Size(109, 46);
            this.buttonTrainValOK.TabIndex = 0;
            this.buttonTrainValOK.Text = "OK";
            this.buttonTrainValOK.UseVisualStyleBackColor = true;
            this.buttonTrainValOK.Click += new System.EventHandler(this.buttonTrainValOK_Click);
            // 
            // buttonTrainValCancel
            // 
            this.buttonTrainValCancel.Location = new System.Drawing.Point(255, 214);
            this.buttonTrainValCancel.Name = "buttonTrainValCancel";
            this.buttonTrainValCancel.Size = new System.Drawing.Size(111, 42);
            this.buttonTrainValCancel.TabIndex = 1;
            this.buttonTrainValCancel.Text = "Cancel";
            this.buttonTrainValCancel.UseVisualStyleBackColor = true;
            this.buttonTrainValCancel.Click += new System.EventHandler(this.buttonTrainValCancel_Click);
            // 
            // textBoxPercentForValidation
            // 
            this.textBoxPercentForValidation.Location = new System.Drawing.Point(17, 20);
            this.textBoxPercentForValidation.Name = "textBoxPercentForValidation";
            this.textBoxPercentForValidation.Size = new System.Drawing.Size(26, 20);
            this.textBoxPercentForValidation.TabIndex = 2;
            this.textBoxPercentForValidation.Text = "25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "% of Images for validation";
            // 
            // checkBoxMirrorHorizontally
            // 
            this.checkBoxMirrorHorizontally.AutoSize = true;
            this.checkBoxMirrorHorizontally.Location = new System.Drawing.Point(62, 34);
            this.checkBoxMirrorHorizontally.Name = "checkBoxMirrorHorizontally";
            this.checkBoxMirrorHorizontally.Size = new System.Drawing.Size(78, 17);
            this.checkBoxMirrorHorizontally.TabIndex = 4;
            this.checkBoxMirrorHorizontally.Text = "horizontally";
            this.checkBoxMirrorHorizontally.UseVisualStyleBackColor = true;
            this.checkBoxMirrorHorizontally.CheckedChanged += new System.EventHandler(this.checkBoxMirrorHorizontally_CheckedChanged);
            // 
            // checkBox90deg
            // 
            this.checkBox90deg.AutoSize = true;
            this.checkBox90deg.Location = new System.Drawing.Point(273, 37);
            this.checkBox90deg.Name = "checkBox90deg";
            this.checkBox90deg.Size = new System.Drawing.Size(56, 17);
            this.checkBox90deg.TabIndex = 5;
            this.checkBox90deg.Text = "by 90°";
            this.checkBox90deg.UseVisualStyleBackColor = true;
            // 
            // checkBox180deg
            // 
            this.checkBox180deg.AutoSize = true;
            this.checkBox180deg.Location = new System.Drawing.Point(273, 60);
            this.checkBox180deg.Name = "checkBox180deg";
            this.checkBox180deg.Size = new System.Drawing.Size(62, 17);
            this.checkBox180deg.TabIndex = 6;
            this.checkBox180deg.Text = "by 180°";
            this.checkBox180deg.UseVisualStyleBackColor = true;
            // 
            // checkBox270deg
            // 
            this.checkBox270deg.AutoSize = true;
            this.checkBox270deg.Location = new System.Drawing.Point(273, 83);
            this.checkBox270deg.Name = "checkBox270deg";
            this.checkBox270deg.Size = new System.Drawing.Size(62, 17);
            this.checkBox270deg.TabIndex = 7;
            this.checkBox270deg.Text = "by 270°";
            this.checkBox270deg.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mirror";
            // 
            // checkBoxMirrorVertically
            // 
            this.checkBoxMirrorVertically.AutoSize = true;
            this.checkBoxMirrorVertically.Location = new System.Drawing.Point(62, 57);
            this.checkBoxMirrorVertically.Name = "checkBoxMirrorVertically";
            this.checkBoxMirrorVertically.Size = new System.Drawing.Size(67, 17);
            this.checkBoxMirrorVertically.TabIndex = 11;
            this.checkBoxMirrorVertically.Text = "vertically";
            this.checkBoxMirrorVertically.UseVisualStyleBackColor = true;
            this.checkBoxMirrorVertically.CheckedChanged += new System.EventHandler(this.checkBoxMirrorvertically_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "or";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rotate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPercentForValidation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 52);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Separate into \"train\" and \"val\" folders";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkBoxMirrorHorizontally);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkBox270deg);
            this.groupBox2.Controls.Add(this.checkBoxMirrorVertically);
            this.groupBox2.Controls.Add(this.checkBox180deg);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.checkBox90deg);
            this.groupBox2.Location = new System.Drawing.Point(26, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 129);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Multiply your dataset";
            // 
            // TrainValFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 275);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonTrainValCancel);
            this.Controls.Add(this.buttonTrainValOK);
            this.Name = "TrainValFolder";
            this.Text = "TrainValFolder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTrainValOK;
        private System.Windows.Forms.Button buttonTrainValCancel;
        private System.Windows.Forms.TextBox textBoxPercentForValidation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxMirrorHorizontally;
        private System.Windows.Forms.CheckBox checkBox90deg;
        private System.Windows.Forms.CheckBox checkBox180deg;
        private System.Windows.Forms.CheckBox checkBox270deg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxMirrorVertically;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}