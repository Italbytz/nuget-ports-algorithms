using System;
namespace Italbytz.Ports.Algorithms.AI.Search
{
    /// <summary>
    /// Stores key-value pairs for efficiency analysis.
    /// </summary>
    public interface IMetrics
    {
        public string Get(string name);

        public void Set(String name, int i);

        public void IncrementInt(string name);

        public int GetInt(string name);
    }
}

