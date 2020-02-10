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

        public RecipesList(string query,
            string cuisine,
            string excludeCuisine,
            string diet,
            string intolerances,
            string equipment,
            string includeIngredients,
            string excludeIngredients,
            string type,
            string maxReadyTime,
            string minCarbs,
            string maxCarbs,
            string minProtein,
            string maxProtein,
            string minCalories,
            string maxCalories,
            string minFat,
            string maxFat,
            string minCaffeine,
            string maxCaffeine,
            string minCopper,
            string maxCopper,
            string minCalcium,
            string maxCalcium,
            string minCholesterol,
            string maxCholesterol,
            string minSaturatedFat,
            string maxSaturatedFat,
            string minVitaminA,
            string maxVitaminA,
            string minVitaminC,
            string maxVitaminC,
            string minVitaminD,
            string maxVitaminD,
            string minVitaminE,
            string maxVitaminE,
            string minVitaminK,
            string maxVitaminK,
            string minVitaminB1,
            string maxVitaminB1,
            string minVitaminB2,
            string maxVitaminB2,
            string minVitaminB5,
            string maxVitaminB5,
            string minVitaminB3,
            string maxVitaminB3,
            string minVitaminB6,
            string maxVitaminB6,
            string minVitaminB12,
            string maxVitaminB12,
            string minFiber,
            string maxFIber,
            string minIron,
            string maxIron,
            string minMagnesium,
            string maxMagnesium,
            string minPotassium,
            string maxPotassium,
            string minSodium,
            string maxSodium,
            string minSugar,
            string maxSugar,
            string minZinc,
            string maxZinc)
        {
            UrlMaker urlMaker = new UrlMaker(query, null, null, null, null, null, null, null, null, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null,
                null);
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