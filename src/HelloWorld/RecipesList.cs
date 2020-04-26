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

            Recipe recipe = JsonConvert.DeserializeObject<Recipe>(this.returnedRecipesString);

            for (int i = 0; i < Int32.Parse(urlMaker.searchAmount); i++)
            {
                var result = recipe.results[i];
                var recipeFromResult = JsonConvert.SerializeObject(result);
                Recipe input = JsonConvert.DeserializeObject<Recipe>(recipeFromResult);

                List<AnalyzedInstruction> analyzedInstructions = input.analyzedInstructions;
                AnalyzedInstruction analyzedInstruction = analyzedInstructions[0];
                List<Step> steps = analyzedInstruction.steps;

                //TODO: refactor this code. Break it up into a few methods
                //foreach (var step in steps)
                for (int j = 0; j < steps.Count; j++)
                {
                    var step = steps[j];
                    var ingredients = step.ingredients;

                    //foreach (var ingredient in ingredients)
                    for (int k = 0; k < ingredients.Count; k++)
                    {
                        var ingredient = ingredients[k];

                        var id = ingredient.id;
                        var name = ingredient.name;
                        var image = ingredient.image;

                        var ingredientFinal = new Ingredient(id, name, image);

                        input.Ingredients.Add(ingredientFinal);
                        input.IngredientsInString.Add(ingredientFinal.name);
                    }
                }

                recipes.Add(input);
            }
        }
    }
}