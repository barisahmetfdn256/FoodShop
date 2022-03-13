using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrate;
using Castle.DynamicProxy;
using Core.Utilites.İntercaptors;
using DataAccsees.Abstract;
using DataAccsees.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Module = Autofac.Module;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           
            builder.RegisterType<FoodManager>().As<IFoodService>().SingleInstance();
            builder.RegisterType<EfFoodDal>().As<IFoodDal>().SingleInstance();

            builder.RegisterType<ShopManager>().As<IShopService>().SingleInstance();
            builder.RegisterType<EfShopDal>().As<IShopDal>().SingleInstance();


            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
