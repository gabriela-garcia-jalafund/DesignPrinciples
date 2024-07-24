namespace Yagni
{
    public class Report
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Report(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public void DisplayReport()
        {
            Console.WriteLine($"Title: {Title}\nContent: {Content}");
        }
    }
}
