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
using System.Collections;
using System.Runtime.Remoting.Contexts;
using System.Data.SQLite;
using System.Data.SqlClient;

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
            cpu.Text = string.Empty;
            ram.Text = string.Empty;
            ManagementObjectSearcher graphicsCardSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject obj in graphicsCardSearcher.Get())
            {
                Graphics.Text = "Graphics Card :\n" + obj["Name"];
            }

            // Get CPU information
            ManagementObjectSearcher cpuSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject obj in cpuSearcher.Get())
            {
                cpu.Text = "CPU :\n" + obj["Name"];
            }

            // Get RAM information
            ManagementObjectSearcher ramSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            long totalRam = 0;
            foreach (ManagementObject obj in ramSearcher.Get())
            {
                totalRam += Convert.ToInt64(obj["Capacity"]);
            }
            ram.Text = "RAM: \nGB" + Math.Round(Convert.ToDouble(totalRam) / 1024 / 1024 / 1024, 2);

            // Get storage information
            ManagementObjectSearcher storageSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk WHERE DriveType=3");
            foreach (ManagementObject obj in storageSearcher.Get())
            {
                storage.Text += "\nDrive: GB free " + obj["Name"] + Math.Round(Convert.ToDouble(obj["FreeSpace"]) / 1024 / 1024 / 1024, 2);
            }

            // Get OS information
            ManagementObjectSearcher osSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject obj in osSearcher.Get())
            {
                Console.WriteLine("OS: {0} {1}", obj["Caption"], obj["OSArchitecture"]);
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            List<string> applist = new List<string>();
            int bestgpuid = 0;
            int bestcpuid = 0;
            int ramcap = 0;
            foreach (object itemChecked in Programs.CheckedItems)
            {
                applist.Add(itemChecked.ToString());
            }
            foreach (object itemChecked in games.CheckedItems)
            {
                applist.Add(itemChecked.ToString());
            }
            foreach (var app in applist)
            {
                string sql = "select * from APPS where APPNAME=" + app;
                connect.connection.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, connect.connection);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sql2 = "select * from GPU where CardName=" + reader["GPU"].ToString();
                    connect.connection.Open();
                    SQLiteCommand cmd2 = new SQLiteCommand(sql, connect.connection);
                    SQLiteDataReader reader2 = cmd.ExecuteReader();
                    while (reader2.Read())
                    {
                        if (bestgpuid < Convert.ToInt32(reader2["ID"]))
                        {
                            bestgpuid = Convert.ToInt32(reader2["ID"]);
                        }
                    }
                    reader2.Close();
                    string sql3 = "select * from CPU where CPUNAME=" + reader["CPUNAME"].ToString();
                    connect.connection.Open();
                    SQLiteCommand cmd3 = new SQLiteCommand(sql, connect.connection);
                    SQLiteDataReader reader3 = cmd.ExecuteReader();
                    while (reader3.Read())
                    {
                        if (bestcpuid < Convert.ToInt32(reader3["ID"]))
                        {
                            bestcpuid = Convert.ToInt32(reader3["ID"]);
                        }
                    }
                    reader3.Close();

                    if (ramcap < Convert.ToInt32(reader["RAM"].ToString()))
                    {
                        ramcap = Convert.ToInt32(reader["RAM"].ToString());
                    }
                    string os = reader["OS"].ToString();


                }//while ending
                reader.Close();
                connect.connection.Close();
            }//foreach ending




        }
    }
}
