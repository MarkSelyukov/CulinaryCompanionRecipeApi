using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace HelloWorld
{
    public class RecipesList
    {
        private string recipeListUrl;
        private string returnedRecipesString { get; set; }
        private Recipe recipeResults = null;
        public List<Recipe> recipes = new List<Recipe>();

        public RecipesList(RecipeSearch recipeSearch)
        {
            UrlMaker urlMaker = new UrlMaker(recipeSearch);
            this.recipeListUrl = urlMaker.UrlCreation;
            this.returnedRecipesString = new WebClient().DownloadString(this.recipeListUrl);
            recipes.Add(JsonConvert.DeserializeObject<Recipe>(this.returnedRecipesString));
        }
    }
}