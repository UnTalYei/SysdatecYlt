using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sysdatec.PruebaTecnica.Application.DataBase;

namespace Sysdatec.PruebaTecnica.Application.Database.User.Queries.GetUserById
{
    public class GetUserByIdQuery : IGetUserByIdQuery
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public GetUserByIdQuery(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }
        public async Task<GetUserByIdModel> Execute(int userId)
        {
            //var entity = await _dataBaseService.User
            //    .FirstOrDefaultAsync(x => x.UserId == userId);
            var entity = _dataBaseService.GetUsers().FirstOrDefault(x=> x.UserId == userId);
            return _mapper.Map<GetUserByIdModel>(entity);
        }
    }
}
