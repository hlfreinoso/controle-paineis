using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using ControlePaineis.Negocios.AcessoBD;
using ControlePaineis.Interface.Autenticação;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlePaineis.Interface.Sistema
{
    public partial class Paineis : System.Web.UI.Page
    {
        public string StrSrv = System.Web.HttpContext.Current.Server.MapPath("~/index.htm");
        public string StrPlc = "192.168.0.254";
        private Registro _registro;
        public void Log(string VIdx, string CBtn)
        {
            _registro = new Registro();
            var ValIndex = VIdx;
            var CodButton = CBtn;
            var NomePage = "Paineis";
            var Usuario = Request.ServerVariables["AUTH_USER"].ToString();
            _registro.RegistrarLog(ValIndex, CodButton, NomePage, Usuario);
        }
        public static void Save(string result)
        {
            string StrFile = System.Web.HttpContext.Current.Server.MapPath("~/index.htm");
            if (!File.Exists(StrFile))
            {
                using (FileStream fs = File.Create(StrFile)) { }
            }
            else
            {
                File.Delete(StrFile);
            }
            using (StreamWriter w = File.AppendText(StrFile))
            {
                w.Write(result);
                w.Close();
            }
        }

        public void Reload()
        {
            var client = new WebClient();
            string result = client.DownloadString(StrSrv);
            string btn1 = result.Substring(80, 1);
            string btn2 = result.Substring(81, 1);
            string btn3 = result.Substring(82, 1);
            string btn4 = result.Substring(83, 1);
            string btn5 = result.Substring(84, 1);
            string btn6 = result.Substring(85, 1);
            string btn7 = result.Substring(86, 1);
            string btn8 = result.Substring(87, 1);
            Ping pingSender = new Ping();
            IPAddress address = IPAddress.Parse(StrPlc);
            PingReply reply = pingSender.Send(address);

            if (reply.Status == IPStatus.Success)
            {
                LabelSts.Text = "Status: On-line";
                LabelSts.CssClass = "label label-success";
                Button1.Enabled = true;
                Button2.Enabled = true;
                Button3.Enabled = true;
                Button4.Enabled = true;
                Button5.Enabled = true;
                Button6.Enabled = true;
                Button7.Enabled = true;
                Button8.Enabled = true;
                ButtonDes.Enabled = true;
                ButtonLig.Enabled = true;
            }
            else
            {
                LabelSts.Text = "Status: Off-line";
                LabelSts.CssClass = "label label-danger";
                btn1 = "0";
                btn2 = "0";
                btn3 = "0";
                btn4 = "0";
                btn5 = "0";
                btn6 = "0";
                btn7 = "0";
                btn8 = "0";
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                ButtonDes.Enabled = false;
                ButtonLig.Enabled = false;
                result = result.Substring(0, 80) + "0000000000" + result.Substring(90, 3);
                Save(result);
            }
            if (btn1 == "1")
            {
                Button1.Text = "Desligar";
                LabelSts1.Text = "   Ligado   ";
                LabelSts1.CssClass = "label label-success";             
            }
            else
            {
                Button1.Text = "Ligar";
                LabelSts1.Text = "Desligado";
                LabelSts1.CssClass = "label label-danger";
            }
            if (btn2 == "1")
            {
                Button2.Text = "Desligar";
                LabelSts2.Text = " Ligado  ";
                LabelSts2.CssClass = "label label-success";
            }
            else
            {
                Button2.Text = "Ligar";
                LabelSts2.Text = "Desligado";
                LabelSts2.CssClass = "label label-danger";
            }
            if (btn3 == "1")
            {
                Button3.Text = "Desligar";
                LabelSts3.Text = " Ligado  ";
                LabelSts3.CssClass = "label label-success";
            }
            else
            {
                Button3.Text = "Ligar";
                LabelSts3.Text = "Desligado";
                LabelSts3.CssClass = "label label-danger";
            }
            if (btn4 == "1")
            {
                Button4.Text = "Desligar";
                LabelSts4.Text = " Ligado  ";
                LabelSts4.CssClass = "label label-success";
            }
            else
            {
                Button4.Text = "Ligar";
                LabelSts4.Text = "Desligado";
                LabelSts4.CssClass = "label label-danger";
            }
            if (btn5 == "1")
            {
                Button5.Text = "Desligar";
                LabelSts5.Text = " Ligado  ";
                LabelSts5.CssClass = "label label-success";
            }
            else
            {
                Button5.Text = "Ligar";
                LabelSts5.Text = "Desligado";
                LabelSts5.CssClass = "label label-danger";
            }
            if (btn6 == "1")
            {
                Button6.Text = "Desligar";
                LabelSts6.Text = " Ligado  ";
                LabelSts6.CssClass = "label label-success";
            }
            else
            {
                Button6.Text = "Ligar";
                LabelSts6.Text = "Desligado";
                LabelSts6.CssClass = "label label-danger";
            }
            if (btn7 == "1")
            {
                Button7.Text = "Desligar";
                LabelSts7.Text = " Ligado  ";
                LabelSts7.CssClass = "label label-success";
            }
            else
            {
                Button7.Text = "Ligar";
                LabelSts7.Text = "Desligado";
                LabelSts7.CssClass = "label label-danger";
            }
            if (btn8 == "1")
            {
                Button8.Text = "Desligar";
                LabelSts8.Text = " Ligado  ";
                LabelSts8.CssClass = "label label-success";
            }
            else
            {
                Button8.Text = "Ligar";
                LabelSts8.Text = "Desligado";
                LabelSts8.CssClass = "label label-danger";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Reload();
        }
        protected void ButtonDes_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            string result = client.DownloadString(StrSrv);
            result = result.Substring(0, 80) + "0000000000" + result.Substring(90, 3);
            Save(result);
            Log(result.Substring(80, 10), "ButtonDes");
            Reload();
        }
        protected void ButtonLig_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            string result = client.DownloadString(StrSrv);
            result = result.Substring(0, 80) + "1111111111" + result.Substring(90, 3);
            Save(result);
            Log(result.Substring(80, 10), "ButtonLig");
            Reload();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            string result = client.DownloadString(StrSrv);
            string btn = result.Substring(80, 1);
            if (btn == "1")
            {
                btn = "0";
            }
            else
            {
                btn = "1";
            }
            result = result.Substring(0, 80) + btn + result.Substring(81, 12);
            Save(result);
            Log(result.Substring(80, 10), "Button1");
            Reload();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            string result = client.DownloadString(StrSrv);
            string btn = result.Substring(81, 1);
            if (btn == "1")
            {
                btn = "0";
            }
            else
            {
                btn = "1";
            }
            result = result.Substring(0, 81) + btn + result.Substring(82, 11);
            Save(result);
            Log(result.Substring(80, 10), "Button2");
            Reload();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            string result = client.DownloadString(StrSrv);
            string btn = result.Substring(82, 1);
            if (btn == "1")
            {
                btn = "0";
            }
            else
            {
                btn = "1";
            }
            result = result.Substring(0, 82) + btn + result.Substring(83, 10);
            Save(result);
            Log(result.Substring(80, 10), "Button3");
            Reload();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            string result = client.DownloadString(StrSrv);
            string btn = result.Substring(83, 1);
            if (btn == "1")
            {
                btn = "0";
            }
            else
            {
                btn = "1";
            }
            result = result.Substring(0, 83) + btn + result.Substring(84, 9);
            Save(result);
            Log(result.Substring(80, 10), "Button4");
            Reload();
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            string result = client.DownloadString(StrSrv);
            string btn = result.Substring(84, 1);
            if (btn == "1")
            {
                btn = "0";
            }
            else
            {
                btn = "1";
            }
            result = result.Substring(0, 84) + btn + result.Substring(85, 8);
            Save(result);
            Log(result.Substring(80, 10), "Button5");
            Reload();
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            string result = client.DownloadString(StrSrv);
            string btn = result.Substring(85, 1);
            if (btn == "1")
            {
                btn = "0";
            }
            else
            {
                btn = "1";
            }
            result = result.Substring(0, 85) + btn + result.Substring(86, 7);
            Save(result);
            Log(result.Substring(80, 10), "Button6");
            Reload();
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            string result = client.DownloadString(StrSrv);
            string btn = result.Substring(86, 1);
            if (btn == "1")
            {
                btn = "0";
            }
            else
            {
                btn = "1";
            }
            result = result.Substring(0, 86) + btn + result.Substring(87, 6);
            Save(result);
            Log(result.Substring(80, 10), "Button7");
            Reload();
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            string result = client.DownloadString(StrSrv);
            string btn = result.Substring(87, 1);
            if (btn == "1")
            {
                btn = "0";
            }
            else
            {
                btn = "1";
            }
            result = result.Substring(0, 87) + btn + result.Substring(88, 5);
            Save(result);
            Log(result.Substring(80, 10), "Button8");
            Reload();
        }
    }
}