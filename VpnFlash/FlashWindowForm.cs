using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VpnFlash
{
    public partial class FlashWindowForm : Form
    {

        public FlashWindowForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
            NetworkChange.NetworkAddressChanged += new NetworkAddressChangedEventHandler(NetworkChange_NetworkAddressChanged);
            SetVpnIndicators();
        }

        private void NetworkChange_NetworkAddressChanged(object sender, EventArgs e)
        {
            // Need to invoke this on the UI thread
            this.Invoke((MethodInvoker)delegate
            {
                SetVpnIndicators();
            });
        }

        private void SetVpnIndicators()
        {
            if (VpnIsActive())
            {
                FlashWindow.Start(this);
                this.Icon = Properties.Resources.vpn;
                this.label_vpn_status.Text = "Connected to VPN: " + VPNName();
            }
            else
            {
                FlashWindow.Stop(this);
                this.Icon = Properties.Resources.circle;
                this.label_vpn_status.Text = "Not connected to a VPN currently";
            }
        }

        private bool VpnIsActive()
        {
            return VPNName() != null;
        }

        // Inspired by code in this Stack Overflow answer: http://stackoverflow.com/questions/12227540/how-can-i-know-whether-a-vpn-connection-is-established-or-not
        private string VPNName()
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface Interface in interfaces)
                {
                    if (Interface.OperationalStatus == OperationalStatus.Up)
                    {
                        if ((Interface.NetworkInterfaceType == NetworkInterfaceType.Ppp) && (Interface.NetworkInterfaceType != NetworkInterfaceType.Loopback))
                        {
                            return Interface.Name + " " + Interface.NetworkInterfaceType.ToString() + " " + Interface.Description;
                        }
                    }
                }
            }
            return null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
