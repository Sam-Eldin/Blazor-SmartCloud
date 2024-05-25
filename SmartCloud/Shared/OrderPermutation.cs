namespace SmartCloud.Shared;

public class OrderPermutation(string os, string osVersion)
{
    public string Os { get; } = os;
    public string OsVersion { get; } = osVersion;
    public int Jv { get; set; } = DefaultValues.SupportedJavaVersions[0];

    public override string ToString()
    {
        return $"OS: {Os}, OS Version: {OsVersion}, Java Version: {Jv}";
    }

    public Dictionary<string, string> GetValuesAsDict()
    {
        return new Dictionary<string, string>()
        {
            {"OS", Os},
            {"Os Version", OsVersion},
            {"Java Version", Jv.ToString()},
        };
    }
}