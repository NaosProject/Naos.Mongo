// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RestoreMongoDatabaseDetails.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Mongo.Domain
{
    using System;
    using Naos.Database.Domain;
    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Captures the details of a restore operation.
    /// </summary>
    public class RestoreMongoDatabaseDetails
    {
        /// <summary>
        /// Gets or sets the location at which to pull the backup for restoration (i.e. file path or URL)
        /// For local/network storage, must be a file and NOT a directory (i.e. c:\MyBackups\TodayBackup.bak, not c:\MyBackups).
        /// </summary>
        public Uri RestoreFrom { get; set; }

        /// <summary>
        /// Gets or sets an enum value with instructions on what to do when restoring to a database that already exists.
        /// </summary>
        public ReplaceOption ReplaceOption { get; set; }
    }

    /// <summary>
    /// Extension methods for <see cref="RestoreMongoDatabaseDetails"/>.
    /// </summary>
    public static class RestoreMongoDatabaseDetailsExtensions
    {
        /// <summary>
        /// Throws an exception if the <see cref="RestoreMongoDatabaseDetails"/> is invalid.
        /// </summary>
        /// <param name="restoreDetails">The restore details to validate.</param>
        public static void ThrowIfInvalid(this RestoreMongoDatabaseDetails restoreDetails)
        {
            new { restoreDetails }.AsArg().Must().NotBeNull();
            new { restoreDetails.RestoreFrom }.AsArg().Must().NotBeNull();
        }
    }
}
