namespace daasauto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            road1 = new PictureBox();
            boom = new PictureBox();
            award = new PictureBox();
            AI1 = new PictureBox();
            AI2 = new PictureBox();
            player = new PictureBox();
            road2 = new PictureBox();
            Roadtrack = new PictureBox();
            startee = new Button();
            txtScore = new Label();
            label2 = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)road1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)award).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)road2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Roadtrack).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(road1);
            panel1.Controls.Add(boom);
            panel1.Controls.Add(award);
            panel1.Controls.Add(AI1);
            panel1.Controls.Add(AI2);
            panel1.Controls.Add(player);
            panel1.Controls.Add(road2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 437);
            panel1.TabIndex = 0;
            // 
            // road1
            // 
            road1.Image = Properties.Resources.roadTrack;
            road1.Location = new Point(2, -470);
            road1.Name = "road1";
            road1.Size = new Size(427, 437);
            road1.SizeMode = PictureBoxSizeMode.StretchImage;
            road1.TabIndex = 10;
            road1.TabStop = false;
            // 
            // boom
            // 
            boom.Image = Properties.Resources.bang;
            boom.Location = new Point(74, 308);
            boom.Name = "boom";
            boom.Size = new Size(59, 50);
            boom.SizeMode = PictureBoxSizeMode.StretchImage;
            boom.TabIndex = 9;
            boom.TabStop = false;
            boom.Tag = "boom";
            // 
            // award
            // 
            award.Image = Properties.Resources.bronze;
            award.Location = new Point(95, 191);
            award.Name = "award";
            award.Size = new Size(250, 100);
            award.SizeMode = PictureBoxSizeMode.StretchImage;
            award.TabIndex = 8;
            award.TabStop = false;
            award.Tag = "award";
            // 
            // AI1
            // 
            AI1.Image = Properties.Resources.carGrey;
            AI1.Location = new Point(95, 52);
            AI1.Name = "AI1";
            AI1.Size = new Size(50, 100);
            AI1.SizeMode = PictureBoxSizeMode.AutoSize;
            AI1.TabIndex = 7;
            AI1.TabStop = false;
            AI1.Tag = "carleft";
            AI1.Click += AI1_Click;
            // 
            // AI2
            // 
            AI2.Image = Properties.Resources.carGreen;
            AI2.Location = new Point(359, 51);
            AI2.Name = "AI2";
            AI2.Size = new Size(50, 101);
            AI2.SizeMode = PictureBoxSizeMode.AutoSize;
            AI2.TabIndex = 6;
            AI2.TabStop = false;
            AI2.Tag = "carright";
            AI2.Click += AI2_Click;
            // 
            // player
            // 
            player.Image = Properties.Resources.carYellow;
            player.Location = new Point(193, 335);
            player.Name = "player";
            player.Size = new Size(50, 99);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 5;
            player.TabStop = false;
            // 
            // road2
            // 
            road2.Image = Properties.Resources.roadTrack;
            road2.Location = new Point(0, 0);
            road2.Name = "road2";
            road2.Size = new Size(427, 437);
            road2.SizeMode = PictureBoxSizeMode.StretchImage;
            road2.TabIndex = 4;
            road2.TabStop = false;
            // 
            // Roadtrack
            // 
            Roadtrack.Image = Properties.Resources.roadTrack;
            Roadtrack.Location = new Point(12, -450);
            Roadtrack.Name = "Roadtrack";
            Roadtrack.Size = new Size(427, 430);
            Roadtrack.SizeMode = PictureBoxSizeMode.StretchImage;
            Roadtrack.TabIndex = 0;
            Roadtrack.TabStop = false;
            // 
            // startee
            // 
            startee.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            startee.Location = new Point(171, 500);
            startee.Name = "startee";
            startee.Size = new Size(103, 36);
            startee.TabIndex = 1;
            startee.Tag = "";
            startee.Text = "Start";
            startee.UseVisualStyleBackColor = true;
            startee.Click += restartgame;
            // 
            // txtScore
            // 
            txtScore.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtScore.Location = new Point(12, 452);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(427, 45);
            txtScore.TabIndex = 2;
            txtScore.Text = "Score: ";
            txtScore.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 550);
            label2.Name = "label2";
            label2.Size = new Size(429, 149);
            label2.TabIndex = 3;
            label2.Text = "Press Left and Right to move the car.\r\n\r\nDont hit any cars!\r\n\r\nDRIVE AS THE TRUE BMW DRIVER SHOULD.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 708);
            Controls.Add(Roadtrack);
            Controls.Add(label2);
            Controls.Add(txtScore);
            Controls.Add(startee);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "BMW simulator";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)road1).EndInit();
            ((System.ComponentModel.ISupportInitialize)boom).EndInit();
            ((System.ComponentModel.ISupportInitialize)award).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)road2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Roadtrack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button startee;
        private Label txtScore;
        private Label label2;
        private PictureBox Roadtrack;
        private PictureBox boom;
        private PictureBox award;
        private PictureBox AI1;
        private PictureBox AI2;
        private PictureBox player;
        private PictureBox road2;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox road1;
    }
}
