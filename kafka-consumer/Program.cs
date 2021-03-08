using System;
using System.Threading;
using Confluent.Kafka;
using Newtonsoft.Json.Linq;

namespace kafka_consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var consumerConfig = new ConsumerConfig(GetConfig());
            consumerConfig.GroupId = "kafka-consumer";
            consumerConfig.AutoOffsetReset = AutoOffsetReset.Earliest;
            consumerConfig.EnableAutoCommit = false;
            var topic = "first_topic";
            var cts = new CancellationTokenSource();

            using (var consumer = new ConsumerBuilder<string, string>(consumerConfig).Build())
            {
                consumer.Subscribe(topic);
                var totalCount = 0;
                try
                {
                    while (true)
                    {
                        var cr = consumer.Consume(cts.Token);
                        totalCount += JObject.Parse(cr.Message.Value.ToString()).Value<int>("count");
                        Console.WriteLine($"Consumed record with key {cr.Message.Key} and value {cr.Message.Value}, and updated total count to {totalCount}");
                    }
                }
                catch (OperationCanceledException)
                {
                    // Ctrl-C was pressed.
                }
                finally
                {
                    consumer.Close();
                }
            }

            Console.WriteLine("Hello World!");
        }

        private static ClientConfig GetConfig()
        {
            var config = new ClientConfig();
            config.BootstrapServers = "localhost:9092";
            return config;
        }
    }
}
