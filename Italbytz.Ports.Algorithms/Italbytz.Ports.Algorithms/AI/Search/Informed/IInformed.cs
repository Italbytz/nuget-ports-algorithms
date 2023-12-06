using System;

namespace Italbytz.Ports.Algorithms.AI.Search.Informed
{
    public interface IInformed<TState, TAction>
    {
        public Func<INode<TState, TAction>, double> HeuristicFn { get; set; }
    }
}