namespace UmbracoDevTest.Services.Interface
{
    public interface ISharedService
    {
        void Add(string key, object value);
        T Get<T>(string key);
    }
}
