using System;
namespace Italbytz.Ports.Algorithms
{
    public interface INode<TState, TAction>
    {
        public TState State { get; }
    }
}

