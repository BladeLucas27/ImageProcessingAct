namespace ImageProcessingAct
{
    partial class ConvolutionMatrix
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
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBoxEdited = new System.Windows.Forms.PictureBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSmooth = new System.Windows.Forms.Button();
            this.buttonGaussian = new System.Windows.Forms.Button();
            this.buttonSharpen = new System.Windows.Forms.Button();
            this.buttonMeanRemoval = new System.Windows.Forms.Button();
            this.buttonEmbossLaplascian = new System.Windows.Forms.Button();
            this.buttonEmboss = new System.Windows.Forms.Button();
            this.buttonEmbossAllDirections = new System.Windows.Forms.Button();
            this.buttonEmbossLossy = new System.Windows.Forms.Button();
            this.buttonEmbossHorizontal = new System.Windows.Forms.Button();
            this.buttonEmbossVertical = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdited)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(26, 99);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxEdited
            // 
            this.pictureBoxEdited.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEdited.Location = new System.Drawing.Point(448, 99);
            this.pictureBoxEdited.Name = "pictureBoxEdited";
            this.pictureBoxEdited.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxEdited.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEdited.TabIndex = 1;
            this.pictureBoxEdited.TabStop = false;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(186, 55);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(73, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load Image";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(607, 55);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save Image";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSmooth
            // 
            this.buttonSmooth.Location = new System.Drawing.Point(866, 153);
            this.buttonSmooth.Name = "buttonSmooth";
            this.buttonSmooth.Size = new System.Drawing.Size(105, 23);
            this.buttonSmooth.TabIndex = 5;
            this.buttonSmooth.Text = "Smoothen";
            this.buttonSmooth.UseVisualStyleBackColor = true;
            this.buttonSmooth.Click += new System.EventHandler(this.buttonSmooth_Click);
            // 
            // buttonGaussian
            // 
            this.buttonGaussian.Location = new System.Drawing.Point(977, 153);
            this.buttonGaussian.Name = "buttonGaussian";
            this.buttonGaussian.Size = new System.Drawing.Size(105, 23);
            this.buttonGaussian.TabIndex = 6;
            this.buttonGaussian.Text = "Gaussian Blur";
            this.buttonGaussian.UseVisualStyleBackColor = true;
            this.buttonGaussian.Click += new System.EventHandler(this.buttonGaussian_Click);
            // 
            // buttonSharpen
            // 
            this.buttonSharpen.Location = new System.Drawing.Point(866, 182);
            this.buttonSharpen.Name = "buttonSharpen";
            this.buttonSharpen.Size = new System.Drawing.Size(105, 23);
            this.buttonSharpen.TabIndex = 7;
            this.buttonSharpen.Text = "Sharpen";
            this.buttonSharpen.UseVisualStyleBackColor = true;
            this.buttonSharpen.Click += new System.EventHandler(this.buttonSharpen_Click);
            // 
            // buttonMeanRemoval
            // 
            this.buttonMeanRemoval.Location = new System.Drawing.Point(977, 183);
            this.buttonMeanRemoval.Name = "buttonMeanRemoval";
            this.buttonMeanRemoval.Size = new System.Drawing.Size(105, 23);
            this.buttonMeanRemoval.TabIndex = 8;
            this.buttonMeanRemoval.Text = "Mean Removal";
            this.buttonMeanRemoval.UseVisualStyleBackColor = true;
            this.buttonMeanRemoval.Click += new System.EventHandler(this.buttonMeanRemoval_Click);
            // 
            // buttonEmbossLaplascian
            // 
            this.buttonEmbossLaplascian.Location = new System.Drawing.Point(866, 266);
            this.buttonEmbossLaplascian.Name = "buttonEmbossLaplascian";
            this.buttonEmbossLaplascian.Size = new System.Drawing.Size(105, 23);
            this.buttonEmbossLaplascian.TabIndex = 10;
            this.buttonEmbossLaplascian.Text = "Laplascian";
            this.buttonEmbossLaplascian.UseVisualStyleBackColor = true;
            this.buttonEmbossLaplascian.Click += new System.EventHandler(this.buttonEmbossLaplascian_Click);
            // 
            // buttonEmboss
            // 
            this.buttonEmboss.Location = new System.Drawing.Point(977, 296);
            this.buttonEmboss.Name = "buttonEmboss";
            this.buttonEmboss.Size = new System.Drawing.Size(105, 23);
            this.buttonEmboss.TabIndex = 11;
            this.buttonEmboss.Text = "Horizontal/Vertical";
            this.buttonEmboss.UseVisualStyleBackColor = true;
            this.buttonEmboss.Click += new System.EventHandler(this.buttonEmboss_Click);
            // 
            // buttonEmbossAllDirections
            // 
            this.buttonEmbossAllDirections.Location = new System.Drawing.Point(866, 295);
            this.buttonEmbossAllDirections.Name = "buttonEmbossAllDirections";
            this.buttonEmbossAllDirections.Size = new System.Drawing.Size(105, 23);
            this.buttonEmbossAllDirections.TabIndex = 12;
            this.buttonEmbossAllDirections.Text = "All Directions";
            this.buttonEmbossAllDirections.UseVisualStyleBackColor = true;
            this.buttonEmbossAllDirections.Click += new System.EventHandler(this.buttonEmbossAllDirections_Click);
            // 
            // buttonEmbossLossy
            // 
            this.buttonEmbossLossy.Location = new System.Drawing.Point(977, 267);
            this.buttonEmbossLossy.Name = "buttonEmbossLossy";
            this.buttonEmbossLossy.Size = new System.Drawing.Size(105, 23);
            this.buttonEmbossLossy.TabIndex = 13;
            this.buttonEmbossLossy.Text = "Lossy";
            this.buttonEmbossLossy.UseVisualStyleBackColor = true;
            this.buttonEmbossLossy.Click += new System.EventHandler(this.buttonEmbossLossy_Click);
            // 
            // buttonEmbossHorizontal
            // 
            this.buttonEmbossHorizontal.Location = new System.Drawing.Point(866, 324);
            this.buttonEmbossHorizontal.Name = "buttonEmbossHorizontal";
            this.buttonEmbossHorizontal.Size = new System.Drawing.Size(105, 23);
            this.buttonEmbossHorizontal.TabIndex = 14;
            this.buttonEmbossHorizontal.Text = "Horizontal";
            this.buttonEmbossHorizontal.UseVisualStyleBackColor = true;
            this.buttonEmbossHorizontal.Click += new System.EventHandler(this.buttonEmbossHorizontal_Click);
            // 
            // buttonEmbossVertical
            // 
            this.buttonEmbossVertical.Location = new System.Drawing.Point(977, 325);
            this.buttonEmbossVertical.Name = "buttonEmbossVertical";
            this.buttonEmbossVertical.Size = new System.Drawing.Size(105, 23);
            this.buttonEmbossVertical.TabIndex = 15;
            this.buttonEmbossVertical.Text = "Vertical";
            this.buttonEmbossVertical.UseVisualStyleBackColor = true;
            this.buttonEmbossVertical.Click += new System.EventHandler(this.buttonEmbossVertical_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Location = new System.Drawing.Point(925, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Emboss Filters:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConvolutionMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonEmbossVertical);
            this.Controls.Add(this.buttonEmbossHorizontal);
            this.Controls.Add(this.buttonEmbossLossy);
            this.Controls.Add(this.buttonEmbossAllDirections);
            this.Controls.Add(this.buttonEmboss);
            this.Controls.Add(this.buttonEmbossLaplascian);
            this.Controls.Add(this.buttonMeanRemoval);
            this.Controls.Add(this.buttonSharpen);
            this.Controls.Add(this.buttonGaussian);
            this.Controls.Add(this.buttonSmooth);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.pictureBoxEdited);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Name = "ConvolutionMatrix";
            this.Size = new System.Drawing.Size(1273, 532);
            this.Load += new System.EventHandler(this.ConvolutionMatrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdited)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBoxEdited;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSmooth;
        private System.Windows.Forms.Button buttonGaussian;
        private System.Windows.Forms.Button buttonSharpen;
        private System.Windows.Forms.Button buttonMeanRemoval;
        private System.Windows.Forms.Button buttonEmbossLaplascian;
        private System.Windows.Forms.Button buttonEmboss;
        private System.Windows.Forms.Button buttonEmbossAllDirections;
        private System.Windows.Forms.Button buttonEmbossLossy;
        private System.Windows.Forms.Button buttonEmbossHorizontal;
        private System.Windows.Forms.Button buttonEmbossVertical;
        private System.Windows.Forms.TextBox textBox1;
    }
}
