namespace FlappyBird
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.bird = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pipeTop.Image = global::FlappyBird.Properties.Resources.tube1;
            this.pipeTop.Location = new System.Drawing.Point(363, 290);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(79, 172);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            this.pipeTop.Click += new System.EventHandler(this.pipeTop_Click);
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.DodgerBlue;
            this.pipeBottom.Image = global::FlappyBird.Properties.Resources.tube2;
            this.pipeBottom.Location = new System.Drawing.Point(531, -1);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(89, 151);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AccessibleDescription = "";
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.CornflowerBlue;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText.Location = new System.Drawing.Point(0, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(102, 29);
            this.scoreText.TabIndex = 3;
            this.scoreText.Text = "Score: 0";
            this.scoreText.Click += new System.EventHandler(this.scoreText_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // bird
            // 
            this.bird.EditValue = ((object)(resources.GetObject("bird.EditValue")));
            this.bird.Location = new System.Drawing.Point(163, 153);
            this.bird.MinimumSize = new System.Drawing.Size(60, 40);
            this.bird.Name = "bird";
            this.bird.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bird.Properties.Appearance.Options.UseBackColor = true;
            this.bird.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopRight;
            this.bird.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.bird.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.bird.Size = new System.Drawing.Size(60, 40);
            this.bird.TabIndex = 0;
            this.bird.EditValueChanged += new System.EventHandler(this.bird_EditValueChanged);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlappyBird.Properties.Resources._21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 460);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.bird);
            this.Name = "GameForm";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.PictureEdit bird;
    }
}