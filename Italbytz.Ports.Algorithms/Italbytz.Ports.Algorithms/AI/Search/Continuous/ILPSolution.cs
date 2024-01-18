namespace Italbytz.Ports.Algorithms.AI.Search.Continuous
{
    public interface ILPSolution
    {
        public double Objective { get; set; }
        public double[] Solution { get; set; }
    }
}