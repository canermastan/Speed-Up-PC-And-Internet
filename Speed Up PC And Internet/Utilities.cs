using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Speed_Up_PC_And_Internet
{
    internal class Utilities
    {
        public void CheckVersion()
        {
            
            try
            {
                string url = "http://www.canermastan.com/versionoptimizeprogram";
                WebRequest webRequest = WebRequest.Create(url);

                WebResponse webResponse;
                webResponse = webRequest.GetResponse();

                StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());
                string cm = streamReader.ReadToEnd();

                int start = cm.IndexOf("<p>") + 3;
                int stop = cm.Substring(start).IndexOf("</p>");

                string versionString = cm.Substring(start, stop);
                double version = Convert.ToDouble(versionString);

                if (!Settings.Default.version.Equals(version))
                {
                    DialogResult option = MessageBox.Show("Güncelleme mevcut!\nŞimdi indirmek ister misiniz?\n\nKullandığınız versiyon: v" + Settings.Default.version + "\nGüncel versiyon: v" + version, "Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (option == DialogResult.Yes)
                    {
                        Process.Start(new ProcessStartInfo("http://www.canermastan.com/download/optimizeprogram") { UseShellExecute = true }); // download link
                    }
                    else
                    {

                    }
                }
            }
            catch
            {

            }
        }
    }
}
