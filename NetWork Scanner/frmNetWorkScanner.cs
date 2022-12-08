using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetWork_Scanner
{
    public partial class frmNetWorkScanner : Form
    {
        public frmNetWorkScanner()
        {
            InitializeComponent();
        }
        const int max = 3;
        const string desk = "MY-Desktop";
        const string google = "google-public-dns-a";
        const string ranken = "ranken.edu";
        const string fail = "None";
        const string time = "Request Timed Out";
        const string services = "services";
        const string FTP_Data = " FTP_Data";
        const string FTP_Control = "FTP_Control";
        const string TELNET = "TELNET";
        const string SMPT = "SMPT";
        const string DNS = "DNS";
        const string HTTP = "HTTP";
        const string NTP = "NTP";
        const string LDAP = "LDAP";
        const string HTTPS = "HTTPS";


        List<Computer> computers = new List<Computer>()
        {
            new Computer ("My-Desktop","127.0.0.1 2",20, 21, 23, 25, 53, 80, 123, 389, 443),
            new Computer ("google-public-dns-a","8.8.8.8",53),
            new Computer ("ranken.edu", "47.44.246.80",25, 80, 443)
        };

        private void btnScan_Click(object sender, EventArgs e)
        {
            int position = ScanIpAddress();
            if (position >= 0 && position <= max)
            {
                ShowComputer(position);
            }
            else
            {
                IpNotFound();
            }
        }
        private int ScanIpAddress()
        {
            string st = txtIP.Text.Trim();
            for (int lcv = 0; lcv < max; lcv++)
            {
                if (computers[lcv].GetIpAddress().ToLower() == st)
                {
                    return lcv;
                }
            }

            return -1;
        }
        private void IpNotFound()
        {
            lbServices.Items.Add(time);
            lbServices.Items.Add(services);
            lbServices.Items.Add(fail);
        }
        private void ShowComputer(int position)
        { 
            if (position == 0)
            {
                lbServices.Items.Clear();
               
                lbServices.Items.Add(computers[position].GetName());
                lbServices.Items.Add(computers[position].GetIpAddress());
                lbServices.Items.Add(services);
                lbServices.Items.Add(computers[position].GetServices() +  ":" + FTP_Data);
                lbServices.Items.Add(computers[position].GetServices1() + ":" + FTP_Control);
                lbServices.Items.Add(computers[position].GetServices2() + ":" + TELNET);
                lbServices.Items.Add(computers[position].GetServices3() + ":" + SMPT);
                lbServices.Items.Add(computers[position].GetServices4() + ":" + DNS);
                lbServices.Items.Add(computers[position].GetServices5() + ":" + HTTP);
                lbServices.Items.Add(computers[position].GetServices6() + ":" + NTP);
                lbServices.Items.Add(computers[position].GetServices7() + ":" + LDAP);
                lbServices.Items.Add(computers[position].GetServices8() + ":" + HTTPS);
               
            }
            if(position == 1)
            {
                lbServices.Items.Clear();
              
                lbServices.Items.Add(computers[position].GetName());
                lbServices.Items.Add(computers[position].GetIpAddress());
                lbServices.Items.Add(services);
                lbServices.Items.Add(computers[position].GetServices() + ":" + DNS);
               

            }
            if (position == 2)
            {

                lbServices.Items.Clear();
            
                lbServices.Items.Add(computers[position].GetName());
                lbServices.Items.Add(computers[position].GetIpAddress());
                lbServices.Items.Add(services);
                lbServices.Items.Add(computers[position].GetServices() + ":" + SMPT);
                lbServices.Items.Add(computers[position].GetServices1() + ":" + HTTP);
                lbServices.Items.Add(computers[position].GetServices2() + ":" + HTTPS);
                

            }




        }
    }
}
