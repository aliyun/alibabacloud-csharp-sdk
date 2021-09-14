// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeEvaluateDedicatedHostsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceRequiredCPU")]
        [Validation(Required=false)]
        public int? InstanceRequiredCPU { get; set; }

        [NameInMap("CpuOverAllocationRatio")]
        [Validation(Required=false)]
        public int? CpuOverAllocationRatio { get; set; }

        [NameInMap("MemoryOverAllocationRatio")]
        [Validation(Required=false)]
        public int? MemoryOverAllocationRatio { get; set; }

        [NameInMap("InstanceRequiredMemory")]
        [Validation(Required=false)]
        public int? InstanceRequiredMemory { get; set; }

        [NameInMap("InstanceClassCode")]
        [Validation(Required=false)]
        public string InstanceClassCode { get; set; }

        [NameInMap("InstanceRequiredStorage")]
        [Validation(Required=false)]
        public int? InstanceRequiredStorage { get; set; }

        [NameInMap("DiskOverAllocationRatio")]
        [Validation(Required=false)]
        public int? DiskOverAllocationRatio { get; set; }

        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        [NameInMap("DedicatedHosts")]
        [Validation(Required=false)]
        public List<DescribeEvaluateDedicatedHostsResponseBodyDedicatedHosts> DedicatedHosts { get; set; }
        public class DescribeEvaluateDedicatedHostsResponseBodyDedicatedHosts : TeaModel {
            [NameInMap("HostAllocationStatus")]
            [Validation(Required=false)]
            public bool? HostAllocationStatus { get; set; }

            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("HostFreeMem")]
            [Validation(Required=false)]
            public int? HostFreeMem { get; set; }

            [NameInMap("HostStatus")]
            [Validation(Required=false)]
            public string HostStatus { get; set; }

            [NameInMap("HostFreeCPU")]
            [Validation(Required=false)]
            public int? HostFreeCPU { get; set; }

            [NameInMap("HostStorage")]
            [Validation(Required=false)]
            public int? HostStorage { get; set; }

            [NameInMap("HostCPU")]
            [Validation(Required=false)]
            public int? HostCPU { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("HostFreeStorage")]
            [Validation(Required=false)]
            public int? HostFreeStorage { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("DedicatedHostName")]
            [Validation(Required=false)]
            public string DedicatedHostName { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("ImageCategory")]
            [Validation(Required=false)]
            public string ImageCategory { get; set; }

            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public string DedicatedHostId { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("IsCouldSSD")]
            [Validation(Required=false)]
            public bool? IsCouldSSD { get; set; }

            [NameInMap("IsAvailableForInstance")]
            [Validation(Required=false)]
            public bool? IsAvailableForInstance { get; set; }

            [NameInMap("HostMem")]
            [Validation(Required=false)]
            public int? HostMem { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            [NameInMap("IPAddress")]
            [Validation(Required=false)]
            public string IPAddress { get; set; }

        }

    }

}
