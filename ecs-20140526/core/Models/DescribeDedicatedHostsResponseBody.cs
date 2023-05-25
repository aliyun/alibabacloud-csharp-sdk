// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostsResponseBody : TeaModel {
        /// <summary>
        /// The details of the dedicated hosts.
        /// </summary>
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

                /// <summary>
                /// The policy that is used to migrate the instances deployed on the dedicated host when the dedicated host fails. Valid values:
                /// 
                /// *   Migrate: The instances are migrated to another physical server. Instances that are not in the Stopped state when the dedicated host fails are restarted after migration.
                /// *   Stop: The instances are stopped. If the dedicated host cannot be repaired, the instances are migrated to another physical machine and then restarted.
                /// 
                /// If cloud disks are attached to the dedicated host, the default value of this parameter is Migrate. If local disks are attched to the dedicated host, the default value of this parameter is Stop.
                /// </summary>
                [NameInMap("ActionOnMaintenance")]
                [Validation(Required=false)]
                public string ActionOnMaintenance { get; set; }

                /// <summary>
                /// Indicates whether the dedicated host is added to the resource pool for automatic deployment. Valid values:
                /// 
                /// *   on: The dedicated host is added to the resource pool for automatic deployment.
                /// *   off: The dedicated host is not added to the resource pool for automatic deployment.
                /// 
                /// For more information about automatic deployment, see the "Automatic deployment" section in [Functions and features](~~118938~~).
                /// </summary>
                [NameInMap("AutoPlacement")]
                [Validation(Required=false)]
                public string AutoPlacement { get; set; }

                /// <summary>
                /// The automatic release time of the dedicated host. The time follows the [ISO 8601](~~25696~~) standard in the `yyyy-MM-ddTHH:mmZ` format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("AutoReleaseTime")]
                [Validation(Required=false)]
                public string AutoReleaseTime { get; set; }

                /// <summary>
                /// The performance specifications of the dedicated host.
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostCapacity Capacity { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostCapacity : TeaModel {
                    /// <summary>
                    /// The available space of the local disks. Unit: GiB.
                    /// </summary>
                    [NameInMap("AvailableLocalStorage")]
                    [Validation(Required=false)]
                    public int? AvailableLocalStorage { get; set; }

                    /// <summary>
                    /// The amount of available memory space. Unit: GiB.
                    /// </summary>
                    [NameInMap("AvailableMemory")]
                    [Validation(Required=false)]
                    public float? AvailableMemory { get; set; }

                    /// <summary>
                    /// The number of available vCPUs.
                    /// </summary>
                    [NameInMap("AvailableVcpus")]
                    [Validation(Required=false)]
                    public int? AvailableVcpus { get; set; }

                    /// <summary>
                    /// The number of available vGPUs.
                    /// </summary>
                    [NameInMap("AvailableVgpus")]
                    [Validation(Required=false)]
                    public int? AvailableVgpus { get; set; }

                    /// <summary>
                    /// The category of the local disks.
                    /// </summary>
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

                    /// <summary>
                    /// The total capacity of the local disks. Unit: GiB.
                    /// </summary>
                    [NameInMap("TotalLocalStorage")]
                    [Validation(Required=false)]
                    public int? TotalLocalStorage { get; set; }

                    /// <summary>
                    /// The total capacity of the memory. Unit: GiB.
                    /// </summary>
                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public float? TotalMemory { get; set; }

                    /// <summary>
                    /// The total number of vCPUs.
                    /// </summary>
                    [NameInMap("TotalVcpus")]
                    [Validation(Required=false)]
                    public int? TotalVcpus { get; set; }

                    /// <summary>
                    /// The total number of vGPUs.
                    /// </summary>
                    [NameInMap("TotalVgpus")]
                    [Validation(Required=false)]
                    public int? TotalVgpus { get; set; }

                }

                /// <summary>
                /// The billing method of the dedicated host.
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// The number of cores in a single CPU.
                /// </summary>
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public int? Cores { get; set; }

                /// <summary>
                /// The CPU overcommit ratio.
                /// </summary>
                [NameInMap("CpuOverCommitRatio")]
                [Validation(Required=false)]
                public float? CpuOverCommitRatio { get; set; }

                /// <summary>
                /// The time when the dedicated host was created. The time follows the [ISO 8601](~~25696~~) standard in the `yyyy-MM-ddTHH:mmZ` format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The ID of the dedicated host cluster to which the dedicated host belongs.
                /// </summary>
                [NameInMap("DedicatedHostClusterId")]
                [Validation(Required=false)]
                public string DedicatedHostClusterId { get; set; }

                /// <summary>
                /// The ID of the dedicated host.
                /// </summary>
                [NameInMap("DedicatedHostId")]
                [Validation(Required=false)]
                public string DedicatedHostId { get; set; }

                /// <summary>
                /// The name of the dedicated host.
                /// </summary>
                [NameInMap("DedicatedHostName")]
                [Validation(Required=false)]
                public string DedicatedHostName { get; set; }

                [NameInMap("DedicatedHostOwnerId")]
                [Validation(Required=false)]
                public long? DedicatedHostOwnerId { get; set; }

                /// <summary>
                /// The type of the dedicated host.
                /// </summary>
                [NameInMap("DedicatedHostType")]
                [Validation(Required=false)]
                public string DedicatedHostType { get; set; }

                /// <summary>
                /// The description of the dedicated host.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The expiration time of the subscription dedicated host. The time follows the [ISO 8601](~~25696~~) standard in the `yyyy-MM-ddTHH:mmZ` format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The GPU model.
                /// </summary>
                [NameInMap("GPUSpec")]
                [Validation(Required=false)]
                public string GPUSpec { get; set; }

                /// <summary>
                /// This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.
                /// </summary>
                [NameInMap("HostDetailInfo")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostHostDetailInfo HostDetailInfo { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostHostDetailInfo : TeaModel {
                    /// <summary>
                    /// This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.
                    /// </summary>
                    [NameInMap("SerialNumber")]
                    [Validation(Required=false)]
                    public string SerialNumber { get; set; }

                }

                /// <summary>
                /// The ECS instances that are created on the dedicated host.
                /// </summary>
                [NameInMap("Instances")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostInstances Instances { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostInstances : TeaModel {
                    [NameInMap("Instance")]
                    [Validation(Required=false)]
                    public List<DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostInstancesInstance> Instance { get; set; }
                    public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostInstancesInstance : TeaModel {
                        /// <summary>
                        /// The ID of the ECS instance that is created on the dedicated host.
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("InstanceOwnerId")]
                        [Validation(Required=false)]
                        public long? InstanceOwnerId { get; set; }

                        /// <summary>
                        /// The instance type of the ECS instance that is created on the dedicated host.
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("SocketId")]
                        [Validation(Required=false)]
                        public string SocketId { get; set; }

                    }

                }

                /// <summary>
                /// The machine code of the dedicated host.
                /// </summary>
                [NameInMap("MachineId")]
                [Validation(Required=false)]
                public string MachineId { get; set; }

                /// <summary>
                /// The network attributes of the dedicated host.
                /// </summary>
                [NameInMap("NetworkAttributes")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostNetworkAttributes NetworkAttributes { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostNetworkAttributes : TeaModel {
                    /// <summary>
                    /// The timeout period of the UDP session that is established between Server Load Balancer (SLB) and the dedicated host. Unit: seconds. Valid value: 60.
                    /// </summary>
                    [NameInMap("SlbUdpTimeout")]
                    [Validation(Required=false)]
                    public int? SlbUdpTimeout { get; set; }

                    /// <summary>
                    /// The timeout period of the UDP session that is established between a user and an Alibaba Cloud service on the dedicated host. Unit: seconds. Valid value: 60.
                    /// </summary>
                    [NameInMap("UdpTimeout")]
                    [Validation(Required=false)]
                    public int? UdpTimeout { get; set; }

                }

                /// <summary>
                /// The reasons why the resources of the dedicated host are locked.
                /// </summary>
                [NameInMap("OperationLocks")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostOperationLocks OperationLocks { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostOperationLocks : TeaModel {
                    [NameInMap("OperationLock")]
                    [Validation(Required=false)]
                    public List<DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostOperationLocksOperationLock> OperationLock { get; set; }
                    public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostOperationLocksOperationLock : TeaModel {
                        /// <summary>
                        /// The reason why the dedicated host is locked. Valid values:
                        /// 
                        /// *   financial: The dedicated host is locked due to overdue payments.
                        /// *   security: The dedicated host is locked due to security reasons.
                        /// </summary>
                        [NameInMap("LockReason")]
                        [Validation(Required=false)]
                        public string LockReason { get; set; }

                    }

                }

                /// <summary>
                /// The number of physical GPUs.
                /// </summary>
                [NameInMap("PhysicalGpus")]
                [Validation(Required=false)]
                public int? PhysicalGpus { get; set; }

                /// <summary>
                /// The region ID of the dedicated host.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group to which the dedicated host belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The unit of the subscription period. Valid values:
                /// 
                /// *   Month
                /// *   Year
                /// </summary>
                [NameInMap("SaleCycle")]
                [Validation(Required=false)]
                public string SaleCycle { get; set; }

                /// <summary>
                /// The number of physical CPUs.
                /// </summary>
                [NameInMap("Sockets")]
                [Validation(Required=false)]
                public int? Sockets { get; set; }

                /// <summary>
                /// The service status of the dedicated host. Valid values:
                /// 
                /// *   Available: The dedicated host is running as expected.
                /// *   UnderAssessment: The dedicated host is available. However, the dedicated host has potential risks that may cause the ECS instances on the dedicated host to fail.
                /// *   PermanentFailure: The dedicated host has permanent failures and cannot be used.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The custom ECS instance families that are supported by the dedicated host.
                /// </summary>
                [NameInMap("SupportedCustomInstanceTypeFamilies")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSupportedCustomInstanceTypeFamilies SupportedCustomInstanceTypeFamilies { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSupportedCustomInstanceTypeFamilies : TeaModel {
                    [NameInMap("SupportedCustomInstanceTypeFamily")]
                    [Validation(Required=false)]
                    public List<string> SupportedCustomInstanceTypeFamily { get; set; }

                }

                /// <summary>
                /// The ECS instance families that are supported by the dedicated host.
                /// </summary>
                [NameInMap("SupportedInstanceTypeFamilies")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSupportedInstanceTypeFamilies SupportedInstanceTypeFamilies { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSupportedInstanceTypeFamilies : TeaModel {
                    [NameInMap("SupportedInstanceTypeFamily")]
                    [Validation(Required=false)]
                    public List<string> SupportedInstanceTypeFamily { get; set; }

                }

                /// <summary>
                /// The ECS instance types that are supported by the dedicated host.
                /// </summary>
                [NameInMap("SupportedInstanceTypesList")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSupportedInstanceTypesList SupportedInstanceTypesList { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostSupportedInstanceTypesList : TeaModel {
                    [NameInMap("SupportedInstanceTypesList")]
                    [Validation(Required=false)]
                    public List<string> SupportedInstanceTypesList { get; set; }

                }

                /// <summary>
                /// The tags of the dedicated host.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostTags Tags { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostTagsTag> Tag { get; set; }
                    public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostTagsTag : TeaModel {
                        /// <summary>
                        /// The key of tag N of the dedicated host.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The value of tag N of the dedicated host.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// The zone ID of the dedicated host.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of dedicated hosts.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
