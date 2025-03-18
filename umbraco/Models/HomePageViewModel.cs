namespace umbraco.Models
{
    public class HomePageViewModel
    {
        public string Title { get; set; }
        public string DescriptiveText { get; set; }
        
        // Collection of Article Titles
        public List<string> Articles { get; set; }
    }

    public class ArticlesResponse
    {
        public List<Article> Results { get; set; }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Url { get; set; }
    }
}