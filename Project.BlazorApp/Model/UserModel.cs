using OA.Data;

namespace Project.BlazorApp.Model
{
    public class UserModel
    {
        public int Id{ get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public int UserRole { get; set; }

        public int UserPrivilages { get; set; }
    }
}
