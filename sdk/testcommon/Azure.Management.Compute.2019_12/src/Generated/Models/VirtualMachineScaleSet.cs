// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    /// <summary> Describes a Virtual Machine Scale Set. </summary>
    public partial class VirtualMachineScaleSet : Resource
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSet. </summary>
        /// <param name="location"> Resource location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public VirtualMachineScaleSet(string location) : base(location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSet. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="sku"> The virtual machine scale set sku. </param>
        /// <param name="plan"> Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**. </param>
        /// <param name="identity"> The identity of the virtual machine scale set, if configured. </param>
        /// <param name="zones"> The virtual machine scale set zones. NOTE: Availability zones can only be set when you create the scale set. </param>
        /// <param name="upgradePolicy"> The upgrade policy. </param>
        /// <param name="automaticRepairsPolicy"> Policy for automatic repairs. </param>
        /// <param name="virtualMachineProfile"> The virtual machine profile. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="overprovision"> Specifies whether the Virtual Machine Scale Set should be overprovisioned. </param>
        /// <param name="doNotRunExtensionsOnOverprovisionedVMs"> When Overprovision is enabled, extensions are launched only on the requested number of VMs which are finally kept. This property will hence ensure that the extensions do not run on the extra overprovisioned VMs. </param>
        /// <param name="uniqueId"> Specifies the ID which uniquely identifies a Virtual Machine Scale Set. </param>
        /// <param name="singlePlacementGroup"> When true this limits the scale set to a single placement group, of max size 100 virtual machines. NOTE: If singlePlacementGroup is true, it may be modified to false. However, if singlePlacementGroup is false, it may not be modified to true. </param>
        /// <param name="zoneBalance"> Whether to force strictly even Virtual Machine distribution cross x-zones in case there is zone outage. </param>
        /// <param name="platformFaultDomainCount"> Fault Domain count for each placement group. </param>
        /// <param name="proximityPlacementGroup"> Specifies information about the proximity placement group that the virtual machine scale set should be assigned to. &lt;br&gt;&lt;br&gt;Minimum api-version: 2018-04-01. </param>
        /// <param name="additionalCapabilities"> Specifies additional capabilities enabled or disabled on the Virtual Machines in the Virtual Machine Scale Set. For instance: whether the Virtual Machines have the capability to support attaching managed data disks with UltraSSD_LRS storage account type. </param>
        /// <param name="scaleInPolicy"> Specifies the scale-in policy that decides which virtual machines are chosen for removal when a Virtual Machine Scale Set is scaled-in. </param>
        internal VirtualMachineScaleSet(string id, string name, string type, string location, IDictionary<string, string> tags, Sku sku, Plan plan, VirtualMachineScaleSetIdentity identity, IList<string> zones, UpgradePolicy upgradePolicy, AutomaticRepairsPolicy automaticRepairsPolicy, VirtualMachineScaleSetVMProfile virtualMachineProfile, string provisioningState, bool? overprovision, bool? doNotRunExtensionsOnOverprovisionedVMs, string uniqueId, bool? singlePlacementGroup, bool? zoneBalance, int? platformFaultDomainCount, SubResource proximityPlacementGroup, AdditionalCapabilities additionalCapabilities, ScaleInPolicy scaleInPolicy) : base(id, name, type, location, tags)
        {
            Sku = sku;
            Plan = plan;
            Identity = identity;
            Zones = zones;
            UpgradePolicy = upgradePolicy;
            AutomaticRepairsPolicy = automaticRepairsPolicy;
            VirtualMachineProfile = virtualMachineProfile;
            ProvisioningState = provisioningState;
            Overprovision = overprovision;
            DoNotRunExtensionsOnOverprovisionedVMs = doNotRunExtensionsOnOverprovisionedVMs;
            UniqueId = uniqueId;
            SinglePlacementGroup = singlePlacementGroup;
            ZoneBalance = zoneBalance;
            PlatformFaultDomainCount = platformFaultDomainCount;
            ProximityPlacementGroup = proximityPlacementGroup;
            AdditionalCapabilities = additionalCapabilities;
            ScaleInPolicy = scaleInPolicy;
        }

        /// <summary> The virtual machine scale set sku. </summary>
        public Sku Sku { get; set; }
        /// <summary> Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**. </summary>
        public Plan Plan { get; set; }
        /// <summary> The identity of the virtual machine scale set, if configured. </summary>
        public VirtualMachineScaleSetIdentity Identity { get; set; }
        /// <summary> The virtual machine scale set zones. NOTE: Availability zones can only be set when you create the scale set. </summary>
        public IList<string> Zones { get; }
        /// <summary> The upgrade policy. </summary>
        public UpgradePolicy UpgradePolicy { get; set; }
        /// <summary> Policy for automatic repairs. </summary>
        public AutomaticRepairsPolicy AutomaticRepairsPolicy { get; set; }
        /// <summary> The virtual machine profile. </summary>
        public VirtualMachineScaleSetVMProfile VirtualMachineProfile { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> Specifies whether the Virtual Machine Scale Set should be overprovisioned. </summary>
        public bool? Overprovision { get; set; }
        /// <summary> When Overprovision is enabled, extensions are launched only on the requested number of VMs which are finally kept. This property will hence ensure that the extensions do not run on the extra overprovisioned VMs. </summary>
        public bool? DoNotRunExtensionsOnOverprovisionedVMs { get; set; }
        /// <summary> Specifies the ID which uniquely identifies a Virtual Machine Scale Set. </summary>
        public string UniqueId { get; }
        /// <summary> When true this limits the scale set to a single placement group, of max size 100 virtual machines. NOTE: If singlePlacementGroup is true, it may be modified to false. However, if singlePlacementGroup is false, it may not be modified to true. </summary>
        public bool? SinglePlacementGroup { get; set; }
        /// <summary> Whether to force strictly even Virtual Machine distribution cross x-zones in case there is zone outage. </summary>
        public bool? ZoneBalance { get; set; }
        /// <summary> Fault Domain count for each placement group. </summary>
        public int? PlatformFaultDomainCount { get; set; }
        /// <summary> Specifies information about the proximity placement group that the virtual machine scale set should be assigned to. &lt;br&gt;&lt;br&gt;Minimum api-version: 2018-04-01. </summary>
        public SubResource ProximityPlacementGroup { get; set; }
        /// <summary> Specifies additional capabilities enabled or disabled on the Virtual Machines in the Virtual Machine Scale Set. For instance: whether the Virtual Machines have the capability to support attaching managed data disks with UltraSSD_LRS storage account type. </summary>
        public AdditionalCapabilities AdditionalCapabilities { get; set; }
        /// <summary> Specifies the scale-in policy that decides which virtual machines are chosen for removal when a Virtual Machine Scale Set is scaled-in. </summary>
        public ScaleInPolicy ScaleInPolicy { get; set; }
    }
}