using NAudio.Wave;

namespace StreamRip
{
    public class MonitorStream
    {

        public MediaFoundationReader? MyMediaFoundationReader { get; set; }
        public WaveOutEvent? waveOutEvent = new();

        public string Play(string? CallLetters)
        {
            try
            {
                var url = "https://playerservices.streamtheworld.com/api/livestream-redirect/" + CallLetters + ".mp3";
                MyMediaFoundationReader = new MediaFoundationReader(url);
                if (waveOutEvent != null)
                {
                    waveOutEvent.Init(MyMediaFoundationReader);
                    waveOutEvent.Play();
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public void Stop()
        {
            if (waveOutEvent != null)
            {
                waveOutEvent.Stop();
                waveOutEvent.Dispose();
            }
            if (MyMediaFoundationReader != null)
            {
                MyMediaFoundationReader.Close();
                MyMediaFoundationReader.Dispose();
            }
        }
    }
}
