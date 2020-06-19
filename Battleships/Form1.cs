using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

//public static class Globals
//{
//    public static int se
//}

namespace Battleships
{
    public partial class Form1 : Form
    {
        int TimerSec = 0;
        int TimerMin = 0;

        int Score = 0;
        int Misses = 0;

        //int[] leaderBoard = new int[10];

        //double seed = Math.Sqrt(DateTime.Now.Second * DateTime.Now.Millisecond * DateTime.Now.Minute);

        int[] BoatLocations = new int[20];

        int remainingShips = 20;

        public Form1(string playerName)
        {
            InitializeComponent();
            label1.Text = playerName;

            RandomizeShipLocations();
        }


        private void RandomizeShipLocations()
        {
            var rnd = new Random();
            var RandomNumbers = Enumerable.Range(1, 100).OrderBy(x => rnd.Next()).Take(100).ToList();
            for (int i = 0; i < BoatLocations.Length; i++)
            {
                BoatLocations[i] = RandomNumbers[i];
            }
        }

        private void Check(int x, Button b)
        {
            //List<Button> btnList = Enumerable.Range(1, 100).Select(i => (Button)this.Controls["button" + i.ToString()]).ToList();

            //Button[] buttons = this.Controls.OfType<Button>().ToArray();

            //label5.Text = Convert.ToString(buttons[0]);

                if (Score == 19 && BoatLocations.Contains(x))//win condition
                {
                    label7HIT.Text = "20";
                    label7REM.Text = "0";
                    tableLayoutPanel1.Hide();
                    timer1.Stop();

                    int EndScore = Score - Misses;
                    string EndTimer = label4.Text;
                    string endMessageLast = "You won!\nYour score was " + EndScore + " !\nWith a time of " + EndTimer;
                    MessageBox.Show(endMessageLast, "Results", MessageBoxButtons.OK);

                    resetAllImages();
                    restartToolStripMenuItem.PerformClick();
                }
                else
                {
                    if (BoatLocations.Contains(x))
                    {
                        //hit
                        b.Enabled = false;
                        b.Image = System.Drawing.Image.FromFile("hit.png");
                        Score++;
                        remainingShips--;
                        UpdateScore();
                    }
                    else
                    {
                        //miss
                        b.Enabled = false;
                        b.Image = System.Drawing.Image.FromFile("miss.png");
                        Misses++;
                        UpdateScore();
                    }
                }
        }

        private void UpdateScore()
        {
            label7HIT.Text = Convert.ToString(Score);
            label8MISS.Text = Convert.ToString(Misses);
            label7REM.Text = Convert.ToString(remainingShips);
        }

        

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)//game start/restart
        {
            tableLayoutPanel1.Show();
            timer1.Stop();
            timer1.Start();
            Score = 0;
            Misses = 0;

            RandomizeShipLocations();

            foreach (Control ctrl in tableLayoutPanel1.Controls)
            {
                ctrl.Enabled = Enabled;
                ctrl.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerSec++;

            int bruh = TimerSec.ToString().Length;

            if (bruh == 1)
            {
                label4.Text = TimerMin + ":0" + TimerSec;
            }
            else
            {
                label4.Text = TimerMin + ":" + TimerSec;
                if (TimerSec == 59)
                {
                    TimerMin++;
                    TimerSec = -1;
                }
            }
            
        }


        private void sendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sendFeedback = new ProcessStartInfo("mailto:domagoj.furdi@gmail.com");
            Process.Start(sendFeedback);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You must hit all of the 20 ships on the field to win.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutBattleshipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creator - Furdi", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region a
        private void resetAllImages()
        {
            TimerMin = 0;
            TimerSec = 0;
            remainingShips = 20;

            button1.Image = null;
            button2.Image = null;
            button3.Image = null;
            button4.Image = null;
            button5.Image = null;
            button6.Image = null;
            button7.Image = null;
            button8.Image = null;
            button9.Image = null;
            button10.Image = null;
            button11.Image = null;
            button12.Image = null;
            button13.Image = null;
            button14.Image = null;
            button15.Image = null;
            button16.Image = null;
            button17.Image = null;
            button18.Image = null;
            button19.Image = null;
            button20.Image = null;
            button21.Image = null;
            button22.Image = null;
            button23.Image = null;
            button24.Image = null;
            button25.Image = null;
            button26.Image = null;
            button27.Image = null;
            button28.Image = null;
            button29.Image = null;
            button30.Image = null;
            button31.Image = null;
            button32.Image = null;
            button33.Image = null;
            button34.Image = null;
            button35.Image = null;
            button36.Image = null;
            button37.Image = null;
            button38.Image = null;
            button39.Image = null;
            button40.Image = null;
            button41.Image = null;
            button42.Image = null;
            button43.Image = null;
            button44.Image = null;
            button45.Image = null;
            button46.Image = null;
            button47.Image = null;
            button48.Image = null;
            button49.Image = null;
            button50.Image = null;
            button51.Image = null;
            button52.Image = null;
            button53.Image = null;
            button54.Image = null;
            button55.Image = null;
            button56.Image = null;
            button57.Image = null;
            button58.Image = null;
            button59.Image = null;
            button60.Image = null;
            button61.Image = null;
            button62.Image = null;
            button63.Image = null;
            button64.Image = null;
            button65.Image = null;
            button66.Image = null;
            button67.Image = null;
            button68.Image = null;
            button69.Image = null;
            button70.Image = null;
            button71.Image = null;
            button72.Image = null;
            button73.Image = null;
            button74.Image = null;
            button75.Image = null;
            button76.Image = null;
            button77.Image = null;
            button78.Image = null;
            button79.Image = null;
            button80.Image = null;
            button81.Image = null;
            button82.Image = null;
            button83.Image = null;
            button84.Image = null;
            button85.Image = null;
            button86.Image = null;
            button87.Image = null;
            button88.Image = null;
            button89.Image = null;
            button90.Image = null;
            button91.Image = null;
            button92.Image = null;
            button93.Image = null;
            button94.Image = null;
            button95.Image = null;
            button96.Image = null;
            button97.Image = null;
            button98.Image = null;
            button99.Image = null;
            button100.Image = null;
        }
        #endregion

        #region BUTTONS

        private void button1_Click(object sender, EventArgs e)
        {
            Check(1, button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Check(2, button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Check(3, button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Check(4, button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Check(5, button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Check(6, button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Check(7, button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Check(8, button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Check(9, button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Check(10, button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Check(11, button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Check(12, button12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Check(13, button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Check(14, button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Check(15, button15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Check(16, button16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Check(17, button17);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Check(18, button18);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Check(19, button19);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Check(20, button20);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Check(21, button21);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Check(22, button22);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Check(23, button23);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Check(24, button24);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Check(25, button25);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Check(26, button26);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Check(27, button27);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Check(28, button28);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Check(29, button29);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Check(30, button30);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Check(31, button31);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Check(32, button32);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Check(33, button33);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Check(34, button34);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Check(35, button35);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Check(36, button36);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Check(37, button37);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Check(38, button38);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Check(39, button39);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Check(40, button40);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Check(41, button41);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Check(42, button42);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Check(43, button43);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Check(44, button44);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Check(45, button45);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Check(46, button46);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Check(47, button47);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Check(48, button48);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Check(49, button49);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Check(50, button50);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Check(51, button51);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            Check(52, button52);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Check(53, button53);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Check(54, button54);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            Check(55, button55);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            Check(56, button56);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            Check(57, button57);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            Check(58, button58);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            Check(59, button59);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            Check(60, button60);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            Check(61, button61);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            Check(62, button62);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            Check(63, button63);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            Check(64, button64);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            Check(65, button65);
        }

        private void button66_Click(object sender, EventArgs e)
        {
            Check(66, button66);
        }

        private void button67_Click(object sender, EventArgs e)
        {
            Check(67, button67);
        }

        private void button68_Click(object sender, EventArgs e)
        {
            Check(68, button68);
        }

        private void button69_Click(object sender, EventArgs e)
        {
            Check(69, button69);
        }

        private void button70_Click(object sender, EventArgs e)
        {
            Check(70, button70);
        }

        private void button71_Click(object sender, EventArgs e)
        {
            Check(71, button71);
        }

        private void button72_Click(object sender, EventArgs e)
        {
            Check(72, button72);
        }

        private void button73_Click(object sender, EventArgs e)
        {
            Check(73, button73);
        }

        private void button74_Click(object sender, EventArgs e)
        {
            Check(74, button74);
        }

        private void button75_Click(object sender, EventArgs e)
        {
            Check(75, button75);
        }

        private void button76_Click(object sender, EventArgs e)
        {
            Check(76, button76);
        }

        private void button77_Click(object sender, EventArgs e)
        {
            Check(77, button77);
        }

        private void button78_Click(object sender, EventArgs e)
        {
            Check(78, button78);
        }

        private void button79_Click(object sender, EventArgs e)
        {
            Check(79, button79);
        }

        private void button80_Click(object sender, EventArgs e)
        {
            Check(80, button80);
        }

        private void button81_Click(object sender, EventArgs e)
        {
            Check(81, button81);
        }

        private void button82_Click(object sender, EventArgs e)
        {
            Check(82, button82);
        }

        private void button83_Click(object sender, EventArgs e)
        {
            Check(83, button83);
        }

        private void button84_Click(object sender, EventArgs e)
        {
            Check(84, button84);
        }

        private void button85_Click(object sender, EventArgs e)
        {
            Check(85, button85);
        }

        private void button86_Click(object sender, EventArgs e)
        {
            Check(86, button86);
        }

        private void button87_Click(object sender, EventArgs e)
        {
            Check(87, button87);
        }

        private void button88_Click(object sender, EventArgs e)
        {
            Check(88, button88);
        }

        private void button89_Click(object sender, EventArgs e)
        {
            Check(89, button89);
        }

        private void button90_Click(object sender, EventArgs e)
        {
            Check(90, button90);
        }

        private void button91_Click(object sender, EventArgs e)
        {
            Check(91, button91);
        }

        private void button92_Click(object sender, EventArgs e)
        {
            Check(92, button92);
        }

        private void button93_Click(object sender, EventArgs e)
        {
            Check(93, button93);
        }

        private void button94_Click(object sender, EventArgs e)
        {
            Check(94, button94);
        }

        private void button95_Click(object sender, EventArgs e)
        {
            Check(95, button95);
        }

        private void button96_Click(object sender, EventArgs e)
        {
            Check(96, button96);
        }

        private void button97_Click(object sender, EventArgs e)
        {
            Check(97, button97);
        }

        private void button98_Click(object sender, EventArgs e)
        {
            Check(98, button98);
        }

        private void button99_Click(object sender, EventArgs e)
        {
            Check(99, button99);
        }

        private void button100_Click(object sender, EventArgs e)
        {
            Check(100, button100);
        }

        #endregion
    }
}