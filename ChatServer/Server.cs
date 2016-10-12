using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace ChatClient
{
    public class Server
    {
        private static int port = 8086;
        public static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(port);
            ChannelServices.RegisterChannel(channel, false);

            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(MyChatRemoteServerObject),
                "MyChatRemoteServerObject",
                WellKnownObjectMode.Singleton);

            System.Console.WriteLine("Server port is: " + port);
            System.Console.WriteLine("<enter> to exit...");
            System.Console.ReadLine();
        }
    }
}
