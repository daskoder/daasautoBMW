namespace daasauto
{
    public partial class Form1 : Form
    {
        int roadspeed;
        int trafficspeed;
        int playerspeed = 12;
        int score;
        int carimage;

        Random rand = new Random();
        Random carposition = new Random();

        bool goleft, goright;


        public Form1()
        {
            InitializeComponent();
            Resetgame();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goleft = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
            score++;

            if (goleft == true && player.Left > 8)
            {
                player.Left -= playerspeed;
            }
            if (goright == true && player.Left < 365)
            {
                player.Left += playerspeed;
            }

            road1.Top += roadspeed;
            road2.Top += roadspeed;
            if (road2.Top > 470)
            {
                road2.Top = -470;
            }
            if (road1.Top > 470)
            {
                road1.Top = -470;
            }

            AI1.Top += trafficspeed;
            AI2.Top += trafficspeed;

            if (AI1.Top > 471)
            {
                changeaicars(AI1);
            }
            if (AI2.Top > 471)
            {
                changeaicars(AI2);
            }
            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameover();
            }
            if (score > 40 && score < 500)
            {
                award.Image = Properties.Resources.bronze;
            }
            if (score > 500 && score < 2000)
            {
                award.Image = Properties.Resources.silver;
                roadspeed = 20;
                trafficspeed = 20;
            }
            if (score > 2000)
            {
                award.Image = Properties.Resources.gold;
                trafficspeed = 27;
                roadspeed = 25;
            }
        }
        private void changeaicars(PictureBox tempcar)
        {
            carimage = rand.Next(1, 9);

            switch (carimage)
            {
                case 1: tempcar.Image = Properties.Resources.ambulance; break;
                case 2: tempcar.Image = Properties.Resources.carGreen; break;
                case 3: tempcar.Image = Properties.Resources.carGrey; break;
                case 4: tempcar.Image = Properties.Resources.carOrange; break;
                case 5: tempcar.Image = Properties.Resources.carPink; break;
                case 6: tempcar.Image = Properties.Resources.CarRed; break;
                case 7: tempcar.Image = Properties.Resources.carYellow; break;
                case 8: tempcar.Image = Properties.Resources.TruckBlue; break;
                case 9: tempcar.Image = Properties.Resources.TruckWhite; break;

            }
            tempcar.Top = carposition.Next(100, 380) * -1;

            if ((string)tempcar.Tag == "carLeft")
            {
                tempcar.Left = carposition.Next(5, 180);
            }
            if ((string)tempcar.Tag == "carRight")
            {
                tempcar.Left = carposition.Next(226, 350);
            }
        }
        private void gameover()
        {
            playsound();
            gameTimer.Stop();
            boom.Visible = true;
            player.Controls.Add(boom);
            boom.Location = new Point(-8, 5);
            boom.BackColor = Color.Transparent;
            award.Visible = true;
            award.BringToFront();

            startee.Enabled = true;
        }
        private void Resetgame()
        {
            startee.Enabled = false;
            boom.Visible = false;
            award.Visible = false;
            goleft = false;
            goright = false;
            score = 0;
            award.Image = Properties.Resources.bronze;

            roadspeed = 12;
            trafficspeed = 15;
            AI1.Top = carposition.Next(200, 450) * -1;
            AI1.Left = carposition.Next(3, 173);

            AI2.Top = carposition.Next(200, 450) * -1;
            AI2.Left = carposition.Next(227, 374);
            gameTimer.Start();
        }

        private void playsound()
        {
            System.Media.SoundPlayer sounding = new System.Media.SoundPlayer(Properties.Resources.metal_pipe_falling_sound_effect_made_with_Voicemod);
        sounding.Play();
        }

        private void AI2_Click(object sender, EventArgs e)
        {

        }

        private void AI1_Click(object sender, EventArgs e)
        {

        }

        private void restartgame(object sender, EventArgs e)
        {
            Resetgame();
        }
    }
}
