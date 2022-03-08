using Autofac;
using ProfileSeeker.Application;
using ProfileSeeker.Persisstence.Github;
using ProfileSeeker.Persisstence.Github.Proxy;

namespace ProfileSeeker.DependencyResolver
{
    public class GithubPersisstenceModule: Module
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
