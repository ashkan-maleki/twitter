using Api.Models;

namespace Api.Data
{
    public class DbInitializer
    {
        public static void Initialize(TwitterContext context)
        {

            // Look for any users.
            if (context.Users.Any())
            {
                return;
            }
            var user1 = new User { FirstName = "F1", LastName = "L1", UserEmail = "user1@gmail.com", UserName = "user1", UserPassword = "password" };
            var user2 = new User { FirstName = "F2", LastName = "L2", UserEmail = "user2@gmail.com", UserName = "user2", UserPassword = "password" };
            var user3 = new User { FirstName = "F3", LastName = "L3", UserEmail = "user3@gmail.com", UserName = "user3", UserPassword = "password" };

            context.Users.Add(user1);
            context.Users.Add(user2);
            context.Users.Add(user3);

            context.SaveChanges();

            // Look for any tweets.
            if (context.Tweets.Any())
            {
                return;
            }
            var tweets = new Tweet[]
            {
                new Tweet{Text="My first tweet", User = user1},
                new Tweet{Text="Carson", User = user1},
                new Tweet{Text="Hi", User = user1},
                new Tweet{Text="Very good", User = user2},
                new Tweet{Text="Hello World!", User = user2},
                new Tweet{Text="I am a good user", User = user3},
            };

            context.Tweets.AddRange(tweets);
            context.SaveChanges();

           
        }
    }
}

