namespace ImageProcessingAct
{
    partial class Part1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonSepia = new System.Windows.Forms.Button();
            this.buttonInvert = new System.Windows.Forms.Button();
            this.buttonGrayScale = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.pictureBoxEdited = new System.Windows.Forms.PictureBox();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBoxHistogram = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdited)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(758, 25);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Save Image";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(433, 29);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Reverse Image";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // buttonSepia
            // 
            this.buttonSepia.Location = new System.Drawing.Point(758, 56);
            this.buttonSepia.Name = "buttonSepia";
            this.buttonSepia.Size = new System.Drawing.Size(75, 23);
            this.buttonSepia.TabIndex = 20;
            this.buttonSepia.Text = "Sepia";
            this.buttonSepia.UseVisualStyleBackColor = true;
            this.buttonSepia.Click += new System.EventHandler(this.buttonSepia_Click_1);
            // 
            // buttonInvert
            // 
            this.buttonInvert.Location = new System.Drawing.Point(593, 56);
            this.buttonInvert.Name = "buttonInvert";
            this.buttonInvert.Size = new System.Drawing.Size(75, 23);
            this.buttonInvert.TabIndex = 18;
            this.buttonInvert.Text = "Invert Image";
            this.buttonInvert.UseVisualStyleBackColor = true;
            this.buttonInvert.Click += new System.EventHandler(this.buttonInvert_Click_1);
            // 
            // buttonGrayScale
            // 
            this.buttonGrayScale.Location = new System.Drawing.Point(513, 56);
            this.buttonGrayScale.Name = "buttonGrayScale";
            this.buttonGrayScale.Size = new System.Drawing.Size(75, 23);
            this.buttonGrayScale.TabIndex = 17;
            this.buttonGrayScale.Text = "Grayscale";
            this.buttonGrayScale.UseVisualStyleBackColor = true;
            this.buttonGrayScale.Click += new System.EventHandler(this.buttonGrayScale_Click_1);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(433, 56);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 16;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click_1);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(168, 56);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 15;
            this.buttonLoad.Text = "Load Image";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click_1);
            // 
            // pictureBoxEdited
            // 
            this.pictureBoxEdited.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEdited.Location = new System.Drawing.Point(433, 98);
            this.pictureBoxEdited.Name = "pictureBoxEdited";
            this.pictureBoxEdited.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxEdited.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEdited.TabIndex = 14;
            this.pictureBoxEdited.TabStop = false;
            this.pictureBoxEdited.Click += new System.EventHandler(this.pictureBoxEdited_Click_1);
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(15, 98);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginal.TabIndex = 13;
            this.pictureBoxOriginal.TabStop = false;
            this.pictureBoxOriginal.Click += new System.EventHandler(this.pictureBoxOriginal_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxHistogram
            // 
            this.pictureBoxHistogram.Location = new System.Drawing.Point(856, 98);
            this.pictureBoxHistogram.Name = "pictureBoxHistogram";
            this.pictureBoxHistogram.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxHistogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHistogram.TabIndex = 23;
            this.pictureBoxHistogram.TabStop = false;
            // 
            // Part1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxHistogram);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonSepia);
            this.Controls.Add(this.buttonInvert);
            this.Controls.Add(this.buttonGrayScale);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.pictureBoxEdited);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Part1";
            this.Size = new System.Drawing.Size(1273, 532);
            this.Load += new System.EventHandler(this.Part1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdited)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonSepia;
        private System.Windows.Forms.Button buttonInvert;
        private System.Windows.Forms.Button buttonGrayScale;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.PictureBox pictureBoxEdited;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBoxHistogram;
    }
}
