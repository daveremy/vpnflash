using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using VpnFlash.Helpers;

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
            if (Vpn.IsActive())
            {
                FlashWindow.Start(this);
                this.Icon = Properties.Resources.vpn;
                this.label_vpn_status.Text = "Connected to VPN: " + Vpn.Name();
                this.disconnect_button.Visible = true;
            }
            else
            {
                FlashWindow.Stop(this);
                this.Icon = Properties.Resources.circle;
                this.label_vpn_status.Text = "Not connected to a VPN currently";
                this.disconnect_button.Visible = false;
            }
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void disconnect_button_Click(object sender, EventArgs e)
        {
            Vpn.Disconnect();
        }
    }
}
