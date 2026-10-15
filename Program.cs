using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyPublisher.Day022
{
    // C#: Fluent LINQ Aggregations & Projections (Day 22)
    // Category: .NET Core & Clean Architecture | Difficulty: Intermediate

    public record ExecutionRecord(int Id, string Topic, DateTime Timestamp);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C#: Fluent LINQ Aggregations & Projections (Day 22) ===");
            var records = new List<ExecutionRecord>
            {
                new(1, "C#: Fluent LINQ Aggregations & Projections (Day 22)", DateTime.UtcNow),
                new(2, "Optimized Pipeline Execution", DateTime.UtcNow)
            };

            foreach (var rec in records)
            {
                Console.WriteLine($"* [{rec.Id}] {rec.Topic} (UTC: {rec.Timestamp})");
            }
        }
    }
}
