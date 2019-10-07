using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

using System.Threading.Tasks;
using BusinessLib.Model.Entity;
using System.Net.Http;

namespace BusinessLib.Common
{

    public interface IApiClient
    {
        Task<ApiResponse> GetAsync(string relativePath);
    }

    public class WebApiClient : IApiClient
    {
        private System.Net.Http.HttpClient _httpClient;

        public WebApiClient()
        {
        }


        public async Task<ApiResponse> GetAsync(string relativePath)
        {
            //Uri completeUri = this.BuildCompleteUri(relativePath);
            ApiResponse response = new ApiResponse();
            HttpClient Client = new HttpClient();
            
            HttpResponseMessage apiResponse = await Client.GetAsync(relativePath);
            if (apiResponse.IsSuccessStatusCode)
            {
                string responseData = apiResponse.Content.ReadAsStringAsync().Result;
                if (!string.IsNullOrWhiteSpace(responseData))
                {
                    response.IsSuccessful = true;
                    response.Data = responseData;
                }
            }
            else
            {
                // TODO: Log Errors
            }

            return response;
        }


    }
}
