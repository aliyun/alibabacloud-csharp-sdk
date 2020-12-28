// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("DedicatedHosts")]
        [Validation(Required=false)]
        public List<DescribeDedicatedHostsResponseBodyDedicatedHosts> DedicatedHosts { get; set; }
        public class DescribeDedicatedHostsResponseBodyDedicatedHosts : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public DescribeDedicatedHostsResponseBodyDedicatedHostsCapacity Capacity { get; set; }
            public class DescribeDedicatedHostsResponseBodyDedicatedHostsCapacity : TeaModel {
                [NameInMap("AvailableMemory")]
                [Validation(Required=false)]
                public float? AvailableMemory { get; set; }
                [NameInMap("LocalStorageCategory")]
                [Validation(Required=false)]
                public string LocalStorageCategory { get; set; }
                [NameInMap("TotalMemory")]
                [Validation(Required=false)]
                public float? TotalMemory { get; set; }
                [NameInMap("TotalLocalStorage")]
                [Validation(Required=false)]
                public int? TotalLocalStorage { get; set; }
                [NameInMap("TotalVcpus")]
                [Validation(Required=false)]
                public int? TotalVcpus { get; set; }
                [NameInMap("TotalVgpus")]
                [Validation(Required=false)]
                public int? TotalVgpus { get; set; }
                [NameInMap("AvailableLocalStorage")]
                [Validation(Required=false)]
                public int? AvailableLocalStorage { get; set; }
                [NameInMap("AvailableVcpus")]
                [Validation(Required=false)]
                public int? AvailableVcpus { get; set; }
                [NameInMap("AvailableVgpus")]
                [Validation(Required=false)]
                public int? AvailableVgpus { get; set; }
            };

            [NameInMap("AutoPlacement")]
            [Validation(Required=false)]
            public string AutoPlacement { get; set; }

            [NameInMap("OperationLocks")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostsResponseBodyDedicatedHostsOperationLocks> OperationLocks { get; set; }
            public class DescribeDedicatedHostsResponseBodyDedicatedHostsOperationLocks : TeaModel {
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

            }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostsResponseBodyDedicatedHostsTags> Tags { get; set; }
            public class DescribeDedicatedHostsResponseBodyDedicatedHostsTags : TeaModel {
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

            }

            [NameInMap("ActionOnMaintenance")]
            [Validation(Required=false)]
            public string ActionOnMaintenance { get; set; }

            [NameInMap("PhysicalGpus")]
            [Validation(Required=false)]
            public int? PhysicalGpus { get; set; }

            [NameInMap("SaleCycle")]
            [Validation(Required=false)]
            public string SaleCycle { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DedicatedHostType")]
            [Validation(Required=false)]
            public string DedicatedHostType { get; set; }

            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public string DedicatedHostId { get; set; }

            [NameInMap("Sockets")]
            [Validation(Required=false)]
            public int? Sockets { get; set; }

            [NameInMap("Cores")]
            [Validation(Required=false)]
            public int? Cores { get; set; }

            [NameInMap("GPUSpec")]
            [Validation(Required=false)]
            public string GPUSpec { get; set; }

            [NameInMap("AutoReleaseTime")]
            [Validation(Required=false)]
            public string AutoReleaseTime { get; set; }

            [NameInMap("CpuOverCommitRatio")]
            [Validation(Required=false)]
            public float? CpuOverCommitRatio { get; set; }

            [NameInMap("SupportedInstanceTypesList")]
            [Validation(Required=false)]
            public List<string> SupportedInstanceTypesList { get; set; }

            [NameInMap("SupportedCustomInstanceTypeFamilies")]
            [Validation(Required=false)]
            public List<string> SupportedCustomInstanceTypeFamilies { get; set; }

            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostsResponseBodyDedicatedHostsInstances> Instances { get; set; }
            public class DescribeDedicatedHostsResponseBodyDedicatedHostsInstances : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

            }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("NetworkAttributes")]
            [Validation(Required=false)]
            public DescribeDedicatedHostsResponseBodyDedicatedHostsNetworkAttributes NetworkAttributes { get; set; }
            public class DescribeDedicatedHostsResponseBodyDedicatedHostsNetworkAttributes : TeaModel {
                [NameInMap("UdpTimeout")]
                [Validation(Required=false)]
                public int? UdpTimeout { get; set; }
                [NameInMap("SlbUdpTimeout")]
                [Validation(Required=false)]
                public int? SlbUdpTimeout { get; set; }
            };

            [NameInMap("DedicatedHostName")]
            [Validation(Required=false)]
            public string DedicatedHostName { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("DedicatedHostClusterId")]
            [Validation(Required=false)]
            public string DedicatedHostClusterId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("SupportedInstanceTypeFamilies")]
            [Validation(Required=false)]
            public List<string> SupportedInstanceTypeFamilies { get; set; }

            [NameInMap("MachineId")]
            [Validation(Required=false)]
            public string MachineId { get; set; }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
