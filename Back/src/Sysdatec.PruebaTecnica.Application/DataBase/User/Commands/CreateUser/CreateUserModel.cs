namespace Sysdatec.PruebaTecnica.Application.Database.User.Commands.CreateUser
{
    public class CreateUserModel
    {
        //En la BD es autoincrementable, se añade para las pruebas inmemory
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        //public string Password { get; set; }
        public string Email { get; set; }
    }
}
