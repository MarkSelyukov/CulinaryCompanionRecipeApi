using System;

namespace HelloWorld
{
    public class UrlMaker
    {
        private string mainUrl = "https://api.spoonacular.com/";
        private string searchURL = "recipes/complexSearch?";

        private string apiKeyURL = "apiKey=";
        private string apiKey = "e1f10f400ad84c099085e73db4e42fc0";

        private string searchAmountURL = "&number=";
        public string searchAmount = "3";

        private string searchRecipeRequiredURL = "&instructionsRequired=";
        private string searchRecipeRequired = "true";

        public string UrlCreation { get; set; }

        private string queryUrl = "&query=";

        public UrlMaker(RecipeSearch recipeSearch)
        {
            string[,] urlArray = new string[66, 2]
            {
                {"&query=", recipeSearch.query},
                {"&cuisine=", recipeSearch.cuisine},
                {"&excludeCuisine=", recipeSearch.excludeCuisine},
                {"&diet=", recipeSearch.diet},
                {"&intolerances=", recipeSearch.intolerances},
                {"&equipment=", recipeSearch.equipment},
                {"&includeIngredients=", recipeSearch.includeIngredients},
                {"&excludeIngredients=", recipeSearch.excludeIngredients},
                {"&type=", recipeSearch.type},
                {"&addRecipeInformation=", "true"}, //set to true since we want to only have one call
                {"&maxReadyTime=", recipeSearch.maxReadyTime},
                {"&minCarbs=", recipeSearch.minCarbs},
                {"&maxCarbs=", recipeSearch.maxCarbs},
                {"&minProtein=", recipeSearch.minProtein},
                {"&maxProtein=", recipeSearch.maxProtein},
                {"&minCalories=", recipeSearch.minCalories},
                {"&maxCalories=", recipeSearch.maxCalories},
                {"&minFat=", recipeSearch.minFat},
                {"&maxFat=", recipeSearch.maxFat},
                {"&minCaffeine=", recipeSearch.minCaffeine},
                {"&maxCaffeine=", recipeSearch.maxCaffeine},
                {"&minCopper=", recipeSearch.minCopper},
                {"&maxCopper=", recipeSearch.maxCopper},
                {"&minCalcium=", recipeSearch.minCalcium},
                {"&maxCalcium=", recipeSearch.maxCalcium},
                {"&minCholesterol=", recipeSearch.minCholesterol},
                {"&maxCholesterol=", recipeSearch.maxCholesterol},
                {"&minSaturatedFat=", recipeSearch.minSaturatedFat},
                {"&maxSaturatedFat=", recipeSearch.maxSaturatedFat},
                {"&minVitaminA=", recipeSearch.minVitaminA},
                {"&maxVitaminA=", recipeSearch.maxVitaminA},
                {"&minVitaminC=", recipeSearch.minVitaminC},
                {"&maxVitaminC=", recipeSearch.maxVitaminC},
                {"&minVitaminD=", recipeSearch.minVitaminD},
                {"&maxVitaminD=", recipeSearch.maxVitaminD},
                {"&minVitaminE=", recipeSearch.minVitaminE},
                {"&maxVitaminE=", recipeSearch.maxVitaminE},
                {"&minVitaminK=", recipeSearch.minVitaminK},
                {"&maxVitaminK=", recipeSearch.maxVitaminK},
                {"&minVitaminB1=", recipeSearch.minVitaminB1},
                {"&maxVitaminB1=", recipeSearch.maxVitaminB1},
                {"&minVitaminB2=", recipeSearch.minVitaminB2},
                {"&maxVitaminB2=", recipeSearch.maxVitaminB2},
                {"&minVitaminB5=", recipeSearch.minVitaminB5},
                {"&maxVitaminB5=", recipeSearch.maxVitaminB5},
                {"&minVitaminB3=", recipeSearch.minVitaminB3},
                {"&maxVitaminB3=", recipeSearch.maxVitaminB3},
                {"&minVitaminB6=", recipeSearch.minVitaminB6},
                {"&maxVitaminB6=", recipeSearch.maxVitaminB6},
                {"&minVitaminB12=", recipeSearch.minVitaminB12},
                {"&maxVitaminB12=", recipeSearch.maxVitaminB12},
                {"&minFiber=", recipeSearch.minFiber},
                {"&maxFIber=", recipeSearch.maxFIber},
                {"&minIron=", recipeSearch.minIron},
                {"&maxIron=", recipeSearch.maxIron},
                {"&minMagnesium=", recipeSearch.minMagnesium},
                {"&maxMagnesium=", recipeSearch.maxMagnesium},
                {"&minPotassium=", recipeSearch.minPotassium},
                {"&maxPotassium=", recipeSearch.maxPotassium},
                {"&minSodium=", recipeSearch.minSodium},
                {"&maxSodium=", recipeSearch.maxSodium},
                {"&minSugar=", recipeSearch.minSugar},
                {"&maxSugar=", recipeSearch.maxSugar},
                {"&minZinc=", recipeSearch.minZinc},
                {"&maxZinc=", recipeSearch.maxZinc},
                {"&limitLicense=", "false"} //set to false unless we need to have license
            };

            UrlCreation = mainUrl + searchURL + apiKeyURL + apiKey + urlArray[0, 0] + urlArray[0, 1] + searchAmountURL +
                          searchAmount + searchRecipeRequiredURL + searchRecipeRequired;

            for (int i = 1; i < 66; i++)
            {
                if (urlArray[i, 1] != null)
                    UrlCreation = UrlCreation + urlArray[i, 0] + urlArray[i, 1];
            }
            
            Console.WriteLine(UrlCreation);
        }
    }
}