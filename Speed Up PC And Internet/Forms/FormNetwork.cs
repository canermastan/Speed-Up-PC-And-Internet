using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Speed_Up_PC_And_Internet
{
    public partial class FormNetwork : Form
    {
        public FormNetwork()
        {
            InitializeComponent();
        }

        private void FormNetwork_Load(object sender, EventArgs e)
        {
            
        }

        private void TcpOptimization()
        {
            string path = @"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces";
            var key1 = Registry.LocalMachine.OpenSubKey(path, RegistryKeyPermissionCheck.ReadWriteSubTree);
            var key2 = Registry.LocalMachine.OpenSubKey(path, RegistryKeyPermissionCheck.ReadWriteSubTree);

            if (key1 != null && key2 != null)
            {
                try
                {
                    key1.SetValue("TcpAckFrequency", 1);
                    key2.SetValue("TCPNoDelay", 1);
                    MessageBox.Show("Nagle Algoritması Uygulandı.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nagle Algoritması uygulanırken bir sorunla karşılaşıldı!\n\nHATA : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

            }
        }

        private void NetworkContractionOff()
        {
            string path = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile";
            var key = Registry.LocalMachine.OpenSubKey(path, RegistryKeyPermissionCheck.ReadWriteSubTree);
            try
            {
                key.SetValue("NetworkThrottlingIndex", 0xffffffff);
                MessageBox.Show("Ağ daralması kapatıldı.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ağ daralması kapatılırken bir hata oluştu!\n\nHata: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearCache()
        {
            Process process = new Process();
            var info = new ProcessStartInfo();
            info.FileName = "cmd.exe";
            process.StartInfo = info;
            string[] arguments = new string[3]
            {
                "/k ipconfig /flushdns",
                "/k ipconfig /release",
                "/k ipconfig /renew"
            };
            for (int i = 0; i < arguments.Length; i++)
            {
                info.Arguments = arguments[i];
                process.Start();
                Thread.Sleep(1000);
                process.CloseMainWindow();
            }
        }

        private void EnableMsmq()
        {
            Process process = new Process();
            var info = new ProcessStartInfo();
            info.FileName = "dism.exe";
            info.Arguments = "/Online /Enable-Feature /FeatureName:MSMQ-Server /all";
            process.StartInfo = info;

            List<ServiceController> services = ServiceController.GetServices().ToList();
            ServiceController msmq = services.Find(o => o.ServiceName == "MSMQ");
            if (msmq == null)
            {
                process.Start();
                MessageBox.Show("MSMQ başarılı bir şekilde aktifleştirildi.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("MSMQ zaten aktif.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTcpOptimization_Click(object sender, EventArgs e)
        {
            TcpOptimization();
        }

        private void btnNetworkContractionOff_Click(object sender, EventArgs e)
        {
            NetworkContractionOff();
        }

        private void btnClearCache_Click(object sender, EventArgs e)
        {
            ClearCache();
            MessageBox.Show("Önbellek Temizlendi.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEnableMsmq_Click(object sender, EventArgs e)
        {
            EnableMsmq();
        }

        private void btnApplyAll_Click(object sender, EventArgs e)
        {
            TcpOptimization();
            NetworkContractionOff();
            ClearCache();
            EnableMsmq();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            /*List<ServiceController> services = ServiceController.GetServices().ToList();
            ServiceController msmq = services.Find(o => o.ServiceName == "MSMQ");
            if (msmq == null)
            {
                if (msmq.Status == ServiceControllerStatus.Running)
                {
                    
                }
            }
            else
            {
                MessageBox.Show("MSMQ zaten aktif.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
    }
}
