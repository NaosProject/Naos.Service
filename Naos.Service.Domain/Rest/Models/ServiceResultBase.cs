// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceResultBase.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Service.Domain
{
    /// <summary>
    /// Result from service operations.
    /// </summary>
    public class ServiceResultBase
    {
        /*
            There will eventually be a generic contract with both internal and external service types.

            Could also create operations to execute we operations; like ExecuteOperationAgainstServiceOp(TOperation operationToExecute, ServiceLocatorBase serviceLocator)
                                                                        {
                                                                            // Could use rules about either putting a serialized object in request body
                                                                            // or decomposing the operation as key value pairs and appending them to
                                                                            // the locator.  Returning operations could take a response body and
                                                                            // deserialize it into the return object.
                                                                        }

            Internal:
                These are where the type is known and likely could be some kind of object aware version of the REST operations.

            External:
                These are where the is perhaps unknowable and dynamic interpretation is used, these would need a common denominator/object unaware
                contract to accomodate this (like strings and byte arrays).
        */
    }
}