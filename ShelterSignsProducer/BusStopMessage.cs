namespace ShelterSignsProducer;

public class BusStopMessage
{
    public DateTime ArrivalTime { get; set; }

    public long ArrivalTimeUnix => new DateTimeOffset(ArrivalTime).ToUnixTimeMilliseconds();

    public string StopName { get; set; }
    
    public string Type { get; set; }

    public string Route { get; set; }

    public string UnknowCategoryCode { get; } = "M";
}