namespace NikovTesting
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RenderTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RTrackBar = new System.Windows.Forms.TrackBar();
            this.GTrackBar = new System.Windows.Forms.TrackBar();
            this.BTrackBar = new System.Windows.Forms.TrackBar();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // RenderTimer
            // 
            this.RenderTimer.Interval = 1;
            this.RenderTimer.Tick += new System.EventHandler(this.RenderTimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Rect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RTrackBar
            // 
            this.RTrackBar.Location = new System.Drawing.Point(406, 81);
            this.RTrackBar.Maximum = 255;
            this.RTrackBar.Name = "RTrackBar";
            this.RTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RTrackBar.Size = new System.Drawing.Size(45, 182);
            this.RTrackBar.TabIndex = 3;
            this.RTrackBar.ValueChanged += new System.EventHandler(this.RTrackBar_ValueChanged);
            // 
            // GTrackBar
            // 
            this.GTrackBar.Location = new System.Drawing.Point(442, 81);
            this.GTrackBar.Maximum = 255;
            this.GTrackBar.Name = "GTrackBar";
            this.GTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.GTrackBar.Size = new System.Drawing.Size(45, 182);
            this.GTrackBar.TabIndex = 4;
            this.GTrackBar.ValueChanged += new System.EventHandler(this.GTrackBar_ValueChanged);
            // 
            // BTrackBar
            // 
            this.BTrackBar.Location = new System.Drawing.Point(477, 81);
            this.BTrackBar.Maximum = 255;
            this.BTrackBar.Name = "BTrackBar";
            this.BTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BTrackBar.Size = new System.Drawing.Size(45, 182);
            this.BTrackBar.TabIndex = 5;
            this.BTrackBar.ValueChanged += new System.EventHandler(this.BTrackBar_ValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(406, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Resize";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(406, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(461, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Bitmap";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Isolate";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(406, 324);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(472, 324);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Unblur";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(525, 398);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BTrackBar);
            this.Controls.Add(this.GTrackBar);
            this.Controls.Add(this.RTrackBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Nikov Testing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer RenderTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar RTrackBar;
        private System.Windows.Forms.TrackBar GTrackBar;
        private System.Windows.Forms.TrackBar BTrackBar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button5;
    }
}

