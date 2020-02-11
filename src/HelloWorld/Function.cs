using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Newtonsoft.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace HelloWorld
{
    public class Function
    {
        private static readonly HttpClient Client = new HttpClient();

        private static async Task<string> GetCallingIp()
        {
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Add("User-Agent", "AWS Lambda .Net Client");

            var msg = await Client.GetStringAsync("http://checkip.amazonaws.com/")
                .ConfigureAwait(continueOnCapturedContext: false);

            return msg.Replace("\n", "");
        }
        
        public APIGatewayProxyResponse LambdaStreamHandler(Stream input, ILambdaContext context)
        {
            string inputString = string.Empty;
            context.Logger.LogLine("started 'LambdaStreamHandler' method");
            // Read the stream into a string
            if (input != null)
            {
                StreamReader streamReader = new StreamReader(input);
                inputString = streamReader.ReadToEnd();
            }
            context.Logger.LogLine($"LambdaStreamHandler: received the following string: {inputString}");
            // Create APIGateway response object that contains the input string.
            // For API Gateway trigger, any other response would generate an exception

            var body = inputString;
            
            var response = new APIGatewayProxyResponse
            {
                Body = JsonConvert.SerializeObject(body),
                StatusCode = (int)HttpStatusCode.OK,
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
            };
            return response;
        }

        public async Task<APIGatewayProxyResponse> FunctionHandler(APIGatewayProxyRequest apigProxyEvent,
            ILambdaContext context)
        {
            var location = await GetCallingIp();

            /*var body = new RecipesList("Pork", null, null, null, null, null, null, null, null, null, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null,
                null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            */
            return new APIGatewayProxyResponse
            {
                //Body = JsonConvert.SerializeObject(body),
                StatusCode = 200,
                Headers = new Dictionary<string, string>
                {
                    {
                        "Content-Type",
                        "application/json"
                    }
                }
            };
        }
    }
}