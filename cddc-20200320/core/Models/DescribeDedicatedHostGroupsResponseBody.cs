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
                public string AllocationPolicy { get; set; }
                public string BastionInstanceId { get; set; }
                public float? CpuAllocateRation { get; set; }
                public float? CpuAllocatedAmount { get; set; }
                public int? CpuAllocationRatio { get; set; }
                public string CreateTime { get; set; }
                public Dictionary<string, string> DedicatedHostCountGroupByHostType { get; set; }
                public string DedicatedHostGroupDesc { get; set; }
                public string DedicatedHostGroupId { get; set; }
                public string DeployType { get; set; }
                public float? DiskAllocateRation { get; set; }
                public float? DiskAllocatedAmount { get; set; }
                public int? DiskAllocationRatio { get; set; }
                public float? DiskUsedAmount { get; set; }
                public float? DiskUtility { get; set; }
                public string Engine { get; set; }
                public int? HostNumber { get; set; }
                public string HostReplacePolicy { get; set; }
                public int? InstanceNumber { get; set; }
                public float? MemAllocateRation { get; set; }
                public float? MemAllocatedAmount { get; set; }
                public int? MemAllocationRatio { get; set; }
                public float? MemUsedAmount { get; set; }
                public float? MemUtility { get; set; }
                public string OpenPermission { get; set; }
                public string Text { get; set; }
                public string VPCId { get; set; }
                public DescribeDedicatedHostGroupsResponseBodyDedicatedHostGroupsDedicatedHostGroupsZoneIDList ZoneIDList { get; set; }
                public class DescribeDedicatedHostGroupsResponseBodyDedicatedHostGroupsDedicatedHostGroupsZoneIDList : TeaModel {
                    [NameInMap("ZoneIDList")]
                    [Validation(Required=false)]
                    public List<string> ZoneIDList { get; set; }

                }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
