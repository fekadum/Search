using UmbracoDevTest.Services.Interface;
using UmbracoDevTest.Services.Models;

namespace UmbracoDevTest.Services.Implementation
{
    public class GetUserService : IGetUserService
    {
        //private readonly ISharedService _sharedService;
        //public GetUserService(ISharedService sharedService)
        //{
        //    _sharedService = sharedService;
        //}

        public async Task<List<UserRS>> GetUsers(string searchKey)
        {
            var users = Users();
            //var previousUser = _sharedService.Get<List<UserRS>>("allUsers");
            //if (previousUser != null && users!=null && previousUser.Count!=users.Count) {
            //// save to application memory for later rather than calling several times and update if data is updated by any means
            //_sharedService.Add("allUsers", users);
            //}
            //return  Users().Where(_ => _.Title.StartsWith(searchKey)).ToList();
            return Users().ToList();
        }
        public  List<UserRS> Users()
        {
            List<UserRS> users = new() { new UserRS() { Id=1,UserID=1,Title="qui est esse",Body="quia et suscipit suscipit recusandae consequuntur expedita et cumreprehenderit molestiae ut ut quas totam " +
                "nostrum rerum est autem sunt rem eveniet architecto"}, new UserRS() { Id = 2, UserID = 1, Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
            Body = "quia et suscipit " +
            "suscipit recusandae consequuntur expedita et cum" +
            "nreprehenderit molestiae ut ut quas totam" +
            "nnostrum rerum est autem sunt rem eveniet architecto" } };
            return users;
        }
    }
}
