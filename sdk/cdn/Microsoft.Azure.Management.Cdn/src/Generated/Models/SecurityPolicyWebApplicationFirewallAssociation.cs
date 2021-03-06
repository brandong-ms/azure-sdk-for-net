// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// settings for security policy patterns to match
    /// </summary>
    public partial class SecurityPolicyWebApplicationFirewallAssociation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SecurityPolicyWebApplicationFirewallAssociation class.
        /// </summary>
        public SecurityPolicyWebApplicationFirewallAssociation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SecurityPolicyWebApplicationFirewallAssociation class.
        /// </summary>
        /// <param name="domains">List of domains.</param>
        /// <param name="patternsToMatch">List of paths</param>
        public SecurityPolicyWebApplicationFirewallAssociation(IList<ResourceReference> domains = default(IList<ResourceReference>), IList<string> patternsToMatch = default(IList<string>))
        {
            Domains = domains;
            PatternsToMatch = patternsToMatch;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of domains.
        /// </summary>
        [JsonProperty(PropertyName = "domains")]
        public IList<ResourceReference> Domains { get; set; }

        /// <summary>
        /// Gets or sets list of paths
        /// </summary>
        [JsonProperty(PropertyName = "patternsToMatch")]
        public IList<string> PatternsToMatch { get; set; }

    }
}
