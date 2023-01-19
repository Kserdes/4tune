using Newtonsoft.Json;
using RestSharp;

namespace _4tune.Services
{
    public class GetYouTubeData
    {
        protected static string channelId = "UCXDrtNp83T47avlWnsE2gdg";
        protected const string apiKey = "AIzaSyC41qwhe9hkQJ8agzk70DoWGjjAegfUXh4";

        static RestClient client = new RestClient("https://www.googleapis.com/youtube/v3")
            .AddDefaultParameter("key", apiKey);

        static RestRequest request = new RestRequest();


        public static string GetComments()
        {
            request
            .AddParameter("part", "snippet")
            .AddParameter("allThreadsRelatedToChannelId", channelId)
            .AddParameter("order", "time")
            .Resource = "/commentThreads";
            var response = client.Get(request).Content.ToString();
            return response;

        }

        public static string GetVideos()
        {
            request
                .AddParameter("part", "statistics")
                .AddParameter("chart", "mostPopular")
                .Resource = "/videos";

            var response = client.Get(request).Content.ToString();
            return response;
        }
        
    }
}
