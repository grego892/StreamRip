using StreamRipper.Interfaces;
using System.Diagnostics;

namespace StreamRip
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public IStreamRipper? streamRipper;
        public MonitorStream monitorStream = new();
        public StreamData dataBind = new();

        public void StartRipBtn_Click(object sender, EventArgs e)
        {
            StartRip();
        }

        public void StopRipBtn_Click(object sender, EventArgs e)
        {
            StopRip();
        }

        public bool Muted = true;
        private void MonitorMuteBtn_Click(object sender, EventArgs e)
        {
            if (Muted)
            {
                if (monitorStream.waveOutEvent != null)
                {
                    MonitorVolumeTrk.Value = 50;
                    monitorStream.waveOutEvent.Volume = .5f;
                    Muted = false;
                    MonitorMuteBtn.Text = "Mute";
                }
            }
            else
            {
                if (monitorStream.waveOutEvent != null)
                {
                    MonitorVolumeTrk.Value = 0;
                    monitorStream.waveOutEvent.Volume = 0;
                    Muted = true;
                    MonitorMuteBtn.Text = "Unmute";
                }
            }

        }

        private void MonitorVolumeTrk_Scroll(object sender, EventArgs e)
        {
            if (monitorStream.waveOutEvent != null)
            {
                monitorStream.waveOutEvent.Volume = (float)(MonitorVolumeTrk.Value * .01);
            }
        }

        private void OpenFolderBtn_Click(object sender, EventArgs e)
        {
            string folderPath = (Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)) + "\\StreamRipper";
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new()
                {
                    Arguments = folderPath,
                    FileName = "explorer.exe"
                };

                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", folderPath));
            }
        }

        private void AboutLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V " + Application.ProductVersion.ToString(), "About", MessageBoxButtons.OK);
        }
    }
}
