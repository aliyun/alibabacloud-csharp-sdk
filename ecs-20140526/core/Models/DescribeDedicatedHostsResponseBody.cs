// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the DDH.</para>
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
                /// <para>The policy used to migrate the ECS instances deployed on the dedicated host when the dedicated host fails. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Migrate: The instances are migrated to another physical machine. Instances that are not in the Stopped state when the dedicated host fails are restarted.</description></item>
                /// <item><description>Stop: The instances are stopped. If the dedicated host cannot be repaired, the instances are migrated to another physical machine and then restarted.</description></item>
                /// </list>
                /// <para>If the dedicated host has cloud disks attached, the default value is Migrate. If the dedicated host has local disks attached, the default value is Stop.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Migrate</para>
                /// </summary>
                [NameInMap("ActionOnMaintenance")]
                [Validation(Required=false)]
                public string ActionOnMaintenance { get; set; }

                /// <summary>
                /// <para>Indicates whether the dedicated host is added to the resource pool for automatic deployment. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>on: The dedicated host is added to the resource pool for automatic deployment.</description></item>
                /// <item><description>off: The dedicated host is not added to the resource pool for automatic deployment.</description></item>
                /// </list>
                /// <para>For information about automatic deployment, see the &quot;Automatic deployment&quot; section in <a href="https://help.aliyun.com/document_detail/118938.html">Functions and features</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AutoPlacement")]
                [Validation(Required=false)]
                public string AutoPlacement { get; set; }

                /// <summary>
                /// <para>The automatic release time of the dedicated host. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-MM-ddTHH:mmZ</c> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-01-01T12:00Z</para>
                /// </summary>
                [NameInMap("AutoReleaseTime")]
                [Validation(Required=false)]
                public string AutoReleaseTime { get; set; }

                /// <summary>
                /// <para>The performance specifications of the dedicated host.</para>
                /// </summary>
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

                    /// <summary>
                    /// <para>The amount of available space on the local disks. Unit: GiB</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>65</para>
                    /// </summary>
                    [NameInMap("AvailableLocalStorage")]
                    [Validation(Required=false)]
                    public int? AvailableLocalStorage { get; set; }

                    /// <summary>
                    /// <para>The amount of available memory. Unit: GiB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>25</para>
                    /// </summary>
                    [NameInMap("AvailableMemory")]
                    [Validation(Required=false)]
                    public float? AvailableMemory { get; set; }

                    /// <summary>
                    /// <para>The number of available vCPUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("AvailableVcpus")]
                    [Validation(Required=false)]
                    public int? AvailableVcpus { get; set; }

                    /// <summary>
                    /// <para>The number of available vGPUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("AvailableVgpus")]
                    [Validation(Required=false)]
                    public int? AvailableVgpus { get; set; }

                    /// <summary>
                    /// <para>The category of local disks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i2</para>
                    /// </summary>
                    [NameInMap("LocalStorageCategory")]
                    [Validation(Required=false)]
                    public string LocalStorageCategory { get; set; }

                    /// <summary>
                    /// <para>The socket capacities.</para>
                    /// </summary>
                    [NameInMap("SocketCapacities")]
                    [Validation(Required=false)]
                    public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostCapacitySocketCapacities SocketCapacities { get; set; }
                    public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostCapacitySocketCapacities : TeaModel {
                        [NameInMap("SocketCapacity")]
                        [Validation(Required=false)]
                        public List<DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostCapacitySocketCapacitiesSocketCapacity> SocketCapacity { get; set; }
                        public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostCapacitySocketCapacitiesSocketCapacity : TeaModel {
                            /// <summary>
                            /// <para>The amount of available memory. Unit: GiB.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>65</para>
                            /// </summary>
                            [NameInMap("AvailableMemory")]
                            [Validation(Required=false)]
                            public float? AvailableMemory { get; set; }

                            /// <summary>
                            /// <para>The number of available vCPUs.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>64</para>
                            /// </summary>
                            [NameInMap("AvailableVcpu")]
                            [Validation(Required=false)]
                            public int? AvailableVcpu { get; set; }

                            /// <summary>
                            /// <para>The socket ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("SocketId")]
                            [Validation(Required=false)]
                            public int? SocketId { get; set; }

                            /// <summary>
                            /// <para>The total amount of memory. Unit: GiB.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>128</para>
                            /// </summary>
                            [NameInMap("TotalMemory")]
                            [Validation(Required=false)]
                            public float? TotalMemory { get; set; }

                            /// <summary>
                            /// <para>The total number of vCPUs.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>128</para>
                            /// </summary>
                            [NameInMap("TotalVcpu")]
                            [Validation(Required=false)]
                            public int? TotalVcpu { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The total capacity of local disks. Unit: GiB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>512</para>
                    /// </summary>
                    [NameInMap("TotalLocalStorage")]
                    [Validation(Required=false)]
                    public int? TotalLocalStorage { get; set; }

                    /// <summary>
                    /// <para>The total amount of memory. Unit: GiB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1024</para>
                    /// </summary>
                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public float? TotalMemory { get; set; }

                    /// <summary>
                    /// <para>The total number of vCPUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>56</para>
                    /// </summary>
                    [NameInMap("TotalVcpus")]
                    [Validation(Required=false)]
                    public int? TotalVcpus { get; set; }

                    /// <summary>
                    /// <para>The total number of vGPUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("TotalVgpus")]
                    [Validation(Required=false)]
                    public int? TotalVgpus { get; set; }

                }

                /// <summary>
                /// <para>The billing method of the dedicated host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Prepaid</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The number of physical cores per CPU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public int? Cores { get; set; }

                /// <summary>
                /// <para>The CPU overcommit ratio. Valid values: 1 to 5.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CpuOverCommitRatio")]
                [Validation(Required=false)]
                public float? CpuOverCommitRatio { get; set; }

                /// <summary>
                /// <para>The time when the dedicated host was created. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-MM-ddTHH:mmZ</c> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-01-01T12:00Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The ID of the dedicated host cluster to which the dedicated host belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dc-bp12wlf6am0vz9v2****</para>
                /// </summary>
                [NameInMap("DedicatedHostClusterId")]
                [Validation(Required=false)]
                public string DedicatedHostClusterId { get; set; }

                /// <summary>
                /// <para>The ID of the dedicated host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dh-bp165p6xk2tlw61e****</para>
                /// </summary>
                [NameInMap("DedicatedHostId")]
                [Validation(Required=false)]
                public string DedicatedHostId { get; set; }

                /// <summary>
                /// <para>The name of the dedicated host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MyDDHTestName</para>
                /// </summary>
                [NameInMap("DedicatedHostName")]
                [Validation(Required=false)]
                public string DedicatedHostName { get; set; }

                /// <summary>
                /// <para>The ID of the dedicated host owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100************7</para>
                /// </summary>
                [NameInMap("DedicatedHostOwnerId")]
                [Validation(Required=false)]
                public long? DedicatedHostOwnerId { get; set; }

                /// <summary>
                /// <para>The type of the dedicated host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ddh.g5</para>
                /// </summary>
                [NameInMap("DedicatedHostType")]
                [Validation(Required=false)]
                public string DedicatedHostType { get; set; }

                /// <summary>
                /// <para>The description of the dedicated host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>this-is-my-DDH</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The expiration time of the subscription dedicated host. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-MM-ddTHH:mmZ</c> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-01-01T12:00Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The GPU model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gpu</para>
                /// </summary>
                [NameInMap("GPUSpec")]
                [Validation(Required=false)]
                public string GPUSpec { get; set; }

                /// <summary>
                /// <para>This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.</para>
                /// </summary>
                [NameInMap("HostDetailInfo")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostHostDetailInfo HostDetailInfo { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostHostDetailInfo : TeaModel {
                    /// <summary>
                    /// <para>This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("SerialNumber")]
                    [Validation(Required=false)]
                    public string SerialNumber { get; set; }

                }

                /// <summary>
                /// <para>The ECS instances that were created on the dedicated host.</para>
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
                        /// <para>The ID of the ECS instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>i-bp14ot0ykf8w13a1****</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The ID of the ECS instance owner.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>128************0</para>
                        /// </summary>
                        [NameInMap("InstanceOwnerId")]
                        [Validation(Required=false)]
                        public long? InstanceOwnerId { get; set; }

                        /// <summary>
                        /// <para>The instance type of the ECS instance that was created on the dedicated host.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ecs.g5.large</para>
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// <para>The ID of the socket to which the ECS instance belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0,1</para>
                        /// </summary>
                        [NameInMap("SocketId")]
                        [Validation(Required=false)]
                        public string SocketId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The machine code of the dedicated host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12aaa123456ff19dec12345d3026e****</para>
                /// </summary>
                [NameInMap("MachineId")]
                [Validation(Required=false)]
                public string MachineId { get; set; }

                /// <summary>
                /// <para>The network attributes of the dedicated host.</para>
                /// </summary>
                [NameInMap("NetworkAttributes")]
                [Validation(Required=false)]
                public DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostNetworkAttributes NetworkAttributes { get; set; }
                public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHostNetworkAttributes : TeaModel {
                    /// <summary>
                    /// <para>The timeout period of the UDP session that is established between Server Load Balancer (SLB) and the dedicated host. Unit: seconds. Only 60 is returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("SlbUdpTimeout")]
                    [Validation(Required=false)]
                    public int? SlbUdpTimeout { get; set; }

                    /// <summary>
                    /// <para>The timeout period of the UDP session that is established between a user and an Alibaba Cloud service on the dedicated host. Unit: seconds. Only 60 is returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("UdpTimeout")]
                    [Validation(Required=false)]
                    public int? UdpTimeout { get; set; }

                }

                /// <summary>
                /// <para>The reasons why the resources of the dedicated host were locked.</para>
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
                        /// <para>The reason why the dedicated host was locked. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>financial: The dedicated host was locked due to overdue payments.</description></item>
                        /// <item><description>security: The dedicated host was locked due to security reasons.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>financial</para>
                        /// </summary>
                        [NameInMap("LockReason")]
                        [Validation(Required=false)]
                        public string LockReason { get; set; }

                    }

                }

                /// <summary>
                /// <para>The number of physical GPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PhysicalGpus")]
                [Validation(Required=false)]
                public int? PhysicalGpus { get; set; }

                /// <summary>
                /// <para>The region ID of the dedicated host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the dedicated host belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aek3b6jzp66****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The unit of the subscription duration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Month</description></item>
                /// <item><description>Year</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Month</para>
                /// </summary>
                [NameInMap("SaleCycle")]
                [Validation(Required=false)]
                public string SaleCycle { get; set; }

                /// <summary>
                /// <para>The number of physical CPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Sockets")]
                [Validation(Required=false)]
                public int? Sockets { get; set; }

                /// <summary>
                /// <para>The status of the dedicated host. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Available: The dedicated host is running as expected.</description></item>
                /// <item><description>UnderAssessment: The dedicated host is available but has potential risks that may cause the ECS instances on the dedicated host to fail.</description></item>
                /// <item><description>PermanentFailure: The dedicated host has permanent failures and is unavailable.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The custom ECS instance families that are supported by the dedicated host.</para>
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
                /// <para>The ECS instance families that are supported by the dedicated host.</para>
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
                /// <para>The ECS instance types that are supported by the dedicated host.</para>
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
                /// <para>The tags of the dedicated host.</para>
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
                        /// <para>The tag key of the dedicated host.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value of the dedicated host.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The zone ID of the dedicated host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-g</para>
                /// </summary>
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
