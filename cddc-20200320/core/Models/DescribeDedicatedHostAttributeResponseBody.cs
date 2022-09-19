// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeDedicatedHostAttributeResponseBody : TeaModel {
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        [NameInMap("AllocationStatus")]
        [Validation(Required=false)]
        public string AllocationStatus { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        [NameInMap("CPUAllocationRatio")]
        [Validation(Required=false)]
        public string CPUAllocationRatio { get; set; }

        [NameInMap("CpuUsed")]
        [Validation(Required=false)]
        public string CpuUsed { get; set; }

        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        [NameInMap("DiskAllocationRatio")]
        [Validation(Required=false)]
        public string DiskAllocationRatio { get; set; }

        [NameInMap("DistributionTag")]
        [Validation(Required=false)]
        public string DistributionTag { get; set; }

        [NameInMap("EcsClassCode")]
        [Validation(Required=false)]
        public string EcsClassCode { get; set; }

        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        [NameInMap("HostCPU")]
        [Validation(Required=false)]
        public int? HostCPU { get; set; }

        [NameInMap("HostClass")]
        [Validation(Required=false)]
        public string HostClass { get; set; }

        [NameInMap("HostMem")]
        [Validation(Required=false)]
        public int? HostMem { get; set; }

        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("HostStatus")]
        [Validation(Required=false)]
        public string HostStatus { get; set; }

        [NameInMap("HostStorage")]
        [Validation(Required=false)]
        public int? HostStorage { get; set; }

        [NameInMap("HostType")]
        [Validation(Required=false)]
        public string HostType { get; set; }

        [NameInMap("IPAddress")]
        [Validation(Required=false)]
        public string IPAddress { get; set; }

        [NameInMap("ImageCategory")]
        [Validation(Required=false)]
        public string ImageCategory { get; set; }

        [NameInMap("InstanceNumber")]
        [Validation(Required=false)]
        public int? InstanceNumber { get; set; }

        [NameInMap("InstanceNumberMaster")]
        [Validation(Required=false)]
        public int? InstanceNumberMaster { get; set; }

        [NameInMap("InstanceNumberROMaster")]
        [Validation(Required=false)]
        public int? InstanceNumberROMaster { get; set; }

        [NameInMap("InstanceNumberROSlave")]
        [Validation(Required=false)]
        public int? InstanceNumberROSlave { get; set; }

        [NameInMap("InstanceNumberSlave")]
        [Validation(Required=false)]
        public int? InstanceNumberSlave { get; set; }

        [NameInMap("MemAllocationRatio")]
        [Validation(Required=false)]
        public string MemAllocationRatio { get; set; }

        [NameInMap("MemoryUsed")]
        [Validation(Required=false)]
        public string MemoryUsed { get; set; }

        [NameInMap("OpenPermission")]
        [Validation(Required=false)]
        public string OpenPermission { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StorageUsed")]
        [Validation(Required=false)]
        public string StorageUsed { get; set; }

        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
