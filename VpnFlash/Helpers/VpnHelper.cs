using System.Net.NetworkInformation;

namespace VpnFlash.Helpers
{
    public static class Vpn 
    {
        public static bool IsActive()
        {
            return GetNetworkInterface() != null;
        }

        public static string Description()
        {
            var i = GetNetworkInterface();
            return i.Name + " " + i.NetworkInterfaceType.ToString() + " " + i.Description;
        }

        public static string Name()
        {
            return GetNetworkInterface().Name;
        }

        private static NetworkInterface GetNetworkInterface()
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface i in interfaces)
                {
                    if (i.OperationalStatus == OperationalStatus.Up)
                    {
                        if ((i.NetworkInterfaceType == NetworkInterfaceType.Ppp) && (i.NetworkInterfaceType != NetworkInterfaceType.Loopback))
                        {
                            return i;
                        }
                    }
                }
            }
            return null;
        }

        public static void Disconnect()
        {
            System.Diagnostics.Process.Start("rasdial.exe", "/d"); 
        }
    }
}
