using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace HelloWorld
{
    public class Recipe
    {
        public JObject[] results { get; set; }

        public bool vegetarian { get; set; }
        public bool vegan { get; set; }
        public bool glutenFree { get; set; }
        public bool dairyFree { get; set; }
        public bool veryHealthy { get; set; }
        public bool cheap { get; set; }
        public bool veryPopular { get; set; }
        public bool sustainable { get; set; }
        public String weightWatcherSmartPoints { get; set; }
        public string gaps { get; set; }
        public bool lowFodmap { get; set; }
        public string sourceUrl { get; set; }
        public string spoonacularSourceUrl { get; set; }
        public String aggregateLikes { get; set; }
        public double spoonacularScore { get; set; }
        public double healthScore { get; set; }
        public double pricePerServing { get; set; }
        public List<ExtendedIngredient> extendedIngredients { get; set; }
        public String id { get; set; }
        public string title { get; set; }
        public String readyInMinutes { get; set; }
        public String servings { get; set; }
        public string image { get; set; }
        public string imageType { get; set; }
        public List<object> cuisines { get; set; }
        public List<string> dishTypes { get; set; }
        public List<string> diets { get; set; }
        public List<object> occasions { get; set; }
        public string instructions { get; set; }
        public List<AnalyzedInstruction> analyzedInstructions { get; set; }
        public object sourceName { get; set; }
        public object creditsText { get; set; }
        public Recipe()
        {
        }

        public override string ToString()
        {
            return "id: " + this.id + " title: " + this.title;
        }
    }
}