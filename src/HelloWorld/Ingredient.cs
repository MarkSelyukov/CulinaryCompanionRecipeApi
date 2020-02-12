namespace HelloWorld
{
    public class Ingredient
    {
        public Ingredient(string id, string name, string image)
        {
            this.id = id;
            this.name = name;
            this.image = image;
        }

        public string id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
    }
}