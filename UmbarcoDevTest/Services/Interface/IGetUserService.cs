using UmbracoDevTest.Services.Models;

namespace UmbracoDevTest.Services.Interface
{
    public interface IGetUserService
    {
        public Task<List<UserRS>> GetUsers (string searchKey);
    }
}
