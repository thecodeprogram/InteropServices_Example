using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace InteropServices_Example
{
    class Program
    {
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);


        static void Main(string[] args)
        {

            Console.Title = "Interop Services Example - Thecodeprogram";
            StartAndWrite();
            Console.ReadLine();
        }

        public static  void StartAndWrite()
        {
            IntPtr windowPointer = IntPtr.Zero;
            int processCount = 100;
            for (int i = 0; (i < processCount) && (windowPointer == IntPtr.Zero); i++)
            {
                windowPointer = FindWindow(null, "exampleNotepad.txt - Not Defteri");
            }
            if (windowPointer != IntPtr.Zero)
            {
                SetForegroundWindow(windowPointer);
                Thread.Sleep(500);
                SendKeys.SendWait("BurakHamdiTUFAN");
                SendKeys.SendWait(Environment.NewLine);
                SendKeys.SendWait("Thecodeprogram");
                SendKeys.SendWait("{ENTER}");
                SendKeys.Flush();
            }
        }

    }
}
