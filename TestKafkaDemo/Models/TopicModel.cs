using System.Collections.Generic;

namespace TestKafkaDemo.Models
{
    public class TopicList
    {
        public List<Topic> Topics { get; set; }
    }

    public class Topic
    {
        public string Name { get; set; }
    }
}
