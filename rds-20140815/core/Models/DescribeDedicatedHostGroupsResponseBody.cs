// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDedicatedHostGroupsResponseBody : TeaModel {
        /// <summary>
        /// The information about dedicated clusters returned.
        /// </summary>
        [NameInMap("DedicatedHostGroups")]
        [Validation(Required=false)]
        public DescribeDedicatedHostGroupsResponseBodyDedicatedHostGroups DedicatedHostGroups { get; set; }
        public class DescribeDedicatedHostGroupsResponseBodyDedicatedHostGroups : TeaModel {
            [NameInMap("DedicatedHostGroups")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostGroupsResponseBodyDedicatedHostGroupsDedicatedHostGroups> DedicatedHostGroups { get; set; }
            public class DescribeDedicatedHostGroupsResponseBodyDedicatedHostGroupsDedicatedHostGroups : TeaModel {
                /// <summary>
                /// The policy based on which the system allocates resources in the dedicated cluster. Valid values:
                /// 
                /// *   **Evenly**: The system evenly allocates the resources to all the hosts in the dedicated cluster.
                /// *   **Intensively**: The system preferentially allocates the resources to the heavily loaded hosts in the dedicated cluster.
                /// </summary>
                [NameInMap("AllocationPolicy")]
                [Validation(Required=false)]
                public string AllocationPolicy { get; set; }

                /// <summary>
                /// The ID of the bastion host.
                /// </summary>
                [NameInMap("BastionInstanceId")]
                [Validation(Required=false)]
                public string BastionInstanceId { get; set; }

                /// <summary>
                /// The percentage of allocated cores in the dedicated cluster. Unit: %.
                /// </summary>
                [NameInMap("CpuAllocateRation")]
                [Validation(Required=false)]
                public float? CpuAllocateRation { get; set; }

                /// <summary>
                /// The number of allocated cores in the dedicated cluster.
                /// </summary>
                [NameInMap("CpuAllocatedAmount")]
                [Validation(Required=false)]
                public float? CpuAllocatedAmount { get; set; }

                /// <summary>
                /// The core overcommitment ratio of the dedicated cluster. Unit: %. For more information about the core overcommitment ratio, see [Manage a dedicated cluster](https://help.aliyun.com/document_detail/182328.html).
                /// </summary>
                [NameInMap("CpuAllocationRatio")]
                [Validation(Required=false)]
                public int? CpuAllocationRatio { get; set; }

                /// <summary>
                /// The timestamp when the dedicated cluster was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The type of storage media that is used for the hosts in the dedicated cluster. Valid values:
                /// 
                /// *   **dhg_cloud_ssd**: cloud disks
                /// *   **dhg_local_ssd**: local disks
                /// </summary>
                [NameInMap("DedicatedHostCountGroupByHostType")]
                [Validation(Required=false)]
                public Dictionary<string, object> DedicatedHostCountGroupByHostType { get; set; }

                /// <summary>
                /// The name of the dedicated cluster.
                /// </summary>
                [NameInMap("DedicatedHostGroupDesc")]
                [Validation(Required=false)]
                public string DedicatedHostGroupDesc { get; set; }

                /// <summary>
                /// The ID of the dedicated cluster.
                /// </summary>
                [NameInMap("DedicatedHostGroupId")]
                [Validation(Required=false)]
                public string DedicatedHostGroupId { get; set; }

                /// <summary>
                /// The percentage of allocated disk space in the dedicated cluster. Unit: %.
                /// </summary>
                [NameInMap("DiskAllocateRation")]
                [Validation(Required=false)]
                public float? DiskAllocateRation { get; set; }

                /// <summary>
                /// The amount of allocated disk space in the dedicated cluster. Unit: GB.
                /// </summary>
                [NameInMap("DiskAllocatedAmount")]
                [Validation(Required=false)]
                public float? DiskAllocatedAmount { get; set; }

                /// <summary>
                /// The disk overcommitment ratio of the dedicated cluster. Unit: %. For more information about the core overcommitment ratio, see [Manage a dedicated cluster](https://help.aliyun.com/document_detail/182328.html).
                /// </summary>
                [NameInMap("DiskAllocationRatio")]
                [Validation(Required=false)]
                public int? DiskAllocationRatio { get; set; }

                /// <summary>
                /// The amount of used disk space in the dedicated cluster. Unit: GB.
                /// </summary>
                [NameInMap("DiskUsedAmount")]
                [Validation(Required=false)]
                public float? DiskUsedAmount { get; set; }

                /// <summary>
                /// The disk usage of the dedicated cluster. Unit: %.
                /// </summary>
                [NameInMap("DiskUtility")]
                [Validation(Required=false)]
                public float? DiskUtility { get; set; }

                /// <summary>
                /// The database engine of the instances in the dedicated cluster.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The total number of hosts in the dedicated cluster.
                /// </summary>
                [NameInMap("HostNumber")]
                [Validation(Required=false)]
                public int? HostNumber { get; set; }

                /// <summary>
                /// The policy that is used to handle host failures. Valid values:
                /// 
                /// *   **Auto**: The system automatically replaces faulty hosts.
                /// *   **Manual**: You must manually replace faulty hosts.
                /// </summary>
                [NameInMap("HostReplacePolicy")]
                [Validation(Required=false)]
                public string HostReplacePolicy { get; set; }

                /// <summary>
                /// The total number of instances in the dedicated cluster.
                /// </summary>
                [NameInMap("InstanceNumber")]
                [Validation(Required=false)]
                public int? InstanceNumber { get; set; }

                /// <summary>
                /// The percentage of allocated memory space in the dedicated cluster. Unit: %.
                /// </summary>
                [NameInMap("MemAllocateRation")]
                [Validation(Required=false)]
                public float? MemAllocateRation { get; set; }

                /// <summary>
                /// The amount of allocated memory space in the dedicated cluster.
                /// </summary>
                [NameInMap("MemAllocatedAmount")]
                [Validation(Required=false)]
                public float? MemAllocatedAmount { get; set; }

                /// <summary>
                /// The memory overcommitment ratio of the dedicated cluster. Unit: %. For more information about the core overcommitment ratio, see [Manage a dedicated cluster](https://help.aliyun.com/document_detail/182328.html).
                /// </summary>
                [NameInMap("MemAllocationRatio")]
                [Validation(Required=false)]
                public int? MemAllocationRatio { get; set; }

                /// <summary>
                /// The amount of used memory space in the dedicated cluster. Unit: MB.
                /// </summary>
                [NameInMap("MemUsedAmount")]
                [Validation(Required=false)]
                public float? MemUsedAmount { get; set; }

                /// <summary>
                /// The memory usage of the dedicated cluster. Unit: %.
                /// </summary>
                [NameInMap("MemUtility")]
                [Validation(Required=false)]
                public float? MemUtility { get; set; }

                /// <summary>
                /// Indicates whether the feature that allows you to have the OS permissions on the host is enabled. Valid values:
                /// 
                /// *   **0** or **null**: The permissions cannot be granted.
                /// *   **1**: The permissions can be granted.
                /// *   **3**: The permissions have been granted.
                /// </summary>
                [NameInMap("OpenPermission")]
                [Validation(Required=false)]
                public string OpenPermission { get; set; }

                /// <summary>
                /// The name and ID of the dedicated cluster. The value consists of **DedicatedHostGroupDesc** and **DedicatedHostGroupId**. Format: DedicatedHostGroupDesc/DedicatedHostGroupId.
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC) to which the dedicated cluster belongs.
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// The zones to which the hosts of the dedicated cluster belong.
                /// </summary>
                [NameInMap("ZoneIDList")]
                [Validation(Required=false)]
                public DescribeDedicatedHostGroupsResponseBodyDedicatedHostGroupsDedicatedHostGroupsZoneIDList ZoneIDList { get; set; }
                public class DescribeDedicatedHostGroupsResponseBodyDedicatedHostGroupsDedicatedHostGroupsZoneIDList : TeaModel {
                    [NameInMap("ZoneIDList")]
                    [Validation(Required=false)]
                    public List<string> ZoneIDList { get; set; }

                }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
