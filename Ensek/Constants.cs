namespace Ensek
{
    public static class Constants
    {
        public static class Config
        {
            public const string ApiUrl = "https://localhost:44377";
        }
        public static class Endpoint
        {
            public const string UploadEndpoint = Config.ApiUrl + "/api/meterreading/upload";
            public const string DownloadEndpoint = Config.ApiUrl + "/your-download-endpoint";
        }

    }
}
