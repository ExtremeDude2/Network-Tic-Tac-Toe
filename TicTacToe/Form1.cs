using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum player { X, O };

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        uint turn = (uint)player.X;
        uint turn_num = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn == 0)
            {
                b.BackColor = Color.Red;
                b.Text = "X";
                checkWin();
                turn = (uint)player.O;
            }
            else
            {
                b.BackColor = Color.Blue;
                b.Text = "O";
                checkWin();
                turn = (uint)player.X;
            }

            turn_num++;
            b.Enabled = false;
        }

        private void checkWin()
        {
            bool winner = false;

            // Horizontal
            if (((NW.Text == N.Text) && (N.Text == NE.Text)) && NW.Text != "")
            {
                winner = true;
            }
            if (((W.Text == Cen.Text) && (Cen.Text == E.Text)) && W.Text != "")
            {
                winner = true;
            }
            if (((SW.Text == S.Text) && (S.Text == SE.Text)) && SW.Text != "")
            {
                winner = true;
            }

            // Vertical
            if (((NW.Text == W.Text) && (W.Text == SW.Text)) && NW.Text != "")
            {
                winner = true;
            }
            if (((N.Text == Cen.Text) && (Cen.Text == S.Text)) && N.Text != "")
            {
                winner = true;
            }
            if (((NE.Text == E.Text) && (E.Text == SE.Text)) && NE.Text != "")
            {
                winner = true;
            }

            // Diagonal
            if (((NW.Text == Cen.Text) && (Cen.Text == SE.Text)) && NW.Text != "")
            {
                winner = true;
            }
            if (((NE.Text == Cen.Text) && (Cen.Text == SW.Text)) && NE.Text != "")
            {
                winner = true;
            }

            // Show winner
            string winner_name = "";

            if (winner)
            {
                // Enable all the buttons
                try
                {
                    foreach (Control c in Controls)
                    {
                        Button b = (Button)c;
                        b.Enabled = false;
                    }
                }
                catch { }

                if (turn == (uint)player.X)
                {
                    winner_name = "X";
                }
                else
                {
                    winner_name = "O";
                }

                MessageBox.Show(winner_name + " wins!", "Game over");
            }

            else if (turn_num == 9)
            {
                MessageBox.Show("Draw!", "Game over");
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = (uint)player.X;
            turn_num = 1;

            // Enable all the buttons
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.UseVisualStyleBackColor = true;
                    b.Text = "";
                }
            }
            catch { }
        }
    }
}
