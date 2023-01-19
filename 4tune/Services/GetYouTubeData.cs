using Newtonsoft.Json;
using RestSharp;

namespace _4tune.Services
{
    public static class GetYouTubeData
    {
        const string channelId = "UCXDrtNp83T47avlWnsE2gdg";
        const string apiKey = "AIzaSyC41qwhe9hkQJ8agzk70DoWGjjAegfUXh4";

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
            var response = client.Get(request).Content;
            return response;

        }

        public static string GetVideos()
        {
            request
                .AddParameter("part", "snippet")
                .AddParameter("chart", "mostPopular")
                .Resource = "/videos";

            var response = client.Get(request).Content;
            return response;
        }

        public static List<string> GetFromFewPages()
        {
            List<Comment> responses = new List<Comment>();
            List<string> comments = new List<string>();

            do
            {
                request = new RestRequest("https://www.googleapis.com/youtube/v3/commentThreads")
                        .AddParameter("part", "snippet")
                        .AddParameter("videoId", "HoWisoh38iE");

                var response = client.Get(request).Content;
                var root = JsonConvert.DeserializeObject<Comment>(response);
                responses.Add(root);
                foreach (var item in root.items)
                {
                    comments.Add(item.snippet.topLevelComment.snippet.textDisplay);
                }
                break;
            } while (true);







            return comments;
        }
    }
}
