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
            ParseJson(recipeResults, urlMaker);
        }

        public void ParseJson(Recipe recipeResults, UrlMaker urlMaker)
        {
            recipeResults = JsonConvert.DeserializeObject<Recipe>(this.returnedRecipesString);

            for (int i = 0; i < Int32.Parse(urlMaker.searchAmount); i++)
            {
                //I have to do it like this because I was getting errors
                string id = recipeResults.results[i].GetValue("id").ToString();
                string title = recipeResults.results[i].GetValue("title").ToString();
                string readyInMinutes = recipeResults.results[i].GetValue("readyInMinutes").ToString();
                string serving = recipeResults.results[i].GetValue("servings").ToString();
                string image = recipeResults.results[i].GetValue("image").ToString();
                string[] imageUrls = {"WOOP"}; //recipeResults.results[i].GetValue("imageUrls").ToObject<string[]>();

                Recipe recipe = new Recipe(id, title, readyInMinutes, serving, image, imageUrls);

                recipes.Add(recipe);
            }
        }
    }
}