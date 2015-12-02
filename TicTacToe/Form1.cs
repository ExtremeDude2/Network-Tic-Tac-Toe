using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

enum player { none, X, O };

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Network objNetwork;

        public uint turn = (uint)player.X;
        public uint turn_num = 1;

        public byte[] data = new byte[512];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objNetwork = new Network(this);

            // Initialize data packet
            data[0] = (byte)player.none;    //NW
            data[1] = (byte)player.none;    //N
            data[2] = (byte)player.none;    //NE
            data[3] = (byte)player.none;    //W
            data[4] = (byte)player.none;    //Cen
            data[5] = (byte)player.none;    //E
            data[6] = (byte)player.none;    //SW
            data[7] = (byte)player.none;    //S
            data[8] = (byte)player.none;    //SE
            data[9] = (byte)player.X;    //turn
            data[10] = (byte) turn_num;   //turn_num
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            // Player X
            if (data[9] == 1)
            {
                b.BackColor = Color.Red;
                b.Text = "X";
                checkWin();
                data[9] = (byte)player.O;
            }
            // Player O
            else if (data[9] == 2)
            {
                b.BackColor = Color.Blue;
                b.Text = "O";
                checkWin();
                data[9] = (byte)player.X;
            }

            data[10]++;
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

                if (data[9] == (uint)player.X)
                {
                    winner_name = "X";
                }
                else
                {
                    winner_name = "O";
                }

                MessageBox.Show(winner_name + " wins!", "Game over");
            }

            else if (data[10] == 9)
            {
                MessageBox.Show("Draw!", "Game over");
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void startServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            joinServer.Enabled = false;
            startServer.Enabled = false;
            disconnect.Enabled = true;

            newGame();
            objNetwork.startServer();
            //toolStripStatusLabel.Text = "Waiting for connection...";
        }

        private void joinServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            joinServer.Enabled = false;
            startServer.Enabled = false;
            disconnect.Enabled = true;

            newGame();
            objNetwork.startClient();
            //toolStripStatusLabel.Text = "Connecting...";
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            joinServer.Enabled = true;
            startServer.Enabled = true;
            disconnect.Enabled = false;

            newGame();
            //toolStripStatusLabel.Text = "";
        }

        private void newGame()
        {
            data[9] = (byte)player.X;
            data[10] = 1;

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
