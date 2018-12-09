using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AnimationplayerExamBites.Classes
{
    public class UsbConfiguration
    {
        private static IntPtr notificationHandle;
        // private static IntPtr windowHandle;
        public static string directory;
        public static string statusfile = directory + @"\Test_file.txt";
        public static string Estatus ;  //encryptedstatusfile
        public static string Dstatus ; //final decrpted file
        public static string MacAddress;
        public static string EMacFile;
        public static string DMacFile;




        internal static class UsbNotification
        {
            public const int DbtDevicearrival = 0x8000; // system detected a new device        
            public const int DbtDeviceremovecomplete = 0x8004; // device is gone      
            public const int WmDevicechange = 0x0219; // device change event      
            private const int DbtDevtypDeviceinterface = 5;
            private static readonly Guid GuidDevinterfaceUSBDevice = new Guid("A5DCBF10-6530-11D2-901F-00C04FB951ED"); // USB devices

            /// <summary>
            /// Registers a window to receive notifications when USB devices are plugged or unplugged.
            /// </summary>
            /// <param name="windowHandle">Handle to the window receiving notifications.</param>
    public static void RegisterUsbDeviceNotification(IntPtr windowHandle)
            {
                DevBroadcastDeviceinterface dbi = new DevBroadcastDeviceinterface
                {
                    DeviceType = DbtDevtypDeviceinterface,
                    Reserved = 0,
                    ClassGuid = GuidDevinterfaceUSBDevice,
                    Name = 0
                };

                dbi.Size = Marshal.SizeOf(dbi);
                IntPtr buffer = Marshal.AllocHGlobal(dbi.Size);
                Marshal.StructureToPtr(dbi, buffer, true);

                notificationHandle = RegisterDeviceNotification(windowHandle, buffer, 0);
            }

            /// <summary>
            /// Unregisters the window for USB device notifications
            /// </summary>
    public static void UnregisterUsbDeviceNotification()
            {
                UnregisterDeviceNotification(notificationHandle);
            }

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr RegisterDeviceNotification(IntPtr recipient, IntPtr notificationFilter, int flags);

    [DllImport("user32.dll")]
    private static extern bool UnregisterDeviceNotification(IntPtr handle);

    [StructLayout(LayoutKind.Sequential)]
    private struct DevBroadcastDeviceinterface
            {
                internal int Size;
                internal int DeviceType;
                internal int Reserved;
                internal Guid ClassGuid;
                internal short Name;
            }
        }



    private IntPtr HwndHandler(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam, ref bool handled)
        {
            if (msg == UsbNotification.WmDevicechange)
            {
                switch ((int)wparam)
                {
                    case UsbNotification.DbtDeviceremovecomplete:
                        Usb_DeviceRemoved();
                        break;
                    case UsbNotification.DbtDevicearrival:
                        USB_DeviceConnected();
                        break;
                }
            }

            handled = false;
            return IntPtr.Zero;
        }

    public void Usb_DeviceRemoved()
        {
            MessageBox.Show("usb removed");
            
        }

    public static bool USB_DeviceConnected()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == System.IO.DriveType.Removable)
                {

                    directory = drive.Name;
                  //  if()

                    System.Windows.MessageBox.Show("Usb Connected" , directory);
                    statusfile = directory + @"Test_file.txt";
                    Estatus = directory + @"EStatus.exbt";  //encryptedstatusfile
                    Dstatus = directory + @"DStatus.txt"; //final decrpted file
                    EMacFile = directory + @"EMacFile.exbt";
                    DMacFile = directory + @"DMacFile.txt";
                    MacAddress = GetMACAddress();
                    //MessageBox.Show(MacAddress);
                    return true;

                }
                
            }
            return false;

            
        }


    static public string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }

        

    public static bool Usb_FilesStatus()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == System.IO.DriveType.Removable)
                {
                    directory = drive.Name;
                    // MessageBox.Show(Estatus);

                    if (File.Exists(EMacFile))
                    {
                        Utility.decryptStatus(EMacFile, DMacFile);
                        TextReader tr = new StreamReader(DMacFile);
                        string s = tr.ReadToEnd().ToString();
                        tr.Close();
                        File.Delete(DMacFile);
                        if(s== MacAddress)
                        {
                            return true;

                        }
                        else
                        {
                            return false;
                        }



                    }
                   else
                    {
                        File.WriteAllText(DMacFile, MacAddress);
                       // File.Create(EMacFile);
                        Utility.encryptionStatus(DMacFile,EMacFile);
                        File.Delete(DMacFile);
                        return true;

                    }

                    }
                  

                }

            return false;
        }
           

    }

       
}



