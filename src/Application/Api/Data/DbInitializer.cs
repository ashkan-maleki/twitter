using Api.Models;

namespace Api.Data
{
    public class DbInitializer
    {
        public static void Initialize(TwitterContext context)
        {
            // Look for any students.
            if (context.Tweets.Any())
            {
                return;
            }
            var tweets = new Tweet[]
            {
                new Tweet{Text="My first tweet"},
                new Tweet{Text="Carson"},
                new Tweet{Text="Hi"},
                new Tweet{Text="Very good"},
                new Tweet{Text="Hello World!"},
            };

            context.Tweets.AddRange(tweets);
            context.SaveChanges();
        }
    }
}

