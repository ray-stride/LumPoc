namespace ShelterSignsProducer;

public class BusStopMessageGenerator
{
    private static readonly Dictionary<int, string> mesageTypes = new() {{0, "BusStop"}, {1, "AdHoc"}};

    private readonly Random _randomizer = new Random();
    
    public BusStopMessage Generate()
    {
        var busStopMessage = new BusStopMessage
        {
            ArrivalTime = DateTime.Now.AddSeconds(_randomizer.Next(60)),
            Route = "S1",
            StopName = "Bus Stop N",
            Type = mesageTypes[_randomizer.Next(0, mesageTypes.Count)],
        };
        
        return busStopMessage;
    }
}