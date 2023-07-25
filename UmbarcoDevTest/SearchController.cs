using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NPoco.fastJSON;
using Umbraco.Cms.Web.Common.Controllers;
using UmbracoDevTest.Services.Implementation;
using UmbracoDevTest.Services.Interface;
using UmbracoDevTest.Services.Models;

namespace UmbracoDevTest
{
    
    public class SearchController : UmbracoApiController
    {
        // GET: SearchController
        private readonly IGetUserService _getUserService;
        public SearchController(IGetUserService getUserService)
        {
            _getUserService = getUserService;

        }
          public async Task<List<UserRS>> Index(string? key)
            {
            return (await _getUserService.GetUsers(key));
            }
        // GET: SearchController/Create
    }
}
