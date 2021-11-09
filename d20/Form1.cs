using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Media;
using System.Windows;




namespace d20
{




    public partial class Form1 : Form
    {


        


        private static bool IsAnimating(PictureBox box)
        {
            var fi = box.GetType().GetField("currentlyAnimating",
                BindingFlags.NonPublic | BindingFlags.Instance);
            return (bool)fi.GetValue(box);
        }
        private static void Animate(PictureBox d20Gif, bool enable)
        {
            d20Gif.Enabled = true;
            var anim = d20Gif.GetType().GetMethod("Animate",
                BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { typeof(bool) }, null);
            anim.Invoke(d20Gif, new object[] { enable });

        }

        public int modifier = 0;

        public Form1()
        {
            

            InitializeComponent();

         

        }

        int movX = 0, movY = 0,mov;
       


        private void Form1_Load(object sender, EventArgs e)
        {
            d20Gif.Enabled = false;

            

    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }



        private void playSoundFromResource(object sender, EventArgs e)
        {
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream s = a.GetManifestResourceStream("<AssemblyName>.bruh.wav");
            SoundPlayer player = new SoundPlayer(s);
            player.Play();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            Animate(d20Gif, !IsAnimating(d20Gif));
            bool modifierZero;


            Random r = new Random();

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            //roll and modifier
            int d20roll = r.Next(1, 21);

            //sound
            bruh1.Text = " ";
            bruh2.Text = " ";
            //

            int modRoll = d20roll;
            d20roll = d20roll + modifier;

            string modRollString = modRoll.ToString();
            string modifierString = modifier.ToString();

            //mod location and correction without modifier
            if (modifier == 0)
            {
                modplusroll.Text = modRollString;
                modifierZero = true;
            }
            else
            {
                modifierZero = false;
            }

            if( modifierZero==true && modRoll <10)
            {
                modplusroll.Location = new Point((int)227, (int)88);
            }

            if(modifier==0 && modRoll >= 10)
            {
                modplusroll.Location = new Point((int)222, (int)88);
            }
            //

            //mod location and correction with modifier
            if (modifierZero == false && modRoll < 10)
            {
                modplusroll.Location = new Point((int)219, (int)88);
            }

            if (modifierZero == false && modRoll >= 10)
            {
                modplusroll.Location = new Point((int)213, (int)88);
            }

           
            //


            //mod text minus or plus correction
            if (modifier>0)
            { 
            modplusroll.Text = modRollString+"+"+ modifierString;
                
            }
            if (modifier<0)
            {

                modplusroll.Text = modRollString + modifierString;

            }

            string d20rollString = d20roll.ToString();
            //
            

            //bruh
            if (d20roll == 1)
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(d20.Properties.Resources.bruh);
                player.Play();
                bruh1.Text = "BRUH";
                bruh2.Text = "BRUH";
            }
           
            //

            //nice
            if (d20roll == 20)
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(d20.Properties.Resources.successsound);
                player.Play();
                bruh1.Text = "NICE!";
                bruh2.Text = "NICE!";
            }
          
            //
            //roll location alignment
            if (d20roll >= 0 && d20roll < 10)
            {

                lblChangeText.Location = new Point((int)224, (int)118);

            }
            else
            {

                lblChangeText.Location = new Point((int)218, (int)118);

            }

            
            lblChangeText.Text = d20rollString;

            if (d20roll < 10 && d20roll < 0)
            {

                lblChangeText.Location = new Point((int)218, (int)118);

            }
            //
        }

        private void lblChangeText_Click(object sender, EventArgs e)
        {

        }

        private void d20Gif_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void movingPanel_Click(object sender, EventArgs e)
        {
            
        }


        private void movingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void movingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void buttonPlus1_Click(object sender, EventArgs e)
        {
            if (modifier < 5)
            {
                modifier++;
            }
            else
            {
                modifier = 5;
            }
            //location
            if (modifier < 0)
            {
                mod.Location = new Point((int)220, (int)267);
            }
            else
            {
                mod.Location = new Point((int)223, (int)267);
            }

            string modString = modifier.ToString();
            mod.Text = modString;

        }

        private void buttonMinus1_Click(object sender, EventArgs e)
        {

            if (modifier > -5)
            {
                modifier--;
            }
            else
            {
                modifier = -5;
            }
            
            //location
            if (modifier<0)
            {
                mod.Location = new Point((int)220, (int)267);
            }
            else
            {
                mod.Location = new Point((int)223, (int)267);
            }
            //

            string modString = modifier.ToString();
            mod.Text = modString;
        }

        private void mod_Click(object sender, EventArgs e)
        {
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mod.Location = new Point((int)223, (int)267);
            modifier = 0;
            string modString = modifier.ToString();
            mod.Text = modString;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void movingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov==1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }


        }

        private void bruh1_Click(object sender, EventArgs e)
        {

        }


    }
}





