namespace ChatClient
{
    partial class MainForm
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
            this.connect_button = new System.Windows.Forms.Button();
            this.text_to_send = new System.Windows.Forms.TextBox();
            this.send_button = new System.Windows.Forms.Button();
            this.text_chat = new System.Windows.Forms.TextBox();
            this.text_nick = new System.Windows.Forms.TextBox();
            this.nick = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(184, 26);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(75, 23);
            this.connect_button.TabIndex = 3;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // text_to_send
            // 
            this.text_to_send.Location = new System.Drawing.Point(12, 310);
            this.text_to_send.Name = "text_to_send";
            this.text_to_send.Size = new System.Drawing.Size(247, 20);
            this.text_to_send.TabIndex = 2;
            this.text_to_send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_to_send_KeyDown);
            // 
            // send_button
            // 
            this.send_button.Enabled = false;
            this.send_button.Location = new System.Drawing.Point(265, 310);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 23);
            this.send_button.TabIndex = 5;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // text_chat
            // 
            this.text_chat.Location = new System.Drawing.Point(12, 55);
            this.text_chat.Multiline = true;
            this.text_chat.Name = "text_chat";
            this.text_chat.ReadOnly = true;
            this.text_chat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_chat.Size = new System.Drawing.Size(328, 249);
            this.text_chat.TabIndex = 6;
            // 
            // text_nick
            // 
            this.text_nick.Location = new System.Drawing.Point(78, 28);
            this.text_nick.Name = "text_nick";
            this.text_nick.Size = new System.Drawing.Size(100, 20);
            this.text_nick.TabIndex = 0;
            this.text_nick.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_nick_KeyDown);
            // 
            // nick
            // 
            this.nick.AutoSize = true;
            this.nick.Location = new System.Drawing.Point(14, 31);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(58, 13);
            this.nick.TabIndex = 7;
            this.nick.Text = "Nickname:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(353, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pingTestToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // pingTestToolStripMenuItem
            // 
            this.pingTestToolStripMenuItem.Enabled = false;
            this.pingTestToolStripMenuItem.Name = "pingTestToolStripMenuItem";
            this.pingTestToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pingTestToolStripMenuItem.Text = "Ping Test";
            this.pingTestToolStripMenuItem.Click += new System.EventHandler(this.pingTestToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 343);
            this.Controls.Add(this.nick);
            this.Controls.Add(this.text_nick);
            this.Controls.Add(this.text_chat);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.text_to_send);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Talk Away!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.TextBox text_to_send;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.TextBox text_chat;
        private System.Windows.Forms.TextBox text_nick;
        private System.Windows.Forms.Label nick;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

