using Microsoft.Extensions.DependencyInjection;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concretes;
using Project.DAL.Repositories.Abstract;
using Project.DAL.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ServiceExtensions
{
    public static class RepManExtentionService
    {
        public static IServiceCollection AddRepManServices(this IServiceCollection services)
        {
            //Repositories
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<IArticleTagRepository, ArticleTagRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IEditorRepository, EditorRepository>();
            services.AddScoped<IProfileRepository, ProfileRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
           

            //Managers
            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));
            services.AddScoped<ISpecialUserManager, SpecialUserManager>();
            services.AddScoped<IArticleManager, ArticleManager>();
            services.AddScoped<IArticleTagManager, ArticleTagManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IEditorManager, EditorManager>();
            services.AddScoped<IProfileManager, ProfileManager>();
            services.AddScoped<ITagManager, TagManager>();
            services.AddScoped<IUserIdentityManager, UserIdentityManager>();
            services.AddScoped<ILoginManager, LoginManager>();

            return services;
        }
    }
}
