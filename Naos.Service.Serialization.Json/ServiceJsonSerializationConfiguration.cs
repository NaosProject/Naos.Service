// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceJsonSerializationConfiguration.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Service.Serialization.Json
{
    using System;
    using System.Collections.Generic;
    using Naos.Protocol.Domain;
    using Naos.Protocol.Serialization.Json;
    using Naos.Service.Domain;
    using OBeautifulCode.Serialization.Json;

    /// <inheritdoc />
    public class ServiceJsonSerializationConfiguration : JsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<string> TypeToRegisterNamespacePrefixFilters =>
            new[]
            {
                FormattableString.Invariant($"{nameof(Naos)}.{nameof(Naos.Service)}.{nameof(Naos.Service.Domain)}"),
            };

        /// <inheritdoc />
        protected override IReadOnlyCollection<JsonSerializationConfigurationType> DependentJsonSerializationConfigurationTypes =>
            new[]
            {
                typeof(ProtocolJsonSerializationConfiguration).ToJsonSerializationConfigurationType(),
            };

        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForJson> TypesToRegisterForJson => new TypeToRegisterForJson[]
        {
            typeof(IResourceLocator).ToTypeToRegisterForJson(),
            typeof(IOperation).ToTypeToRegisterForJson(),
            typeof(IEvent<>).ToTypeToRegisterForJson(),
        };
    }
}
