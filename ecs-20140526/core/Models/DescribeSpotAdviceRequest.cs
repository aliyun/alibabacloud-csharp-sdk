// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSpotAdviceRequest : TeaModel {
        /// <summary>
        /// The number of vCPUs of the instance type. For more information, see [Instance families](~~25378~~).
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// The number of GPUs that the GPU-accelerated instance has. For information about the valid values, see [GPU-accelerated compute optimized instance types](~~108496~~).
        /// </summary>
        [NameInMap("GpuAmount")]
        [Validation(Required=false)]
        public int? GpuAmount { get; set; }

        /// <summary>
        /// The GPU type. Valid values:
        /// 
        /// *   NVIDIA P4
        /// *   NVIDIA T4
        /// *   NVIDIA P100
        /// *   NVIDIA V100
        /// *   NVIDIA A100
        /// 
        /// This parameter is empty by default, which indicates that all GPU types are queried. For more information, see [GPU-accelerated compute optimized instance types](~~108496~~).
        /// </summary>
        [NameInMap("GpuSpec")]
        [Validation(Required=false)]
        public string GpuSpec { get; set; }

        /// <summary>
        /// The level of the instance family. Valid values:
        /// 
        /// *   EntryLevel: entry level.
        /// *   EnterpriseLevel: enterprise level.
        /// *   CreditEntryLevel: credit-based entry level. For more information, see [Overview](~~59977~~) of burstable instances.
        /// 
        /// This parameter is empty by default, which indicates that instance families of all levels are queried.
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// The instance family. For more information, see [Instance families](~~25378~~).
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// The instance types. You can specify to 10 instance types.
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// The memory size of the instance type. Unit: GiB. For more information, see [Instance families](~~25378~~).
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// The minimum number of vCPUs of the instance type. For more information, see [Instance families](~~25378~~).
        /// </summary>
        [NameInMap("MinCores")]
        [Validation(Required=false)]
        public int? MinCores { get; set; }

        /// <summary>
        /// The minimum memory size of the instance type. For more information, see [Instance families](~~25378~~).
        /// </summary>
        [NameInMap("MinMemory")]
        [Validation(Required=false)]
        public float? MinMemory { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~25609~~) operation to query the most recent list of regions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the zone.
        /// 
        /// This parameter is empty by default, which indicates that all zones in the specified region are queried.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
