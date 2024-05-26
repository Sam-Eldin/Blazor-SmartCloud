namespace SmartCloud.Components.Shared;

public static class DefaultValues
{
    public static readonly string[] SupportedJavaVersions =
    [
        "No Java", "Adopt 11", "Adopt 17", "Adopt 21",
        "Amazon 11", "Amazon 17", "Amazon 21",
        "Azul 11", "Azul 17", "Azul 21",
        "Oracle 11", "Oracle 17", "Oracle 21",
        "Microsoft 11", "Microsoft 17", "Microsoft 21"
    ];

    private static readonly string[] SupportedWindowsVersions = ["Windows 2016", "Windows 2019", "Windows 2022"];

    private static readonly string[] SupportedLinuxVersions =
    [
        "RedHat 7", "RedHat 8", "RedHat 9",
        "Centos 7", "Centos 7.5", "Centos 8", "Centos 9",
        "Debian 10", "Debian 11", "Debian 12",
        "Alma Linux 8", "Alma Linux 9", "Amazon Linux 2",
        "Amazon Linux 2022", "Amazon Linux 2023",
        "Oracle Linux 7.2", "Oracle Linux 7.3",
        "Suse 12", "Suse 15", "Ubuntu 18", "Ubuntu 20", "Ubuntu 22"
    ];

    private static readonly string[] SupportedAixVersions = ["AIX 7.2", "AIX 7.3"];

    private static readonly Dictionary<string, string[]> SupportedPermutations = new()
    {
        { "Windows", SupportedWindowsVersions },
        { "Linux", SupportedLinuxVersions },
        // { "Aix", SupportedAixVersions }
    };

    public static List<OrderPermutation> GetAll()
    {
        var permutations = new List<OrderPermutation>();
        foreach (var kvp in SupportedPermutations)
        {
            permutations.AddRange(kvp.Value.Select(osVersion => new OrderPermutation(kvp.Key, osVersion)));
        }
        return permutations;
    }

    public static List<OrderPermutation> GetAll(string osVersion)
    {
        var permutations = new List<OrderPermutation>();
        foreach (var kvp in SupportedPermutations)
        {
            permutations.AddRange(kvp.Value.Where(_osVersion => _osVersion.Contains(osVersion))
                .Select(_osVersion => new OrderPermutation(kvp.Key, _osVersion)));
        }
        return permutations;
    }
}