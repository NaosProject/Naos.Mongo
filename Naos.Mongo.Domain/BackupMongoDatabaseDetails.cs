// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BackupMongoDatabaseDetails.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Mongo.Domain
{
    using System;
    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Captures the details of a backup operation.
    /// </summary>
    public class BackupMongoDatabaseDetails
    {
        /// <summary>
        /// Gets or sets the name of the backup (not the name of the backup file,
        /// but rather the name of the backup set identifying the backup within the file).
        /// If not specified, it is blank.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a description of the backup.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the location at which to save the backup (i.e. file path or URL).
        /// For local/network storage, must be a file and NOT a directory (i.e. c:\MyBackups\TodayBackup.bak, not c:\MyBackups).
        /// </summary>
        public Uri BackupTo { get; set; }

        /// <summary>
        /// Gets or sets the name of the credential to use when backing up to a URL.
        /// </summary>
        public string Credential { get; set; }
    }

    /// <summary>
    /// Extension methods for <see cref="BackupMongoDatabaseDetails"/>.
    /// </summary>
    public static class BackupMongoDatabaseDetailsExtensions
    {
        /// <summary>
        /// Throws an exception if the <see cref="BackupMongoDatabaseDetails"/> is invalid.
        /// </summary>
        /// <param name="backupDetails">The backup details to validate.</param>
        public static void ThrowIfInvalid(this BackupMongoDatabaseDetails backupDetails)
        {
            new { backupDetails }.AsArg().Must().NotBeNull();
            new { backupDetails.BackupTo }.AsArg().Must().NotBeNull();

            if (!string.IsNullOrWhiteSpace(backupDetails.Name))
            {
                if (backupDetails.Name.Length > 128)
                {
                    throw new ArgumentException("Name cannot be more than 128 characters in length.");
                }
            }

            if (!string.IsNullOrWhiteSpace(backupDetails.Description))
            {
                if (backupDetails.Description.Length > 255)
                {
                    throw new ArgumentException("Description cannot be more than 255 characters in length.");
                }
            }
        }
    }
}
