using System;
using System.Windows.Forms;
using System.Media;

namespace FlappyBird
{
    public partial class FlappyBirdGame : Form
    {
        bool jumping = false;
        int pipeSpeed = 5;
        int garvity = 4;
        int gravity = 4;
        int scorer = 0;
        bool isStarted = false;

        Random rnd = new Random();

        bool tick = false;
        SoundPlayer snd;

        public FlappyBirdGame()
        {
            InitializeComponent();
            rocket.Enabled = true;
            //rocket.Visible = false;
            //Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
            snd = new SoundPlayer(System.IO.Directory.GetCurrentDirectory()  + "//flap.wav");

        }
        int count = 3;
        private void game_Tick(object sender, EventArgs e) /// thread
        {
            if (isStarted)
            {
                if (rocket.Bounds.IntersectsWith(ground.Bounds) )
                {
                    rocket.Visible = false;
                }
                else if (rocket.Bounds.IntersectsWith(pipeboxBottom.Bounds))
                {
                    rocket.Visible = false;
                }
                else if (rocket.Bounds.IntersectsWith(pipeboxtop.Bounds))
                {
                    rocket.Visible = false;
                    pipeboxtop.Visible = false;
                }
                else if (rocket.Bounds.IntersectsWith(plane.Bounds))
                {
                    rocket.Visible = false;
                    plane.Visible = false;
                }
                pipeboxBottom.Left -= pipeSpeed; // position gula change hpchhe
                pipeboxtop.Left -= pipeSpeed;
                flappyBird.Top += garvity;
                plane.Left -= pipeSpeed;
                rocket.Left -= pipeSpeed;
                rocket.Top -= gravity;
                gravity++;
                //pipeSpeed++;
                int rand = rnd.Next(-100, 10);
                if (count==0)
                {
                    plane.Visible = !plane.Visible;
                    count = 3;
                }

                
                
                this.Text = "Your score is " + scorer;

                if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
                {
                    endGme();
                }
                else if (flappyBird.Bounds.IntersectsWith(pipeboxBottom.Bounds))
                {
                    endGme();
                }
                else if (flappyBird.Bounds.IntersectsWith(pipeboxtop.Bounds)&& pipeboxtop.Visible!=false)
                {
                    endGme();
                }
                else if (flappyBird.Bounds.IntersectsWith(plane.Bounds) && plane.Visible!=false)
                {
                    endGme();
                }
                else if (flappyBird.Bounds.IntersectsWith(rocket.Bounds) && rocket.Visible != false)
                {
                    endGme();
                }
                if (pipeboxBottom.Left <= -80)
                {
                    pipeboxBottom.Left = 300;
                    scorer++;
                }
                else if (pipeboxtop.Left < -95)
                {
                    pipeboxtop.Left = 400;
                    pipeboxtop.Visible = true;
                    scorer++;
                }
                if (plane.Left<=-95)
                {
                    plane.Left = 400;
                    scorer++;
                    count--;
                    plane.Visible = true;
                }
                if (rocket.Top<=0)
                {
                    rocket.Visible = true;
                    rocket.Top = this.Height-100;
                    rocket.Left = 400;
                    scorer++;
                    gravity = 5;
                    //pipeSpeed = 5;
                }
                //Console.WriteLine(rocket.Top);
            }
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space && game.Enabled==true)
            {
                snd.Play();
                jumping = true;
                garvity = -4;
                isStarted = true; /// space chaple eta kaj kore auto
                
            }
            if (e.KeyCode==Keys.P)
            {
                game.Enabled = !game.Enabled;
            }

        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
                garvity = 4;
                isStarted = true;
            }
            
        }
        private void endGme()
        {
            snd = new SoundPlayer(System.IO.Directory.GetCurrentDirectory() + "//hurt.wav");
            snd.Play();
            game.Stop();

            end1.Visible = true;
            maker.Visible = true;
        }
    }
}
/// koto pichhi game dekho 161 matro dekhao