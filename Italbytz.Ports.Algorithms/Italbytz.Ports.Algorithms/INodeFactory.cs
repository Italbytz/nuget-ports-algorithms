using System;
using System.Collections.Generic;
using Italbytz.Adapters.Algorithms.Search.Framework;

namespace Italbytz.Ports.Algorithms
{
    public interface INodeFactory<TState, TAction>
    {

        public Node<TState, TAction> CreateNode(TState state);

        public List<Node<TState, TAction>> GetSuccessors(INode<TState, TAction> node, IProblem<TState, TAction> problem);

        public bool UseParentLinks { get; set; }

    }
}

