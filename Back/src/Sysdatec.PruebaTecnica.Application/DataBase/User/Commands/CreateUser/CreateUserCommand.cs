


using AutoMapper;
using Sysdatec.PruebaTecnica.Application.DataBase;
using Sysdatec.PruebaTecnica.Domain.Entities.User;

namespace Sysdatec.PruebaTecnica.Application.Database.User.Commands.CreateUser
{
    public class CreateUserCommand : ICreateUserCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public CreateUserCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;

        }
        public async Task<CreateUserModel> Execute(CreateUserModel model)
        {
            var entity = _mapper.Map<UserEntity>(model);

            _dataBaseService.AddUser(entity);

            //await _dataBaseService.User.AddAsync(entity);
            //await _dataBaseService.SaveAsync();
            return model;
        }

    }
}
