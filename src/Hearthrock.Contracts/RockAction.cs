﻿// <copyright file="RockAction.cs" company="https://github.com/yangyuan">
//     Copyright (c) The Hearthrock Project. All rights reserved.
// </copyright>

namespace Hearthrock.Contracts
{
    using System.Collections.Generic;

    /// <summary>
    /// Action contract of Hearthrock
    /// </summary>
    public class RockAction
    {
        /// <summary>
        /// Source entity of the action.
        /// </summary>
        public int Source { set; get; }

        /// <summary>
        /// Target entities of the action.
        /// </summary>
        public List<int> Targets { set; get; }

        /// <summary>
        /// The factory method.
        /// </summary>
        /// <param name="rockIds">A list of RockId. The first one is source, others are targets.</param>
        /// <returns>The RockAction.</returns>
        public static RockAction Create(params int[] rockIds)
        {
            var action = new RockAction();
            action.Source = rockIds[0];
            action.Targets = new List<int>();
            for (var i=1; i< rockIds.Length; i++)
            {
                action.Targets.Add(rockIds[i]);
            }

            return action;
        }
    }
}