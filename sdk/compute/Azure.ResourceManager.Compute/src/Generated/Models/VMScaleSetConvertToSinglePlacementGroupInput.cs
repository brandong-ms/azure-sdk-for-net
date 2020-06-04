// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The VMScaleSetConvertToSinglePlacementGroupInput. </summary>
    public partial class VMScaleSetConvertToSinglePlacementGroupInput
    {
        /// <summary> Initializes a new instance of VMScaleSetConvertToSinglePlacementGroupInput. </summary>
        public VMScaleSetConvertToSinglePlacementGroupInput()
        {
        }

        /// <summary> Id of the placement group in which you want future virtual machine instances to be placed. To query placement group Id, please use Virtual Machine Scale Set VMs - Get API. If not provided, the platform will choose one with maximum number of virtual machine instances. </summary>
        public string ActivePlacementGroupId { get; set; }
    }
}