using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;
namespace PCSUGGESTER
{
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void mainpage_Load(object sender, EventArgs e)
        {
            Graphics.Text = string.Empty;
            cpu.Text=string.Empty;
            ram.Text=string.Empty;
            storage.Text=string.Empty;
            ManagementObjectSearcher graphicsCardSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject obj in graphicsCardSearcher.Get())
            {
                Graphics.Text="Graphics Card :"+ obj["Name"];
            }

            // Get CPU information
            ManagementObjectSearcher cpuSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject obj in cpuSearcher.Get())
            {
                cpu.Text="CPU :"+ obj["Name"];
            }

            // Get RAM information
            ManagementObjectSearcher ramSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            long totalRam = 0;
            foreach (ManagementObject obj in ramSearcher.Get())
            {
                totalRam += Convert.ToInt64(obj["Capacity"]);
            }
            ram.Text="RAM: GB"+ Math.Round(Convert.ToDouble(totalRam) / 1024 / 1024 / 1024, 2);

            // Get storage information
            ManagementObjectSearcher storageSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk WHERE DriveType=3");
            foreach (ManagementObject obj in storageSearcher.Get())
            {
                storage.Text+="Drive: GB free"+ obj["Name"]+ Math.Round(Convert.ToDouble(obj["FreeSpace"]) / 1024 / 1024 / 1024, 2);
            }

            // Get OS information
            ManagementObjectSearcher osSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject obj in osSearcher.Get())
            {
                Console.WriteLine("OS: {0} {1}", obj["Caption"], obj["OSArchitecture"]);
            }
        }
    }
}
