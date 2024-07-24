namespace Kiss
{
    public class Program
    {
        public static void Main()
        {
            var person = new Person("John", 30);
            person.ShowInformation();

            var pikachu = new Pokemon("Pikachu", 25, "Electric");
            pikachu.DisplayInformation();
        }
    }
}