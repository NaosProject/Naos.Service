// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceJsonSerializationConfiguration.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Service.Serialization.Json
{
    using System;
    using System.Collections.Generic;
    using Naos.Service.Domain;
    using OBeautifulCode.Serialization.Json;

    /// <inheritdoc />
    public class ServiceJsonSerializationConfiguration : JsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForJson> TypesToRegisterForJson => new TypeToRegisterForJson[]
        {
            typeof(ServiceLocatorBase).ToTypeToRegisterForJson(),
        };
    }
}
