using OA.Data;

namespace Project.BlazorApp.Data
{
    public class HelperService
    {
        public Task<User[]> GetUsersAsync()
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new User
            {
                Name = $"Name{index}",
                Surname = $"surname{index}",
            }).ToArray());
        }
    }
}
