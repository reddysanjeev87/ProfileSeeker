using Autofac;
using ProfileSeeker.Application;
using ProfileSeeker.Persisstence.Github;
using ProfileSeeker.Persisstence.Github.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
  
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HttpClientProxy>().As<IHttpClientProxy>();
            builder.RegisterType<JsonConverter>().As<IJsonConverter>();
            builder.RegisterType<ProfileSeekerConfiguration>().As<IProfileSeekerConfiguration>();
            builder.RegisterType<UserProfileSeeker>().As<IUserProfileSeeker>();
            builder.RegisterType<UserRepositorySeeker>().As<IUserRepositorySeeker>();
            base.Load(builder);
        }
    }
    
}