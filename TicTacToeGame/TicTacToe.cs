using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    
    public partial class TicTacToe : Form
    {
        private static bool first = false;
        private static bool second = false;
        private static bool third = false;
        private static bool fourth = false;
        private static bool fifth = false;
        private static bool sixth = false;
        private static bool seven = false;
        private static bool eight = false;
        private static bool nine = false;

        private static bool player1 = true;
        private static bool player2 = false;

        private static int counter = 0;

        private static bool endgame = false;

        private static String winner = "";
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            InitTimer();
            InitTimer2();
            InitTimer3();
            
            InitTimer5();
            label5.Visible = false;
            stop.Enabled = false;
            stop.Visible = false;
        }

        private Timer timer;
        public void InitTimer()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 2000;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            button1.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            button2.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            button3.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            button4.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            button5.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            button6.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            button7.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            button8.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            button9.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            button10.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            button11.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            button12.BackColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
        }

        private Timer timer2;
        public void InitTimer2()
        {
            timer2 = new Timer();
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 3000;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            label1.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label2.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label3.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label4.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label5.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label6.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label7.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label8.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label9.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));

            label1.Text = "O";
            label2.Text = "O";
            label3.Text = "O";
            label4.Text = "O";
            label5.Text = "O";
            label6.Text = "O";
            label7.Text = "O";
            label8.Text = "O";
            label9.Text = "O";
        }

        private Timer timer3;
        public void InitTimer3()
        {
            timer3 = new Timer();
            timer3.Tick += new EventHandler(timer3_Tick);
            timer3.Interval = 2000;
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            label1.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label2.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label3.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label4.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label5.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label6.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label7.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label8.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label9.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));

            label1.Text = "X";
            label2.Text = "X";
            label3.Text = "X";
            label4.Text = "X";
            label5.Text = "X";
            label6.Text = "X";
            label7.Text = "X";
            label8.Text = "X";
            label9.Text = "X";
        }

        private Timer timer4;
        public void InitTimer4()
        {
            timer4 = new Timer();
            timer4.Tick += new EventHandler(timer4_Tick);
            timer4.Interval = 1000;
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if(counter == 9)
            {
                if(endgame == false)
                {
                    MessageBox.Show("The match is a draw!");
                    endgame = true;
                }
                else
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;
                    timer4.Stop();
                    stop.Enabled = true;
                    stop.Visible = true;
                }
                
            } 
            else if (label1.Text.Equals("X") && label2.Text.Equals("X") && label3.Text.Equals("X"))
            {
                
                if(endgame == false)
                {
                    MessageBox.Show("The winner is player two!");
                    endgame = true;
                }
                else
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;
                    timer4.Stop();
                    stop.Enabled = true;
                    stop.Visible = true;
                }
                
            }
            else if (label1.Text.Equals("O") && label2.Text.Equals("O") && label3.Text.Equals("O"))
            {
                if(endgame == false)
                {
                    MessageBox.Show("The winner is player one!");
                    endgame = true;
                }
                else
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;
                    timer4.Stop();
                    stop.Enabled = true;
                    stop.Visible = true;
                }
            }
            else if (label4.Text.Equals("X") && label5.Text.Equals("X") && label6.Text.Equals("X"))
            {
                if(endgame == false)
                {
                    MessageBox.Show("The winner is player two!");
                    endgame = true;
                }
                else
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;
                    timer4.Stop();
                    stop.Enabled = true;
                    stop.Visible = true;
                }
            }
            else if (label4.Text.Equals("O") && label5.Text.Equals("O") && label6.Text.Equals("O"))
            {
                if(endgame == false)
                {
                    MessageBox.Show("The winner is player one!");
                    endgame = true;
                }
                else
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;
                    timer4.Stop();
                    stop.Enabled = true;
                    stop.Visible = true;
                }
            }
            else if (label7.Text.Equals("X") && label8.Text.Equals("X") && label9.Text.Equals("X"))
            {
                if(endgame == false)
                {
                    MessageBox.Show("The winner is player two!");
                    endgame = true;
                }
                else
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;
                    timer4.Stop();
                    stop.Enabled = true;
                    stop.Visible = true;
                }
            }
            else if (label7.Text.Equals("O") && label8.Text.Equals("O") && label9.Text.Equals("O"))
            {
                if(endgame == false)
                {
                    MessageBox.Show("The winner is player one!");
                    endgame = true;
                }
                else
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;
                    timer4.Stop();
                    stop.Enabled = true;
                    stop.Visible = true;
                }

            }
            else if (label1.Text.Equals("X") && label4.Text.Equals("X") && label7.Text.Equals("X"))
            {
                if(endgame == false)
                {
                    MessageBox.Show("The winner is player two!");
                    endgame = true;
                }
                else
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;
                    timer4.Stop();
                    stop.Enabled = true;
                    stop.Visible = true;
                }
            }
            else if (label1.Text.Equals("O") && label4.Text.Equals("O") && label7.Text.Equals("O"))
            {
                if(endgame == false)
                {
                    MessageBox.Show("The winner is player one!");
                    endgame = true;
                }
                else
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;
                    timer4.Stop();
                    stop.Enabled = true;
                    stop.Visible = true;
                }
            }
            else if (label2.Text.Equals("X") && label5.Text.Equals("X") && label8.Text.Equals("X"))
            {
                if(endgame == false)
                {
                    MessageBox.Show("The winner is player two!");
                    endgame = true;
                }
                else
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;
                    timer4.Stop();
                    stop.Enabled = true;
                    stop.Visible = true;
                }
            }
            else if (label2.Text.Equals("O") && label5.Text.Equals("O") && label8.Text.Equals("O"))
            {
                if(endgame == false)
                {
                    MessageBox.Show("The winner is player one!");
                    endgame = true;
                }
                else
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;
                    timer4.Stop();
                    stop.Enabled = true;
                    stop.Visible = true;
                }
            }
            else if (label3.Text.Equals("X") && label6.Text.Equals("X") && label9.Text.Equals("X"))
            {
                if(endgame == false)
                {
                    MessageBox.Show("The winner is player two!");
                    endgame = true;
                }
                else
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;
                    timer4.Stop();
                    stop.Enabled = true;
                    stop.Visible = true;
                }
            }
            else if (label3.Text.Equals("O") && label6.Text.Equals("O") && label9.Text.Equals("O"))
            {
                if(endgame == false)
                {
                    MessageBox.Show("The winner is player one!");
                    endgame = true;
                }
                else
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;
                    timer4.Stop();
                    stop.Enabled = true;
                    stop.Visible = true;
                }
            }
            else if (label1.Text.Equals("X") && label5.Text.Equals("X") && label9.Text.Equals("X"))
            {
                if(endgame == false)
                {
                    MessageBox.Show("The winner is player two!");
                    endgame = true;
                }
                else
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;
                    timer4.Stop();
                    stop.Enabled = true;
                    stop.Visible = true;
                }
            }
            else if (label1.Text.Equals("O") && label5.Text.Equals("O") && label9.Text.Equals("O"))
            {
                if(endgame == false)
                {
                    MessageBox.Show("The winner is player one!");
                    endgame = true;
                }
                else
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;
                    timer4.Stop();
                    stop.Enabled = true;
                    stop.Visible = true;
                }
            }
            else if (label3.Text.Equals("X") && label5.Text.Equals("X") && label7.Text.Equals("X"))
            {
                if(endgame == false)
                {
                    MessageBox.Show("The winner is player two!");
                    endgame = true;
                }
                else
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;
                    timer4.Stop();
                    stop.Enabled = true;
                    stop.Visible = true;
                }
            }
            else if (label3.Text.Equals("O") && label5.Text.Equals("O") && label7.Text.Equals("O"))
            {
                if(endgame == false)
                {
                    MessageBox.Show("The winner is player one!");
                    endgame = true;
                }
                else
                {
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    label6.Enabled = false;
                    label7.Enabled = false;
                    label8.Enabled = false;
                    label9.Enabled = false;
                    timer4.Stop();
                    stop.Enabled = true;
                    stop.Visible = true;
                }
            }
        }

        private Timer timer5;
        public void InitTimer5()
        {
            timer5 = new Timer();
            timer5.Tick += new EventHandler(timer5_Tick);
            timer5.Interval = 2000;
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            label1.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label2.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label3.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label4.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label5.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label6.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label7.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label8.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
            label9.ForeColor = Color.FromArgb(ran.Next(0, 256), ran.Next(0, 256), ran.Next(0, 256));
        }


        private void start_Click(object sender, EventArgs e)
        {
            InitTimer4();
            timer2.Stop();
            timer3.Stop();
            
            start.Enabled = false;
            start.Visible = false;
            label5.Visible = true;
            label1.Text = "1";
            label2.Text = "2";
            label3.Text = "3";
            label4.Text = "4";
            label5.Text = "5";
            label6.Text = "6";
            label7.Text = "7";
            label8.Text = "8";
            label9.Text = "9";
            MessageBox.Show("Player One is O (Circle)");
            MessageBox.Show("Player two is X (Cross)");
            MessageBox.Show("Enjoy! :)");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(first == true)
            {
                MessageBox.Show("Move not allowed! Please choose another one!");
            }
            else
            {
                first = true;
                if (player1 == true)
                {
                    label1.Text = "O";
                    player1 = false;
                    player2 = true;
                    counter++;
                }
                else
                {
                    label1.Text = "X";
                    player1 = true;
                    player2 = false;
                    counter++;
                }
            }
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if(second == true)
            {
                MessageBox.Show("Move not allowed! Please choose another one!");
            }
            else
            {
                second = true;
                if (player1 == true)
                {
                    label2.Text = "O";
                    player1 = false;
                    player2 = true;
                    counter++;
                }
                else
                {
                    label2.Text = "X";
                    player1 = true;
                    player2 = false;
                    counter++;
                }
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if(third == true)
            {
                MessageBox.Show("Move not allowed! Please choose another one!");
            }
            else
            {
                third = true;
                if (player1 == true)
                {
                    label3.Text = "O";
                    player1 = false;
                    player2 = true;
                    counter++;
                }
                else
                {
                    label3.Text = "X";
                    player1 = true;
                    player2 = false;
                    counter++;
                }
            }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if(fourth == true)
            {
                MessageBox.Show("Move not allowed! Please choose another one!");
            }
            else
            {
                fourth = true;
                if (player1 == true)
                {
                    label4.Text = "O";
                    player1 = false;
                    player2 = true;
                    counter++;
                }
                else
                {
                    label4.Text = "X";
                    player1 = true;
                    player2 = false;
                    counter++;
                }
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (fifth == true)
            {
                MessageBox.Show("Move not allowed! Please choose another one!");
            }
            else
            {
                fifth = true;
                if (player1 == true)
                {
                    label5.Text = "O";
                    player1 = false;
                    player2 = true;
                    counter++;
                }
                else
                {
                    label5.Text = "X";
                    player1 = true;
                    player2 = false;
                    counter++;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (sixth == true)
            {
                MessageBox.Show("Move not allowed! Please choose another one!");
            }
            else
            {
                sixth = true;
                if (player1 == true)
                {
                    label6.Text = "O";
                    player1 = false;
                    player2 = true;
                    counter++;
                }
                else
                {
                    label6.Text = "X";
                    player1 = true;
                    player2 = false;
                    counter++;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (seven == true)
            {
                MessageBox.Show("Move not allowed! Please choose another one!");
            }
            else
            {
                seven = true;
                if (player1 == true)
                {
                    label7.Text = "O";
                    player1 = false;
                    player2 = true;
                    counter++;
                }
                else
                {
                    label7.Text = "X";
                    player1 = true;
                    player2 = false;
                    counter++;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (eight == true)
            {
                MessageBox.Show("Move not allowed! Please choose another one!");
            }
            else
            {
                eight = true;
                if (player1 == true)
                {
                    label8.Text = "O";
                    player1 = false;
                    player2 = true;
                    counter++;
                }
                else
                {
                    label8.Text = "X";
                    player1 = true;
                    player2 = false;
                    counter++;
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (nine == true)
            {
                MessageBox.Show("Move not allowed! Please choose another one!");
            }
            else
            {
                nine = true;
                if (player1 == true)
                {
                    label9.Text = "O";
                    player1 = false;
                    player2 = true;
                    counter++;
                }
                else
                {
                    label9.Text = "X";
                    player1 = true;
                    player2 = false;
                    counter++;
                }
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
