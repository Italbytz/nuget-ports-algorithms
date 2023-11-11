namespace Italbytz.Ports.Algorithms
{
    public interface ISolver<TParameters, TSolution>
    {
        TSolution Solve(TParameters parameters);
    }
}
