namespace VpnFlash
{
    partial class FlashWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashWindowForm));
            this.label_vpn_status = new System.Windows.Forms.Label();
            this.minimize_button = new System.Windows.Forms.Button();
            this.disconnect_button = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayIconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_vpn_status
            // 
            this.label_vpn_status.AutoSize = true;
            this.label_vpn_status.Location = new System.Drawing.Point(61, 50);
            this.label_vpn_status.Name = "label_vpn_status";
            this.label_vpn_status.Size = new System.Drawing.Size(125, 13);
            this.label_vpn_status.TabIndex = 0;
            this.label_vpn_status.Text = "Determing VPN Status ...";
            // 
            // minimize_button
            // 
            this.minimize_button.Location = new System.Drawing.Point(183, 121);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(84, 26);
            this.minimize_button.TabIndex = 1;
            this.minimize_button.Text = "Minimize";
            this.minimize_button.UseVisualStyleBackColor = true;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            // 
            // disconnect_button
            // 
            this.disconnect_button.Location = new System.Drawing.Point(64, 121);
            this.disconnect_button.Name = "disconnect_button";
            this.disconnect_button.Size = new System.Drawing.Size(102, 26);
            this.disconnect_button.TabIndex = 2;
            this.disconnect_button.Text = "DISCONNECT";
            this.disconnect_button.UseVisualStyleBackColor = true;
            this.disconnect_button.Visible = false;
            this.disconnect_button.Click += new System.EventHandler(this.disconnect_button_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayIconContextMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "VpnFlash";
            this.trayIcon.Visible = true;
            // 
            // trayIconContextMenu
            // 
            this.trayIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.trayIconContextMenu.Name = "trayIconContextMenu";
            this.trayIconContextMenu.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FlashWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 174);
            this.Controls.Add(this.disconnect_button);
            this.Controls.Add(this.minimize_button);
            this.Controls.Add(this.label_vpn_status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlashWindowForm";
            this.Load += new System.EventHandler(this.FlashWindowForm_Load);
            this.trayIconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_vpn_status;
        private System.Windows.Forms.Button minimize_button;
        private System.Windows.Forms.Button disconnect_button;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;



    }
}

