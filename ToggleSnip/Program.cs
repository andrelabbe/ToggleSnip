using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace ToggleSnip
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Start the snipping tool process
            Process snippingTool = new Process();
            snippingTool.StartInfo.FileName = @"C:\Program Files\WindowsApps\Microsoft.ScreenSketch_11.2310.54.0_x64__8wekyb3d8bbwe\SnippingTool\SnippingTool.exe";
            snippingTool.Start();
            Thread.Sleep(400);
            // Wait for the process to be ready
            snippingTool.WaitForInputIdle();

            // Start of the eky stroke sequence

            Thread.Sleep(400);
 //           SendKeys.SendWait("{TAB}");
            Thread.Sleep(400);
            SendKeys.SendWait("{TAB}");
            Thread.Sleep(400);
            SendKeys.SendWait("{TAB}");
            Thread.Sleep(400);
            SendKeys.SendWait("{TAB}");
            Thread.Sleep(400);
            SendKeys.SendWait("{TAB}");
            Thread.Sleep(400);
            SendKeys.SendWait("{UP}");
            Thread.Sleep(400);
            SendKeys.SendWait("{ENTER}");
            Thread.Sleep(400);
            SendKeys.SendWait("{TAB}");
            Thread.Sleep(400);
            SendKeys.SendWait("{TAB}");
            Thread.Sleep(400);
            SendKeys.SendWait(" ");
            Thread.Sleep(400);
            //SendKeys.SendWait("{TAB}");
            //Thread.Sleep(400);
            //SendKeys.SendWait("{TAB}");
            //Thread.Sleep(400);
            //SendKeys.SendWait("{TAB}");
            //Thread.Sleep(400);
            SendKeys.SendWait("% ");
            Thread.Sleep(400);
            SendKeys.SendWait("{UP}");
            Thread.Sleep(400);
            SendKeys.SendWait("{ENTER}");


        }
    }
}
