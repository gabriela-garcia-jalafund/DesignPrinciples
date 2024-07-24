namespace Yagni
{
    public class Program 
    {
        public static void Main()
        {
            var report = new Report("US_03 - Report Emergency", "This is my report, it is very important, please read it.");
            report.DisplayReport();
        }
    }
}