// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeDedicatedHostGroupsResponseBody : TeaModel {
        /// <summary>
        /// The queried hosts.
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
                /// The policy that is used to allocate host resources. Valid values:
                /// 
                /// *   **Evenly**: The system preferentially deploys database instances on the hosts where no resources or fewer resources are allocated. This maximizes system stability.
                /// *   **Intensively**: The system preferentially deploys database instances on the hosts that are created earlier and have more allocated resources. This maximizes resource utilization.
                /// </summary>
                [NameInMap("AllocationPolicy")]
                [Validation(Required=false)]
                public string AllocationPolicy { get; set; }

                /// <summary>
                /// The ID of the primary instance deployed on the host. If no primary instance is deployed on the host, an empty string is returned.
                /// </summary>
                [NameInMap("BastionInstanceId")]
                [Validation(Required=false)]
                public string BastionInstanceId { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The CPU allocation ratio of the host.
                /// </summary>
                [NameInMap("CpuAllocateRation")]
                [Validation(Required=false)]
                public float? CpuAllocateRation { get; set; }

                /// <summary>
                /// The number of CPU cores allocated to the host.
                /// </summary>
                [NameInMap("CpuAllocatedAmount")]
                [Validation(Required=false)]
                public float? CpuAllocatedAmount { get; set; }

                /// <summary>
                /// The CPU overcommit ratio of the host.
                /// </summary>
                [NameInMap("CpuAllocationRatio")]
                [Validation(Required=false)]
                public int? CpuAllocationRatio { get; set; }

                /// <summary>
                /// The time when the host was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The number of hosts by storage type.
                /// </summary>
                [NameInMap("DedicatedHostCountGroupByHostType")]
                [Validation(Required=false)]
                public Dictionary<string, object> DedicatedHostCountGroupByHostType { get; set; }

                /// <summary>
                /// The name of the dedicated cluster in which the host is created.
                /// </summary>
                [NameInMap("DedicatedHostGroupDesc")]
                [Validation(Required=false)]
                public string DedicatedHostGroupDesc { get; set; }

                /// <summary>
                /// The ID of the dedicated cluster in which the host is created.
                /// </summary>
                [NameInMap("DedicatedHostGroupId")]
                [Validation(Required=false)]
                public string DedicatedHostGroupId { get; set; }

                /// <summary>
                /// The instance deployment mode of the host.
                /// </summary>
                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public string DeployType { get; set; }

                /// <summary>
                /// The disk allocation rate of the host.
                /// </summary>
                [NameInMap("DiskAllocateRation")]
                [Validation(Required=false)]
                public float? DiskAllocateRation { get; set; }

                /// <summary>
                /// The disk storage allocated to the host.
                /// </summary>
                [NameInMap("DiskAllocatedAmount")]
                [Validation(Required=false)]
                public float? DiskAllocatedAmount { get; set; }

                /// <summary>
                /// The storage overcommit ratio of the host.
                /// </summary>
                [NameInMap("DiskAllocationRatio")]
                [Validation(Required=false)]
                public int? DiskAllocationRatio { get; set; }

                /// <summary>
                /// The disk storage used by the host.
                /// </summary>
                [NameInMap("DiskUsedAmount")]
                [Validation(Required=false)]
                public float? DiskUsedAmount { get; set; }

                /// <summary>
                /// The disk usage of the host.
                /// </summary>
                [NameInMap("DiskUtility")]
                [Validation(Required=false)]
                public float? DiskUtility { get; set; }

                /// <summary>
                /// The database engine of the host.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The number of hosts.
                /// </summary>
                [NameInMap("HostNumber")]
                [Validation(Required=false)]
                public int? HostNumber { get; set; }

                /// <summary>
                /// The policy that is used for host troubleshooting. Valid values:
                /// 
                /// *   Auto (default): The system automatically replaces faulty hosts.
                /// *   Manual: You must manually replace faulty hosts.
                /// </summary>
                [NameInMap("HostReplacePolicy")]
                [Validation(Required=false)]
                public string HostReplacePolicy { get; set; }

                /// <summary>
                /// The number of instances deployed on the host.
                /// </summary>
                [NameInMap("InstanceNumber")]
                [Validation(Required=false)]
                public int? InstanceNumber { get; set; }

                /// <summary>
                /// The memory allocation ratio of the host.
                /// </summary>
                [NameInMap("MemAllocateRation")]
                [Validation(Required=false)]
                public float? MemAllocateRation { get; set; }

                /// <summary>
                /// The amount of memory allocated to the host.
                /// </summary>
                [NameInMap("MemAllocatedAmount")]
                [Validation(Required=false)]
                public float? MemAllocatedAmount { get; set; }

                /// <summary>
                /// The memory overcommit ratio of the host.
                /// </summary>
                [NameInMap("MemAllocationRatio")]
                [Validation(Required=false)]
                public int? MemAllocationRatio { get; set; }

                /// <summary>
                /// The amount of used memory.
                /// </summary>
                [NameInMap("MemUsedAmount")]
                [Validation(Required=false)]
                public float? MemUsedAmount { get; set; }

                /// <summary>
                /// The memory usage.
                /// </summary>
                [NameInMap("MemUtility")]
                [Validation(Required=false)]
                public float? MemUtility { get; set; }

                /// <summary>
                /// Indicates whether the host OS permissions are granted. Valid values:
                /// 
                /// *   **0 or 1**: no.
                /// *   **2 or 3** (default): yes.
                /// 
                /// >  When you create a dedicated cluster that runs **MySQL**, **SQL Server**, or **PostgreSQL**, you can grant the host OS permissions based on your business requirements.
                /// </summary>
                [NameInMap("OpenPermission")]
                [Validation(Required=false)]
                public string OpenPermission { get; set; }

                /// <summary>
                /// The description of the host.
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// The virtual private cloud (VPC) ID of the dedicated cluster in which the host is created.
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

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
