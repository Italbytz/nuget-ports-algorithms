/** 
 * The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under 
 * MIT License
 * Copyright (c) 2015 aima-java contributors
 */

using System;
using Italbytz.Ports.Algorithms.AI.Search;

namespace Italbytz.Ports.Algorithms.AI.Problem
{
    /// <summary>
    /// A formal problem definition.
    /// </summary>
    /// <typeparam name="TState">The type used to represent states</typeparam>
    /// <typeparam name="TAction">The type of the actions to be used to navigate through the state space</typeparam>
    public interface IProblem<TState, TAction> : IOnlineSearchProblem<TState, TAction>
    {
        /*/// <summary>
        /// Returns the description of what each action does.
        /// </summary>
        /// <param name="state">The given state.</param>
        /// <param name="action">The action.</param>
        /// <returns>Description.</returns>
        public TState GetResult(TState state, TAction action);*/

        Func<TState, TAction, TState> Result { get; }

        bool TestSolution(INode<TState, TAction> node);
    }
}
