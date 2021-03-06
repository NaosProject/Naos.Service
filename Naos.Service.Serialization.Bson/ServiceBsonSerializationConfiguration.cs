﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceBsonSerializationConfiguration.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Service.Serialization.Bson
{
    using System;
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using Naos.Protocol.Serialization.Bson;
    using Naos.Service.Domain;
    using OBeautifulCode.Serialization.Bson;
    using OBeautifulCode.Type;

    /// <inheritdoc />
    public class ServiceBsonSerializationConfiguration : BsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<string> TypeToRegisterNamespacePrefixFilters =>
            new[]
            {
                Naos.Service.Domain.ProjectInfo.Namespace,
            };

        /// <inheritdoc />
        protected override IReadOnlyCollection<BsonSerializationConfigurationType> DependentBsonSerializationConfigurationTypes =>
            new[]
            {
                typeof(ProtocolBsonSerializationConfiguration).ToBsonSerializationConfigurationType(),
            };

        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForBson> TypesToRegisterForBson => new[]
        {
            typeof(IModel).ToTypeToRegisterForBson(),
        };
    }
}
