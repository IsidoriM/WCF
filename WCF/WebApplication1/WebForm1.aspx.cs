using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        IHelloRemotingService.IHelloRemtingService client;
        TcpChannel channel = new TcpChannel();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ChannelServices.RegisterChannel(channel);
            client = (IHelloRemotingService.IHelloRemtingService)Activator.GetObject(
              typeof(IHelloRemotingService.IHelloRemtingService),
              "tcp://localhost:8080/GetMessage");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = client.GetMessage(TextBox1.Text);
        }

    }
}