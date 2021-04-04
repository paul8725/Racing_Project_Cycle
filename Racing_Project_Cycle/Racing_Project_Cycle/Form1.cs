using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing_Project_Cycle
{
    public partial class Form1 : Form
    {
        String playerName = "";
        String selectedCycle = "";
        String selectedAmount = "";
        int Ramesh = 100, Vickey = 100, Aman = 100, Gopal = 100;
        int rIns = 0,vIns=0,aIns=0,gIns=0;
        better bet = new better();

        public Form1()
        {
            InitializeComponent();
            onloadGen();
        }
        public void onloadGen() {
            //add the items to the betting cycle 
            betting_cycle.Items.Add("1");
            betting_cycle.Items.Add("2");
            betting_cycle.Items.Add("3");
            betting_cycle.Items.Add("4");

            //add the amount to the cycle 
            for (int x=1;x<=50;x++) {
                betting_amount.Items.Add("" + x);
            }

            //add the name of the player 
            betting_player.Items.Add("Ramesh");
            betting_player.Items.Add("Vicky");
            betting_player.Items.Add("Aman");
            betting_player.Items.Add("Gopal");

            start_btn.Enabled = false;
        }

        // will look into every possible aspect that weather all aspects have been selected or not 

        private void bet_setter_btn_Click(object sender, EventArgs e)
        {
            if (playerName.Equals("Ramesh"))
            {
                if (Convert.ToInt32(selectedAmount)<=Ramesh) {
                    ramesh_better.Text = playerName + " " + selectedAmount + " " + selectedCycle;
                    start_btn.Enabled = true;
                    rIns = 1;
                }
                else {
                    MessageBox.Show("You dont have enough account balance ");
                }
            }
            else if (playerName.Equals("Vicky"))
            {
                if (Convert.ToInt32(selectedAmount) <= Vickey)
                {
                    vicky_better.Text = playerName + " " + selectedAmount + " " + selectedCycle;
                    start_btn.Enabled = true;
                    vIns = 1;
                }
                else
                {
                    MessageBox.Show("You dont have enough account balance ");
                }
            }
            else if (playerName.Equals("Gopal"))
            {
                if (Convert.ToInt32(selectedAmount) <= Gopal)
                {
                    gopal_bettor.Text = playerName + " " + selectedAmount + " " + selectedCycle;
                    start_btn.Enabled = true;
                    gIns = 1;
                }
                else
                {
                    MessageBox.Show("You dont have enough account balance ");
                }

            }
            else if (playerName.Equals("Aman"))
            {
                if (Convert.ToInt32(selectedAmount) <= Aman)
                {
                    aman_better.Text = playerName + " " + selectedAmount + " " + selectedCycle;
                    start_btn.Enabled = true;
                    aIns = 1;
                }
                else
                {
                    MessageBox.Show("You Can not Play Becaue you have less Amount in Account ");
                }
            }
            else {
                MessageBox.Show("Please Select all Options ");
            }

            playerName = "";
            selectedAmount = "";
            selectedCycle = "";
        }

        // will start the game when someone will click on start button 

        private void start_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cycle1.Left += bet.rNumber();
            cycle2.Left += bet.rNumber();
            cycle3.Left += bet.rNumber();
            cycle4.Left += bet.rNumber();
            if (cycle1.Left>750)
            {
                timer1.Stop();
                //MessageBox.Show("1");
                result(1);
            }
            if (cycle2.Left > 750)
            {
                timer1.Stop();
                //MessageBox.Show("2");
                result(2);
            }
            if (cycle3.Left > 750)
            {
                timer1.Stop();
                //MessageBox.Show("3");
                result(3);
            }
            if (cycle4.Left > 750)
            {
                timer1.Stop();
              //  MessageBox.Show("4");
                result(4);
            }

        }

        // printing results of each candidate in screen

        public void result(int y) {
            if (rIns==1) {
                string[] h = ramesh_better.Text.ToString().Split(' ');
                if (y == Convert.ToInt32(h[2]))
                {
                    Ramesh = Ramesh + Convert.ToInt32(h[1]);
                }
                else {
                    Ramesh = Ramesh - Convert.ToInt32(h[1]);
                }
            }


            if (gIns == 1)
            {
                string[] h = gopal_bettor.Text.ToString().Split(' ');
                if (y == Convert.ToInt32(h[2]))
                {
                    Gopal = Gopal + Convert.ToInt32(h[1]);
                }
                else
                {
                    Gopal = Gopal - Convert.ToInt32(h[1]);
                }
            }

            if (vIns == 1)
            {
                string[] h =vicky_better.Text.ToString().Split(' ');
                if (y == Convert.ToInt32(h[2]))
                {
                    Vickey=Vickey + Convert.ToInt32(h[1]);
                }
                else
                {
                    Vickey = Vickey - Convert.ToInt32(h[1]);
                }
            }


            if (aIns == 1)
            {
                string[] h = aman_better.Text.ToString().Split(' ');
                if (y == Convert.ToInt32(h[2]))
                {
                    Aman=Aman + Convert.ToInt32(h[1]);
                }
                else
                {
                    Aman = Aman - Convert.ToInt32(h[1]);
                }
            }

            ramesh_better.Text = Ramesh + "$ in Ramesh Account";
            vicky_better.Text = Vickey+ "$ in Vicky Account";
            gopal_bettor.Text = Gopal + "$ in Gopal Account";
            aman_better.Text = Aman + "$ in Aman Account";
            
            vIns = 0;
            rIns = 0;
            gIns = 0;
            aIns = 0;

            start_btn.Enabled = false;
            
            playerName = "";
            selectedAmount = "";
            selectedCycle = "";
            
            cycle1.Left = 0;
            cycle2.Left = 0;
            cycle3.Left = 0;
            cycle4.Left = 0;

            betting_amount.Text = "";
            betting_cycle.Text = "";
            betting_player.Text = "";

        }

        private void betting_cycle_TextChanged(object sender, EventArgs e)
        {
            selectedCycle = betting_cycle.Text;
        }

        private void betting_amount_TextChanged(object sender, EventArgs e)
        {
            selectedAmount = betting_amount.Text;
        }

        private void betting_player_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerName = betting_player.Text;
        }
    }
}
