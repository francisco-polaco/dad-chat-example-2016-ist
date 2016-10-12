using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ChatClient
{
    public delegate void DelAddMsg(string msg);

    public partial class MainForm : Form
    {
        private ClientManager cm;

        public MainForm()
        {
            InitializeComponent();
            cm = new ClientManager();
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            try
            {
                cm.connect(text_nick.Text,  
                    this, new DelAddMsg(this.addMsg));
            }catch (SocketException ex){
                MessageBox.Show("Error connecting to server. " + ex.Message);
                return;
            }
            
            pingTestToolStripMenuItem.Enabled = true;
            send_button.Enabled = true;
        }


        private void send_button_Click(object sender, EventArgs e)
        {
            if (text_to_send.Text != "")
            {
                string msg = "[" + DateTime.Now.ToString("HH:mm") + "] : " + text_to_send.Text;
                cm.sendMsg(msg);
                text_to_send.Text = "";
                addMsg("Me @ " + msg);
            }
        }

 
        private void text_to_send_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                send_button_Click(this, new EventArgs());
            }
        }


        void addMsg(string msg)
        {
            if (text_chat.Text == "")
            {
                text_chat.Text = msg;
            } else text_chat.AppendText("\r\n" + msg);
        }

       

        private void pingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cm.ping());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // cm.unreg();
            Application.Exit();
        }

        private void MainForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            
            switch (MessageBox.Show(this, "Are you sure?", "Do you still want leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //Stay on this form
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    cm.unreg();
                    break;
            }
            
        }

        private void text_nick_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connect_button_Click(this, new EventArgs());
            }
        }
    }
}

