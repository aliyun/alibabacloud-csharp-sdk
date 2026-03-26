// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
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
                [Validation(Required=false)]
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
                    [NameInMap("AvailableInstanceTypes")]
                    [Validation(Required=false)]
                    public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostCapacityAvailableInstanceTypes AvailableInstanceTypes { get; set; }
                    public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostCapacityAvailableInstanceTypes : TeaModel {
                        [NameInMap("AvailableInstanceType")]
                        [Validation(Required=false)]
                        public List<DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostCapacityAvailableInstanceTypesAvailableInstanceType> AvailableInstanceType { get; set; }
                        public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostCapacityAvailableInstanceTypesAvailableInstanceType : TeaModel {
                            [NameInMap("AvailableInstanceCapacity")]
                            [Validation(Required=false)]
                            public int? AvailableInstanceCapacity { get; set; }

                            [NameInMap("InstanceType")]
                            [Validation(Required=false)]
                            public string InstanceType { get; set; }

                        }

                    }

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

                    [NameInMap("SocketCapacities")]
                    [Validation(Required=false)]
                    public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostCapacitySocketCapacities SocketCapacities { get; set; }
                    public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostCapacitySocketCapacities : TeaModel {
                        [NameInMap("SocketCapacity")]
                        [Validation(Required=false)]
                        public List<DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostCapacitySocketCapacitiesSocketCapacity> SocketCapacity { get; set; }
                        public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostCapacitySocketCapacitiesSocketCapacity : TeaModel {
                            [NameInMap("AvailableMemory")]
                            [Validation(Required=false)]
                            public float? AvailableMemory { get; set; }

                            [NameInMap("AvailableVcpu")]
                            [Validation(Required=false)]
                            public int? AvailableVcpu { get; set; }

                            [NameInMap("SocketId")]
                            [Validation(Required=false)]
                            public int? SocketId { get; set; }

                            [NameInMap("TotalMemory")]
                            [Validation(Required=false)]
                            public float? TotalMemory { get; set; }

                            [NameInMap("TotalVcpu")]
                            [Validation(Required=false)]
                            public int? TotalVcpu { get; set; }

                        }

                    }

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

                [NameInMap("Cores")]
                [Validation(Required=false)]
                public int? Cores { get; set; }

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

                [NameInMap("DedicatedHostOwnerId")]
                [Validation(Required=false)]
                public long? DedicatedHostOwnerId { get; set; }

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

                        [NameInMap("InstanceOwnerId")]
                        [Validation(Required=false)]
                        public long? InstanceOwnerId { get; set; }

                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("SocketId")]
                        [Validation(Required=false)]
                        public string SocketId { get; set; }

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

                [NameInMap("Sockets")]
                [Validation(Required=false)]
                public int? Sockets { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SupportedCustomInstanceTypeFamilies")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSupportedCustomInstanceTypeFamilies SupportedCustomInstanceTypeFamilies { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSupportedCustomInstanceTypeFamilies : TeaModel {
                    [NameInMap("SupportedCustomInstanceTypeFamily")]
                    [Validation(Required=false)]
                    public List<string> SupportedCustomInstanceTypeFamily { get; set; }

                }

                [NameInMap("SupportedInstanceTypeFamilies")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSupportedInstanceTypeFamilies SupportedInstanceTypeFamilies { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSupportedInstanceTypeFamilies : TeaModel {
                    [NameInMap("SupportedInstanceTypeFamily")]
                    [Validation(Required=false)]
                    public List<string> SupportedInstanceTypeFamily { get; set; }

                }

                [NameInMap("SupportedInstanceTypesList")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSupportedInstanceTypesList SupportedInstanceTypesList { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSupportedInstanceTypesList : TeaModel {
                    [NameInMap("SupportedInstanceTypesList")]
                    [Validation(Required=false)]
                    public List<string> SupportedInstanceTypesList { get; set; }

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

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists. If the return value of this parameter is empty when you specify MaxResults and NextToken for a paged query, no more results are to be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e71d8a535bd9cc11</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7654525A-9964-4ABB-8BCD-98F8835E809A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of dedicated hosts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
