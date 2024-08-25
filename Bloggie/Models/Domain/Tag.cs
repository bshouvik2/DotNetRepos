namespace Bloggie.Models.Domain
{
    public class Tag
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string displayname { get; set; }
        public ICollection<BlogPost> myBlogPost { get; set; }

    }
}
