using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using VpnFlash.Helpers;
using Microsoft.WindowsAPICodePack;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Taskbar;

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
                SetVpnIndicators(true);
            });
        }

        private void SetVpnIndicators(bool setOverlay = false)
        {
            if (Vpn.IsActive())
            {
                FlashWindow.Start(this);
                // this.Icon = Properties.Resources.vpn;
                this.label_vpn_status.Text = "Connected to VPN: " + Vpn.Name();
                this.disconnect_button.Visible = true;
                this.ShowInTaskbar = true;
                if (setOverlay) TaskbarManager.Instance.SetOverlayIcon(Properties.Resources.vpn, "VPN");
            }
            else
            {
                FlashWindow.Stop(this);
                this.ShowInTaskbar = false;
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

        private void FlashWindowForm_Load(object sender, EventArgs e)
        {

        }
    }
}
