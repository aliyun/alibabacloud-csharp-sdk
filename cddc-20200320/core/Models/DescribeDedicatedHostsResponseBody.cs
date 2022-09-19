// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeDedicatedHostsResponseBody : TeaModel {
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        [NameInMap("DedicatedHosts")]
        [Validation(Required=false)]
        public DescribeDedicatedHostsResponseBodyDedicatedHosts DedicatedHosts { get; set; }
        public class DescribeDedicatedHostsResponseBodyDedicatedHosts : TeaModel {
            [NameInMap("DedicatedHosts")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHosts> DedicatedHosts { get; set; }
            public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHosts : TeaModel {
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                [NameInMap("AllocationStatus")]
                [Validation(Required=false)]
                public string AllocationStatus { get; set; }

                [NameInMap("BastionInstanceId")]
                [Validation(Required=false)]
                public string BastionInstanceId { get; set; }

                [NameInMap("CPUAllocationRatio")]
                [Validation(Required=false)]
                public string CPUAllocationRatio { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

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

                [NameInMap("DiskInfo")]
                [Validation(Required=false)]
                public string DiskInfo { get; set; }

                [NameInMap("DistributionSymbol")]
                [Validation(Required=false)]
                public string DistributionSymbol { get; set; }

                [NameInMap("DistributionTag")]
                [Validation(Required=false)]
                public string DistributionTag { get; set; }

                [NameInMap("EcsClassCode")]
                [Validation(Required=false)]
                public string EcsClassCode { get; set; }

                [NameInMap("EcsId")]
                [Validation(Required=false)]
                public string EcsId { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("HostCPU")]
                [Validation(Required=false)]
                public string HostCPU { get; set; }

                [NameInMap("HostClass")]
                [Validation(Required=false)]
                public string HostClass { get; set; }

                [NameInMap("HostMem")]
                [Validation(Required=false)]
                public string HostMem { get; set; }

                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                [NameInMap("HostStatus")]
                [Validation(Required=false)]
                public string HostStatus { get; set; }

                [NameInMap("HostStorage")]
                [Validation(Required=false)]
                public string HostStorage { get; set; }

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
                public string InstanceNumber { get; set; }

                [NameInMap("MemAllocationRatio")]
                [Validation(Required=false)]
                public string MemAllocationRatio { get; set; }

                [NameInMap("MemoryUsed")]
                [Validation(Required=false)]
                public string MemoryUsed { get; set; }

                [NameInMap("MssqlSupportVersion")]
                [Validation(Required=false)]
                public string MssqlSupportVersion { get; set; }

                [NameInMap("OpenPermission")]
                [Validation(Required=false)]
                public string OpenPermission { get; set; }

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

        [NameInMap("MaxAutoScaleHostStorage")]
        [Validation(Required=false)]
        public long? MaxAutoScaleHostStorage { get; set; }

        [NameInMap("PageNumbers")]
        [Validation(Required=false)]
        public int? PageNumbers { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecords")]
        [Validation(Required=false)]
        public int? TotalRecords { get; set; }

    }

}
