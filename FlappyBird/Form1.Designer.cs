namespace FlappyBird
{
    partial class FlappyBirdGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBirdGame));
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeboxtop = new System.Windows.Forms.PictureBox();
            this.pipeboxBottom = new System.Windows.Forms.PictureBox();
            this.game = new System.Windows.Forms.Timer(this.components);
            this.end1 = new System.Windows.Forms.Label();
            this.maker = new System.Windows.Forms.Label();
            this.plane = new System.Windows.Forms.PictureBox();
            this.rocket = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeboxtop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeboxBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(114, 171);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(34, 28);
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-4, 391);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(338, 108);
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // pipeboxtop
            // 
            this.pipeboxtop.Image = ((System.Drawing.Image)(resources.GetObject("pipeboxtop.Image")));
            this.pipeboxtop.Location = new System.Drawing.Point(52, -54);
            this.pipeboxtop.Name = "pipeboxtop";
            this.pipeboxtop.Size = new System.Drawing.Size(70, 200);
            this.pipeboxtop.TabIndex = 2;
            this.pipeboxtop.TabStop = false;
            // 
            // pipeboxBottom
            // 
            this.pipeboxBottom.Image = ((System.Drawing.Image)(resources.GetObject("pipeboxBottom.Image")));
            this.pipeboxBottom.Location = new System.Drawing.Point(200, 247);
            this.pipeboxBottom.Name = "pipeboxBottom";
            this.pipeboxBottom.Size = new System.Drawing.Size(70, 147);
            this.pipeboxBottom.TabIndex = 3;
            this.pipeboxBottom.TabStop = false;
            // 
            // game
            // 
            this.game.Enabled = true;
            this.game.Interval = 20;
            this.game.Tick += new System.EventHandler(this.game_Tick);
            // 
            // end1
            // 
            this.end1.AutoSize = true;
            this.end1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end1.Location = new System.Drawing.Point(128, 91);
            this.end1.Name = "end1";
            this.end1.Size = new System.Drawing.Size(94, 20);
            this.end1.TabIndex = 6;
            this.end1.Text = "GameOver";
            this.end1.Visible = false;
            // 
            // maker
            // 
            this.maker.AutoSize = true;
            this.maker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maker.Location = new System.Drawing.Point(141, 211);
            this.maker.Name = "maker";
            this.maker.Size = new System.Drawing.Size(64, 20);
            this.maker.TabIndex = 7;
            this.maker.Text = "shanto";
            this.maker.Visible = false;
            // 
            // plane
            // 
            this.plane.Image = ((System.Drawing.Image)(resources.GetObject("plane.Image")));
            this.plane.Location = new System.Drawing.Point(242, 137);
            this.plane.Name = "plane";
            this.plane.Size = new System.Drawing.Size(53, 39);
            this.plane.TabIndex = 8;
            this.plane.TabStop = false;
            this.plane.Visible = false;
            // 
            // rocket
            // 
            this.rocket.Image = ((System.Drawing.Image)(resources.GetObject("rocket.Image")));
            this.rocket.Location = new System.Drawing.Point(296, 344);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(12, 41);
            this.rocket.TabIndex = 9;
            this.rocket.TabStop = false;
            // 
            // FlappyBirdGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(337, 502);
            this.Controls.Add(this.rocket);
            this.Controls.Add(this.plane);
            this.Controls.Add(this.maker);
            this.Controls.Add(this.end1);
            this.Controls.Add(this.pipeboxBottom);
            this.Controls.Add(this.pipeboxtop);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.flappyBird);
            this.Enabled = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(353, 541);
            this.MinimumSize = new System.Drawing.Size(353, 541);
            this.Name = "FlappyBirdGame";
            this.Text = "Your score is ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeboxtop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeboxBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeboxtop;
        private System.Windows.Forms.PictureBox pipeboxBottom;
        private System.Windows.Forms.Timer game;
        private System.Windows.Forms.Label end1;
        private System.Windows.Forms.Label maker;
        private System.Windows.Forms.PictureBox plane;
        private System.Windows.Forms.PictureBox rocket;
    }
}

