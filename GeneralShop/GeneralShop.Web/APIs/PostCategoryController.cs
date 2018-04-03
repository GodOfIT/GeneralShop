using GeneralShop.Web.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GeneralShop.Service;
using GeneralShop.Model.Models;

namespace GeneralShop.Web.APIs
{
    [RoutePrefix("apis/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postCategoryService;
        public PostCategoryController(IErrorService errorService, IPostCategoryService postCategoryService) : base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }
    
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                    var listcategory = _postCategoryService.GetAll();
                HttpResponseMessage response = null;
                response = request.CreateResponse(HttpStatusCode.OK, listcategory);
                return response;
            });
        }



    }
}