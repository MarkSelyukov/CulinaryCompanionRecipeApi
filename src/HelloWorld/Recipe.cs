using System;
using System.Collections.Generic;
using Newtonsoft.Json;
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
        //TODO: change this to just be analyzed instruction and not a list
        public List<AnalyzedInstruction> analyzedInstructions { get; set; }
        public object sourceName { get; set; }
        public object creditsText { get; set; }
        //TODO: add a method that returns the names of the ingredients
        public List<Ingredient> Ingredients = new List<Ingredient>();

        public Recipe(JObject[] results, bool vegetarian, bool vegan, bool glutenFree, bool dairyFree, bool veryHealthy, bool cheap, bool veryPopular, bool sustainable, string weightWatcherSmartPoints, string gaps, bool lowFodmap, string sourceUrl, string spoonacularSourceUrl, string aggregateLikes, double spoonacularScore, double healthScore, double pricePerServing, List<ExtendedIngredient> extendedIngredients, string id, string title, string readyInMinutes, string servings, string image, string imageType, List<object> cuisines, List<string> dishTypes, List<string> diets, List<object> occasions, string instructions, List<AnalyzedInstruction> analyzedInstructions, object sourceName, object creditsText)
        {
            this.results = results;
            this.vegetarian = vegetarian;
            this.vegan = vegan;
            this.glutenFree = glutenFree;
            this.dairyFree = dairyFree;
            this.veryHealthy = veryHealthy;
            this.cheap = cheap;
            this.veryPopular = veryPopular;
            this.sustainable = sustainable;
            this.weightWatcherSmartPoints = weightWatcherSmartPoints;
            this.gaps = gaps;
            this.lowFodmap = lowFodmap;
            this.sourceUrl = sourceUrl;
            this.spoonacularSourceUrl = spoonacularSourceUrl;
            this.aggregateLikes = aggregateLikes;
            this.spoonacularScore = spoonacularScore;
            this.healthScore = healthScore;
            this.pricePerServing = pricePerServing;
            this.extendedIngredients = extendedIngredients;
            this.id = id;
            this.title = title;
            this.readyInMinutes = readyInMinutes;
            this.servings = servings;
            this.image = image;
            this.imageType = imageType;
            this.cuisines = cuisines;
            this.dishTypes = dishTypes;
            this.diets = diets;
            this.occasions = occasions;
            this.instructions = instructions;
            this.analyzedInstructions = analyzedInstructions;
            this.sourceName = sourceName;
            this.creditsText = creditsText;
        }
        
        /*
        public override string ToString()
        {
            return "id: " + this.id + " title: " + this.title;
        }
        */
    }
}