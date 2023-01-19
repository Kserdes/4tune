public class Snippet
{
    public string videoId { get; set; }
    public TopLevelComment topLevelComment { get; set; }
    public bool canReply { get; set; }
    public int totalReplyCount { get; set; }
    public bool isPublic { get; set; }
    public string textDisplay { get; set; }
    public string textOriginal { get; set; }
    public string authorDisplayName { get; set; }
    public string authorProfileImageUrl { get; set; }
    public string authorChannelUrl { get; set; }
    public AuthorChannelId authorChannelId { get; set; }
    public bool canRate { get; set; }
    public string viewerRating { get; set; }
    public int likeCount { get; set; }
    public DateTime publishedAt { get; set; }
    public DateTime updatedAt { get; set; }
}