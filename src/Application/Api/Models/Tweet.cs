namespace Api.Models
{
    public class Tweet
    {
        public int TweetId { get; set; }
        public string? Text { get; set; }
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
