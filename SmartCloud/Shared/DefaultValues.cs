namespace SmartCloud.Shared;

public static class DefaultValues
{
    public static readonly int[] SupportedJavaVersions = [11, 17, 21];
    private static readonly string[] SupportedWindowsVersions = ["Windows 2016", "Windows 2019", "Windows 2022"];
    private static readonly string[] SupportedLinuxVersions = ["RedHat 7", "RedHat 8", "RedHat 9"];
    private static readonly string[] SupportedAixVersions = ["AIX 7.2", "AIX 7.3"];

    private static readonly Dictionary<string, string[]> SupportedPermutations = new()
    {
        { "Windows", SupportedWindowsVersions },
        { "Linux", SupportedLinuxVersions },
        { "Aix", SupportedAixVersions }
    };

    public static List<OrderPermutation> GetAll()
    {
        var permutations = new List<OrderPermutation>();
        foreach (var kvp in SupportedPermutations)
        {
            permutations.AddRange(
                kvp.Value.Select(osVersion => new OrderPermutation(kvp.Key, osVersion)));
        }

        return permutations;
    }
}