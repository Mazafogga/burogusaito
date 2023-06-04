namespace burogusaito.Models
{
    public class User
    {
        public Guid id { get; set; }
        // string email
        public string? email { get; set; }
        // string password
        public string? password { get; set; }

        // string firstname
        public string? firstname { get; set; }

        // string lastname
        public string? lastname { get; set; }

        public DateTime created_at { get; set; }
        // string updated_at
        public DateTime updated_at { get; set; }
    }
}
