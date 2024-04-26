namespace webme12.Models
{
    public class Article
    {
        public long Id{ get; set; }
        public string Description{ get; set; }
        public string Title{ get; set; }
        public string Img { get; set; }


        public Article(int id,string desctiption,string title,string img)
        {

            Id = id;

            Description = desctiption;

            Title = title;

            Img = img;

        }

    }
}
