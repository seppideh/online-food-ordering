using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Online_Food_Ordering_System.Data;
using Online_Food_Ordering_System.Repository.Implementations;
using Online_Food_Ordering_System.Repository.Interfaces;

namespace Online_Food_Ordering_System
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
      services.AddDbContext<FoodStoreContext>(options =>
               options.UseNpgsql(Configuration.GetConnectionString("FoodStoreConnectionStrings")));
      services.AddControllers();

      services.AddTransient<IDiscountTicketRepository, DiscountTicketRepository>();
      services.AddTransient<IItemRepository, ItemRepository>();
      services.AddTransient<IOrderDetailRepository, OrderDetailRepository>();
      services.AddTransient<IOrderRepository, OrderRepository>();
      services.AddTransient<IPaymentRepository, PaymentRepository>();
      services.AddTransient<IUserRepository, UserRepository>();

      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      app.UseSwagger();
      app.UseSwaggerUI(c =>
      {
        c.SwaggerEndpoint("v1/swagger.json", "My API V1");
      });
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
