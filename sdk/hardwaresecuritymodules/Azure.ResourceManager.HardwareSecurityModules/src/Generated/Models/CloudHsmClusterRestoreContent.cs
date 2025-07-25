// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    /// <summary> Cloud Hsm Cluster restore information. </summary>
    public partial class CloudHsmClusterRestoreContent : BackupRestoreRequestBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="CloudHsmClusterRestoreContent"/>. </summary>
        /// <param name="azureStorageBlobContainerUri"> The Azure blob storage container Uri which contains the backup. </param>
        /// <param name="backupId"> An autogenerated unique string ID for labeling the backup. It contains both a UUID and a date timestamp. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureStorageBlobContainerUri"/> or <paramref name="backupId"/> is null. </exception>
        public CloudHsmClusterRestoreContent(Uri azureStorageBlobContainerUri, string backupId) : base(azureStorageBlobContainerUri)
        {
            Argument.AssertNotNull(azureStorageBlobContainerUri, nameof(azureStorageBlobContainerUri));
            Argument.AssertNotNull(backupId, nameof(backupId));

            BackupId = backupId;
        }

        /// <summary> Initializes a new instance of <see cref="CloudHsmClusterRestoreContent"/>. </summary>
        /// <param name="azureStorageBlobContainerUri"> The Azure blob storage container Uri which contains the backup. </param>
        /// <param name="token"> The SAS token pointing to an Azure blob storage container. This property is reserved for Azure Backup Service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="backupId"> An autogenerated unique string ID for labeling the backup. It contains both a UUID and a date timestamp. </param>
        internal CloudHsmClusterRestoreContent(Uri azureStorageBlobContainerUri, string token, IDictionary<string, BinaryData> serializedAdditionalRawData, string backupId) : base(azureStorageBlobContainerUri, token, serializedAdditionalRawData)
        {
            BackupId = backupId;
        }

        /// <summary> Initializes a new instance of <see cref="CloudHsmClusterRestoreContent"/> for deserialization. </summary>
        internal CloudHsmClusterRestoreContent()
        {
        }

        /// <summary> An autogenerated unique string ID for labeling the backup. It contains both a UUID and a date timestamp. </summary>
        public string BackupId { get; }
    }
}
