using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net6api.Models
{
    public class APIModels
    {
        //public record User {([Required] int userId, [Required] string email, string firstName, string lastName);

        public class people 
        {
            public List<user>? users { get; set; }
        }
        public class user
        {
            [Required]
            public int userId { get; set; }
            [Required]
            public string? email { get; set; }
            public string? firstName { get; set; }
            public string? lastName { get; set; }

            public List<story>? stories { get; set; }

        };

        //public record Story([Required] int storyId, [Required] string title, int userId);
        public class story
        {
            [Required]
            public int storyId { get; set; }
            [Required]
            public string? title { get; set; }      
            public int? points { get; set; }
            public DateTime dueDate { get; set; }            
            [Required]
            public int userId { get; set; }                 
        }
    }
}
