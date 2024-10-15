using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Sysdatec.PruebaTecnica.Application.Configuration;
using Sysdatec.PruebaTecnica.Application.Database.User.Commands.CreateUser;
using Sysdatec.PruebaTecnica.Application.Database.User.Queries.GetAllUser;
using Sysdatec.PruebaTecnica.Application.Database.User.Queries.GetUserById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarkerYlt.Booking.Application.Validators.User;

namespace Sysdatec.PruebaTecnica.Application
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var mapper = new MapperConfiguration(config =>
            {
                config.AddProfile(new MapperProfile());
            });
            #region User
            services.AddSingleton(mapper.CreateMapper());
            services.AddTransient<ICreateUserCommand, CreateUserCommand>();
            services.AddTransient<IGetAllUserQuery, GetAllUserQuery>();
            services.AddTransient<IGetUserByIdQuery, GetUserByIdQuery>();
            #endregion

            #region Validator
            services.AddScoped<IValidator<CreateUserModel>, CreateUserValidator>();
            #endregion
            return services;
        }
    }
}
