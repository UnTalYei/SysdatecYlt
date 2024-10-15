using Microsoft.EntityFrameworkCore;
using Sysdatec.PruebaTecnica.Application.DataBase;
using Sysdatec.PruebaTecnica.Domain.Entities.User;
using Sysdatec.PruebaTecnica.Persistence.Configuration;

namespace Sysdatec.PruebaTecnica.Persistence.DataBase
{
    public class DataBaseService : DbContext, IDataBaseService
    {
        public DataBaseService(DbContextOptions options): base(options)
        {
            
        }
        //Se crea codigo para mostrar conexion a la bd, pero se usara el InMemory
        public DbSet<UserEntity> User { get; set; }
        public async Task<bool> SaveAsync()
        {
            return await SaveChangesAsync() > 0;
        }
        //Metodo para invocar la configuracion que necesitamos de nuestras entidades
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfiguration(modelBuilder);
        }
        //Nuestras modificaciones de configuracion 
        private void EntityConfiguration(ModelBuilder modelBuilder)
        {
            new UserConfiguration(modelBuilder.Entity<UserEntity>());
        }


        //Contexto de Datos (In-Memory):
        private static List<UserEntity> _users = new List<UserEntity>();
        public List<UserEntity> Users => _users;

        public UserEntity AddUser(UserEntity user)
        {
            //Para efecto de pruebas, añadimos el usuario aleatorio y añadimos una validación para saber si existe o no
            
            if (!_users.Exists(userElement => userElement.UserId == user.UserId))
            {
                _users.Add(user);
            }
            return user;
        }
        public List<UserEntity> GetUsers()
        {
            return _users;
        }

    }
}
