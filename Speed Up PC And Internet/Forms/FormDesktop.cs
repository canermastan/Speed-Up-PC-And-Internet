using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;


namespace Speed_Up_PC_And_Internet
{
    public partial class FormDesktop : Form
    {
        public FormDesktop()
        {
            InitializeComponent();
        }

        private void ClearCache()
        {
            string[] paths = new string[3]
            {
                "c:\\windows\\temp",
                "c:\\users\\"+Environment.UserName+"\\appdata\\local\\temp",
                "c:\\windows\\prefetch"
            };

            foreach (string path in paths)
            {
                var dir = new DirectoryInfo(path);
                foreach (var file in Directory.GetFiles(dir.ToString()))
                {
                    try
                    {
                        File.Delete(file);
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void DisableServices()
        { 
            string[] arguments = new string[]
            {
                String.Format("/C sc {0} {1} {2}", "config", "wuauserv", "start=disabled"), // Windows Update startup=disable
                String.Format("/C sc {0} {1} {2}", "config", "WSearch", "start=disabled"), // Windows Search startup=disable
                String.Format("/C sc {0} {1} {2}", "config", "SysMain", "start=disabled"), // SysMain (Superfetch) startup=disable
                String.Format("/C sc {0} {1}", "stop", "wuauserv"), // Windows Update status=stopped
                String.Format("/C sc {0} {1}", "stop", "WSearch"), // Windows Search status=stopped
                String.Format("/C sc {0} {1}", "stop", "SysMain"), // SysMain (Superfetch) status=stopped
            };
            var info = new ProcessStartInfo();
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.FileName = "cmd.exe";

            for (int i = 0; i < arguments.Length; i++)
            {
                info.Arguments = arguments[i];
                using (var process = new Process { StartInfo = info })
                {
                    if (!process.Start())
                    {
                        return;
                    }
                    process.WaitForExit();
                }
            }
        }
        private void btnClearCache_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Önbellek temizleniyor...", "İşlem Başlatıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearCache();
            MessageBox.Show("Önbellek temizlendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDisableServices_Click(object sender, EventArgs e)
        {
            DisableServices();
            MessageBox.Show("Gereksiz servisler kapatıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            
        }

        private void btnApplyAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Önbellek temizleniyor...", "İşlem Başlatıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearCache();
            MessageBox.Show("Önbellek temizlendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DisableServices();
            MessageBox.Show("Gereksiz servisler kapatıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
