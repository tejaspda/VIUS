using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessLib.Model.Entity;

namespace BusinessLib.Common
{
    public class APIWrapper
    {
        private IApiClient _apiClient;

        public async Task<ActionResult> ApiGet(string relativePath)
        {

            ApiResponse response = await this.ApiClient.GetAsync(relativePath);
            ActionResult result = response.IsSuccessful ? new ContentResult { Content = response.Data, ContentType = "application/json" } as ActionResult : new JsonResult(response.Data);
            return result;
        }

        protected IApiClient ApiClient
        {
            get
            {
                return this._apiClient;
            }
        }


    }
}
