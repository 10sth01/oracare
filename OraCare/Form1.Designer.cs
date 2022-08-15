namespace OraCare
{
    partial class LoadingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingWindow));
            this.ORACARE = new System.Windows.Forms.Label();
            this.loadingBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ORACARE
            // 
            this.ORACARE.AutoSize = true;
            this.ORACARE.BackColor = System.Drawing.Color.Transparent;
            this.ORACARE.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORACARE.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ORACARE.Location = new System.Drawing.Point(80, 240);
            this.ORACARE.Name = "ORACARE";
            this.ORACARE.Size = new System.Drawing.Size(137, 33);
            this.ORACARE.TabIndex = 2;
            this.ORACARE.Text = "ORACARE";
            // 
            // loadingBar
            // 
            this.loadingBar.BackColor = System.Drawing.Color.AliceBlue;
            this.loadingBar.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.loadingBar.Location = new System.Drawing.Point(0, 310);
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(300, 20);
            this.loadingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loadingBar.TabIndex = 3;
            this.loadingBar.Click += new System.EventHandler(this.LoadingBar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(296, 323);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.ORACARE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingWindow";
            this.Text = "OraCare";
            this.Load += new System.EventHandler(this.LoadingWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ORACARE;
        private System.Windows.Forms.ProgressBar loadingBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

