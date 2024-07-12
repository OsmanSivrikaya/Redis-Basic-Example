using StackExchange.Redis;

var connection = await ConnectionMultiplexer.ConnectAsync("localhost:1453");
var subscriber = connection.GetSubscriber();

while (true) {
    Console.Write("Mesaj: ");
    var message = Console.ReadLine();
    await subscriber.PublishAsync("mychannel", message);
}