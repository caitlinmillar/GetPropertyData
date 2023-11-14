using RestSharp;

namespace GetPropertyData
{
    public class APIHelper
    {

        public static async Task<string> GetAsync(string url, Dictionary<string, string> queryParams = null, List<string[]> querystrings = null)
        {
            using (var client = new HttpClient())
            {
                if (queryParams != null)
                {
                    var queryString = new FormUrlEncodedContent(queryParams);
                    url += $"?{queryString.ReadAsStringAsync().Result}";
                }
                if (querystrings != null)
                {
                    //Add list to body
                }
                

                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }

        public static RestResponse SendRequest(string endpoint, Method method, Dictionary<string, string> headers = null, object body = null)
        {
            var client = new RestClient();
            var request = new RestRequest(endpoint, method);

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                }
            }

            if (body != null)
            {
                request.AddJsonBody(body);
            }

            return client.Execute(request);
        }

    }
}
