// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeDedicatedHostsResponseBody : TeaModel {
        [NameInMap("DedicatedHosts")]
        [Validation(Required=false)]
        public DescribeDedicatedHostsResponseBodyDedicatedHosts DedicatedHosts { get; set; }
        public class DescribeDedicatedHostsResponseBodyDedicatedHosts : TeaModel {
            [NameInMap("DedicatedHost")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHost> DedicatedHost { get; set; }
            public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHost : TeaModel {
                [NameInMap("SchedulerOptions")]
                [Validation(Required=true)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSchedulerOptions SchedulerOptions { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSchedulerOptions : TeaModel {
                    [NameInMap("ManagedPrivateSpaceId")]
                    [Validation(Required=false)]
                    public string ManagedPrivateSpaceId { get; set; }

                }

                [NameInMap("ActionOnMaintenance")]
                [Validation(Required=false)]
                public string ActionOnMaintenance { get; set; }

                [NameInMap("AutoPlacement")]
                [Validation(Required=false)]
                public string AutoPlacement { get; set; }

                [NameInMap("AutoReleaseTime")]
                [Validation(Required=false)]
                public string AutoReleaseTime { get; set; }

                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostCapacity Capacity { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostCapacity : TeaModel {
                    [NameInMap("AvailableLocalStorage")]
                    [Validation(Required=false)]
                    public int? AvailableLocalStorage { get; set; }

                    [NameInMap("AvailableMemory")]
                    [Validation(Required=false)]
                    public float? AvailableMemory { get; set; }

                    [NameInMap("AvailableVcpus")]
                    [Validation(Required=false)]
                    public int? AvailableVcpus { get; set; }

                    [NameInMap("AvailableVgpus")]
                    [Validation(Required=false)]
                    public int? AvailableVgpus { get; set; }

                    [NameInMap("LocalStorageCategory")]
                    [Validation(Required=false)]
                    public string LocalStorageCategory { get; set; }

                    [NameInMap("TotalLocalStorage")]
                    [Validation(Required=false)]
                    public int? TotalLocalStorage { get; set; }

                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public float? TotalMemory { get; set; }

                    [NameInMap("TotalVcpus")]
                    [Validation(Required=false)]
                    public int? TotalVcpus { get; set; }

                    [NameInMap("TotalVgpus")]
                    [Validation(Required=false)]
                    public int? TotalVgpus { get; set; }

                }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("CpuOverCommitRatio")]
                [Validation(Required=false)]
                public float? CpuOverCommitRatio { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("DedicatedHostClusterId")]
                [Validation(Required=false)]
                public string DedicatedHostClusterId { get; set; }

                [NameInMap("DedicatedHostId")]
                [Validation(Required=false)]
                public string DedicatedHostId { get; set; }

                [NameInMap("DedicatedHostName")]
                [Validation(Required=false)]
                public string DedicatedHostName { get; set; }

                [NameInMap("DedicatedHostType")]
                [Validation(Required=false)]
                public string DedicatedHostType { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("GPUSpec")]
                [Validation(Required=false)]
                public string GPUSpec { get; set; }

                [NameInMap("HostDetailInfo")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostHostDetailInfo HostDetailInfo { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostHostDetailInfo : TeaModel {
                    [NameInMap("SerialNumber")]
                    [Validation(Required=false)]
                    public string SerialNumber { get; set; }

                }

                [NameInMap("Instances")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostInstances Instances { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostInstances : TeaModel {
                    [NameInMap("Instance")]
                    [Validation(Required=false)]
                    public List<DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostInstancesInstance> Instance { get; set; }
                    public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostInstancesInstance : TeaModel {
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                    }

                }

                [NameInMap("MachineId")]
                [Validation(Required=false)]
                public string MachineId { get; set; }

                [NameInMap("NetworkAttributes")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostNetworkAttributes NetworkAttributes { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostNetworkAttributes : TeaModel {
                    [NameInMap("SlbUdpTimeout")]
                    [Validation(Required=false)]
                    public int? SlbUdpTimeout { get; set; }

                    [NameInMap("UdpTimeout")]
                    [Validation(Required=false)]
                    public int? UdpTimeout { get; set; }

                }

                [NameInMap("OperationLocks")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostOperationLocks OperationLocks { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostOperationLocks : TeaModel {
                    [NameInMap("OperationLock")]
                    [Validation(Required=false)]
                    public List<DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostOperationLocksOperationLock> OperationLock { get; set; }
                    public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostOperationLocksOperationLock : TeaModel {
                        [NameInMap("LockReason")]
                        [Validation(Required=false)]
                        public string LockReason { get; set; }

                    }

                }

                [NameInMap("PhysicalGpus")]
                [Validation(Required=false)]
                public int? PhysicalGpus { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SaleCycle")]
                [Validation(Required=false)]
                public string SaleCycle { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SupportInstanceTypeFamilies")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSupportInstanceTypeFamilies SupportInstanceTypeFamilies { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSupportInstanceTypeFamilies : TeaModel {
                    [NameInMap("SupportInstanceTypeFamily")]
                    [Validation(Required=false)]
                    public List<string> SupportInstanceTypeFamily { get; set; }

                }

                [NameInMap("SupportInstanceTypesList")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSupportInstanceTypesList SupportInstanceTypesList { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSupportInstanceTypesList : TeaModel {
                    [NameInMap("SupportInstanceTypesList")]
                    [Validation(Required=false)]
                    public List<string> SupportInstanceTypesList { get; set; }

                }

                [NameInMap("SupportedCustomInstanceTypeFamilies")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSupportedCustomInstanceTypeFamilies SupportedCustomInstanceTypeFamilies { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSupportedCustomInstanceTypeFamilies : TeaModel {
                    [NameInMap("SupportedCustomInstanceTypeFamily")]
                    [Validation(Required=false)]
                    public List<string> SupportedCustomInstanceTypeFamily { get; set; }

                }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostTags Tags { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostTagsTag> Tag { get; set; }
                    public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("TotalPhysicalCores")]
                [Validation(Required=false)]
                public int? TotalPhysicalCores { get; set; }

                [NameInMap("TotalSockets")]
                [Validation(Required=false)]
                public int? TotalSockets { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
