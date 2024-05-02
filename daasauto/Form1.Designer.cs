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
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            Roadtrack = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Roadtrack).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(Roadtrack);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 437);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(171, 500);
            button1.Name = "button1";
            button1.Size = new Size(103, 36);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 452);
            label1.Name = "label1";
            label1.Size = new Size(427, 45);
            label1.TabIndex = 2;
            label1.Text = "Score: 0";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 550);
            label2.Name = "label2";
            label2.Size = new Size(429, 149);
            label2.TabIndex = 3;
            label2.Text = "Press and Right to move the car.\r\n\r\nDont hit any cars!\r\n\r\nDRIVE AS THE TRUE BMW DRIVER SHOULD.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Roadtrack
            // 
            Roadtrack.Image = Properties.Resources.roadTrack;
            Roadtrack.Location = new Point(0, 0);
            Roadtrack.Name = "Roadtrack";
            Roadtrack.Size = new Size(427, 437);
            Roadtrack.TabIndex = 0;
            Roadtrack.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 708);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "BMW simulator";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Roadtrack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label2;
        private PictureBox Roadtrack;
    }
}
