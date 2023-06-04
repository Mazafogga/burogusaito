namespace burogusaito.Models
{
    public class Post
    {
        // uuid id
        public Guid id { get; set; }
        // string title
        public string? title { get; set; }
        // string body
        public string? body { get; set; }

        public int status { get; set; } = 1;
        // string author
        public Guid author { get; set; }
        // string created_at
        public DateTime created_at { get; set; }
        // string updated_at
        public DateTime updated_at { get; set; }
    }
}
