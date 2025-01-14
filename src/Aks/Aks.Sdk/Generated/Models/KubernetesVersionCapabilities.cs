// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Capabilities on this Kubernetes version.
    /// </summary>
    public partial class KubernetesVersionCapabilities
    {
        /// <summary>
        /// Initializes a new instance of the KubernetesVersionCapabilities
        /// class.
        /// </summary>
        public KubernetesVersionCapabilities()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KubernetesVersionCapabilities
        /// class.
        /// </summary>
        public KubernetesVersionCapabilities(IList<string> supportPlan = default(IList<string>))
        {
            SupportPlan = supportPlan;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supportPlan")]
        public IList<string> SupportPlan { get; set; }

    }
}
