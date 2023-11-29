using System;
namespace Italbytz.Ports.Algorithms
{
    public interface INode<TState, TAction>
    {
        public TState State { get; }
        public double PathCost { get; }
        public int Depth { get; }
        public TAction Action { get; }
        public INode<TState, TAction> Parent { get; }
        public bool IsRootNode();
    }
}

