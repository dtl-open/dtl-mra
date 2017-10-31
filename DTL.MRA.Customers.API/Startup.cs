﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTL.MRA.Customers.API.Data;
using DTL.MRA.Customers.API.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DTL.MRA.Customers.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            var sqlConnectionString = Configuration.GetConnectionString("DataAccessPostgreSqlProvider");

            services.AddDbContext<CustomerDbContext>(options =>
                options.UseNpgsql(sqlConnectionString)
            );

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<ICustomerRepository, CustomerRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}