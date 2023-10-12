using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NAudio.Wave;
using StreamRipper.Extensions;
using StreamRipper.Interfaces;
using StreamRipper.Models;

namespace StreamRip
{
    public class StreamProcess
    {
        public static IStreamRipper InitRip(string CallLetters)
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .Configure<LoggerFilterOptions>(cfg => cfg.MinLevel = LogLevel.Trace)
                .AddStreamRipper()
                .BuildServiceProvider();

            var streamRipperFactory = serviceProvider.GetService<IStreamRipperFactory>();

            var streamRipper = streamRipperFactory.New(new StreamRipperOptions
            {
                Url = new Uri("https://playerservices.streamtheworld.com/api/livestream-redirect/" + CallLetters + ".mp3"),

                MaxBufferSize = 10 * 1000000    // stop when buffer size passes 10 megabytes
            });

            return streamRipper;
        }

        public static void MonitorStream(string CallLetters)
        {
            var url = "https://playerservices.streamtheworld.com/api/livestream-redirect/" + CallLetters + ".mp3";
            using (var mf = new MediaFoundationReader(url))
            using (var wo = new WasapiOut())
            {
                wo.Init(mf);
                wo.Play();
            }
        }
    }
}
