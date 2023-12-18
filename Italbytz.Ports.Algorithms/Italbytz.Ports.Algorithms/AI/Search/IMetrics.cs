using System;
namespace Italbytz.Ports.Algorithms.AI.Search
{
    /// <summary>
    /// Stores key-value pairs for efficiency analysis.
    /// </summary>
    public interface IMetrics
    {
        public string Get(string name);

        public void Set(string name, int i);
        
        public void Set(string name, long l);
        
        public void Set(string name, double d);

        public void IncrementInt(string name);

        public int GetInt(string name);
        
        public double GetDouble(string name);
        
        public long GetLong(string name);
    }
}

