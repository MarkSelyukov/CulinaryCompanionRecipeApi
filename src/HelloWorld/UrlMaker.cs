namespace HelloWorld
{
        public class UrlMaker
    {
        private string mainUrl = "https://api.spoonacular.com/";
        private string searchURL = "recipes/complexSearch?";

        private string apiKeyURL = "apiKey=";
        private string apiKey = "e1f10f400ad84c099085e73db4e42fc0";

        private string searchAmountURL = "&number=";
        public string searchAmount = "5";

        private string searchRecipeRequiredURL = "&instructionsRequired=";
        private string searchRecipeRequired = "true";

        public string UrlCreation { get; set; }
        
        private string queryUrl = "&query=";

        public UrlMaker(string query,
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
            string[,] urlArray = new string[66, 2]
            {
                {"&query=", query},
                {"&cuisine=", cuisine},
                {"&excludeCuisine=", excludeCuisine},
                {"&diet=", diet},
                {"&intolerances=", intolerances},
                {"&equipment=", equipment},
                {"&includeIngredients=", includeIngredients},
                {"&excludeIngredients=", excludeIngredients},
                {"&type=", type},
                {"&addRecipeInformation=", "true"}, //set to true since we want to only have one call
                {"&maxReadyTime=", maxReadyTime},
                {"&minCarbs=", minCarbs},
                {"&maxCarbs=", maxCarbs},
                {"&minProtein=", minProtein},
                {"&maxProtein=", maxProtein},
                {"&minCalories=", minCalories},
                {"&maxCalories=", maxCalories},
                {"&minFat=", minFat},
                {"&maxFat=", maxFat},
                {"&minCaffeine=", minCaffeine},
                {"&maxCaffeine=", maxCaffeine},
                {"&minCopper=", minCopper},
                {"&maxCopper=", maxCopper},
                {"&minCalcium=", minCalcium},
                {"&maxCalcium=", maxCalcium},
                {"&minCholesterol=", minCholesterol},
                {"&maxCholesterol=", maxCholesterol},
                {"&minSaturatedFat=", minSaturatedFat},
                {"&maxSaturatedFat=", maxSaturatedFat},
                {"&minVitaminA=", minVitaminA},
                {"&maxVitaminA=", maxVitaminA},
                {"&minVitaminC=", minVitaminC},
                {"&maxVitaminC=", maxVitaminC},
                {"&minVitaminD=", minVitaminD},
                {"&maxVitaminD=", maxVitaminD},
                {"&minVitaminE=", minVitaminE},
                {"&maxVitaminE=", maxVitaminE},
                {"&minVitaminK=", minVitaminK},
                {"&maxVitaminK=", maxVitaminK},
                {"&minVitaminB1=", minVitaminB1},
                {"&maxVitaminB1=", maxVitaminB1},
                {"&minVitaminB2=", minVitaminB2},
                {"&maxVitaminB2=", maxVitaminB2},
                {"&minVitaminB5=", minVitaminB5},
                {"&maxVitaminB5=", maxVitaminB5},
                {"&minVitaminB3=", minVitaminB3},
                {"&maxVitaminB3=", maxVitaminB3},
                {"&minVitaminB6=", minVitaminB6},
                {"&maxVitaminB6=", maxVitaminB6},
                {"&minVitaminB12=", minVitaminB12},
                {"&maxVitaminB12=", maxVitaminB12},
                {"&minFiber=", minFiber},
                {"&maxFIber=", maxFIber},
                {"&minIron=", minIron},
                {"&maxIron=", maxIron},
                {"&minMagnesium=", minMagnesium},
                {"&maxMagnesium=", maxMagnesium},
                {"&minPotassium=", minPotassium},
                {"&maxPotassium=", maxPotassium},
                {"&minSodium=", minSodium},
                {"&maxSodium=", maxSodium},
                {"&minSugar=", minSugar},
                {"&maxSugar=", maxSugar},
                {"&minZinc=", minZinc},
                {"&maxZinc=", maxZinc},
                {"&limitLicense=", "false"} //set to false unless we need to have license
            };

            UrlCreation = mainUrl + searchURL + apiKeyURL + apiKey + urlArray[0, 0] + urlArray[0, 1] + searchAmountURL +
                          searchAmount + searchRecipeRequiredURL + searchRecipeRequired;

            for (int i = 1; i < 66; i++)
            {
                if (urlArray[i, 1] != null)
                    UrlCreation = UrlCreation + urlArray[i, 0] + urlArray[i, 1];
            }
        }
    }
}