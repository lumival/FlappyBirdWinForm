
namespace FlappyBirdWinForm
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
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.groundBox = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::FlappyBirdWinForm.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(46, 181);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(71, 60);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // groundBox
            // 
            this.groundBox.Image = global::FlappyBirdWinForm.Properties.Resources.ground;
            this.groundBox.Location = new System.Drawing.Point(-10, 591);
            this.groundBox.Name = "groundBox";
            this.groundBox.Size = new System.Drawing.Size(611, 130);
            this.groundBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groundBox.TabIndex = 1;
            this.groundBox.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::FlappyBirdWinForm.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(375, 374);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(97, 232);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::FlappyBirdWinForm.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(456, -5);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(96, 206);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 3;
            this.pipeTop.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.scoreText.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold);
            this.scoreText.Location = new System.Drawing.Point(106, 626);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(139, 39);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(585, 674);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.groundBox);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.flappyBird);
            this.Name = "Form1";
            this.Text = "Flappy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox groundBox;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

