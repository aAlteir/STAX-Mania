using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace STAX_Mania
{
    public partial class Main : Form
    {
        private DirectoryInfo DirAPO;
        private DirectoryInfo DirCon;

        public Main()
        {
            InitializeComponent();
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal,
            int size, string filePath);

        private void Main_Load(object sender, EventArgs e)
        {
            var settingDirectory = new StringBuilder(255);
            var settingMode = new StringBuilder(255);
            GetPrivateProfileString("STAXMania", "DIRECTORY", "(NONE)", settingDirectory, 255,
                Environment.CurrentDirectory + @"\setting.ini");
            GetPrivateProfileString("STAXMania", "MODE", "(NONE)", settingMode, 255,
                Environment.CurrentDirectory + @"\setting.ini");

            DirAPO = new DirectoryInfo(settingDirectory.ToString());
            DirCon = new DirectoryInfo(settingDirectory + @"\config");

            if (DirAPO.Exists)
            {
                Status_Eqapo.Text = "설치됨";
                Install_EQ.Enabled = false;
            }

            if (settingMode.ToString() == "MONITOR")
                Status_Mode.Text = "Monitor Mode";
            else if (settingMode.ToString() == "SIGNATURE") Status_Mode.Text = "Signature Mode";
        }

        private void Apply_Monitor_Click(object sender, EventArgs e)
        {
            var configWriter = new StreamWriter(DirCon + @"\config.txt", false);
            configWriter.WriteLine("Preamp: -8.1 dB");
            configWriter.WriteLine("Filter: ON PK Fc 600 Hz Gain 1.7 dB Q 2.8");
            configWriter.WriteLine("Filter: ON PK Fc 1400 Hz Gain -4.2 dB Q 1.2");
            configWriter.WriteLine("Filter: ON PK Fc 3200 Hz Gain 6.1 dB Q 1");
            configWriter.WriteLine("Filter: ON PK Fc 6100 Hz Gain -2.9 dB Q 3.5");
            configWriter.WriteLine("Filter: ON PK Fc 7900 Hz Gain 2.3 dB Q 2.5");
            configWriter.WriteLine("Filter: ON PK Fc 10500 Hz Gain -6.6 dB Q 5.4");
            configWriter.Close();

            Status_Mode.Text = "Monitor Mode";

            MessageBox.Show("모니터 모드가 적용되었습니다.", "스탁스매니아");
        }

        private void Apply_Signature_Click(object sender, EventArgs e)
        {
            var configWriter = new StreamWriter(DirCon + @"\config.txt", false);
            configWriter.WriteLine("Preamp: -8.1 dB");
            configWriter.WriteLine("Filter: ON PK Fc 600 Hz Gain 4.4 dB Q 1.2");
            configWriter.WriteLine("Filter: ON PK Fc 1600 Hz Gain -2.6 dB Q 1.3");
            configWriter.WriteLine("Filter: ON PK Fc 3350 Hz Gain 8.1 dB Q 1.1");
            configWriter.WriteLine("Filter: ON PK Fc 8700 Hz Gain 2.5 dB Q 1.2");
            configWriter.Close();

            Status_Mode.Text = "Signature Mode";
            MessageBox.Show("시그니처 모드가 적용되었습니다.", "스탁스매니아");
        }

        private void Apply_Restore_Click(object sender, EventArgs e)
        {
            var configWriter = new StreamWriter(DirCon + @"\config.txt", false);
            configWriter.WriteLine("");
            configWriter.Close();
            MessageBox.Show("모드 적용이 해제되었습니다.", "스탁스매니아");
            Status_Mode.Text = "적용 안됨";
        }

        private void Install_EQ_Click(object sender, EventArgs e)
        {
            Process.Start("https://sourceforge.net/projects/equalizerapo/files/latest/download");
        }

        private void Choose_EQ_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            if (dialog.SelectedPath == "")
                return;
            var selectedPath = dialog.SelectedPath;
            DirAPO = new DirectoryInfo(selectedPath);
            WritePrivateProfileString("STAXMania", "DIRECTORY", selectedPath, "setting.ini");
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            WritePrivateProfileString("STAXMania", "DIRECTORY", DirAPO.ToString(),
                Environment.CurrentDirectory + @"\setting.ini");
            WritePrivateProfileString("STAXMania", "MODE",
                Status_Mode.Text == "Monitor Mode" ? "MONITOR" :
                Status_Mode.Text == "Signature Mode" ? "SIGNATURE" : "NONE",
                Environment.CurrentDirectory + @"\setting.ini");
        }

        private bool check_install()
        {
            if (!DirAPO.Exists)
            {
                MessageBox.Show("EqualizerAPO가 설치되어 있지 않습니다.", "스탁스매니아");
                return false;
            }

            Status_Eqapo.Text = "설치됨";
            return true;
        }
    }
}