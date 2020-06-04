// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment on error behavior. </summary>
    public partial class OnErrorDeployment
    {
        /// <summary> Initializes a new instance of OnErrorDeployment. </summary>
        public OnErrorDeployment()
        {
        }

        /// <summary> The deployment on error behavior type. Possible values are LastSuccessful and SpecificDeployment. </summary>
        public OnErrorDeploymentType? Type { get; set; }
        /// <summary> The deployment to be used on error case. </summary>
        public string DeploymentName { get; set; }
    }
}