﻿/** 
 * The original version of this file is part of <see href="https://github.com/aimacode/aima-java"/> which is released under 
 * MIT License
 * Copyright (c) 2015 aima-java contributors
 */

using System;
namespace Italbytz.Ports.Algorithms
{
    public interface IAgent<TPercept, TAction>
    {
        public bool Alive { get; }
        TAction? Act(TPercept percept);
    }
}
