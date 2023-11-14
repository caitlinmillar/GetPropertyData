using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetPropertyData
{


    public class CosmosDBHelper
    {
        private readonly CosmosClient _client;
        private readonly string _databaseName;
        private readonly string _containerName;

        public CosmosDBHelper(string connectionString, string databaseName, string containerName)
        {
            _client = new CosmosClient(connectionString);
            _databaseName = databaseName;
            _containerName = containerName;
        }

        public async Task<IEnumerable<T>> QueryItemsAsync<T>(string query)
        {
            var container = _client.GetContainer(_databaseName, _containerName);
            var queryDefinition = new QueryDefinition(query);
            var iterator = container.GetItemQueryIterator<T>(queryDefinition);

            var results = new List<T>();
            while (iterator.HasMoreResults)
            {
                var response = await iterator.ReadNextAsync();
                results.AddRange(response.ToList());
            }

            return results;
        }
    }
}
