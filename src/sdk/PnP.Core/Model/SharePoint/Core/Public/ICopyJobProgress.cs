﻿using System.Collections.Generic;

namespace PnP.Core.Model.SharePoint
{
    /// <summary>
    /// Represents the progress of a migration job
    /// </summary>
    public interface ICopyJobProgress
    {
        /// <summary>
        /// The state of the migration job currently in progress
        /// </summary>
        public MigrationJobState JobState { get; }
        
        /// <summary>
        /// List of all the logs currently generated by the migration job
        /// </summary>
        public IList<string> Logs { get; }
    }
}