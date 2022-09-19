// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeDedicatedHostGroupsResponseBody : TeaModel {
        [NameInMap("DedicatedHostGroups")]
        [Validation(Required=false)]
        public DescribeDedicatedHostGroupsResponseBodyDedicatedHostGroups DedicatedHostGroups { get; set; }
        public class DescribeDedicatedHostGroupsResponseBodyDedicatedHostGroups : TeaModel {
            [NameInMap("DedicatedHostGroups")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostGroupsResponseBodyDedicatedHostGroupsDedicatedHostGroups> DedicatedHostGroups { get; set; }
            public class DescribeDedicatedHostGroupsResponseBodyDedicatedHostGroupsDedicatedHostGroups : TeaModel {
                [NameInMap("AllocationPolicy")]
                [Validation(Required=false)]
                public string AllocationPolicy { get; set; }

                [NameInMap("BastionInstanceId")]
                [Validation(Required=false)]
                public string BastionInstanceId { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("CpuAllocateRation")]
                [Validation(Required=false)]
                public float? CpuAllocateRation { get; set; }

                [NameInMap("CpuAllocatedAmount")]
                [Validation(Required=false)]
                public float? CpuAllocatedAmount { get; set; }

                [NameInMap("CpuAllocationRatio")]
                [Validation(Required=false)]
                public int? CpuAllocationRatio { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DedicatedHostCountGroupByHostType")]
                [Validation(Required=false)]
                public Dictionary<string, object> DedicatedHostCountGroupByHostType { get; set; }

                [NameInMap("DedicatedHostGroupDesc")]
                [Validation(Required=false)]
                public string DedicatedHostGroupDesc { get; set; }

                [NameInMap("DedicatedHostGroupId")]
                [Validation(Required=false)]
                public string DedicatedHostGroupId { get; set; }

                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public string DeployType { get; set; }

                [NameInMap("DiskAllocateRation")]
                [Validation(Required=false)]
                public float? DiskAllocateRation { get; set; }

                [NameInMap("DiskAllocatedAmount")]
                [Validation(Required=false)]
                public float? DiskAllocatedAmount { get; set; }

                [NameInMap("DiskAllocationRatio")]
                [Validation(Required=false)]
                public int? DiskAllocationRatio { get; set; }

                [NameInMap("DiskUsedAmount")]
                [Validation(Required=false)]
                public float? DiskUsedAmount { get; set; }

                [NameInMap("DiskUtility")]
                [Validation(Required=false)]
                public float? DiskUtility { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("HostNumber")]
                [Validation(Required=false)]
                public int? HostNumber { get; set; }

                [NameInMap("HostReplacePolicy")]
                [Validation(Required=false)]
                public string HostReplacePolicy { get; set; }

                [NameInMap("InstanceNumber")]
                [Validation(Required=false)]
                public int? InstanceNumber { get; set; }

                [NameInMap("MemAllocateRation")]
                [Validation(Required=false)]
                public float? MemAllocateRation { get; set; }

                [NameInMap("MemAllocatedAmount")]
                [Validation(Required=false)]
                public float? MemAllocatedAmount { get; set; }

                [NameInMap("MemAllocationRatio")]
                [Validation(Required=false)]
                public int? MemAllocationRatio { get; set; }

                [NameInMap("MemUsedAmount")]
                [Validation(Required=false)]
                public float? MemUsedAmount { get; set; }

                [NameInMap("MemUtility")]
                [Validation(Required=false)]
                public float? MemUtility { get; set; }

                [NameInMap("OpenPermission")]
                [Validation(Required=false)]
                public string OpenPermission { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
