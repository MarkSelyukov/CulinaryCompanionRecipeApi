namespace HelloWorld
{
    public class UrlMaker
    {
        private string mainUrl = "https://api.spoonacular.com/recipes/";
        private string searchURL = "search?";

        private string apiKeyURL = "apiKey=";
        private string apiKey = "e1f10f400ad84c099085e73db4e42fc0";

        private string queryUrl = "&query=";
        
        private string searchAmountURL = "&number=";
        public string searchAmount = "5";

        private string searchRecipeRequiredURL = "&instructionsRequired=";
        private string searchRecipeRequired = "true";

        public string UrlCreation { get; set;}

        public UrlMaker(string query)
        {
            UrlCreation = mainUrl+searchURL+apiKeyURL+apiKey+queryUrl+query+searchAmountURL+searchAmount+searchRecipeRequiredURL+searchRecipeRequired;
        }

        public UrlMaker(int id)
        {
            
        }
    }
}