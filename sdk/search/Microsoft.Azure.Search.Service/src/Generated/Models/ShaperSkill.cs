// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A skill for reshaping the outputs. It creates a complex type to support
    /// composite fields (also known as multipart fields).
    /// <see
    /// href="https://docs.microsoft.com/azure/search/cognitive-search-skill-shaper"
    /// />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Skills.Util.ShaperSkill")]
    public partial class ShaperSkill : Skill
    {
        /// <summary>
        /// Initializes a new instance of the ShaperSkill class.
        /// </summary>
        public ShaperSkill()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ShaperSkill class.
        /// </summary>
        /// <param name="inputs">Inputs of the skills could be a column in the
        /// source data set, or the output of an upstream skill.</param>
        /// <param name="outputs">The output of a skill is either a field in an
        /// Azure Search index, or a value that can be consumed as an input by
        /// another skill.</param>
        /// <param name="name">The name of the skill which uniquely identifies
        /// it within the skillset. A skill with no name defined will be given
        /// a default name of its 1-based index in the skills array, prefixed
        /// with the character '#'.</param>
        /// <param name="description">The description of the skill which
        /// describes the inputs, outputs, and usage of the skill.</param>
        /// <param name="context">Represents the level at which operations take
        /// place, such as the document root or document content (for example,
        /// /document or /document/content). The default is /document.</param>
        public ShaperSkill(IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs, string name = default(string), string description = default(string), string context = default(string))
            : base(inputs, outputs, name, description, context)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
