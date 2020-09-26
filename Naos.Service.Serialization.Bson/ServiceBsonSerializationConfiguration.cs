﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceBsonSerializationConfiguration.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Service.Serialization.Bson
{
    using System;
    using System.Collections.Generic;
    using Naos.Service.Domain;
    using OBeautifulCode.Serialization.Bson;

    /// <inheritdoc />
    public class ServiceBsonSerializationConfiguration : BsonSerializationConfigurationBase
    {
        /// <inheritdoc />
        protected override IReadOnlyCollection<TypeToRegisterForBson> TypesToRegisterForBson => new TypeToRegisterForBson[]
        {
            typeof(ServiceLocatorBase).ToTypeToRegisterForBson(),
        };
    }
}
