namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startServer = new System.Windows.Forms.ToolStripMenuItem();
            this.joinServer = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.NW = new System.Windows.Forms.Button();
            this.N = new System.Windows.Forms.Button();
            this.NE = new System.Windows.Forms.Button();
            this.W = new System.Windows.Forms.Button();
            this.Cen = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.SW = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Button();
            this.SE = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.networkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(261, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startServer,
            this.joinServer,
            this.disconnect});
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.networkToolStripMenuItem.Text = "Network";
            // 
            // startServer
            // 
            this.startServer.Name = "startServer";
            this.startServer.Size = new System.Drawing.Size(133, 22);
            this.startServer.Text = "Start Server";
            this.startServer.Click += new System.EventHandler(this.startServerToolStripMenuItem_Click);
            // 
            // joinServer
            // 
            this.joinServer.Name = "joinServer";
            this.joinServer.Size = new System.Drawing.Size(133, 22);
            this.joinServer.Text = "Join Server";
            this.joinServer.Click += new System.EventHandler(this.joinServerToolStripMenuItem_Click);
            // 
            // disconnect
            // 
            this.disconnect.Enabled = false;
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(133, 22);
            this.disconnect.Text = "Disconnect";
            this.disconnect.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // NW
            // 
            this.NW.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NW.Location = new System.Drawing.Point(12, 27);
            this.NW.Name = "NW";
            this.NW.Size = new System.Drawing.Size(75, 75);
            this.NW.TabIndex = 1;
            this.NW.UseVisualStyleBackColor = true;
            this.NW.Click += new System.EventHandler(this.button_click);
            // 
            // N
            // 
            this.N.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N.Location = new System.Drawing.Point(93, 27);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(75, 75);
            this.N.TabIndex = 2;
            this.N.UseVisualStyleBackColor = true;
            this.N.Click += new System.EventHandler(this.button_click);
            // 
            // NE
            // 
            this.NE.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NE.Location = new System.Drawing.Point(174, 27);
            this.NE.Name = "NE";
            this.NE.Size = new System.Drawing.Size(75, 75);
            this.NE.TabIndex = 3;
            this.NE.UseVisualStyleBackColor = true;
            this.NE.Click += new System.EventHandler(this.button_click);
            // 
            // W
            // 
            this.W.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.W.Location = new System.Drawing.Point(12, 108);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(75, 75);
            this.W.TabIndex = 4;
            this.W.UseVisualStyleBackColor = true;
            this.W.Click += new System.EventHandler(this.button_click);
            // 
            // Cen
            // 
            this.Cen.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Cen.Location = new System.Drawing.Point(93, 108);
            this.Cen.Name = "Cen";
            this.Cen.Size = new System.Drawing.Size(75, 75);
            this.Cen.TabIndex = 5;
            this.Cen.UseVisualStyleBackColor = true;
            this.Cen.Click += new System.EventHandler(this.button_click);
            // 
            // E
            // 
            this.E.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.E.Location = new System.Drawing.Point(174, 108);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(75, 75);
            this.E.TabIndex = 6;
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.button_click);
            // 
            // SW
            // 
            this.SW.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.SW.Location = new System.Drawing.Point(12, 189);
            this.SW.Name = "SW";
            this.SW.Size = new System.Drawing.Size(75, 75);
            this.SW.TabIndex = 7;
            this.SW.UseVisualStyleBackColor = true;
            this.SW.Click += new System.EventHandler(this.button_click);
            // 
            // S
            // 
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.S.Location = new System.Drawing.Point(93, 189);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(75, 75);
            this.S.TabIndex = 8;
            this.S.UseVisualStyleBackColor = true;
            this.S.Click += new System.EventHandler(this.button_click);
            // 
            // SE
            // 
            this.SE.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.SE.Location = new System.Drawing.Point(174, 189);
            this.SE.Name = "SE";
            this.SE.Size = new System.Drawing.Size(75, 75);
            this.SE.TabIndex = 9;
            this.SE.UseVisualStyleBackColor = true;
            this.SE.Click += new System.EventHandler(this.button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 276);
            this.Controls.Add(this.SE);
            this.Controls.Add(this.S);
            this.Controls.Add(this.SW);
            this.Controls.Add(this.E);
            this.Controls.Add(this.Cen);
            this.Controls.Add(this.W);
            this.Controls.Add(this.NE);
            this.Controls.Add(this.N);
            this.Controls.Add(this.NW);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startServer;
        private System.Windows.Forms.ToolStripMenuItem joinServer;
        private System.Windows.Forms.ToolStripMenuItem disconnect;
        public System.Windows.Forms.Button NW;
        public System.Windows.Forms.Button N;
        public System.Windows.Forms.Button NE;
        public System.Windows.Forms.Button W;
        public System.Windows.Forms.Button Cen;
        public System.Windows.Forms.Button E;
        public System.Windows.Forms.Button SW;
        public System.Windows.Forms.Button S;
        public System.Windows.Forms.Button SE;
    }
}

