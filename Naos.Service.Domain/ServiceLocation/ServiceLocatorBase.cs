// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceLocatorBase.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Service.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Type;

    /// <summary>
    /// Base <see cref="Naos.Service"/> domain extension of <see cref="ResourceLocatorBase"/>.
    /// </summary>
    public abstract partial class ServiceLocatorBase : ResourceLocatorBase, IModelViaCodeGen
    {
    }
}
