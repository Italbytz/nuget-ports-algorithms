using System;
using System.Collections.Generic;
using Italbytz.Ports.Algorithms.AI.Problem;

namespace Italbytz.Ports.Algorithms.AI.Search
{
    public interface INodeFactory<TState, TAction>
    {

        public INode<TState, TAction> CreateNode(TState state);

        public List<INode<TState, TAction>> GetSuccessors(INode<TState, TAction> node, IProblem<TState, TAction> problem);

        public bool UseParentLinks { get; set; }

    }
}

