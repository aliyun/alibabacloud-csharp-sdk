// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scaling configurations.</para>
        /// </summary>
        [NameInMap("ScalingConfigurations")]
        [Validation(Required=false)]
        public List<DescribeScalingConfigurationsResponseBodyScalingConfigurations> ScalingConfigurations { get; set; }
        public class DescribeScalingConfigurationsResponseBodyScalingConfigurations : TeaModel {
            /// <summary>
            /// <para>Indicates whether the ECS instance on a dedicated host is associated with the dedicated host. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>default: The instance is not associated with the dedicated host. If you restart an instance that was stopped in Economical Mode and the original dedicated host of the instance has insufficient resources, the instance is automatically deployed to another dedicated host in the automatic deployment resource pool.</description></item>
            /// <item><description>host: The instance is associated with the dedicated host. If you restart an instance that was stopped in Economical Mode, the instance remains on the original dedicated host. If the available resources of the original dedicated host are insufficient, the instance cannot be restarted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Affinity")]
            [Validation(Required=false)]
            public string Affinity { get; set; }

            /// <summary>
            /// <para>The number of vCPUs.</para>
            /// <para>You can specify CPU and Memory to define the range of instance types. For example, if you set CPU to 2 and Memory to 16, the instance types that have 2 vCPUs and 16 GiB are returned. If you specify CPU and Memory, Auto Scaling determines the available instance types based on factors such as I/O optimization requirements and zones and preferentially creates instances by using the lowest-priced instance type.</para>
            /// <remarks>
            /// <para> You can specify CPU and Memory to define instance types only when you set Scaling Policy to Cost Optimization and no instance type is specified in the scaling configuration.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The time at which the scaling configuration was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2014-08-14T10:58Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The performance mode of the burstable instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: the standard mode. For more information, see the &quot;Standard mode&quot; section in the <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a> topic.</description></item>
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
            /// <para>The priority of the custom ECS instance type + vSwitch combination.</para>
            /// <remarks>
            /// <para> This parameter takes effect only when Scaling Policy of the scaling group is set to Priority Policy.</para>
            /// </remarks>
            /// <para>If Auto Scaling cannot create ECS instances by using the custom ECS instance type + vSwitch combination of the highest priority, Auto Scaling creates ECS instances by using the custom ECS instance type + vSwitch combination of the next highest priority.</para>
            /// <remarks>
            /// <para> If you specify the priorities of only a portion of custom ECS instance type + vSwitch combinations, Auto Scaling preferentially creates ECS instances by using the custom combinations that have specified priorities. If the custom combinations that have specified priorities do not provide sufficient resources, Auto Scaling creates ECS instances by using the custom combinations that do not have specified priorities based on the specified orders of vSwitches and instance types.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>Example: the specified order of vSwitches for your scaling group is vsw1 and vsw2 and the specified order of instance types in your scaling configuration is type1 and type 2. In addition, you use CustomPriorities to specify [&quot;vsw2+type2&quot;, &quot;vsw1+type2&quot;]. In this example, the vsw2+type2 combination has the highest priority and the vsw2+type1 combination has the lowest priority. The vsw1+type2 combination has a higher priority than the vsw1+type1 combination.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("CustomPriorities")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsCustomPriorities> CustomPriorities { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsCustomPriorities : TeaModel {
                /// <summary>
                /// <para>The ECS instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.c6a.4xlarge</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp14zolna43z266bq****</para>
                /// </summary>
                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

            /// <summary>
            /// <para>The data disks.</para>
            /// </summary>
            [NameInMap("DataDisks")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsDataDisks> DataDisks { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsDataDisks : TeaModel {
                /// <summary>
                /// <para>The ID of the automatic snapshot policy that is applied to the data disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sp-bp19nq9enxqkomib****</para>
                /// </summary>
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                /// <summary>
                /// <para>Indicates whether the Performance Burst feature is enabled for the data disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is available only when you set <c>DataDisk.Category</c> to <c>cloud_auto</c>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// <para>The categories of the data disks. The values are sorted based on their priorities. The first value has the highest priority. If Auto Scaling cannot create instances by using the disk category of the highest priority, Auto Scaling creates instances by using the disk category of the next highest priority. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud: basic disk. DeleteWithInstance of a basic disk created along with the ECS instance is set to true.</description></item>
                /// <item><description>cloud_efficiency: ultra disk.</description></item>
                /// <item><description>cloud_ssd: standard SSD.</description></item>
                /// <item><description>cloud_essd: ESSD.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Categories")]
                [Validation(Required=false)]
                public List<string> Categories { get; set; }

                /// <summary>
                /// <para>The category of the data disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud: basic disk. DeleteWithInstance of a basic disk created along with the ECS instance is set to true.</description></item>
                /// <item><description>cloud_efficiency: ultra disk.</description></item>
                /// <item><description>cloud_ssd: standard SSD.</description></item>
                /// <item><description>ephemeral_ssd: local SSD.</description></item>
                /// <item><description>cloud_essd: ESSD.</description></item>
                /// <item><description>cloud_auto: ESSD AutoPL.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cloud</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Indicates whether the data disk is released when the instance to which the data disk is attached is released. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                /// <summary>
                /// <para>The description of the data disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The mount target of the data disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/dev/xvdb</para>
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// <para>The name of the data disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssdData</para>
                /// </summary>
                [NameInMap("DiskName")]
                [Validation(Required=false)]
                public string DiskName { get; set; }

                /// <summary>
                /// <para>Indicates whether the data disk is encrypted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// <para>Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public string Encrypted { get; set; }

                /// <summary>
                /// <para>The ID of the Key Management Service (KMS) key that is applied to the data disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                /// <summary>
                /// <para>The PL of the data disk that is an ESSD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The provisioned IOPS of the data disk.</para>
                /// <remarks>
                /// <para> IOPS measures the number of read and write operations that an Elastic Block Storage (EBS) device can process per second.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ProvisionedIops")]
                [Validation(Required=false)]
                public long? ProvisionedIops { get; set; }

                /// <summary>
                /// <para>The size of the data disk. Unit: GB. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>5 to 2000 if you set Category to cloud.</description></item>
                /// <item><description>20 to 32768 if you set Category to cloud_efficiency.</description></item>
                /// <item><description>20 to 32768 if you set Category to cloud_ssd.</description></item>
                /// <item><description>20 to 32768 if you set Category to cloud_essd.</description></item>
                /// <item><description>5 to 800 if you set Category to ephemeral_ssd.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>The ID of the snapshot based on which the data disk is created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s-23f2i****</para>
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the dedicated host cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dc-zm04u8r3lohsq****</para>
            /// </summary>
            [NameInMap("DedicatedHostClusterId")]
            [Validation(Required=false)]
            public string DedicatedHostClusterId { get; set; }

            /// <summary>
            /// <para>The ID of the dedicated host on which the ECS instance is created. Preemptible instances are not supported by dedicated hosts. Therefore, if you specify DedicatedHostId, SpotStrategy and SpotPriceLimit are ignored.</para>
            /// <para>You can call the DescribeDedicatedHosts operation to query the IDs of dedicated hosts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dh-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public string DedicatedHostId { get; set; }

            /// <summary>
            /// <para>Indicates whether Release Protection is enabled for the ECS instances. You can specify this parameter to determine whether the ECS instances can be deleted by using the ECS console or calling the DeleteInstance operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Release Protection is enabled for the ECS instances. You cannot delete the ECS instances by using the ECS console or calling the DeleteInstance operation.</description></item>
            /// <item><description>false: Release Protection is disabled for the ECS instances. You can delete the ECS instances by using the ECS console or calling the DeleteInstance operation.</description></item>
            /// </list>
            /// <remarks>
            /// <para> You can enable Release Protection for only pay-as-you-go instances to prevent unexpected instance deletion during scale-in events. The Release Protection feature does not affect normal scaling activities. In other words, an instance that meets the criteria of scale-in policies may be removed from a scaling group during a scale-in event even if you enabled Release Protection for the instance.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <para>The ID of the deployment set to which the Elastic Compute Service (ECS) instances belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp1frxuzdg87zh4p****</para>
            /// </summary>
            [NameInMap("DeploymentSetId")]
            [Validation(Required=false)]
            public string DeploymentSetId { get; set; }

            /// <summary>
            /// <para>The hostname series of the ECS instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LocalHost</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The ID of the High Performance Computing (HPC) cluster to which the ECS instances belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hpc-clus****</para>
            /// </summary>
            [NameInMap("HpcClusterId")]
            [Validation(Required=false)]
            public string HpcClusterId { get; set; }

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
            /// <para>Indicates whether the security hardening mode (IMDSv2) is forcefully used to access instance metadata. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>optional: The security hardening mode IMDSv2 is not forcibly used.</description></item>
            /// <item><description>required: The security hardening mode (IMDSv2) is forcibly used. After you set this parameter to required, you cannot access instance metadata in normal mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>optional</para>
            /// </summary>
            [NameInMap("HttpTokens")]
            [Validation(Required=false)]
            public string HttpTokens { get; set; }

            /// <summary>
            /// <para>The name of the image family. You can specify this parameter to obtain the latest available images in the current image family for instance creation. If you specify ImageId, you cannot specify <c>ImageFamily</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hangzhou-daily-update</para>
            /// </summary>
            [NameInMap("ImageFamily")]
            [Validation(Required=false)]
            public string ImageFamily { get; set; }

            /// <summary>
            /// <para>The ID of the image file that provides the image resource for Auto Scaling to create ECS instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>centos6u5_64_20G_aliaegis_2014****.vhd</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The name of the image file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>centos6u5_64_20G_aliaegis_2014****.vhd</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>Indicates whether the ecs-user username can be used to log on to an ECS instance created from the scaling configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ImageOptionsLoginAsNonRoot")]
            [Validation(Required=false)]
            public bool? ImageOptionsLoginAsNonRoot { get; set; }

            /// <summary>
            /// <para>The image source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system: a public image provided by Alibaba Cloud</description></item>
            /// <item><description>self: a custom image that you created</description></item>
            /// <item><description>others: a shared image from another Alibaba Cloud account or a community image published by another Alibaba Cloud account</description></item>
            /// <item><description>marketplace: an Alibaba Cloud Marketplace image</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("ImageOwnerAlias")]
            [Validation(Required=false)]
            public string ImageOwnerAlias { get; set; }

            /// <summary>
            /// <para>The description of the ECS instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The generation of the ECS instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs-3</para>
            /// </summary>
            [NameInMap("InstanceGeneration")]
            [Validation(Required=false)]
            public string InstanceGeneration { get; set; }

            /// <summary>
            /// <para>The naming series of the ECS instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The intelligent configuration settings, which determine the available instance types.</para>
            /// </summary>
            [NameInMap("InstancePatternInfos")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsInstancePatternInfos> InstancePatternInfos { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsInstancePatternInfos : TeaModel {
                /// <summary>
                /// <para>The architectures of instance types. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>X86: x86.</description></item>
                /// <item><description>Heterogeneous: heterogeneous computing, such as GPU-accelerated or FPGA-accelerated.</description></item>
                /// <item><description>BareMetal: ECS Bare Metal Instance.</description></item>
                /// <item><description>Arm: Arm.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Architectures")]
                [Validation(Required=false)]
                public List<string> Architectures { get; set; }

                /// <summary>
                /// <para>Indicates whether burstable instance types are included. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Exclude: Burstable instance types are not included.</description></item>
                /// <item><description>Include: Burstable instance types are included.</description></item>
                /// <item><description>Required: Only burstable instance types are included.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Include</para>
                /// </summary>
                [NameInMap("BurstablePerformance")]
                [Validation(Required=false)]
                public string BurstablePerformance { get; set; }

                /// <summary>
                /// <para>The number of vCPUs of the instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public int? Cores { get; set; }

                /// <summary>
                /// <para>The CPU architectures of the instance types. Valid values:</para>
                /// <remarks>
                /// <para> You can specify 1 to 2 CPU architectures.</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description>x86</description></item>
                /// <item><description>Arm</description></item>
                /// </list>
                /// </summary>
                [NameInMap("CpuArchitectures")]
                [Validation(Required=false)]
                public List<string> CpuArchitectures { get; set; }

                /// <summary>
                /// <para>The instance types that are excluded. You can use wildcard characters, such as an asterisk (\*), to exclude an instance type or an instance family. Examples:</para>
                /// <list type="bullet">
                /// <item><description>ecs.c6.large: The ecs.c6.large instance type is excluded.</description></item>
                /// <item><description>ecs.c6.\*: The c6 instance family is excluded.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ExcludedInstanceTypes")]
                [Validation(Required=false)]
                public List<string> ExcludedInstanceTypes { get; set; }

                /// <summary>
                /// <para>The GPU models.</para>
                /// </summary>
                [NameInMap("GpuSpecs")]
                [Validation(Required=false)]
                public List<string> GpuSpecs { get; set; }

                /// <summary>
                /// <para>The categories of ECS instances. Valid values:</para>
                /// <remarks>
                /// <para> Up to 10 categories of ECS instances are supported.</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description>General-purpose: general-purpose instance type.</description></item>
                /// <item><description>Compute-optimized: compute-optimized instance type.</description></item>
                /// <item><description>Memory-optimized: memory-optimized instance type.</description></item>
                /// <item><description>Big data: big data instance type.</description></item>
                /// <item><description>Local SSDs: instance type with local SSDs.</description></item>
                /// <item><description>High Clock Speed: instance type with high clock speeds.</description></item>
                /// <item><description>Enhanced: enhanced instance type.</description></item>
                /// <item><description>Shared: shared instance type.</description></item>
                /// <item><description>Compute-optimized with GPU: GPU-accelerated compute-optimized instance type.</description></item>
                /// <item><description>Visual Compute-optimized: visual compute-optimized instance type.</description></item>
                /// <item><description>Heterogeneous Service: heterogeneous service instance type.</description></item>
                /// <item><description>Compute-optimized with FPGA: FPGA-accelerated compute-optimized instance type.</description></item>
                /// <item><description>Compute-optimized with NPU: NPU-accelerated compute-optimized instance type.</description></item>
                /// <item><description>ECS Bare Metal: ECS Bare Metal Instance type.</description></item>
                /// <item><description>High Performance Compute: HPC-optimized instance type.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("InstanceCategories")]
                [Validation(Required=false)]
                public List<string> InstanceCategories { get; set; }

                /// <summary>
                /// <para>The level of the instance family.</para>
                /// <list type="bullet">
                /// <item><description>EntryLevel: entry level (shared instance types). Instance types of this level are the most cost-effective but may not provide stable computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared instance families</a>.</description></item>
                /// <item><description>EnterpriseLevel: enterprise level. Instance types of this level provide stable performance and dedicated resources, and are suitable for scenarios that require high stability. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>.</description></item>
                /// <item><description>CreditEntryLevel: credit entry level (burstable instance types). CPU credits are used to ensure computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low but may fluctuate in specific cases. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EnterpriseLevel</para>
                /// </summary>
                [NameInMap("InstanceFamilyLevel")]
                [Validation(Required=false)]
                public string InstanceFamilyLevel { get; set; }

                /// <summary>
                /// <para>The instance families that are queried. You can query 1 to 10 instance families in each call.</para>
                /// </summary>
                [NameInMap("InstanceTypeFamilies")]
                [Validation(Required=false)]
                public List<string> InstanceTypeFamilies { get; set; }

                /// <summary>
                /// <para>The maximum hourly price for the pay-as-you-go or preemptible instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaxPrice")]
                [Validation(Required=false)]
                public float? MaxPrice { get; set; }

                /// <summary>
                /// <para>The maximum number of vCPUs per instance type.</para>
                /// <remarks>
                /// <para> The value of MaximumCpuCoreCount cannot exceed four times the value of MinimumCpuCoreCount.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MaximumCpuCoreCount")]
                [Validation(Required=false)]
                public int? MaximumCpuCoreCount { get; set; }

                /// <summary>
                /// <para>The maximum number of GPUs per instance. The value must be a positive integer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaximumGpuAmount")]
                [Validation(Required=false)]
                public int? MaximumGpuAmount { get; set; }

                /// <summary>
                /// <para>The maximum memory size per instance. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MaximumMemorySize")]
                [Validation(Required=false)]
                public float? MaximumMemorySize { get; set; }

                /// <summary>
                /// <para>The memory size of the instance type. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

                /// <summary>
                /// <para>The baseline vCPU computing performance (overall baseline performance of all vCPUs) per t5 or t6 burstable instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("MinimumBaselineCredit")]
                [Validation(Required=false)]
                public int? MinimumBaselineCredit { get; set; }

                /// <summary>
                /// <para>The minimum number of vCPUs per instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MinimumCpuCoreCount")]
                [Validation(Required=false)]
                public int? MinimumCpuCoreCount { get; set; }

                /// <summary>
                /// <para>The minimum number of IPv6 addresses per ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinimumEniIpv6AddressQuantity")]
                [Validation(Required=false)]
                public int? MinimumEniIpv6AddressQuantity { get; set; }

                /// <summary>
                /// <para>The minimum number of IPv4 addresses per ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MinimumEniPrivateIpAddressQuantity")]
                [Validation(Required=false)]
                public int? MinimumEniPrivateIpAddressQuantity { get; set; }

                /// <summary>
                /// <para>The minimum number of elastic network interfaces (ENIs) per instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MinimumEniQuantity")]
                [Validation(Required=false)]
                public int? MinimumEniQuantity { get; set; }

                /// <summary>
                /// <para>The minimum number of GPUs per instance. The value must be a positive integer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MinimumGpuAmount")]
                [Validation(Required=false)]
                public int? MinimumGpuAmount { get; set; }

                /// <summary>
                /// <para>The initial vCPU credits per t5 or t6 burstable instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("MinimumInitialCredit")]
                [Validation(Required=false)]
                public int? MinimumInitialCredit { get; set; }

                /// <summary>
                /// <para>The minimum memory size per instance. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MinimumMemorySize")]
                [Validation(Required=false)]
                public float? MinimumMemorySize { get; set; }

                /// <summary>
                /// <para>The processor models of the instance types. You can specify 1 to 10 processor models.</para>
                /// </summary>
                [NameInMap("PhysicalProcessorModels")]
                [Validation(Required=false)]
                public List<string> PhysicalProcessorModels { get; set; }

            }

            /// <summary>
            /// <para>The instance types of the ECS instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g6.large</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The ECS instance types.</para>
            /// </summary>
            [NameInMap("InstanceTypes")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The billing method for network usage. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PayByBandwidth: pay-by-bandwidth. You are charged for the bandwidth that you specified by using InternetMaxBandwidthOut.</description></item>
            /// <item><description>PayByTraffic: pay-by-traffic. You are charged for the actual traffic that you used. InternetMaxBandwidthOut specifies only the maximum available bandwidth.</description></item>
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
            /// <para>200</para>
            /// </summary>
            [NameInMap("InternetMaxBandwidthIn")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthIn { get; set; }

            /// <summary>
            /// <para>The maximum outbound public bandwidth. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InternetMaxBandwidthOut")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>Indicates whether the ECS instances are I/O optimized. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>none: The ECS instances are not I/O optimized.</description></item>
            /// <item><description>optimized: The ECS instances are I/O optimized.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("IoOptimized")]
            [Validation(Required=false)]
            public string IoOptimized { get; set; }

            /// <summary>
            /// <para>The number of randomly generated IPv6 addresses that are allocated to the elastic network interface (ENI).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Ipv6AddressCount")]
            [Validation(Required=false)]
            public int? Ipv6AddressCount { get; set; }

            /// <summary>
            /// <para>The name of the key pair that is used to log on to an ECS instance created from the scaling configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>keypair****</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <para>The status of the scaling configuration in the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Active: The scaling configuration is active in the scaling group. Auto Scaling uses the scaling configuration that is in the Active state to create ECS instances during scale-out events.</description></item>
            /// <item><description>Inactive: The scaling configuration is inactive in the scaling group. Scaling configurations that are in the Inactive state are still contained in the scaling group, but Auto Scaling does not use the inactive scaling configurations to create ECS instances during scale-out events.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("LifecycleState")]
            [Validation(Required=false)]
            public string LifecycleState { get; set; }

            /// <summary>
            /// <para>The weight of an ECS instance as a backend server. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LoadBalancerWeight")]
            [Validation(Required=false)]
            public int? LoadBalancerWeight { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: GiB.</para>
            /// <para>You can specify CPU and Memory to define the range of instance types. For example, if you set CPU to 2 and Memory to 16, the instance types that have 2 vCPUs and 16 GiB are returned. If you specify CPU and Memory, Auto Scaling determines the available instance types based on factors such as I/O optimization requirements and zones and preferentially creates instances by using the lowest-priced instance type.</para>
            /// <remarks>
            /// <para> You can specify CPU and Memory to define instance types only when you set Scaling Policy to Cost Optimization and no instance type is specified in the scaling configuration.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <para>The ENIs.</para>
            /// </summary>
            [NameInMap("NetworkInterfaces")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsNetworkInterfaces> NetworkInterfaces { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsNetworkInterfaces : TeaModel {
                /// <summary>
                /// <para>The ENI type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Primary: the primary ENI</description></item>
                /// <item><description>Secondary: the secondary ENI</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Primary</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The number of randomly generated IPv6 addresses that are allocated to the primary ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Ipv6AddressCount")]
                [Validation(Required=false)]
                public int? Ipv6AddressCount { get; set; }

                /// <summary>
                /// <para>The communication mode of the ENI. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Standard: The TCP communication mode is used.</description></item>
                /// <item><description>HighPerformance: The Elastic RDMA Interface (ERI) is enabled and the remote direct memory access (RDMA) communication mode is used.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HighPerformance</para>
                /// </summary>
                [NameInMap("NetworkInterfaceTrafficMode")]
                [Validation(Required=false)]
                public string NetworkInterfaceTrafficMode { get; set; }

                /// <summary>
                /// <para>The IDs of the security groups to which the ENIs belong.</para>
                /// </summary>
                [NameInMap("SecurityGroupIds")]
                [Validation(Required=false)]
                public List<string> SecurityGroupIds { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the password preconfigured in the image is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PasswordInherit")]
            [Validation(Required=false)]
            public bool? PasswordInherit { get; set; }

            /// <summary>
            /// <para>Indicates whether a password is configured for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PasswordSetted")]
            [Validation(Required=false)]
            public bool? PasswordSetted { get; set; }

            [NameInMap("PrivatePoolOptions.Id")]
            [Validation(Required=false)]
            public string PrivatePoolOptions_id { get; set; }

            [NameInMap("PrivatePoolOptions.MatchCriteria")]
            [Validation(Required=false)]
            public string PrivatePoolOptions_matchCriteria { get; set; }

            /// <summary>
            /// <para>The name of the Resource Access Management (RAM) role assumed by the ECS instances. This name is provided and maintained by RAM. You can call the ListRoles operation to query the available RAM roles.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ramrole****</para>
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the ECS instances belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzn2ou7xo****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ResourcePoolOptions")]
            [Validation(Required=false)]
            public DescribeScalingConfigurationsResponseBodyScalingConfigurationsResourcePoolOptions ResourcePoolOptions { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsResourcePoolOptions : TeaModel {
                [NameInMap("PrivatePoolIds")]
                [Validation(Required=false)]
                public List<string> PrivatePoolIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PrivatePoolFirst</para>
                /// </summary>
                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public string Strategy { get; set; }

            }

            /// <summary>
            /// <para>The ID of the scaling configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asc-bp1ezrfgoyn5kijl****</para>
            /// </summary>
            [NameInMap("ScalingConfigurationId")]
            [Validation(Required=false)]
            public string ScalingConfigurationId { get; set; }

            /// <summary>
            /// <para>The name of the scaling configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>scalingconfigura****</para>
            /// </summary>
            [NameInMap("ScalingConfigurationName")]
            [Validation(Required=false)]
            public string ScalingConfigurationName { get; set; }

            /// <summary>
            /// <para>The ID of the scaling group to which the scaling configuration belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-bp17pelvl720x3v7****</para>
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in invitational preview and is not available for use.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("SchedulerOptions")]
            [Validation(Required=false)]
            public DescribeScalingConfigurationsResponseBodyScalingConfigurationsSchedulerOptions SchedulerOptions { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsSchedulerOptions : TeaModel {
                /// <summary>
                /// <remarks>
                /// <para> This parameter is in invitational preview and is not available for use.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>testManagedPrivateSpaceId</para>
                /// </summary>
                [NameInMap("ManagedPrivateSpaceId")]
                [Validation(Required=false)]
                public string ManagedPrivateSpaceId { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether Security Hardening is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Active: Security Hardening is enabled. This value is applicable to only public images.</description></item>
            /// <item><description>Deactive: Security Hardening is disabled. This value is applicable to all images.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("SecurityEnhancementStrategy")]
            [Validation(Required=false)]
            public string SecurityEnhancementStrategy { get; set; }

            /// <summary>
            /// <para>The ID of the security group to which the ECS instances belong. ECS instances that belong to the same security group can communicate with each other.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp18kz60mefs****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The IDs of the security groups to which the ECS instances belong. ECS instances that belong to the same security group can communicate with each other.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            [NameInMap("SecurityOptions")]
            [Validation(Required=false)]
            public DescribeScalingConfigurationsResponseBodyScalingConfigurationsSecurityOptions SecurityOptions { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsSecurityOptions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>TDX</para>
                /// </summary>
                [NameInMap("ConfidentialComputingMode")]
                [Validation(Required=false)]
                public string ConfidentialComputingMode { get; set; }

            }

            /// <summary>
            /// <para>The protection period of the preemptible instances. Unit: hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SpotDuration")]
            [Validation(Required=false)]
            public int? SpotDuration { get; set; }

            /// <summary>
            /// <para>The interruption event of the preemptible instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Terminate</para>
            /// </summary>
            [NameInMap("SpotInterruptionBehavior")]
            [Validation(Required=false)]
            public string SpotInterruptionBehavior { get; set; }

            /// <summary>
            /// <para>The preemptible instances.</para>
            /// </summary>
            [NameInMap("SpotPriceLimits")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsSpotPriceLimits> SpotPriceLimits { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsSpotPriceLimits : TeaModel {
                /// <summary>
                /// <para>The instance type of the preemptible instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g6.large</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The price limit of the preemptible instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.125</para>
                /// </summary>
                [NameInMap("PriceLimit")]
                [Validation(Required=false)]
                public float? PriceLimit { get; set; }

            }

            /// <summary>
            /// <para>The preemption policy that is applied to pay-as-you-go instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NoSpot: The instances are created as regular pay-as-you-go instances.</description></item>
            /// <item><description>SpotWithPriceLimit: The instances are created as preemptible instances that have a user-defined maximum hourly price.</description></item>
            /// <item><description>SpotAsPriceGo: The instances are preemptible instances for which the market price at the time of purchase is automatically used as the bid price.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>The ID of the storage set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ss-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("StorageSetId")]
            [Validation(Required=false)]
            public string StorageSetId { get; set; }

            /// <summary>
            /// <para>The maximum number of partitions in the storage set. The value is an integer that is greater than or equal to 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("StorageSetPartitionNumber")]
            [Validation(Required=false)]
            public int? StorageSetPartitionNumber { get; set; }

            /// <summary>
            /// <para>The ID of the automatic snapshot policy that is applied to the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-bp12m37ccmxvbmi5****</para>
            /// </summary>
            [NameInMap("SystemDiskAutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string SystemDiskAutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Indicates whether the Performance Burst feature is enabled for the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is available only when you set SystemDisk.Category to cloud_auto.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SystemDiskBurstingEnabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>The categories of the system disks. The values are sorted based on their priorities. The first value has the highest priority. If Auto Scaling cannot create instances by using the disk category of the highest priority, Auto Scaling creates instances by using the disk category of the next highest priority. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic disk</description></item>
            /// <item><description>cloud_efficiency: ultra disk</description></item>
            /// <item><description>cloud_ssd: standard SSD</description></item>
            /// <item><description>cloud_essd: ESSD</description></item>
            /// </list>
            /// </summary>
            [NameInMap("SystemDiskCategories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// <para>The category of the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic disk</description></item>
            /// <item><description>cloud_efficiency: ultra disk</description></item>
            /// <item><description>cloud_ssd: standard SSD</description></item>
            /// <item><description>ephemeral_ssd: local SSD</description></item>
            /// <item><description>cloud_essd: enterprise SSD (ESSD)</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The description of the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test system disk.</para>
            /// </summary>
            [NameInMap("SystemDiskDescription")]
            [Validation(Required=false)]
            public string SystemDiskDescription { get; set; }

            /// <summary>
            /// <para>The encryption algorithm that is applied to the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AES-256</description></item>
            /// <item><description>SM4-128</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AES-256</para>
            /// </summary>
            [NameInMap("SystemDiskEncryptAlgorithm")]
            [Validation(Required=false)]
            public string SystemDiskEncryptAlgorithm { get; set; }

            /// <summary>
            /// <para>Indicates whether the system disk is encrypted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SystemDiskEncrypted")]
            [Validation(Required=false)]
            public bool? SystemDiskEncrypted { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key that is applied to the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("SystemDiskKMSKeyId")]
            [Validation(Required=false)]
            public string SystemDiskKMSKeyId { get; set; }

            /// <summary>
            /// <para>The name of the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd_Test</para>
            /// </summary>
            [NameInMap("SystemDiskName")]
            [Validation(Required=false)]
            public string SystemDiskName { get; set; }

            /// <summary>
            /// <para>The performance level (PL) of the system disk that is an ESSD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("SystemDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned IOPS of the system disk.</para>
            /// <remarks>
            /// <para> IOPS measures the number of read and write operations that an EBS device can process per second.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SystemDiskProvisionedIops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsTags> Tags { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the ECS instance. You can specify up to 20 tags for each ECS instance.</para>
                /// <para>The tag key cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with <c>acs:</c> or <c>aliyun</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>binary</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the ECS instance. You can specify up to 20 tags for each ECS instance.</para>
                /// <para>The tag value can be an empty string. The tag value can be up to 128 characters in length. It cannot start with <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alterTable</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the ECS instance is created on a dedicated host. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>default: The ECS instance is created on a non-dedicated host.</description></item>
            /// <item><description>host: The ECS instance is created on a dedicated host. If you do not specify DedicatedHostId, the system selects a dedicated host for the ECS instance.</description></item>
            /// </list>
            /// <para>Default value: default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Tenancy")]
            [Validation(Required=false)]
            public string Tenancy { get; set; }

            /// <summary>
            /// <para>The user data of the ECS instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>echo hello ecs!</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>The weights of the instance types. The value of this parameter indicates the capacity of an instance of the specified instance type in the scaling group. A higher weight indicates that a smaller number of instances of the instance type are required to meet the expected capacity requirement.</para>
            /// </summary>
            [NameInMap("WeightedCapacities")]
            [Validation(Required=false)]
            public List<int?> WeightedCapacities { get; set; }

            /// <summary>
            /// <para>The ID of the zone in which the ECS instances are created. You can call the DescribeZones operation to query the zone IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-g</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The total number of scaling configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
