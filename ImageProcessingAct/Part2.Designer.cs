namespace ImageProcessingAct
{
    partial class Part2
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxA = new System.Windows.Forms.PictureBox();
            this.pictureBoxB = new System.Windows.Forms.PictureBox();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.buttonLoad1 = new System.Windows.Forms.Button();
            this.buttonLoad2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonUseWebcam = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxA
            // 
            this.pictureBoxA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxA.Location = new System.Drawing.Point(18, 45);
            this.pictureBoxA.Name = "pictureBoxA";
            this.pictureBoxA.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxA.TabIndex = 0;
            this.pictureBoxA.TabStop = false;
            this.pictureBoxA.Click += new System.EventHandler(this.pictureBoxA_Click);
            // 
            // pictureBoxB
            // 
            this.pictureBoxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxB.Location = new System.Drawing.Point(437, 45);
            this.pictureBoxB.Name = "pictureBoxB";
            this.pictureBoxB.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxB.TabIndex = 1;
            this.pictureBoxB.TabStop = false;
            this.pictureBoxB.Click += new System.EventHandler(this.pictureBoxB_Click);
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResult.Location = new System.Drawing.Point(858, 45);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResult.TabIndex = 2;
            this.pictureBoxResult.TabStop = false;
            this.pictureBoxResult.Click += new System.EventHandler(this.pictureBoxResult_Click);
            // 
            // buttonLoad1
            // 
            this.buttonLoad1.Location = new System.Drawing.Point(105, 16);
            this.buttonLoad1.Name = "buttonLoad1";
            this.buttonLoad1.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad1.TabIndex = 3;
            this.buttonLoad1.Text = "Load Image";
            this.buttonLoad1.UseVisualStyleBackColor = true;
            this.buttonLoad1.Click += new System.EventHandler(this.buttonLoad1_Click);
            // 
            // buttonLoad2
            // 
            this.buttonLoad2.Location = new System.Drawing.Point(596, 16);
            this.buttonLoad2.Name = "buttonLoad2";
            this.buttonLoad2.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad2.TabIndex = 4;
            this.buttonLoad2.Text = "Load Image";
            this.buttonLoad2.UseVisualStyleBackColor = true;
            this.buttonLoad2.Click += new System.EventHandler(this.buttonLoad2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(992, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1093, 16);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save Image";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Location = new System.Drawing.Point(958, 16);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(75, 23);
            this.buttonSubtract.TabIndex = 7;
            this.buttonSubtract.Text = "Subtract";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(947, 451);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(311, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 180;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(858, 451);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(86, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Green Threshold";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(947, 487);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(311, 45);
            this.trackBar3.TabIndex = 11;
            this.trackBar3.Value = 100;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(858, 487);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(86, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Red/Blue Max";
            // 
            // buttonUseWebcam
            // 
            this.buttonUseWebcam.Location = new System.Drawing.Point(248, 16);
            this.buttonUseWebcam.Name = "buttonUseWebcam";
            this.buttonUseWebcam.Size = new System.Drawing.Size(75, 23);
            this.buttonUseWebcam.TabIndex = 13;
            this.buttonUseWebcam.Text = "Webcam";
            this.buttonUseWebcam.UseVisualStyleBackColor = true;
            this.buttonUseWebcam.Click += new System.EventHandler(this.buttonUseWebcam_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Part2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUseWebcam);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLoad2);
            this.Controls.Add(this.buttonLoad1);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.pictureBoxB);
            this.Controls.Add(this.pictureBoxA);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Part2";
            this.Size = new System.Drawing.Size(1273, 532);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxA;
        private System.Windows.Forms.PictureBox pictureBoxB;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.Button buttonLoad1;
        private System.Windows.Forms.Button buttonLoad2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonUseWebcam;
        private System.Windows.Forms.Timer timer1;
    }
}
