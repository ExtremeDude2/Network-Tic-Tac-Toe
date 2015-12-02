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

namespace TicTacToe
{
    public class Network
    {
        Form1 objTicTacToe = null;

        private byte[] buffer = new byte[512];
        private List<Socket> serverClientSocket = new List<Socket>();
        private Socket serverSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private Socket clientSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public Network(Form1 pThis)
        {
            objTicTacToe = pThis;
        }

        public void startServer()
        {
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, 12345));
            serverSocket.Listen(2);
            serverSocket.BeginAccept(new AsyncCallback(acceptCallback), null);
        }

        private void acceptCallback(IAsyncResult AR)
        {
            Socket socket = serverSocket.EndAccept(AR);
            serverClientSocket.Add(socket);
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(reciveCallback), socket);
            serverSocket.BeginAccept(new AsyncCallback(acceptCallback), null);
        }

        private void reciveCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            int received = socket.EndReceive(AR);
            Array.Copy(buffer, objTicTacToe.data, received);

            // Read data and set it up on system
            // X data
            if (buffer[0] == (byte)player.X)
            {
                objTicTacToe.NW.BackColor = Color.Red;
                objTicTacToe.NW.Text = "X";
                objTicTacToe.NW.Enabled = false;
            }
            if (buffer[1] == (byte)player.X)
            {
                objTicTacToe.N.BackColor = Color.Red;
                objTicTacToe.N.Text = "X";
                objTicTacToe.N.Enabled = false;
            }
            if (buffer[2] == (byte)player.X)
            {
                objTicTacToe.NE.BackColor = Color.Red;
                objTicTacToe.NE.Text = "X";
                objTicTacToe.NE.Enabled = false;
            }
            if (buffer[3] == (byte)player.X)
            {
                objTicTacToe.W.BackColor = Color.Red;
                objTicTacToe.W.Text = "X";
                objTicTacToe.W.Enabled = false;
            }
            if (buffer[4] == (byte)player.X)
            {
                objTicTacToe.Cen.BackColor = Color.Red;
                objTicTacToe.Cen.Text = "X";
                objTicTacToe.Cen.Enabled = false;
            }
            if (buffer[5] == (byte)player.X)
            {
                objTicTacToe.E.BackColor = Color.Red;
                objTicTacToe.E.Text = "X";
                objTicTacToe.E.Enabled = false;
            }
            if (buffer[6] == (byte)player.X)
            {
                objTicTacToe.SW.BackColor = Color.Red;
                objTicTacToe.SW.Text = "X";
                objTicTacToe.SW.Enabled = false;
            }
            if (buffer[7] == (byte)player.X)
            {
                objTicTacToe.S.BackColor = Color.Red;
                objTicTacToe.S.Text = "X";
                objTicTacToe.S.Enabled = false;
            }
            if (buffer[8] == (byte)player.X)
            {
                objTicTacToe.SE.BackColor = Color.Blue;
                objTicTacToe.SE.Text = "X";
                objTicTacToe.SE.Enabled = false;
            }

            // O data
            if (buffer[0] == (byte)player.O)
            {
                objTicTacToe.NW.BackColor = Color.Blue;
                objTicTacToe.NW.Text = "O";
                objTicTacToe.NW.Enabled = false;
            }
            if (buffer[1] == (byte)player.O)
            {
                objTicTacToe.N.BackColor = Color.Blue;
                objTicTacToe.N.Text = "O";
                objTicTacToe.N.Enabled = false;
            }
            if (buffer[2] == (byte)player.O)
            {
                objTicTacToe.NE.BackColor = Color.Blue;
                objTicTacToe.NE.Text = "O";
                objTicTacToe.NE.Enabled = false;
            }
            if (buffer[3] == (byte)player.O)
            {
                objTicTacToe.W.BackColor = Color.Blue;
                objTicTacToe.W.Text = "O";
                objTicTacToe.W.Enabled = false;
            }
            if (buffer[4] == (byte)player.O)
            {
                objTicTacToe.Cen.BackColor = Color.Blue;
                objTicTacToe.Cen.Text = "O";
                objTicTacToe.Cen.Enabled = false;
            }
            if (buffer[5] == (byte)player.O)
            {
                objTicTacToe.E.BackColor = Color.Blue;
                objTicTacToe.E.Text = "O";
                objTicTacToe.E.Enabled = false;
            }
            if (buffer[6] == (byte)player.O)
            {
                objTicTacToe.SW.BackColor = Color.Blue;
                objTicTacToe.SW.Text = "O";
                objTicTacToe.SW.Enabled = false;
            }
            if (buffer[7] == (byte)player.O)
            {
                objTicTacToe.S.BackColor = Color.Blue;
                objTicTacToe.S.Text = "O";
                objTicTacToe.S.Enabled = false;
            }
            if (buffer[8] == (byte)player.O)
            {
                objTicTacToe.SE.BackColor = Color.Blue;
                objTicTacToe.SE.Text = "O";
                objTicTacToe.SE.Enabled = false;
            }

            socket.BeginSend(objTicTacToe.data, 0, objTicTacToe.data.Length, SocketFlags.None, new AsyncCallback(sendCallback), socket);
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(reciveCallback), socket);
        }

        private void sendCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
        }

        public void startClient()
        {
            int attempts = 0;

            while (!clientSocket.Connected && attempts < 10)
            {
                try
                {
                    attempts++;
                    clientSocket.Connect(IPAddress.Loopback, 12345);
                }
                catch (SocketException)
                {
                    if (attempts >= 10)
                    {
                        MessageBox.Show("Could not connect after " + attempts.ToString() + " attepmts", "Error");
                    }
                }
            }

            MessageBox.Show("Connected after " + attempts.ToString() + " attepmts", "Connected");
        }
    }
}
