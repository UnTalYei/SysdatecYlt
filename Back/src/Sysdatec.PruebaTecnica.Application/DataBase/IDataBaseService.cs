using Microsoft.EntityFrameworkCore;
using Sysdatec.PruebaTecnica.Domain.Entities.User;

namespace Sysdatec.PruebaTecnica.Application.DataBase
{
    public interface IDataBaseService
    {
        DbSet<UserEntity> User { get; set; }
        Task<bool> SaveAsync();

        //Data In Memory
        UserEntity AddUser(UserEntity user);
        List<UserEntity> GetUsers();

    }
}
