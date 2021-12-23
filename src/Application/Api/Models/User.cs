using System.Text.Json.Serialization;

namespace Api.Models
{
    public class User
    {

        [JsonIgnore]
        public int UserId { get; set; }
        public string UserName { get; set; }
        [JsonIgnore]
        public string UserPassword { get; set; }

        public string UserEmail { get; set; }

        
        public DateTime CreatedDate { get; set; } = DateTime.Now;

       
        public DateTime LastModifiedDate { get; set;} = DateTime.Now;

        public string FirstName { get; set; }
        public string LastName { get; set; }   



    }
}
