﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce.Business.Abstract;
using E_Commerce.Business.Concrete;
using E_Commerce.DataAccess.Abstract;
using E_Commerce.DataAccess.Concrete.EntityFramework;
using E_Commerce.MvcWebUI.Middlewares;
using E_Commerce.MvcWebUI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.MvcWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal,EfProductDal>();
            services.AddScoped<ICategoryService,CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddSingleton<ICartSessionService, CartSessionService>();
            services.AddSingleton<ICartService, CartService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSession(); 
            services.AddDistributedMemoryCache();
            services.AddMvc();  
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            { 
                app.UseDeveloperExceptionPage();
            }

            app.UseFileServer();
            app.UseNodeModules(env.ContentRootPath);
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvcWithDefaultRoute();
        }
    }
}
