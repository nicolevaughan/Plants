namespace Plants
{
    interface IPlants
    {
        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Scientific { get; set; }

        //Methods
        string FullName();
        string Growth();
    }
    class Program
    {
        class GrowPlants : IPlants
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Scientific { get; set; }
            public string Water { get; set; }
            public string Sun { get; set; }

            public GrowPlants()
            {
                Id = 0;
                Name = string.Empty;
                Scientific = string.Empty;
                Water = string.Empty;
                Sun = string.Empty;
            }
            public GrowPlants(int id, string name, string scientific, string water, string sun)
            {
                Id = id;
                Name = name;
                Scientific = scientific;
                Water = water;
                Sun = sun;
            }
            public string FullName()
            {
                return Name + " also known as " + Scientific;
            }
            public string Growth()
            {
                return "I have " + Water + " water needs and require " + Sun + " to grow";
            }
        }
        static void Main(string[] args)
        {
            //GrowPlants object created using parameterized constructor
            GrowPlants plants = new GrowPlants(1, "Common Buttonbush", "Cephalanthus occidentalis", "Medium to High", "Full Sun");
            Console.WriteLine(plants.FullName());
            Console.WriteLine(plants.Growth());

            //GrowPlants object created using default constructor
            GrowPlants herb = new GrowPlants();
            herb.Id = 2;
            herb.Name = "Swamp Milkweed";
            herb.Scientific = "Asclepias incarnata";
            herb.Water = "High";
            herb.Sun = "Full Sun to Partial Shade";
            Console.WriteLine(herb.FullName());
            Console.WriteLine(herb.Growth());
        }
    }
}
    
