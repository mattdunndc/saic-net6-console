using System.ComponentModel.DataAnnotations;

namespace saic_net6_console
{
    public class APIModels
    {        

        public class Users 
        {
            public List<User>? users { get; set; }
        }
        public class User
        {
            [Required]
            public int userId { get; set; }
            [Required]
            public string? email { get; set; }
            public string? firstName { get; set; }
            public string? lastName { get; set; }

            public List<Story>? stories { get; set; }

        };

       
        public class Story
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
