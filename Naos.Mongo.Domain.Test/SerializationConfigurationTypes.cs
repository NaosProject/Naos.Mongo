﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SerializationConfigurationTypes.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package Naos.Build.Conventions.VisualStudioProjectTemplates.Domain.Test (1.55.46)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Mongo.Domain.Test
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.CodeAnalysis;

    using OBeautifulCode.Serialization.Bson;
    using OBeautifulCode.Serialization.Json;

    using Naos.Mongo.Serialization.Bson;
    using Naos.Mongo.Serialization.Json;

    [ExcludeFromCodeCoverage]
    [GeneratedCode("Naos.Build.Conventions.VisualStudioProjectTemplates.Domain.Test", "1.55.46")]
    public static class SerializationConfigurationTypes
    {
        public static BsonSerializationConfigurationType BsonSerializationConfigurationType => typeof(MongoBsonSerializationConfiguration).ToBsonSerializationConfigurationType();

        public static JsonSerializationConfigurationType JsonSerializationConfigurationType => typeof(MongoJsonSerializationConfiguration).ToJsonSerializationConfigurationType();
    }
}
