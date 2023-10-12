namespace StreamRip
{
    public partial class MainForm
    {
        public void StartRip()
        {
            if (StartRipBtn.InvokeRequired)
            {
                StartRipBtn.BeginInvoke(() =>
                {
                    StartRipBtn.Enabled = dataBind.StreamRunning;
                    StopRipBtn.Enabled = !dataBind.StreamRunning;
                });
            }
            else
            {
                StartRipBtn.Enabled = dataBind.StreamRunning;
                StopRipBtn.Enabled = !dataBind.StreamRunning;
            }

            streamRipper = StreamProcess.InitRip(CallLettersTxt.Text.ToUpper());

            string ErrorText = monitorStream.Play(CallLettersTxt.Text.ToUpper());
            if (ErrorText != "")
            {
                Error(ErrorText);
            }
            if (monitorStream != null)
            {
                monitorStream.waveOutEvent.Volume = 0;
            }

            // The recommended way is to have an async event handlers
            streamRipper.SongChangedEventHandlers += async (_, arg) =>
            {
                try
                {
                    // Create filename from SongInfo
                    dataBind.CurrentSong = $"{arg.SongInfo.SongMetadata}";

                    // Save the stream to file
                    string filePath = (Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)) + "\\StreamRipper\\" + CallLettersTxt.Text + "\\";

                    FileInfo file = new(filePath);

                    file.Directory?.Create(); // If the directory already exists, this method does nothing.

                    await File.WriteAllBytesAsync(filePath + $"{arg.SongInfo.SongMetadata}.mp3", arg.SongInfo.Stream.ToArray());
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            };

            streamRipper.MetadataChangedHandlers += (_, arg) =>
            {
                if (CurrentSongTxt.InvokeRequired)
                {
                    CurrentSongTxt.BeginInvoke(() =>
                    {
                        CurrentSongTxt.Text = $"{arg.SongMetadata.Title + " - " + arg.SongMetadata.Artist}";
                    });
                }
                else
                {
                    CurrentSongTxt.Text = $"{arg.SongMetadata.Title + " - " + arg.SongMetadata.Artist}";
                }
            };

            streamRipper.Start();
        }
        public void StopRip()
        {
            streamRipper?.Dispose();

            monitorStream?.Stop();

            if (StopRipBtn.InvokeRequired)
            {
                StopRipBtn.BeginInvoke(() =>
                {
                    StartRipBtn.Enabled = !dataBind.StreamRunning;
                    StopRipBtn.Enabled = dataBind.StreamRunning;
                });
            }
            else
            {
                StartRipBtn.Enabled = !dataBind.StreamRunning;
                StopRipBtn.Enabled = dataBind.StreamRunning;
            }
            CurrentSongTxt.Text = "";
        }
        public async Task Error(string Message)
        {
            StopRip();
            if (Message == "0xC00D001A")
            {
                Message = "Call Letters not valid.  Please re-enter.";
            }
            CurrentSongTxt.Text = "Error:  " + Message;
            await Task.Delay(5000);
            CurrentSongTxt.Text = "";
        }
    }
}
