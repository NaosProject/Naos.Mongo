﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MongoJsonSerializationConfiguration.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Mongo.Serialization.Json
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Naos.Protocol.Serialization.Json;
    using OBeautifulCode.Serialization.Json;
    using OBeautifulCode.Type;
    using OBeautifulCode.Type.Recipes;

    /// <inheritdoc />
    public class MongoJsonSerializationConfiguration : JsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<string> TypeToRegisterNamespacePrefixFilters =>
            new[]
            {
                Naos.Mongo.Domain.ProjectInfo.Namespace,
            };

        /// <inheritdoc />
        protected override IReadOnlyCollection<JsonSerializationConfigurationType> DependentJsonSerializationConfigurationTypes =>
            new[]
            {
                typeof(ProtocolJsonSerializationConfiguration).ToJsonSerializationConfigurationType(),
            };

        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForJson> TypesToRegisterForJson => new Type[0]
            .Concat(new[] { typeof(IModel) })
            .Concat(Naos.Mongo.Domain.ProjectInfo.Assembly.GetPublicEnumTypes())
            .Select(_ => _.ToTypeToRegisterForJson())
            .ToList();
    }
}
