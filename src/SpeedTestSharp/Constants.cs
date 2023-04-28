namespace SpeedTestSharp
{
    public class Constants
    {
        public const string ConfigUrl = "https://www.speedtest.net/speedtest-config.php";
        public const string ServersUrl = "http://www.speedtest.net/speedtest-servers.php";
        public const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const int MaxUploadSize = 10;
        public static readonly int[] DownloadSizes = { 350, 500, 750, 1000, 1500, 2000, 2500, 3000, 3500, 4000 };
    }
}
