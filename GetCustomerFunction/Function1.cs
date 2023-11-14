using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;

namespace GetCustomerFunction
{
    public static class Function1
    {
        [FunctionName("QueryCosmosDB")]
        public static IActionResult Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
        [CosmosDB(
            databaseName: "hackdatadb",
            collectionName: "customerDetails",
            ConnectionStringSetting = "AccountEndpoint=https://hackdatadb.documents.azure.com:443/;AccountKey=XnzdHzA2ntyqvqTUC5QQnwvRaAHWVXzTSpKdmhK7p7hjSszwYbej7n2Ul4XcnmoRjV2vbuwW7E9uACDbmScWIA==;")] CosmosClient client)
        {

                // Parse query parameters
                string firstName = req.Query["firstName"];
                string lastName = req.Query["lastName"];

                // Build SQL query
                string sqlQuery = "SELECT * FROM c WHERE c.firstName = @firstName AND c.lastName = @lastName";
                QueryDefinition queryDefinition = new QueryDefinition(sqlQuery)
                    .WithParameter("@firstName", firstName)
                    .WithParameter("@lastName", lastName);

                // Execute query
                List<object> results = new List<object>();
                FeedIterator<object> resultSetIterator = client.GetDatabase("your-database-name")
                    .GetContainer("your-collection-name")
                    .GetItemQueryIterator<object>(queryDefinition);
                while (resultSetIterator.HasMoreResults)
                {
                    FeedResponse<object> response = resultSetIterator.ReadNextAsync().Result;
                    results.AddRange(response);
                }

                return new OkObjectResult(results);
            }
        }
    }
}
