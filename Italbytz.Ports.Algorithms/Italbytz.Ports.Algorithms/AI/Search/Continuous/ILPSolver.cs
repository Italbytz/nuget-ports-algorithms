namespace Italbytz.Ports.Algorithms.AI.Search.Continuous
{
    public interface ILPSolver
    {
        public ILPSolution Solve(ILPModel model);
        public ILPSolution Solve(string model, LPFileFormat format);
    }
}