using System.ComponentModel.DataAnnotations;

namespace MyBlog.Models
{
    public class Post
    {
        public int PostId { get; set; }
        [Required,
         MaxLength(length:50)]
        public string PostTitle { get; set; }
        [Required,
         MaxLength(length:500)]
        public string PostBody { get; set; }
        public List<string>? PostImages { get; set; }
        public List<string>? VideoPlayer { get; set; }
        [Required, DataType(DataType.DateTime)]
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        [Required, DataType(DataType.DateTime)]
        public DateTime UpdatedTime { get; set; }
    }
}
