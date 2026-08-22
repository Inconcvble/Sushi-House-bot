using System.Linq;

public class RegionResolver
{
    private readonly IEnumerable<Location> _knownLocations;

    public RegionResolver(IEnumerable<Location> knownLocations)
    {
        _knownLocations = knownLocations;
    }

    public Location? ResolveRegion(string regionName)
    {
        return _knownLocations.FirstOrDefault(l => l.RegionName == regionName);
    }
}
