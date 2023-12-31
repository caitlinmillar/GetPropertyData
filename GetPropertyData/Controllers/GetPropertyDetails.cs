using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GetPropertyData.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetPropertyDetails : ControllerBase
    {

        public string CustomerURL = "https://get-hackdata.azurewebsites.net/api/get-cust-details?code=kERyrCjem5eBRFDBLLCO2yRfYxEUbuMtCxhgdHAqpUCIAzFuTe3kfA==";
        public string MultCustURL = "https://get-hackdata.azurewebsites.net/api/get-multiple-cust?code=fV2WMh3ld3z93qPjdypjq56W_fNsh2k5UoGa1U_XzEBFAzFuZaqs1w==";
        public string inspectiondataurl = "https://get-hackdata.azurewebsites.net/api/get-multiple-inspection-data?code=7e7Cad6Vf4ne5ITgf_dibRBQibzuONZvGpQ1B6b8cF1qAzFup2Iylg==";
        private readonly ILogger<GetPropertyDetails> _logger;
        public string DBConnectionstr = "AccountEndpoint=https://hackdatadb.documents.azure.com:443/;AccountKey=XnzdHzA2ntyqvqTUC5QQnwvRaAHWVXzTSpKdmhK7p7hjSszwYbej7n2Ul4XcnmoRjV2vbuwW7E9uACDbmScWIA==;";
        public GetPropertyDetails(ILogger<GetPropertyDetails> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<string> GetPropertyData(string Fname, string Sname, string DOB)
        {


           

            RequestDefinition requestDefinition = new RequestDefinition();
            requestDefinition.columnNames = new List<string>  { "First Name", "Last Name", "Date of Birth" };
            requestDefinition.columnValues = new List<string> { Fname, Sname, DOB };
          
        
            var response = APIHelper.SendRequest(MultCustURL,RestSharp.Method.Get, null , requestDefinition);
                       var customer = JsonConvert.DeserializeObject<List<Customer>>(response.Content);
            if (customer != null)
            {
                RequestDefinition requestDefinition1 = new RequestDefinition();
                requestDefinition1.columnNames = new List<string> { "Property Address" };
                requestDefinition1.columnValues = new List<string> { customer[0].PropertyAddress };
               
                 response = APIHelper.SendRequest(inspectiondataurl, RestSharp.Method.Get, null, requestDefinition1);

                var inspectionData = JsonConvert.DeserializeObject<List<InspectionData>>(response.Content);
                if (inspectionData != null)
                {
                    responses responses = new responses() { customer = customer[0], inspectionData = inspectionData[0] };
                    return Ok(responses);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }


        }
    }
}