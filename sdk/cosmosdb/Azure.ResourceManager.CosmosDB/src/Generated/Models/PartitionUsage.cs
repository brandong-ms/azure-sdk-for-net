// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The partition level usage data for a usage request. </summary>
    public partial class PartitionUsage : Usage
    {
        /// <summary> Initializes a new instance of PartitionUsage. </summary>
        internal PartitionUsage()
        {
        }

        /// <summary> Initializes a new instance of PartitionUsage. </summary>
        /// <param name="unit"> The unit of the metric. </param>
        /// <param name="name"> The name information for the metric. </param>
        /// <param name="quotaPeriod"> The quota period used to summarize the usage values. </param>
        /// <param name="limit"> Maximum value for this metric. </param>
        /// <param name="currentValue"> Current value for this metric. </param>
        /// <param name="partitionId"> The partition id (GUID identifier) of the usages. </param>
        /// <param name="partitionKeyRangeId"> The partition key range id (integer identifier) of the usages. </param>
        internal PartitionUsage(UnitType? unit, MetricName name, string quotaPeriod, long? limit, long? currentValue, string partitionId, string partitionKeyRangeId) : base(unit, name, quotaPeriod, limit, currentValue)
        {
            PartitionId = partitionId;
            PartitionKeyRangeId = partitionKeyRangeId;
        }

        /// <summary> The partition id (GUID identifier) of the usages. </summary>
        public string PartitionId { get; }
        /// <summary> The partition key range id (integer identifier) of the usages. </summary>
        public string PartitionKeyRangeId { get; }
    }
}