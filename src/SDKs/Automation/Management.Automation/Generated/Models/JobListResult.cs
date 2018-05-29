// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response model for the list job operation.
    /// </summary>
    public partial class JobListResult
    {
        /// <summary>
        /// Initializes a new instance of the JobListResult class.
        /// </summary>
        public JobListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobListResult class.
        /// </summary>
        /// <param name="value">Gets or sets a list of jobs.</param>
        /// <param name="nextLink">Gets or sets the next link.</param>
        public JobListResult(IList<Job> value = default(IList<Job>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of jobs.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Job> Value { get; set; }

        /// <summary>
        /// Gets or sets the next link.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}