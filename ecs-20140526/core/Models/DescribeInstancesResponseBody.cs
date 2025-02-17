// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the queried instances.</para>
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
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("AdditionalInfo")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceAdditionalInfo AdditionalInfo { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceAdditionalInfo : TeaModel {
                    [NameInMap("EnableHighDensityMode")]
                    [Validation(Required=false)]
                    public bool? EnableHighDensityMode { get; set; }

                }

                /// <summary>
                /// <para>The automatic release time of the pay-as-you-go instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-10T04:04Z</para>
                /// </summary>
                [NameInMap("AutoReleaseTime")]
                [Validation(Required=false)]
                public string AutoReleaseTime { get; set; }

                /// <summary>
                /// <para>The ID of the cluster to which the instance belongs.</para>
                /// <remarks>
                /// <para> This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>c-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The number of vCPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>Details about the CPU options.</para>
                /// </summary>
                [NameInMap("CpuOptions")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceCpuOptions CpuOptions { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceCpuOptions : TeaModel {
                    /// <summary>
                    /// <para>The number of physical CPU cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("CoreCount")]
                    [Validation(Required=false)]
                    public int? CoreCount { get; set; }

                    /// <summary>
                    /// <remarks>
                    /// <para> This parameter is deprecated.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Numa")]
                    [Validation(Required=false)]
                    public string Numa { get; set; }

                    /// <summary>
                    /// <para>The number of threads per CPU core.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("ThreadsPerCore")]
                    [Validation(Required=false)]
                    public int? ThreadsPerCore { get; set; }

                    /// <summary>
                    /// <para>The CPU topology type of the instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ContinuousCoreToHTMapping: Hyper-Threading (HT) continuous CPU topology</description></item>
                    /// <item><description>DiscreteCoreToHTMapping: HT discrete CPU topology</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ContinuousCoreToHTMapping</para>
                    /// </summary>
                    [NameInMap("TopologyType")]
                    [Validation(Required=false)]
                    public string TopologyType { get; set; }

                }

                /// <summary>
                /// <para>The time when the instance was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time is displayed in UTC. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-10T04:04Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The performance mode of the burstable instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Standard: the standard mode. For more information, see the &quot;Standard mode&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
                /// <item><description>Unlimited: the unlimited mode. For more information, see the &quot;Unlimited mode&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("CreditSpecification")]
                [Validation(Required=false)]
                public string CreditSpecification { get; set; }

                /// <summary>
                /// <para>The information about the dedicated host. The value is an array that consists of DedicatedHostClusterId, DedicatedHostId, and DedicatedHostName.</para>
                /// </summary>
                [NameInMap("DedicatedHostAttribute")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceDedicatedHostAttribute DedicatedHostAttribute { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceDedicatedHostAttribute : TeaModel {
                    /// <summary>
                    /// <para>The ID of the dedicated host cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dc-bp67acfmxazb4h****</para>
                    /// </summary>
                    [NameInMap("DedicatedHostClusterId")]
                    [Validation(Required=false)]
                    public string DedicatedHostClusterId { get; set; }

                    /// <summary>
                    /// <para>The ID of the dedicated host.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dh-bp67acfmxazb4p****</para>
                    /// </summary>
                    [NameInMap("DedicatedHostId")]
                    [Validation(Required=false)]
                    public string DedicatedHostId { get; set; }

                    /// <summary>
                    /// <para>The name of the dedicated host.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testDedicatedHostName</para>
                    /// </summary>
                    [NameInMap("DedicatedHostName")]
                    [Validation(Required=false)]
                    public string DedicatedHostName { get; set; }

                }

                /// <summary>
                /// <para>The attributes of the instance on the dedicated host.</para>
                /// </summary>
                [NameInMap("DedicatedInstanceAttribute")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceDedicatedInstanceAttribute DedicatedInstanceAttribute { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceDedicatedInstanceAttribute : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the instance on the dedicated host is associated with the dedicated host. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>default: The instance is not associated with the dedicated host. When the instance is restarted from economical mode, the instance may be automatically deployed on another dedicated host in the automatic deployment resource pool.</description></item>
                    /// <item><description>host: The instance is associated with the dedicated host. When the instance is restarted from economical mode, the instance is still deployed on the original dedicated host.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("Affinity")]
                    [Validation(Required=false)]
                    public string Affinity { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the instance is hosted on a dedicated host. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>default: The instance is not hosted on a dedicated host.</description></item>
                    /// <item><description>host: The instance is hosted on a dedicated host.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("Tenancy")]
                    [Validation(Required=false)]
                    public string Tenancy { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether release protection is enabled for the instance. This parameter determines whether you can use the ECS console or call the DeleteInstance operation to release the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Release protection is enabled for the instance.</description></item>
                /// <item><description>false: Release protection is disabled for the instance.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is applicable only to pay-as-you-go instances. The release protection feature can protect instances against manual releases, but not against automatic releases.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                /// <summary>
                /// <para>The number of the deployment set group to which the instance belongs in a deployment set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DeploymentSetGroupNo")]
                [Validation(Required=false)]
                public int? DeploymentSetGroupNo { get; set; }

                /// <summary>
                /// <para>The ID of the deployment set to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("DeploymentSetId")]
                [Validation(Required=false)]
                public string DeploymentSetId { get; set; }

                /// <summary>
                /// <para>The description of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDescription</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether data disks can be attached to the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeviceAvailable")]
                [Validation(Required=false)]
                public bool? DeviceAvailable { get; set; }

                /// <summary>
                /// <para>Details about the capacity reservation associated with the instance.</para>
                /// </summary>
                [NameInMap("EcsCapacityReservationAttr")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceEcsCapacityReservationAttr EcsCapacityReservationAttr { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceEcsCapacityReservationAttr : TeaModel {
                    /// <summary>
                    /// <para>The ID of the capacity reservation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cr-bp67acfmxazb4p****</para>
                    /// </summary>
                    [NameInMap("CapacityReservationId")]
                    [Validation(Required=false)]
                    public string CapacityReservationId { get; set; }

                    /// <summary>
                    /// <para>The preference of the capacity reservation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cr-bp67acfmxazb4p****</para>
                    /// </summary>
                    [NameInMap("CapacityReservationPreference")]
                    [Validation(Required=false)]
                    public string CapacityReservationPreference { get; set; }

                }

                /// <summary>
                /// <para>Details about the EIP associated with the instance.</para>
                /// </summary>
                [NameInMap("EipAddress")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceEipAddress EipAddress { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceEipAddress : TeaModel {
                    /// <summary>
                    /// <para>The ID of the EIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eip-2ze88m67qx5z****</para>
                    /// </summary>
                    [NameInMap("AllocationId")]
                    [Validation(Required=false)]
                    public string AllocationId { get; set; }

                    /// <summary>
                    /// <para>The maximum public bandwidth of the EIP. Unit: Mbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Bandwidth")]
                    [Validation(Required=false)]
                    public int? Bandwidth { get; set; }

                    /// <summary>
                    /// <para>The metering method of the EIP. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PayByBandwidth</description></item>
                    /// <item><description>PayByTraffic</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PayByTraffic</para>
                    /// </summary>
                    [NameInMap("InternetChargeType")]
                    [Validation(Required=false)]
                    public string InternetChargeType { get; set; }

                    /// <summary>
                    /// <para>The EIP.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><c>42.112.**.**</c></para>
                    /// </summary>
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public string IpAddress { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the EIP can be disassociated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsSupportUnassociate")]
                    [Validation(Required=false)]
                    public bool? IsSupportUnassociate { get; set; }

                }

                /// <summary>
                /// <para>The expiration time of the instance. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time is displayed in UTC. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-10T04:04Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The number of GPUs for the instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("GPUAmount")]
                [Validation(Required=false)]
                public int? GPUAmount { get; set; }

                /// <summary>
                /// <para>The category of GPUs for the instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NVIDIA V100</para>
                /// </summary>
                [NameInMap("GPUSpec")]
                [Validation(Required=false)]
                public string GPUSpec { get; set; }

                /// <summary>
                /// <remarks>
                /// <para> This parameter is in invitational preview and is not publicly available.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("HibernationOptions")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceHibernationOptions HibernationOptions { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceHibernationOptions : TeaModel {
                    /// <summary>
                    /// <remarks>
                    /// <para> This parameter is in invitational preview and is not publicly available.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Configured")]
                    [Validation(Required=false)]
                    public bool? Configured { get; set; }

                }

                /// <summary>
                /// <para>The hostname of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testHostName</para>
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                /// <summary>
                /// <para>The ID of the HPC cluster to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hpc-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("HpcClusterId")]
                [Validation(Required=false)]
                public string HpcClusterId { get; set; }

                /// <summary>
                /// <remarks>
                /// <para> This parameter is in invitational preview and is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ISP")]
                [Validation(Required=false)]
                public string ISP { get; set; }

                /// <summary>
                /// <para>The image ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The image options.</para>
                /// </summary>
                [NameInMap("ImageOptions")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceImageOptions ImageOptions { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceImageOptions : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the operating system supports access to disks over the NVMe protocol. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> This parameter is returned only if you specify CURRENT_OS_NVME_SUPPORTED in AdditionalAttributes in the request.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CurrentOSNVMeSupported")]
                    [Validation(Required=false)]
                    public bool? CurrentOSNVMeSupported { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the instance that uses the image supports logons of the ecs-user user. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("LoginAsNonRoot")]
                    [Validation(Required=false)]
                    public bool? LoginAsNonRoot { get; set; }

                }

                /// <summary>
                /// <para>The internal IP addresses of the instance located in the classic network.</para>
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
                /// <para>The billing method of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PrePaid: subscription</description></item>
                /// <item><description>PostPaid: pay-as-you-go</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InstanceNameTest</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The network type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>classic</description></item>
                /// <item><description>vpc</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("InstanceNetworkType")]
                [Validation(Required=false)]
                public string InstanceNetworkType { get; set; }

                /// <summary>
                /// <para>The instance type of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g5.large</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The instance family of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g5</para>
                /// </summary>
                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                /// <summary>
                /// <para>The billing method for network usage. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PayByBandwidth: pay-by-bandwidth</description></item>
                /// <item><description>PayByTraffic: pay-by-traffic</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PayByTraffic</para>
                /// </summary>
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// <para>The maximum inbound public bandwidth. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("InternetMaxBandwidthIn")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthIn { get; set; }

                /// <summary>
                /// <para>The maximum outbound public bandwidth. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("InternetMaxBandwidthOut")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthOut { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance is an I/O optimized instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IoOptimized")]
                [Validation(Required=false)]
                public bool? IoOptimized { get; set; }

                /// <summary>
                /// <para>The name of the key pair.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testKeyPairName</para>
                /// </summary>
                [NameInMap("KeyPairName")]
                [Validation(Required=false)]
                public string KeyPairName { get; set; }

                /// <summary>
                /// <para>The number of local disks attached to the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("LocalStorageAmount")]
                [Validation(Required=false)]
                public int? LocalStorageAmount { get; set; }

                /// <summary>
                /// <para>The capacity of local disks attached to the instance. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("LocalStorageCapacity")]
                [Validation(Required=false)]
                public long? LocalStorageCapacity { get; set; }

                /// <summary>
                /// <para>The memory size. Unit: MiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16384</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                /// <summary>
                /// <para>Details about the metadata options.</para>
                /// </summary>
                [NameInMap("MetadataOptions")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceMetadataOptions MetadataOptions { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceMetadataOptions : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the access channel is enabled for instance metadata. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>enabled</description></item>
                    /// <item><description>disabled</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>enabled</para>
                    /// </summary>
                    [NameInMap("HttpEndpoint")]
                    [Validation(Required=false)]
                    public string HttpEndpoint { get; set; }

                    /// <summary>
                    /// <remarks>
                    /// <para> This parameter is not publicly available.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("HttpPutResponseHopLimit")]
                    [Validation(Required=false)]
                    public int? HttpPutResponseHopLimit { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the security hardening mode (IMDSv2) is forcefully used to access instance metadata. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>optional: The security hardening mode (IMDSv2) is not forcefully used.</description></item>
                    /// <item><description>required: The security hardening mode (IMDSv2) is forcefully used.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>optional</para>
                    /// </summary>
                    [NameInMap("HttpTokens")]
                    [Validation(Required=false)]
                    public string HttpTokens { get; set; }

                }

                /// <summary>
                /// <para>The ENIs attached to the instance.</para>
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
                        /// <para>The IPv4 prefixes of the ENI. This parameter has a value only when <c>AdditionalAttributes.N</c> is set to <c>NETWORK_PRIMARY_ENI_IP</c>.</para>
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
                                /// <para>The IPv4 prefix of the ENI.</para>
                                /// </summary>
                                [NameInMap("Ipv4Prefix")]
                                [Validation(Required=false)]
                                public string Ipv4Prefix { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The IPv6 prefixes of the ENI. This parameter has a value only when <c>AdditionalAttributes.N</c> is set to <c>NETWORK_PRIMARY_ENI_IP</c>.</para>
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
                                /// <para>The IPv6 prefix of the ENI.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2001:1111:<em>:</em>::/64</para>
                                /// </summary>
                                [NameInMap("Ipv6Prefix")]
                                [Validation(Required=false)]
                                public string Ipv6Prefix { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The IPv6 addresses of the ENI. This parameter has a value only when <c>AdditionalAttributes.N</c> is set to <c>NETWORK_PRIMARY_ENI_IP</c>.</para>
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
                                /// <para>The IPv6 address of the ENI.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2408:4321:180:1701:94c7:bc38:3bfa:***</para>
                                /// </summary>
                                [NameInMap("Ipv6Address")]
                                [Validation(Required=false)]
                                public string Ipv6Address { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The MAC address of the ENI.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>00:16:3e:32:b4:**</para>
                        /// </summary>
                        [NameInMap("MacAddress")]
                        [Validation(Required=false)]
                        public string MacAddress { get; set; }

                        /// <summary>
                        /// <para>The ID of the ENI.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>eni-2zeh9atclduxvf1z****</para>
                        /// </summary>
                        [NameInMap("NetworkInterfaceId")]
                        [Validation(Required=false)]
                        public string NetworkInterfaceId { get; set; }

                        /// <summary>
                        /// <para>The primary private IP address of the ENI.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><c>172.17.**.**</c>*</para>
                        /// </summary>
                        [NameInMap("PrimaryIpAddress")]
                        [Validation(Required=false)]
                        public string PrimaryIpAddress { get; set; }

                        /// <summary>
                        /// <para>The private IP addresses of the ENI.</para>
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
                                /// <para>Indicates whether the IP address is the primary private IP address. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>true</description></item>
                                /// <item><description>false</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("Primary")]
                                [Validation(Required=false)]
                                public bool? Primary { get; set; }

                                /// <summary>
                                /// <para>The private domain name of the instance.</para>
                                /// <remarks>
                                /// <para> This parameter has a value in a specific format only if <c>HostnameType</c> is set to <c>IpBased</c> or <c>InstanceIdBased</c>.</para>
                                /// </remarks>
                                /// 
                                /// <b>Example:</b>
                                /// <para>dnsTestName</para>
                                /// </summary>
                                [NameInMap("PrivateDnsName")]
                                [Validation(Required=false)]
                                public string PrivateDnsName { get; set; }

                                /// <summary>
                                /// <para>The private IP address of the ENI.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para><c>172.17.**.**</c></para>
                                /// </summary>
                                [NameInMap("PrivateIpAddress")]
                                [Validation(Required=false)]
                                public string PrivateIpAddress { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The type of the ENI. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Primary</description></item>
                        /// <item><description>Secondary</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Primary</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <para>The name of the operating system of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS 7.4 64-bit</para>
                /// </summary>
                [NameInMap("OSName")]
                [Validation(Required=false)]
                public string OSName { get; set; }

                /// <summary>
                /// <para>The English name of the operating system of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS  7.4 64 bit</para>
                /// </summary>
                [NameInMap("OSNameEn")]
                [Validation(Required=false)]
                public string OSNameEn { get; set; }

                /// <summary>
                /// <para>The type of the operating system of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>windows: Windows operating systems</description></item>
                /// <item><description>linux: Linux operating systems</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>linux</para>
                /// </summary>
                [NameInMap("OSType")]
                [Validation(Required=false)]
                public string OSType { get; set; }

                /// <summary>
                /// <para>The reasons why the instance was locked.</para>
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
                        /// <para>The message returned when the instance was locked.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The specified instance is locked due to financial reason.</para>
                        /// </summary>
                        [NameInMap("LockMsg")]
                        [Validation(Required=false)]
                        public string LockMsg { get; set; }

                        /// <summary>
                        /// <para>The reason why the instance was locked. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>financial: The instance was locked due to overdue payments.</description></item>
                        /// <item><description>security: The instance was locked due to security reasons.</description></item>
                        /// <item><description>recycling: The preemptible instance was locked and pending release.</description></item>
                        /// <item><description>dedicatedhostfinancial: The instance was locked due to overdue payments for the dedicated host.</description></item>
                        /// <item><description>refunded: The instance was locked because a refund was made for the instance.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Recycling</para>
                        /// </summary>
                        [NameInMap("LockReason")]
                        [Validation(Required=false)]
                        public string LockReason { get; set; }

                    }

                }

                /// <summary>
                /// <para>The private domain name options of the instance.</para>
                /// <para>For information about the resolution of ECS private domain names, see <a href="https://help.aliyun.com/document_detail/2844797.html">ECS private DNS resolution</a>.</para>
                /// </summary>
                [NameInMap("PrivateDnsNameOptions")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstancePrivateDnsNameOptions PrivateDnsNameOptions { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstancePrivateDnsNameOptions : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether DNS Resolution from the Instance ID-based Hostname to the Instance Primary Private IPv6 Address (AAAA Record) is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
                    /// </list>
                    /// <para>Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("EnableInstanceIdDnsAAAARecord")]
                    [Validation(Required=false)]
                    public bool? EnableInstanceIdDnsAAAARecord { get; set; }

                    /// <summary>
                    /// <para>Indicates whether DNS Resolution from the Instance ID-based Hostname to the Instance Primary Private IPv4 Address (A Record) is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
                    /// </list>
                    /// <para>Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("EnableInstanceIdDnsARecord")]
                    [Validation(Required=false)]
                    public bool? EnableInstanceIdDnsARecord { get; set; }

                    /// <summary>
                    /// <para>Indicates whether DNS Resolution from the IP Address-based Hostname to the Instance Primary Private IPv4 Address (A Record) is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
                    /// </list>
                    /// <para>Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("EnableIpDnsARecord")]
                    [Validation(Required=false)]
                    public bool? EnableIpDnsARecord { get; set; }

                    /// <summary>
                    /// <para>Indicates whether Reverse DNS Resolution from the Instance Primary Private IPv4 Address to the IP Address-based Hostname (PTR Record) is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true</description></item>
                    /// <item><description>false</description></item>
                    /// </list>
                    /// <para>Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("EnableIpDnsPtrRecord")]
                    [Validation(Required=false)]
                    public bool? EnableIpDnsPtrRecord { get; set; }

                    /// <summary>
                    /// <para>The type of hostname. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Custom: custom hostname</description></item>
                    /// <item><description>IpBased: IP address-based hostname</description></item>
                    /// <item><description>InstanceIdBased: instance ID-based hostname</description></item>
                    /// </list>
                    /// <para>Default value: Custom.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Custom</para>
                    /// </summary>
                    [NameInMap("HostnameType")]
                    [Validation(Required=false)]
                    public string HostnameType { get; set; }

                }

                /// <summary>
                /// <para>The public IP addresses of the instance.</para>
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
                /// <para>The RDMA IP addresses of the instance in the HPC cluster.</para>
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
                /// <para>Indicates whether the instance can be recycled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Recyclable")]
                [Validation(Required=false)]
                public bool? Recyclable { get; set; }

                /// <summary>
                /// <para>The region ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <remarks>
                /// <para> The parameter is removed.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>month</para>
                /// </summary>
                [NameInMap("SaleCycle")]
                [Validation(Required=false)]
                public string SaleCycle { get; set; }

                /// <summary>
                /// <para>The IDs of the security groups to which the instance belongs.</para>
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
                /// <para>The serial number of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>51d1353b-22bf-4567-a176-8b3e12e4****</para>
                /// </summary>
                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                /// <summary>
                /// <para>The protection period of the preemptible instance. Unit: hours. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: After a preemptible instance is created, Alibaba Cloud ensures that the instance is not automatically released within 1 hour. After the 1-hour protection period ends, the system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.</description></item>
                /// <item><description>0: After a preemptible instance is created, Alibaba Cloud does not ensure that the instance runs for 1 hour. The system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.</description></item>
                /// </list>
                /// <para>Alibaba Cloud sends an ECS system event to notify you 5 minutes before the instance is released. Preemptible instances are billed by second. We recommend that you specify a protection period based on your business requirements.</para>
                /// <remarks>
                /// <para> This parameter is returned when SpotStrategy is set to SpotWithPriceLimit or SpotAsPriceGo.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SpotDuration")]
                [Validation(Required=false)]
                public int? SpotDuration { get; set; }

                /// <summary>
                /// <para>The interruption mode of the preemptible instance when the system initiates a preemptible instance interruption operation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Terminate: releases the preemptible instance.</description></item>
                /// <item><description>Stop: stops the instance in economical mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Terminate</para>
                /// </summary>
                [NameInMap("SpotInterruptionBehavior")]
                [Validation(Required=false)]
                public string SpotInterruptionBehavior { get; set; }

                /// <summary>
                /// <para>The maximum hourly price of the instance. The value can be accurate to three decimal places. This parameter is valid when SpotStrategy is set to SpotWithPriceLimit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.98</para>
                /// </summary>
                [NameInMap("SpotPriceLimit")]
                [Validation(Required=false)]
                public float? SpotPriceLimit { get; set; }

                /// <summary>
                /// <para>The bidding policy for the pay-as-you-go instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NoSpot: The instance is a regular pay-as-you-go instance.</description></item>
                /// <item><description>SpotWithPriceLimit: The instance is a preemptible instance with a user-defined maximum hourly price.</description></item>
                /// <item><description>SpotAsPriceGo: The instance is a preemptible instance for which the market price is automatically used as the bid price. The market price can be up to the pay-as-you-go price.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NoSpot</para>
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// <para>The time when the instance was last started. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time is displayed in UTC. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-10T04:04Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance continues to be billed after it is stopped. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>KeepCharging: The instance is stopped in standard mode. Billing for the instance continues after the instance is stopped, and resources are retained for the instance.</description></item>
                /// <item><description>StopCharging: The instance is stopped in economical mode. Billing for some resources of the instance stops after the instance is stopped. When the instance is stopped, its resources such as vCPUs, memory, and public IP addresses are released. The instance may be unable to restart if some required resources are out of stock in the current region.</description></item>
                /// <item><description>Not-applicable: The instance does not support economical mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>KeepCharging</para>
                /// </summary>
                [NameInMap("StoppedMode")]
                [Validation(Required=false)]
                public string StoppedMode { get; set; }

                /// <summary>
                /// <para>The tags of the instance.</para>
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
                        /// <para>The tag key of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag value of the instance.</para>
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
                /// <para>The virtual LAN (VLAN) ID of the instance.</para>
                /// <remarks>
                /// <para> This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("VlanId")]
                [Validation(Required=false)]
                public string VlanId { get; set; }

                /// <summary>
                /// <para>The VPC attributes of the instance.</para>
                /// </summary>
                [NameInMap("VpcAttributes")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesInstanceVpcAttributes VpcAttributes { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceVpcAttributes : TeaModel {
                    /// <summary>
                    /// <para>The NAT IP address of the instance. The NAT IP address is used by ECS instances in different VPCs for communication.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><c>172.17.**.**</c></para>
                    /// </summary>
                    [NameInMap("NatIpAddress")]
                    [Validation(Required=false)]
                    public string NatIpAddress { get; set; }

                    /// <summary>
                    /// <para>The private IP addresses of the instance.</para>
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
                    /// <para>The ID of the vSwitch to which the instance is connected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-2zeh0r1pabwtg6wcs****</para>
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>The ID of the VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-2zeuphj08tt7q3brd****</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// <para>The zone ID of the instance.</para>
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
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instances queried.</para>
        /// <remarks>
        /// <para> If you specify the <c>MaxResults</c> and <c>NextToken</c> request parameters to perform a paged query, the value of the <c>TotalCount</c> response parameter is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
