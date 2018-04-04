using AutoMapper;
using GeneralShop.Model.Models;
using GeneralShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneralShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Post, PostViewModel>();
            }
            );
        }
    }
}