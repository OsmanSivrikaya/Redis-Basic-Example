using StackExchange.Redis;

var connection = await ConnectionMultiplexer.ConnectAsync("localhost:1453");
var subscriber = connection.GetSubscriber();

await subscriber.SubscribeAsync("mychannel", (channel, message) =>
{
    Console.WriteLine(message);
});

Console.Read();