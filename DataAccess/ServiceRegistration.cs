using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class ServiceRegistration
    {
        public static void AddDataAccessRegistration(this IServiceCollection services)
        {
            services.AddScoped<ICategoryDal, EFCategoryDal>();
            //services.AddScoped<ICustomerDal, Ef>();
            services.AddScoped<IOrderDal, EFOrderDal>();
            services.AddScoped<IProductDal, EFProductDal>();
        }
    }
}
