/** 
 * The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under 
 * MIT License
 * Copyright (c) 2015 aima-java contributors
 */

using System;
using System.Collections.Generic;

namespace Italbytz.Ports.Algorithms
{
    /// <summary>
    /// An online search problem.
    /// </summary>
    /// <typeparam name="TState">The type used to represent states</typeparam>
    /// <typeparam name="TAction">The type of the actions to be used to navigate through the state space</typeparam>
    public interface IOnlineSearchProblem<TState, TAction>
    {
        /// <summary>
        /// The initial state of the agent.
        /// </summary>
        public TState InitialState { get; }

        /// <summary>
        /// Returns the description of the possible actions available to the agent at a given state.
        /// </summary>
        /// <param name="state">The given state.</param>
        /// <returns>List of possible actions.</returns>
        public List<TAction> GetActions(TState state);

        /// Determines whether a given state is a goal state.
        /// <param name="state">The given state.</param>
        /// <returns>True, if the state is a goal state.</returns>
        public bool TestGoal(TState state);

        /// Returns the step cost of taking an action in a state to reach state.
        public double GetStepCosts(TState state, TAction action, TState stateDelta);

    }
}

