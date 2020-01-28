using Newtonsoft.Json.Linq;

namespace HelloWorld
{
    public class Recipe
    {
        public JObject[] results { get; set; }
        
        public string id { get; set; }
        public string title { get; set; }
        public string readyInMinutes { get; set; }
        public string servings { get; set; }
        public string image { get; set; }
        public string[] imageUrls { get; set; }

        Recipe() {}

        public Recipe(string id, string title, string readyInMinutes, string servings, string image, string[] imageUrls)
        {
            this.id = id;
            this.title = title;
            this.readyInMinutes = readyInMinutes;
            this.servings = servings;
            this.image = image;
            this.imageUrls = imageUrls;
        }

        public override string ToString()
        {
            return "id: " + this.id + " title: " + this.title + "image urls: " + imageUrls[0];
        }
    }
}