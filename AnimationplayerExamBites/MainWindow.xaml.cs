using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AnimationplayerExamBites.Classes;
using AnimationplayerExamBites.Pages;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Interop;

namespace AnimationplayerExamBites
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string jString;
        public static  string Dpath;
        //for print screen code
        private static LowLevelKeyboardProc objKeyboardProcess;
        private static IntPtr ptrHook;
        public const int WDA_MONITOR = 0x01;
        //for screen rocord
        [DllImport("user32.dll")]
        static extern bool SetWindowDisplayAffinity(IntPtr hWnd, int dwAffinity);

        public MainWindow()
        {
            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule; //Get Current Module
            objKeyboardProcess = new LowLevelKeyboardProc(captureKey); //Assign callback function each time keyboard process
                                                                       //Setting Hook of Keyboard Process for current module
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);
            

            jString = Utility.Serialization();
            // Utility.PopulateList();
            Utility.DetectClockManipulation(DateTime.Now);
            LoadConfig();
            
            //System.Windows.MessageBox.Show(abc.ToString());
            this.Closed += MainWindow_Closed;
            //InitializeComponent();
            //Switcher.pageSwitcher = this;
            //Switcher.Switch(new UILevel());
        }

        private void MainWindow_Closed(object sender, EventArgs e)
        {
            try
            { 
            if (File.Exists(UIVideoPlayer.DSource))
            {
                File.Delete(UIVideoPlayer.DSource);
            }
            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Errorr!!");
            }


        }

        public void Navigate(System.Windows.Controls.UserControl nextPage)
        {
            this.Content = nextPage; //navigating through all the User controls
        }

        public void LoadConfig()
        {
            MetaData.Metadata.Init(jString);
            if (UsbConfiguration.USB_DeviceConnected())
            {
                //if()
                //{
                //}


                if ( UsbConfiguration.Usb_FilesStatus())
                {
                    Dpath = UsbConfiguration.directory;
                    InitializeComponent();
                    Switcher.pageSwitcher = this;
                    Switcher.Switch(new UILevel());

                }
                else
                {
                    System.Windows.MessageBox.Show("Your Subsrciption has been Expired :D");
                    this.Close();
                }

            }
            else
            {
                System.Windows.MessageBox.Show("BaryeMeharbani Exambite ki Usb connect karain.");
                this.Close();
            }



        }



       
       //When main window activate event occoure the screen record disable code will be fired.

        private void MainWindowActivate(object sender, EventArgs e)
        {
            IntPtr windowHandle = new WindowInteropHelper(System.Windows.Application.Current.MainWindow).Handle;
            SetWindowDisplayAffinity(windowHandle, WDA_MONITOR);
        }

       //// //FOR PRINT SCREEN DISABLE//
        [StructLayout(LayoutKind.Sequential)]
        private struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
            internal Key SystemKey;
            internal bool Handled;
        }

        //System level functions to be used for hook and unhook keyboard input
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string name);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern short GetAsyncKeyState(Keys key);



        private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
        {
            if (nCode >= 0)
            {

                KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));

                if (objKeyInfo.key == Keys.LWin && objKeyInfo.key == Keys.PrintScreen ||
                    objKeyInfo.key == Keys.RWin && objKeyInfo.key == Keys.PrintScreen ||
                    objKeyInfo.key == Keys.PrintScreen ||
                    objKeyInfo.key == Keys.ControlKey && objKeyInfo.key == Keys.PrintScreen ||
                    objKeyInfo.key == Keys.RControlKey && objKeyInfo.key == Keys.PrintScreen ||
                    objKeyInfo.key == Keys.LControlKey && objKeyInfo.key == Keys.PrintScreen ||
                     objKeyInfo.key == Keys.Alt && objKeyInfo.key == Keys.PrintScreen ||
                      objKeyInfo.key == Keys.LShiftKey && objKeyInfo.key == Keys.PrintScreen ||
                       objKeyInfo.key == Keys.LControlKey ||
                        objKeyInfo.key == Keys.RControlKey
                 )
                // Disabling Windows keys
                {
                    return (IntPtr)1;
                }
            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
            // System.Windows.MessageBox.Show("disabled");
            //Application.Exit();
        }



    }
}
