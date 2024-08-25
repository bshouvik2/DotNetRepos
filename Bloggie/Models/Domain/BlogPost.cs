using System.Formats.Asn1;

namespace Bloggie.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public string heading { get; set; }
        public string pageTitle { get; set; }
        public string content { get; set; }
        public string shortDescription { get; set; }
        public string featuredImageURL { get; set; }
        public string Urlhandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public bool Visible { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}
