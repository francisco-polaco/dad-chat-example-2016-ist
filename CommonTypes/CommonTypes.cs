using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Threading;
using System.Windows.Forms;

namespace ChatClient
{
    public class MyChatRemoteServerObject : MarshalByRefObject
    {
        private ArrayList allMsgs = new ArrayList();

        private SortedDictionary<string, ConnectionPack> clients
            = new SortedDictionary<string, ConnectionPack>();

        public string ping()
        {
            Console.WriteLine("Ping");
            return "Pong";
        }

        public void reg(string nick, string url, int port)
        {
            if (clients.ContainsKey(nick))
            {
                Console.WriteLine("A client with nickname: " + nick +
                    " already exists.");
                throw new RegistryRemoteException();
            }
            else
            {
                Console.WriteLine("A new client as been registered with nickname: " + nick +
                    "\r\nHe can be found at: " + url);
                lock (clients)
                {
                    clients.Add(nick, new ConnectionPack(url, port));
                }
                new Thread(() =>
                {
                    if (allMsgs.Count > 0)
                    {
                        Console.WriteLine("There is messages in the session, updating new client.");
                        MyChatRemoteClientObject remoteObj = (MyChatRemoteClientObject)Activator.GetObject(
                            typeof(MyChatRemoteClientObject),
                            url);
                        if (remoteObj != null)
                        {
                            lock (allMsgs)
                            {
                                foreach (string m in allMsgs)
                                {
                                    Console.WriteLine(m);
                                    remoteObj.propagateMsg(m);
                                }
                            }
                        }
                    }
                }).Start();
            }

        }

        public void sendMsg(string nick, string msg)
        {
            Console.WriteLine("Client " + nick + " as sent: " + msg);
            msg = nick + " @ " + msg;
            lock (allMsgs) { 
                allMsgs.Add(msg);
            }
            foreach (KeyValuePair<string, ConnectionPack> entry in clients)
            {
                if (entry.Key != nick) {
                    Console.WriteLine("Trying to open socket to client " + entry.Key + 
                        " with port: " + entry.Value.Port);
                    MyChatRemoteClientObject remoteObj = (MyChatRemoteClientObject)Activator.GetObject(
                    typeof(MyChatRemoteClientObject),
                    entry.Value.Url);
                    if(remoteObj != null) remoteObj.propagateMsg(msg);
                }
            }
        }

        public void unreg(string nick)
        {
            Console.WriteLine("Client " + nick + " is leaving.");
            sendMsg(nick, "[" + DateTime.Now.ToString("HH:mm") + "] : I'm leaving. Bye bye lindonas!");
            lock (clients)
            {
                clients.Remove(nick);
            }
        }
    }


    public class MyChatRemoteClientObject : MarshalByRefObject
    {
        private Form form;
        private Delegate d;

        public MyChatRemoteClientObject() { }

        public MyChatRemoteClientObject(Form form, Delegate d)
        {
            this.form = form;
            this.d = d;
        }

        public void propagateMsg(string msg)
        {
            form.Invoke(d, new object[] { msg });
        }

    }

    public class ConnectionPack
    {
        private string url;
        private int port;

        public ConnectionPack(string url, int port)
        {
            this.url = url;
            this.port = port;
        }

        public int Port
        {
            get
            {
                return port;
            }

            set
            {
                port = value;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }
    }

    [Serializable]
    public class RegistryRemoteException : RemotingException, ISerializable
    {
        // ...
    }
}
