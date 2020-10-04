// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NamedServiceLocator.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Service.Domain
{
    using Naos.Protocol.Domain;
    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Named locator for general use.
    /// </summary>
    public partial class NamedServiceLocator : ServiceLocatorBase, IModelViaCodeGen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NamedServiceLocator"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public NamedServiceLocator(
            string name)
        {
            name.MustForArg(nameof(name)).NotBeNullNorWhiteSpace();

            this.Name = name;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }
    }
}
