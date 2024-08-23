// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// Details about the queried instances.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesInstance> Instance { get; set; }
            public class DescribeInstancesResponseBodyInstancesInstance : TeaModel {
                /// <summary>
                /// The automatic release time of the pay-as-you-go instance.
                /// </summary>
                [NameInMap("AutoReleaseTime")]
                [Validation(Required=false)]
                public string AutoReleaseTime { get; set; }

                /// <summary>
                /// The ID of the cluster to which the instance belongs.
                /// 
                /// >  This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The number of vCPUs.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// Details about the CPU options.
                /// </summary>
                [NameInMap("CpuOptions")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceCpuOptions CpuOptions { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceCpuOptions : TeaModel {
                    /// <summary>
                    /// The number of physical CPU cores.
                    /// </summary>
                    [NameInMap("CoreCount")]
                    [Validation(Required=false)]
                    public int? CoreCount { get; set; }

                    /// <summary>
                    /// >  This parameter is deprecated.
                    /// </summary>
                    [NameInMap("Numa")]
                    [Validation(Required=false)]
                    public string Numa { get; set; }

                    /// <summary>
                    /// The number of threads per CPU core.
                    /// </summary>
                    [NameInMap("ThreadsPerCore")]
                    [Validation(Required=false)]
                    public int? ThreadsPerCore { get; set; }

                    /// <summary>
                    /// The CPU topology type of the instance. Valid values:
                    /// 
                    /// *   ContinuousCoreToHTMapping: Hyper-Threading (HT) continuous CPU topology
                    /// *   DiscreteCoreToHTMapping: HT discrete CPU topology
                    /// </summary>
                    [NameInMap("TopologyType")]
                    [Validation(Required=false)]
                    public string TopologyType { get; set; }

                }

                /// <summary>
                /// The time when the instance was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time is displayed in UTC. For more information, see [ISO 8601](https://help.aliyun.com/document_detail/25696.html).
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The performance mode of the burstable instance. Valid values:
                /// 
                /// *   Standard: the standard mode. For more information, see the "Standard mode" section in [Overview of burstable instances](https://help.aliyun.com/document_detail/59977.html).
                /// *   Unlimited: the unlimited mode. For more information, see the "Unlimited mode" section in [Overview of burstable instances](https://help.aliyun.com/document_detail/59977.html).
                /// </summary>
                [NameInMap("CreditSpecification")]
                [Validation(Required=false)]
                public string CreditSpecification { get; set; }

                /// <summary>
                /// The information about the dedicated host. The value is an array that consists of DedicatedHostClusterId, DedicatedHostId, and DedicatedHostName.
                /// </summary>
                [NameInMap("DedicatedHostAttribute")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceDedicatedHostAttribute DedicatedHostAttribute { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceDedicatedHostAttribute : TeaModel {
                    /// <summary>
                    /// The ID of the dedicated host cluster.
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

                }

                /// <summary>
                /// The attributes of the instance on the dedicated host.
                /// </summary>
                [NameInMap("DedicatedInstanceAttribute")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceDedicatedInstanceAttribute DedicatedInstanceAttribute { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceDedicatedInstanceAttribute : TeaModel {
                    /// <summary>
                    /// Indicates whether the instance on the dedicated host is associated with the dedicated host. Valid values:
                    /// 
                    /// *   default: The instance is not associated with the dedicated host. When the instance is restarted from economical mode, the instance may be automatically deployed on another dedicated host in the automatic deployment resource pool.
                    /// *   host: The instance is associated with the dedicated host. When the instance is restarted from economical mode, the instance is still deployed on the original dedicated host.
                    /// </summary>
                    [NameInMap("Affinity")]
                    [Validation(Required=false)]
                    public string Affinity { get; set; }

                    /// <summary>
                    /// Indicates whether the instance is hosted on a dedicated host. Valid values:
                    /// 
                    /// *   default: The instance is not hosted on a dedicated host.
                    /// *   host: The instance is hosted on a dedicated host.
                    /// </summary>
                    [NameInMap("Tenancy")]
                    [Validation(Required=false)]
                    public string Tenancy { get; set; }

                }

                /// <summary>
                /// Indicates whether release protection is enabled for the instance. This parameter determines whether you can use the ECS console or call the DeleteInstance operation to release the instance. Valid values:
                /// 
                /// *   true: Release protection is enabled for the instance.
                /// *   false: Release protection is disabled for the instance.
                /// 
                /// >  This parameter is applicable only to pay-as-you-go instances. The release protection feature can protect instances against manual releases, but not against automatic releases.
                /// </summary>
                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                /// <summary>
                /// The number of the deployment set group to which the instance belongs in a deployment set.
                /// </summary>
                [NameInMap("DeploymentSetGroupNo")]
                [Validation(Required=false)]
                public int? DeploymentSetGroupNo { get; set; }

                /// <summary>
                /// The ID of the deployment set to which the instance belongs.
                /// </summary>
                [NameInMap("DeploymentSetId")]
                [Validation(Required=false)]
                public string DeploymentSetId { get; set; }

                /// <summary>
                /// The description of the instance.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// Indicates whether data disks can be attached to the instance. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("DeviceAvailable")]
                [Validation(Required=false)]
                public bool? DeviceAvailable { get; set; }

                /// <summary>
                /// Details about the capacity reservation associated with the instance.
                /// </summary>
                [NameInMap("EcsCapacityReservationAttr")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceEcsCapacityReservationAttr EcsCapacityReservationAttr { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceEcsCapacityReservationAttr : TeaModel {
                    /// <summary>
                    /// The ID of the capacity reservation.
                    /// </summary>
                    [NameInMap("CapacityReservationId")]
                    [Validation(Required=false)]
                    public string CapacityReservationId { get; set; }

                    /// <summary>
                    /// The preference of the capacity reservation.
                    /// </summary>
                    [NameInMap("CapacityReservationPreference")]
                    [Validation(Required=false)]
                    public string CapacityReservationPreference { get; set; }

                }

                /// <summary>
                /// Details about the EIP associated with the instance.
                /// </summary>
                [NameInMap("EipAddress")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceEipAddress EipAddress { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceEipAddress : TeaModel {
                    /// <summary>
                    /// The ID of the EIP.
                    /// </summary>
                    [NameInMap("AllocationId")]
                    [Validation(Required=false)]
                    public string AllocationId { get; set; }

                    /// <summary>
                    /// The maximum public bandwidth of the EIP. Unit: Mbit/s.
                    /// </summary>
                    [NameInMap("Bandwidth")]
                    [Validation(Required=false)]
                    public int? Bandwidth { get; set; }

                    /// <summary>
                    /// The metering method of the EIP. Valid values:
                    /// 
                    /// *   PayByBandwidth
                    /// *   PayByTraffic
                    /// </summary>
                    [NameInMap("InternetChargeType")]
                    [Validation(Required=false)]
                    public string InternetChargeType { get; set; }

                    /// <summary>
                    /// The EIP.
                    /// </summary>
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public string IpAddress { get; set; }

                    /// <summary>
                    /// Indicates whether the EIP can be disassociated.
                    /// </summary>
                    [NameInMap("IsSupportUnassociate")]
                    [Validation(Required=false)]
                    public bool? IsSupportUnassociate { get; set; }

                }

                /// <summary>
                /// The expiration time of the instance. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time is displayed in UTC. For more information, see [ISO 8601](https://help.aliyun.com/document_detail/25696.html).
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The number of GPUs for the instance type.
                /// </summary>
                [NameInMap("GPUAmount")]
                [Validation(Required=false)]
                public int? GPUAmount { get; set; }

                /// <summary>
                /// The category of GPUs for the instance type.
                /// </summary>
                [NameInMap("GPUSpec")]
                [Validation(Required=false)]
                public string GPUSpec { get; set; }

                /// <summary>
                /// >  This parameter is in invitational preview and is not publicly available.
                /// </summary>
                [NameInMap("HibernationOptions")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceHibernationOptions HibernationOptions { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceHibernationOptions : TeaModel {
                    /// <summary>
                    /// >  This parameter is in invitational preview and is not publicly available.
                    /// </summary>
                    [NameInMap("Configured")]
                    [Validation(Required=false)]
                    public bool? Configured { get; set; }

                }

                /// <summary>
                /// The hostname of the instance.
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                /// <summary>
                /// The ID of the HPC cluster to which the instance belongs.
                /// </summary>
                [NameInMap("HpcClusterId")]
                [Validation(Required=false)]
                public string HpcClusterId { get; set; }

                /// <summary>
                /// >  This parameter is in invitational preview and is not publicly available.
                /// </summary>
                [NameInMap("ISP")]
                [Validation(Required=false)]
                public string ISP { get; set; }

                /// <summary>
                /// The image ID of the instance.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// Details about the image options.
                /// </summary>
                [NameInMap("ImageOptions")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceImageOptions ImageOptions { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceImageOptions : TeaModel {
                    /// <summary>
                    /// Indicates whether the instance that uses the image supports logons of the ecs-user user. Valid values:
                    /// 
                    /// *   true
                    /// *   false
                    /// </summary>
                    [NameInMap("LoginAsNonRoot")]
                    [Validation(Required=false)]
                    public bool? LoginAsNonRoot { get; set; }

                }

                /// <summary>
                /// The internal IP addresses of the instance located in the classic network.
                /// </summary>
                [NameInMap("InnerIpAddress")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceInnerIpAddress InnerIpAddress { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceInnerIpAddress : TeaModel {
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public List<string> IpAddress { get; set; }

                }

                /// <summary>
                /// The billing method of the instance. Valid values:
                /// 
                /// *   PrePaid: subscription
                /// *   PostPaid: pay-as-you-go
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The instance name.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The network type of the instance. Valid values:
                /// 
                /// *   classic
                /// *   vpc
                /// </summary>
                [NameInMap("InstanceNetworkType")]
                [Validation(Required=false)]
                public string InstanceNetworkType { get; set; }

                /// <summary>
                /// The instance type of the instance.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The instance family of the instance.
                /// </summary>
                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                /// <summary>
                /// The billing method for network usage. Valid values:
                /// 
                /// *   PayByBandwidth: pay-by-bandwidth
                /// *   PayByTraffic: pay-by-traffic
                /// </summary>
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// The maximum inbound public bandwidth. Unit: Mbit/s.
                /// </summary>
                [NameInMap("InternetMaxBandwidthIn")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthIn { get; set; }

                /// <summary>
                /// The maximum outbound public bandwidth. Unit: Mbit/s.
                /// </summary>
                [NameInMap("InternetMaxBandwidthOut")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthOut { get; set; }

                /// <summary>
                /// Indicates whether the instance is an I/O optimized instance. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("IoOptimized")]
                [Validation(Required=false)]
                public bool? IoOptimized { get; set; }

                /// <summary>
                /// The name of the key pair.
                /// </summary>
                [NameInMap("KeyPairName")]
                [Validation(Required=false)]
                public string KeyPairName { get; set; }

                /// <summary>
                /// The number of local disks attached to the instance.
                /// </summary>
                [NameInMap("LocalStorageAmount")]
                [Validation(Required=false)]
                public int? LocalStorageAmount { get; set; }

                /// <summary>
                /// The capacity of local disks attached to the instance. Unit: GiB.
                /// </summary>
                [NameInMap("LocalStorageCapacity")]
                [Validation(Required=false)]
                public long? LocalStorageCapacity { get; set; }

                /// <summary>
                /// The memory size. Unit: MiB.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                /// <summary>
                /// Details about the metadata options.
                /// </summary>
                [NameInMap("MetadataOptions")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceMetadataOptions MetadataOptions { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceMetadataOptions : TeaModel {
                    /// <summary>
                    /// Indicates whether the access channel is enabled for instance metadata. Valid values:
                    /// 
                    /// *   enabled
                    /// *   disabled
                    /// </summary>
                    [NameInMap("HttpEndpoint")]
                    [Validation(Required=false)]
                    public string HttpEndpoint { get; set; }

                    /// <summary>
                    /// >  This parameter is not publicly available.
                    /// </summary>
                    [NameInMap("HttpPutResponseHopLimit")]
                    [Validation(Required=false)]
                    public int? HttpPutResponseHopLimit { get; set; }

                    /// <summary>
                    /// Indicates whether the security hardening mode (IMDSv2) is forcefully used to access instance metadata. Valid values:
                    /// 
                    /// *   optional: The security hardening mode (IMDSv2) is not forcefully used.
                    /// *   required: The security hardening mode (IMDSv2) is forcefully used.
                    /// </summary>
                    [NameInMap("HttpTokens")]
                    [Validation(Required=false)]
                    public string HttpTokens { get; set; }

                }

                /// <summary>
                /// The ENIs attached to the instance.
                /// </summary>
                [NameInMap("NetworkInterfaces")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceNetworkInterfaces NetworkInterfaces { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfaces : TeaModel {
                    [NameInMap("NetworkInterface")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterface> NetworkInterface { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterface : TeaModel {
                        /// <summary>
                        /// The IPv4 prefixes of the ENI. This parameter has a value only when `AdditionalAttributes.N` is set to `NETWORK_PRIMARY_ENI_IP`.
                        /// </summary>
                        [NameInMap("Ipv4PrefixSets")]
                        [Validation(Required=false)]
                        public DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv4PrefixSets Ipv4PrefixSets { get; set; }
                        public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv4PrefixSets : TeaModel {
                            [NameInMap("Ipv4PrefixSet")]
                            [Validation(Required=false)]
                            public List<DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv4PrefixSetsIpv4PrefixSet> Ipv4PrefixSet { get; set; }
                            public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv4PrefixSetsIpv4PrefixSet : TeaModel {
                                /// <summary>
                                /// The IPv4 prefix of the ENI.
                                /// </summary>
                                [NameInMap("Ipv4Prefix")]
                                [Validation(Required=false)]
                                public string Ipv4Prefix { get; set; }

                            }

                        }

                        /// <summary>
                        /// The IPv6 prefixes of the ENI. This parameter has a value only when `AdditionalAttributes.N` is set to `NETWORK_PRIMARY_ENI_IP`.
                        /// </summary>
                        [NameInMap("Ipv6PrefixSets")]
                        [Validation(Required=false)]
                        public DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv6PrefixSets Ipv6PrefixSets { get; set; }
                        public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv6PrefixSets : TeaModel {
                            [NameInMap("Ipv6PrefixSet")]
                            [Validation(Required=false)]
                            public List<DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv6PrefixSetsIpv6PrefixSet> Ipv6PrefixSet { get; set; }
                            public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv6PrefixSetsIpv6PrefixSet : TeaModel {
                                /// <summary>
                                /// The IPv6 prefix of the ENI.
                                /// </summary>
                                [NameInMap("Ipv6Prefix")]
                                [Validation(Required=false)]
                                public string Ipv6Prefix { get; set; }

                            }

                        }

                        /// <summary>
                        /// The IPv6 addresses of the ENI. This parameter has a value only when `AdditionalAttributes.N` is set to `NETWORK_PRIMARY_ENI_IP`.
                        /// </summary>
                        [NameInMap("Ipv6Sets")]
                        [Validation(Required=false)]
                        public DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv6Sets Ipv6Sets { get; set; }
                        public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv6Sets : TeaModel {
                            [NameInMap("Ipv6Set")]
                            [Validation(Required=false)]
                            public List<DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv6SetsIpv6Set> Ipv6Set { get; set; }
                            public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfaceIpv6SetsIpv6Set : TeaModel {
                                /// <summary>
                                /// The IPv6 address of the ENI.
                                /// </summary>
                                [NameInMap("Ipv6Address")]
                                [Validation(Required=false)]
                                public string Ipv6Address { get; set; }

                            }

                        }

                        /// <summary>
                        /// The MAC address of the ENI.
                        /// </summary>
                        [NameInMap("MacAddress")]
                        [Validation(Required=false)]
                        public string MacAddress { get; set; }

                        /// <summary>
                        /// The ID of the ENI.
                        /// </summary>
                        [NameInMap("NetworkInterfaceId")]
                        [Validation(Required=false)]
                        public string NetworkInterfaceId { get; set; }

                        /// <summary>
                        /// The primary private IP address of the ENI.
                        /// </summary>
                        [NameInMap("PrimaryIpAddress")]
                        [Validation(Required=false)]
                        public string PrimaryIpAddress { get; set; }

                        /// <summary>
                        /// The private IP addresses of the ENI.
                        /// </summary>
                        [NameInMap("PrivateIpSets")]
                        [Validation(Required=false)]
                        public DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacePrivateIpSets PrivateIpSets { get; set; }
                        public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacePrivateIpSets : TeaModel {
                            [NameInMap("PrivateIpSet")]
                            [Validation(Required=false)]
                            public List<DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacePrivateIpSetsPrivateIpSet> PrivateIpSet { get; set; }
                            public class DescribeInstancesResponseBodyInstancesInstanceNetworkInterfacesNetworkInterfacePrivateIpSetsPrivateIpSet : TeaModel {
                                /// <summary>
                                /// Indicates whether the IP address is the primary private IP address. Valid values:
                                /// 
                                /// *   true
                                /// *   false
                                /// </summary>
                                [NameInMap("Primary")]
                                [Validation(Required=false)]
                                public bool? Primary { get; set; }

                                /// <summary>
                                /// >  This parameter is in invitational preview and is not publicly available.
                                /// </summary>
                                [NameInMap("PrivateDnsName")]
                                [Validation(Required=false)]
                                public string PrivateDnsName { get; set; }

                                /// <summary>
                                /// The private IP address of the ENI.
                                /// </summary>
                                [NameInMap("PrivateIpAddress")]
                                [Validation(Required=false)]
                                public string PrivateIpAddress { get; set; }

                            }

                        }

                        /// <summary>
                        /// The type of the ENI. Valid values:
                        /// 
                        /// *   Primary
                        /// *   Secondary
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// The name of the operating system of the instance.
                /// </summary>
                [NameInMap("OSName")]
                [Validation(Required=false)]
                public string OSName { get; set; }

                /// <summary>
                /// The English name of the operating system of the instance.
                /// </summary>
                [NameInMap("OSNameEn")]
                [Validation(Required=false)]
                public string OSNameEn { get; set; }

                /// <summary>
                /// The type of the operating system of the instance. Valid values:
                /// 
                /// *   windows: Windows operating systems
                /// *   linux: Linux operating systems
                /// </summary>
                [NameInMap("OSType")]
                [Validation(Required=false)]
                public string OSType { get; set; }

                /// <summary>
                /// The reasons why the instance was locked.
                /// </summary>
                [NameInMap("OperationLocks")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceOperationLocks OperationLocks { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceOperationLocks : TeaModel {
                    [NameInMap("LockReason")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceOperationLocksLockReason> LockReason { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceOperationLocksLockReason : TeaModel {
                        /// <summary>
                        /// The message returned when the instance was locked.
                        /// </summary>
                        [NameInMap("LockMsg")]
                        [Validation(Required=false)]
                        public string LockMsg { get; set; }

                        /// <summary>
                        /// The reason why the instance was locked. Valid values:
                        /// 
                        /// *   financial: The instance was locked due to overdue payments.
                        /// *   security: The instance was locked due to security reasons.
                        /// *   recycling: The preemptible instance was locked and pending release.
                        /// *   dedicatedhostfinancial: The instance was locked due to overdue payments for the dedicated host.
                        /// *   refunded: The instance was locked because a refund was made for the instance.
                        /// </summary>
                        [NameInMap("LockReason")]
                        [Validation(Required=false)]
                        public string LockReason { get; set; }

                    }

                }

                /// <summary>
                /// >  This parameter is in invitational preview and is not publicly available.
                /// </summary>
                [NameInMap("PrivateDnsNameOptions")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstancePrivateDnsNameOptions PrivateDnsNameOptions { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstancePrivateDnsNameOptions : TeaModel {
                    /// <summary>
                    /// >  This parameter is in invitational preview and is not publicly available.
                    /// </summary>
                    [NameInMap("EnableInstanceIdDnsAAAARecord")]
                    [Validation(Required=false)]
                    public bool? EnableInstanceIdDnsAAAARecord { get; set; }

                    /// <summary>
                    /// >  This parameter is in invitational preview and is not publicly available.
                    /// </summary>
                    [NameInMap("EnableInstanceIdDnsARecord")]
                    [Validation(Required=false)]
                    public bool? EnableInstanceIdDnsARecord { get; set; }

                    /// <summary>
                    /// >  This parameter is in invitational preview and is not publicly available.
                    /// </summary>
                    [NameInMap("EnableIpDnsARecord")]
                    [Validation(Required=false)]
                    public bool? EnableIpDnsARecord { get; set; }

                    /// <summary>
                    /// >  This parameter is in invitational preview and is not publicly available.
                    /// </summary>
                    [NameInMap("EnableIpDnsPtrRecord")]
                    [Validation(Required=false)]
                    public bool? EnableIpDnsPtrRecord { get; set; }

                    /// <summary>
                    /// >  This parameter is in invitational preview and is not publicly available.
                    /// </summary>
                    [NameInMap("HostnameType")]
                    [Validation(Required=false)]
                    public string HostnameType { get; set; }

                }

                /// <summary>
                /// The public IP addresses of the instance.
                /// </summary>
                [NameInMap("PublicIpAddress")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstancePublicIpAddress PublicIpAddress { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstancePublicIpAddress : TeaModel {
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public List<string> IpAddress { get; set; }

                }

                /// <summary>
                /// The RDMA IP addresses of the instance in the HPC cluster.
                /// </summary>
                [NameInMap("RdmaIpAddress")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceRdmaIpAddress RdmaIpAddress { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceRdmaIpAddress : TeaModel {
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public List<string> IpAddress { get; set; }

                }

                /// <summary>
                /// Indicates whether the instance can be recycled.
                /// </summary>
                [NameInMap("Recyclable")]
                [Validation(Required=false)]
                public bool? Recyclable { get; set; }

                /// <summary>
                /// The region ID of the instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group to which the instance belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// >  The parameter is removed.
                /// </summary>
                [NameInMap("SaleCycle")]
                [Validation(Required=false)]
                public string SaleCycle { get; set; }

                /// <summary>
                /// The IDs of the security groups to which the instance belongs.
                /// </summary>
                [NameInMap("SecurityGroupIds")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceSecurityGroupIds SecurityGroupIds { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceSecurityGroupIds : TeaModel {
                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroupId { get; set; }

                }

                /// <summary>
                /// The serial number of the instance.
                /// </summary>
                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                /// <summary>
                /// The protection period of the preemptible instance. Unit: hours. Valid values:
                /// 
                /// *   1: After a preemptible instance is created, Alibaba Cloud ensures that the instance is not automatically released within 1 hour. After the 1-hour protection period ends, the system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.
                /// *   0: After a preemptible instance is created, Alibaba Cloud does not ensure that the instance runs for 1 hour. The system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.
                /// 
                /// Alibaba Cloud sends an ECS system event to notify you 5 minutes before the instance is released. Preemptible instances are billed by second. We recommend that you specify a protection period based on your business requirements.
                /// 
                /// >  This parameter is returned when SpotStrategy is set to SpotWithPriceLimit or SpotAsPriceGo.
                /// </summary>
                [NameInMap("SpotDuration")]
                [Validation(Required=false)]
                public int? SpotDuration { get; set; }

                /// <summary>
                /// The interruption mode of the preemptible instance when the system initiates a preemptible instance interruption operation. Valid values:
                /// 
                /// *   Terminate: releases the preemptible instance.
                /// *   Stop: stops the instance in economical mode.
                /// </summary>
                [NameInMap("SpotInterruptionBehavior")]
                [Validation(Required=false)]
                public string SpotInterruptionBehavior { get; set; }

                /// <summary>
                /// The maximum hourly price of the instance. The value can be accurate to three decimal places. This parameter is valid when SpotStrategy is set to SpotWithPriceLimit.
                /// </summary>
                [NameInMap("SpotPriceLimit")]
                [Validation(Required=false)]
                public float? SpotPriceLimit { get; set; }

                /// <summary>
                /// The bidding policy for the pay-as-you-go instance. Valid values:
                /// 
                /// *   NoSpot: The instance is a regular pay-as-you-go instance.
                /// *   SpotWithPriceLimit: The instance is a preemptible instance with a user-defined maximum hourly price.
                /// *   SpotAsPriceGo: The instance is a preemptible instance for which the market price is automatically used as the bid price. The market price can be up to the pay-as-you-go price.
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// The time when the instance was last started. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time is displayed in UTC. For more information, see [ISO 8601](https://help.aliyun.com/document_detail/25696.html).
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The status of the instance.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// Indicates whether the instance continues to be billed after it is stopped. Valid values:
                /// 
                /// *   KeepCharging: The instance is stopped in standard mode. Billing for the instance continues after the instance is stopped, and resources are retained for the instance.
                /// *   StopCharging: The instance is stopped in economical mode. Billing for some resources of the instance stops after the instance is stopped. When the instance is stopped, its resources such as vCPUs, memory, and public IP addresses are released. The instance may be unable to restart if some required resources are out of stock in the current region.
                /// *   Not-applicable: The instance does not support economical mode.
                /// </summary>
                [NameInMap("StoppedMode")]
                [Validation(Required=false)]
                public string StoppedMode { get; set; }

                /// <summary>
                /// The tags of the instance.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceTags Tags { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceTagsTag> Tag { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key of the instance.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value of the instance.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// The virtual LAN (VLAN) ID of the instance.
                /// 
                /// >  This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.
                /// </summary>
                [NameInMap("VlanId")]
                [Validation(Required=false)]
                public string VlanId { get; set; }

                /// <summary>
                /// The VPC attributes of the instance.
                /// </summary>
                [NameInMap("VpcAttributes")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceVpcAttributes VpcAttributes { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceVpcAttributes : TeaModel {
                    /// <summary>
                    /// The NAT IP address of the instance. The NAT IP address is used by ECS instances in different VPCs for communication.
                    /// </summary>
                    [NameInMap("NatIpAddress")]
                    [Validation(Required=false)]
                    public string NatIpAddress { get; set; }

                    /// <summary>
                    /// The private IP addresses of the instance.
                    /// </summary>
                    [NameInMap("PrivateIpAddress")]
                    [Validation(Required=false)]
                    public DescribeInstancesResponseBodyInstancesInstanceVpcAttributesPrivateIpAddress PrivateIpAddress { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceVpcAttributesPrivateIpAddress : TeaModel {
                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public List<string> IpAddress { get; set; }

                    }

                    /// <summary>
                    /// The ID of the vSwitch to which the instance is connected.
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// The ID of the VPC.
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// The zone ID of the instance.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of instances queried.
        /// 
        /// >  If you specify the `MaxResults` and `NextToken` request parameters to perform a paged query, the value of the `TotalCount` response parameter is invalid.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
