// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Workspace update parameters.
    /// </summary>
    public partial class WorkspaceUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceUpdateParameters class.
        /// </summary>
        public WorkspaceUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceUpdateParameters class.
        /// </summary>
        /// <param name="tags">Tags.</param>
        public WorkspaceUpdateParameters(IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets tags.
        /// </summary>
        /// <remarks>
        /// The user specified tags associated with the Workspace.
        /// </remarks>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}