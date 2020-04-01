using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlePaineis.Interface.Sistema
{
    public partial class Sensores : System.Web.UI.Page
    {
        public string StrPlc = "192.168.0.254";
        protected void Page_Load(object sender, EventArgs e)
        {
            Ping pingSender = new Ping();
            IPAddress address = IPAddress.Parse(StrPlc);
            PingReply reply = pingSender.Send(address);
            if (reply.Status == IPStatus.Success)
            {
                LabelSts.Text = "Status: On-line";
                LabelSts.CssClass = "label label-success";
                var client = new WebClient();
                StrPlc = "http://" + StrPlc + "/";
                string result = client.DownloadString(StrPlc);
                Label1.Text = "Temperatura: " + result + "C";
            }
            else
            {
                LabelSts.Text = "Status: Off-line";
                LabelSts.CssClass = "label label-danger";
                Label1.Text = "Sem Valor da temperatura";
            }
        }
    }
}