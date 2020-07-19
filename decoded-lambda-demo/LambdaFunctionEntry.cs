using Amazon.Lambda.Core;
using Amazon.Lambda.SQSEvents;
using System.Threading.Tasks;
using System.Text.Json;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace decoded_lambda_demo
{
    public class LambdaFunctionEntry
    {
        public async Task FunctionHandler(SQSEvent invocationEvent, ILambdaContext context)
        {
            await Task.FromResult(0); // dummy awaiter

            LambdaLogger.Log(JsonSerializer.Serialize(invocationEvent));
        }
    }
}
