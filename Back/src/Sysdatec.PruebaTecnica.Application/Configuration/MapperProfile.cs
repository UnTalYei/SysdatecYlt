using AutoMapper;
using Sysdatec.PruebaTecnica.Application.Database.User.Commands.CreateUser;
using Sysdatec.PruebaTecnica.Application.Database.User.Queries.GetAllUser;
using Sysdatec.PruebaTecnica.Application.Database.User.Queries.GetUserById;
using Sysdatec.PruebaTecnica.Domain.Entities.User;


namespace Sysdatec.PruebaTecnica.Application.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region User 
            CreateMap<UserEntity, CreateUserModel>().ReverseMap();
            //CreateMap<UserEntity, UpdateUserModel>().ReverseMap();
            CreateMap<UserEntity, GetAllUserModel>().ReverseMap();
            CreateMap<UserEntity, GetUserByIdModel>().ReverseMap();
            //CreateMap<UserEntity, GetUserByUserNameAndPasswordModel>().ReverseMap();
            #endregion
        }
    }
}
