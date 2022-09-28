using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace d20
{
    public partial class Roll_History : Form
    {
        public List<PictureBox> pictureBoxes = new List<PictureBox>();
        public List<Label> labels = new List<Label>();
        List<int> rolls = new List<int>();

        public int rollCount_local;
        public Roll_History(int x,List<int> rolls)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Visible = true;

            rollCount_local = x;
            this.rolls = rolls;

            AddPBs();
            AddLBLs();
            drawHistory();
        }
        public void MakeVisible(PictureBox pictureBox)
        {
            pictureBox.Visible = true;       
        }
        public void AddLBLs()
        {
            labels.Add(lbl_history1);
            labels.Add(lbl_history2);
            labels.Add(lbl_history3);
            labels.Add(lbl_history4);
            labels.Add(lbl_history5);
            labels.Add(lbl_history6);
            labels.Add(lbl_history7);
        }
        public void AddPBs()
        {
            pictureBoxes.Add(history_1);
            pictureBoxes.Add(history_2);
            pictureBoxes.Add(history_3);
            pictureBoxes.Add(history_4);
            pictureBoxes.Add(history_5);
            pictureBoxes.Add(history_6);
            pictureBoxes.Add(history_7);
        }


        public void label_propFix() //add variables, add equation
        {
           for (int i = 0; i < rollCount_local; i++)
            {
                if (i == 0)
                    {
                        if (labels[0].Text.Length == 1)
                            labels[0].Location = new Point((pictureBoxes[0].Location.X + 64), (pictureBoxes[0].Location.Y + 63)); //235, 121  //(pictureBoxes[0].Location.X + 64), (pictureBoxes[0].Location.Y + 63)

                        if (labels[0].Text.Length == 2)
                            labels[0].Location = new Point((pictureBoxes[0].Location.X + 61), (pictureBoxes[0].Location.Y + 63)); //241, 121  //(pictureBoxes[0].Location.X + 61), (pictureBoxes[0].Location.Y + 63)
                    }
                else
                labels[i].Location = new Point((pictureBoxes[i].Location.X+41), (pictureBoxes[i].Location.Y+41));
            }
        }


        public void drawHistory()
        {
            if (rollCount_local == 0)
            {
                lbl_noRolls.Visible = true;
            }
            else
            {
                for (int i = 0; i <= rollCount_local-1; i++)
                {
                    
                    {
                        pictureBoxes[i].Visible = true;
                        pictureBoxes[i].BringToFront();
                        labels[i].Text = rolls[(rollCount_local-1)-i].ToString();
                        labels[i].Visible = true;
                        labels[i].BringToFront();
                    }
                }
            }
            label_propFix();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
