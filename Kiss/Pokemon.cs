namespace Kiss
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Type { get; set; }

        public Pokemon(string name, int level, string type)
        {
            Name = name;
            Level = level;
            Type = type;
        }

        public void DisplayInformation()
        {
            Console.WriteLine($"Name: {Name}, Level: {Level}, Type: {Type}");
        }
    }
}