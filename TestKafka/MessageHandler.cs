using System;
using System.Threading;
using System.Threading.Tasks;
using Confluent.Kafka;

namespace TestKafka
{
    public static class MessageHandler
    {
        public static async Task ProduceMessage(string serverUri, string topic, string message)
        {
            var config = new ProducerConfig { BootstrapServers = serverUri };
            using (var p = new ProducerBuilder<Null, string>(config).Build())
            {
                _ = await p.ProduceAsync(topic, new Message<Null, string> { Value = message });
            }
        }

        public static string ConsumeMessage(string serverUri, string topic)
        {
            var config = new ConsumerConfig
            {
                GroupId = "Test-Group",
                BootstrapServers = serverUri,
                EnableAutoCommit = false,
                StatisticsIntervalMs = 5000,
                SessionTimeoutMs = 6000,
                AutoOffsetReset = AutoOffsetReset.Earliest,
                EnablePartitionEof = true
            };

            using (var c = new ConsumerBuilder<Ignore, string>(config).Build())
            {
                c.Subscribe(topic);
                var cts = new CancellationTokenSource();
                Console.CancelKeyPress += (_, e) => {
                    e.Cancel = true; // prevent the process from terminating.
                    cts.Cancel();
                };

                var cr = c.Consume(cts.Token);
                c.Commit(cr);
                return cr.Message.Value;
            }
        }
    }
}
