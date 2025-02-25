using System.Text.Json;
using ShelterSignsProducer;

Console.WriteLine("Starting Shelter Signs Producer");

var generator = new BusStopMessageGenerator();

while (true)
{
    await MqttClient.PublishApplicationMessage(JsonSerializer.Serialize(generator.Generate()));
    
    await Task.Delay(5000);
}
