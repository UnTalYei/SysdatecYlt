using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sysdatec.PruebaTecnica.Application.DataBase;

namespace Sysdatec.PruebaTecnica.Application.Database.User.Queries.GetAllUser
{
    public class GetAllUserQuery : IGetAllUserQuery
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public GetAllUserQuery(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }
        public async Task<List<GetAllUserModel>> Execute()
        {
            //var listEntity = await _dataBaseService.User.ToListAsync();
            var listEntity = _dataBaseService.GetUsers();
            return _mapper.Map<List<GetAllUserModel>>(listEntity);
        }
    }
}
