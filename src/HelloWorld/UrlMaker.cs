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
            string[,] urlArray = new string[2, 2]
            {
                {"&query=", query},
                {"two", "two"}
            };
            
            UrlCreation = mainUrl+searchURL+apiKeyURL+apiKey+urlArray[0,0]+urlArray[0,1]+searchAmountURL+searchAmount+searchRecipeRequiredURL+searchRecipeRequired;

            for (int i = 1; i < urlArray.Length; i++)
            {
                if(urlArray[1,i]!=null)
                    UrlCreation = UrlCreation + urlArray[0, i] + urlArray[1, i];
            }
        }

        public UrlMaker(int id)
        {
            
        }
    }
}