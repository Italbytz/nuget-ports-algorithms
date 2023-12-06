// The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under
// MIT License
// Copyright (c) 2015 aima-java contributors

using System;
using System.Collections.Generic;

namespace Italbytz.Ports.Algorithms.AI.Problem
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
        
        public Func<TState, List<TAction>> Actions { get; }
        
        public Func<TState, bool> GoalTest { get; }
        
        public Func<TState, TAction, TState, double> StepCosts { get; }

    }
}

