using SmartCloud.Components.Shared;

namespace SmartCloud.Services;
using System.Net.Http;

public class Jenkins
{
    private readonly HttpClient client = new();

    public Task OrderPermutation(OrderPermutation permutation)
    {
        return Task.Delay(2000);
        return client.PostAsync("https://autodev-asdf:8585", 
            new FormUrlEncodedContent(permutation.GetValuesAsDict())
            );
    }
}