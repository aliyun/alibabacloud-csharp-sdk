// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
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
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The collection of scaling configuration information.</para>
        /// </summary>
        [NameInMap("ScalingConfigurations")]
        [Validation(Required=false)]
        public List<DescribeScalingConfigurationsResponseBodyScalingConfigurations> ScalingConfigurations { get; set; }
        public class DescribeScalingConfigurationsResponseBodyScalingConfigurations : TeaModel {
            /// <summary>
            /// <para>Whether the Dedicated Host instance is associated with a dedicated host. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>default: The instance is not associated with a dedicated host. If economical mode is enabled, when the instance restarts after being stopped and the original dedicated host lacks sufficient resources, the instance is placed on another dedicated host in the automatic deployment resource pool.</para>
            /// </description></item>
            /// <item><description><para>host: The instance is associated with a dedicated host. If economical mode is enabled, when the instance restarts after being stopped, it remains on the original dedicated host. If the original dedicated host lacks sufficient resources, the instance fails to restart.</para>
            /// </description></item>
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
            /// <para>Specifying both CPU and Memory defines a range of instance types. For example, CPU=2 and Memory=16 defines all instance types with 2 vCPUs and 16 GiB memory. Auto Scaling determines available instance types based on I/O optimization, zone, and other factors, then creates the lowest-priced instance according to price sorting.</para>
            /// <remarks>
            /// <para>This range-based configuration takes effect only in cost optimization mode when no instance type is specified in the scaling configuration.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>CPU options.</para>
            /// </summary>
            [NameInMap("CpuOptions")]
            [Validation(Required=false)]
            public DescribeScalingConfigurationsResponseBodyScalingConfigurationsCpuOptions CpuOptions { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsCpuOptions : TeaModel {
                /// <summary>
                /// <para>Nested virtualization, whether to enable hardware-based nested virtualization. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>enabled: Enabled.</para>
                /// </description></item>
                /// <item><description><para>disabled: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("NestedVirtualization")]
                [Validation(Required=false)]
                public string NestedVirtualization { get; set; }

            }

            /// <summary>
            /// <para>The creation time of the scaling configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2014-08-14T10:58Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The operating mode for burstable instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Standard: Standard mode. For performance details, see the Performance-constrained mode section in <a href="https://help.aliyun.com/document_detail/59977.html">What are burstable instances?</a></para>
            /// </description></item>
            /// <item><description><para>Unlimited: Unlimited mode. For performance details, see the Unlimited mode section in <a href="https://help.aliyun.com/document_detail/59977.html">What are burstable instances?</a></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("CreditSpecification")]
            [Validation(Required=false)]
            public string CreditSpecification { get; set; }

            /// <summary>
            /// <para>The custom priority for ECS instance type plus vSwitch combinations.</para>
            /// <remarks>
            /// <para>Notice: This parameter takes effect only when the scaling group\&quot;s scaling policy is set to priority-based.</para>
            /// </remarks>
            /// <para>If Auto Scaling cannot create an instance using a higher-priority instance type plus vSwitch combination, it automatically tries the next priority combination.</para>
            /// <remarks>
            /// <para>If you specify custom priorities for only some instance type plus vSwitch combinations, unspecified combinations have lower priority. Among unspecified combinations, priority follows the scaling group\&quot;s vSwitch order and the scaling configuration\&quot;s instance type order.</para>
            /// <list type="bullet">
            /// <item><description>Example: Scaling group vSwitch order is vsw1, vsw2. Scaling configuration instance type order is type1, type2. Custom priority order is [&quot;vsw2+type2&quot;, &quot;vsw1+type2&quot;]. Final priority order is: &quot;vsw2+type2&quot; &gt; &quot;vsw1+type2&quot; &gt; &quot;vsw1+type1&quot; &gt; &quot;vsw2+type1&quot;.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("CustomPriorities")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsCustomPriorities> CustomPriorities { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsCustomPriorities : TeaModel {
                /// <summary>
                /// <para>The instance type of the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.c6a.4xlarge</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The ID of the virtual switch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp14zolna43z266bq****</para>
                /// </summary>
                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

            /// <summary>
            /// <para>The collection of data disk information.</para>
            /// </summary>
            [NameInMap("DataDisks")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsDataDisks> DataDisks { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsDataDisks : TeaModel {
                /// <summary>
                /// <para>The ID of the automatic snapshot policy applied to the data disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sp-bp19nq9enxqkomib****</para>
                /// </summary>
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                /// <summary>
                /// <para>Whether Burst (performance burst) is enabled for the data disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Enabled.</para>
                /// </description></item>
                /// <item><description><para>false: Disabled.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter appears only when <c>DataDisk.Category</c> is <c>cloud_auto</c>.</para>
                /// </remarks>
                /// <para>&lt;props=&quot;china&quot;&gt;</para>
                /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// <para>Multiple disk categories for the data disk. The first disk category has the highest priority, followed by others in descending order. If Auto Scaling cannot use a higher-priority disk category, it automatically tries the next priority category to create the data disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>cloud: basic disk. Basic disks created with an instance have DeleteWithInstance set to true.</para>
                /// </description></item>
                /// <item><description><para>cloud_efficiency: ultra disk.</para>
                /// </description></item>
                /// <item><description><para>cloud_ssd: standard SSD.</para>
                /// </description></item>
                /// <item><description><para>cloud_essd: ESSD.</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("Categories")]
                [Validation(Required=false)]
                public List<string> Categories { get; set; }

                /// <summary>
                /// <para>The disk category of the data disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>cloud: basic disk. Basic disks created with an instance have DeleteWithInstance set to true.</para>
                /// </description></item>
                /// <item><description><para>cloud_efficiency: ultra disk.</para>
                /// </description></item>
                /// <item><description><para>cloud_ssd: standard SSD.</para>
                /// </description></item>
                /// <item><description><para>ephemeral_ssd: local SSD.</para>
                /// </description></item>
                /// <item><description><para>cloud_essd: ESSD.</para>
                /// </description></item>
                /// <item><description><para>cloud_auto: ESSD AutoPL.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cloud</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Whether to release the data disk when releasing the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Release the disk along with the instance.</para>
                /// </description></item>
                /// <item><description><para>false: Keep the disk when releasing the instance.</para>
                /// </description></item>
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
                /// <para>Whether the data disk is encrypted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Encrypted.</para>
                /// </description></item>
                /// <item><description><para>false: Not encrypted.</para>
                /// </description></item>
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
                /// <para>The KMS key ID corresponding to the data disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                /// <summary>
                /// <para>The performance level of the ESSD data disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The provisioned IOPS (Input/Output Operations Per Second) performance metric for the data disk.</para>
                /// <remarks>
                /// <para>IOPS (Input/Output Operations Per Second) measures the number of I/O operations per second, indicating block storage read/write capability. Unit: operations.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ProvisionedIops")]
                [Validation(Required=false)]
                public long? ProvisionedIops { get; set; }

                /// <summary>
                /// <para>The size of the data disk. Unit: GiB. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>cloud: 5–2000.</para>
                /// </description></item>
                /// <item><description><para>cloud_efficiency: 20–32768.</para>
                /// </description></item>
                /// <item><description><para>cloud_ssd: 20–32768.</para>
                /// </description></item>
                /// <item><description><para>cloud_essd: 20–32768.</para>
                /// </description></item>
                /// <item><description><para>ephemeral_ssd: 5–800.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>The snapshot ID used to create the data disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s-23f2i****</para>
                /// </summary>
                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

            }

            /// <summary>
            /// <para>The dedicated host cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dc-zm04u8r3lohsq****</para>
            /// </summary>
            [NameInMap("DedicatedHostClusterId")]
            [Validation(Required=false)]
            public string DedicatedHostClusterId { get; set; }

            /// <summary>
            /// <para>Whether to create the ECS instance on a Dedicated Host. Since Dedicated Hosts do not support spot instances, specifying DedicatedHostId automatically ignores SpotStrategy and SpotPriceLimit settings in the request.</para>
            /// <para>You can call the DescribeDedicatedHosts API to query the list of Dedicated Host IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dh-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public string DedicatedHostId { get; set; }

            /// <summary>
            /// <para>The instance release protection attribute, specifying whether the instance can be directly released through the ECS console or API (DeleteInstance). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enable instance release protection. The instance cannot be directly released through the ECS console or API (DeleteInstance).</para>
            /// </description></item>
            /// <item><description><para>false: Disable instance release protection. The instance can be directly released through the ECS console or API (DeleteInstance).</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This attribute applies only to pay-as-you-go instances to prevent accidental deletion of instances scaled out by Auto Scaling. It does not affect normal scale-in activities. Instances with release protection enabled can still be released during scale-in activities.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <para>The ID of the deployment set to which the ECS instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-bp1frxuzdg87zh4p****</para>
            /// </summary>
            [NameInMap("DeploymentSetId")]
            [Validation(Required=false)]
            public string DeploymentSetId { get; set; }

            /// <summary>
            /// <para>The hostname of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LocalHost</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The ID of the HPC cluster to which the ECS instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hpc-clus****</para>
            /// </summary>
            [NameInMap("HpcClusterId")]
            [Validation(Required=false)]
            public string HpcClusterId { get; set; }

            /// <summary>
            /// <para>Whether to enable the instance metadata access channel. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>enabled: Enabled.</para>
            /// </description></item>
            /// <item><description><para>disabled: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("HttpEndpoint")]
            [Validation(Required=false)]
            public string HttpEndpoint { get; set; }

            /// <summary>
            /// <para>Whether to enforce hardened mode (IMDSv2) when accessing instance metadata. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>optional: Do not enforce.</para>
            /// </description></item>
            /// <item><description><para>required: Enforce. When set, standard mode cannot access instance metadata.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>optional</para>
            /// </summary>
            [NameInMap("HttpTokens")]
            [Validation(Required=false)]
            public string HttpTokens { get; set; }

            /// <summary>
            /// <para>The image family name. Setting this parameter retrieves the latest available image within the specified image family for instance creation. If ImageId is already set, do not set this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hangzhou-daily-update</para>
            /// </summary>
            [NameInMap("ImageFamily")]
            [Validation(Required=false)]
            public string ImageFamily { get; set; }

            /// <summary>
            /// <para>The image file ID used as the image resource for automatic instance creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>centos6u5_64_20G_aliaegis_2014****.vhd</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>centos6u5_64_20G_aliaegis_2014****.vhd</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>Whether the ECS instance uses the ecs-user account to log on. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Yes.</para>
            /// </description></item>
            /// <item><description><para>false: No.</para>
            /// </description></item>
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
            /// <item><description><para>system: Public images provided by Alibaba Cloud.</para>
            /// </description></item>
            /// <item><description><para>self: Custom images you created.</para>
            /// </description></item>
            /// <item><description><para>others: Shared or community images provided by other Alibaba Cloud users.</para>
            /// </description></item>
            /// <item><description><para>marketplace: Images provided by Alibaba Cloud Marketplace.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("ImageOwnerAlias")]
            [Validation(Required=false)]
            public string ImageOwnerAlias { get; set; }

            /// <summary>
            /// <para>The description of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The series of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs-3</para>
            /// </summary>
            [NameInMap("InstanceGeneration")]
            [Validation(Required=false)]
            public string InstanceGeneration { get; set; }

            /// <summary>
            /// <para>The name of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The collection of intelligent configuration information used to filter eligible instance type ranges.</para>
            /// </summary>
            [NameInMap("InstancePatternInfos")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsInstancePatternInfos> InstancePatternInfos { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsInstancePatternInfos : TeaModel {
                /// <summary>
                /// <para>The architecture type of the instance type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>X86: X86 compute.</para>
                /// </description></item>
                /// <item><description><para>Heterogeneous: Heterogeneous compute, such as GPU or FPGA.</para>
                /// </description></item>
                /// <item><description><para>BareMetal: ECS Bare Metal Instance.</para>
                /// </description></item>
                /// <item><description><para>Arm: Arm compute.</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("Architectures")]
                [Validation(Required=false)]
                public List<string> Architectures { get; set; }

                /// <summary>
                /// <para>Whether the instance type supports performance burst. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Exclude: Exclude burstable instance types.</para>
                /// </description></item>
                /// <item><description><para>Include: Include burstable instance types.</para>
                /// </description></item>
                /// <item><description><para>Required: Include only burstable instance types.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Include</para>
                /// </summary>
                [NameInMap("BurstablePerformance")]
                [Validation(Required=false)]
                public string BurstablePerformance { get; set; }

                /// <summary>
                /// <para>The number of vCPU cores for the instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public int? Cores { get; set; }

                /// <summary>
                /// <para>The CPU architecture of the instance type. Valid values:</para>
                /// <remarks>
                /// <para>N indicates multiple CPU architectures can be specified. N ranges from 1 to 2.</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>X86.</para>
                /// </description></item>
                /// <item><description><para>ARM.</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("CpuArchitectures")]
                [Validation(Required=false)]
                public List<string> CpuArchitectures { get; set; }

                /// <summary>
                /// <para>The instance types to exclude. Use wildcard characters (\*) to exclude a single instance type or an entire instance family. Examples:</para>
                /// <list type="bullet">
                /// <item><description><para>ecs.c6.large: Excludes the ecs.c6.large instance type.</para>
                /// </description></item>
                /// <item><description><para>ecs.c6.\*: Excludes all instance types in the c6 family.</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("ExcludedInstanceTypes")]
                [Validation(Required=false)]
                public List<string> ExcludedInstanceTypes { get; set; }

                /// <summary>
                /// <para>GPU types.</para>
                /// </summary>
                [NameInMap("GpuSpecs")]
                [Validation(Required=false)]
                public List<string> GpuSpecs { get; set; }

                /// <summary>
                /// <para>Instance categories. Valid values:</para>
                /// <remarks>
                /// <para>N indicates multiple instance categories can be specified. N ranges from 1 to 10.</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>General-purpose: General-purpose.</para>
                /// </description></item>
                /// <item><description><para>Compute-optimized: Compute-optimized.</para>
                /// </description></item>
                /// <item><description><para>Memory-optimized: Memory-optimized.</para>
                /// </description></item>
                /// <item><description><para>Big data: Big data.</para>
                /// </description></item>
                /// <item><description><para>Local SSDs: Local SSD.</para>
                /// </description></item>
                /// <item><description><para>High Clock Speed: High frequency.</para>
                /// </description></item>
                /// <item><description><para>Enhanced: Enhanced.</para>
                /// </description></item>
                /// <item><description><para>Shared: Shared-resource.</para>
                /// </description></item>
                /// <item><description><para>Compute-optimized with GPU: GPU.</para>
                /// </description></item>
                /// <item><description><para>Visual Compute-optimized: Visual compute.</para>
                /// </description></item>
                /// <item><description><para>Heterogeneous Service: Heterogeneous computing.</para>
                /// </description></item>
                /// <item><description><para>Compute-optimized with FPGA: FPGA.</para>
                /// </description></item>
                /// <item><description><para>Compute-optimized with NPU: NPU.</para>
                /// </description></item>
                /// <item><description><para>ECS Bare Metal: ECS Bare Metal Instance.</para>
                /// </description></item>
                /// <item><description><para>High Performance Compute: High-performance computing (HPC).</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("InstanceCategories")]
                [Validation(Required=false)]
                public List<string> InstanceCategories { get; set; }

                /// <summary>
                /// <para>The instance family level.</para>
                /// <list type="bullet">
                /// <item><description><para>EntryLevel: Entry-level, i.e., shared-resource instances. Lower cost but cannot guarantee stable compute performance. Suitable for workloads with low average CPU usage. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared-resource instances</a>.</para>
                /// </description></item>
                /// <item><description><para>EnterpriseLevel: Enterprise-level. Stable performance with dedicated resources. Suitable for workloads requiring high stability. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
                /// </description></item>
                /// <item><description><para>CreditEntryLevel: Credit entry-level, i.e., burstable instances. Uses CPU credits to ensure compute performance. Suitable for workloads with low average CPU usage and occasional bursts. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Burstable instances</a>.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EnterpriseLevel</para>
                /// </summary>
                [NameInMap("InstanceFamilyLevel")]
                [Validation(Required=false)]
                public string InstanceFamilyLevel { get; set; }

                /// <summary>
                /// <para>The instance families to query. N indicates multiple instance families can be specified. N ranges from 1 to 10.</para>
                /// </summary>
                [NameInMap("InstanceTypeFamilies")]
                [Validation(Required=false)]
                public List<string> InstanceTypeFamilies { get; set; }

                /// <summary>
                /// <para>The maximum hourly price acceptable for pay-as-you-go or spot instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaxPrice")]
                [Validation(Required=false)]
                public float? MaxPrice { get; set; }

                /// <summary>
                /// <para>The maximum number of vCPU cores for the instance type.</para>
                /// <remarks>
                /// <para>MaximumCpuCoreCount cannot exceed four times MinimumCpuCoreCount.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MaximumCpuCoreCount")]
                [Validation(Required=false)]
                public int? MaximumCpuCoreCount { get; set; }

                /// <summary>
                /// <para>The maximum number of GPUs. Valid values: positive integers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaximumGpuAmount")]
                [Validation(Required=false)]
                public int? MaximumGpuAmount { get; set; }

                /// <summary>
                /// <para>The maximum memory size. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MaximumMemorySize")]
                [Validation(Required=false)]
                public float? MaximumMemorySize { get; set; }

                /// <summary>
                /// <para>The memory size for the instance type. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

                /// <summary>
                /// <para>The minimum baseline vCPU compute performance (sum of all vCPUs) for burstable instances t5 and t6.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("MinimumBaselineCredit")]
                [Validation(Required=false)]
                public int? MinimumBaselineCredit { get; set; }

                /// <summary>
                /// <para>The minimum number of vCPU cores for the instance type.</para>
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
                /// <para>The minimum number of elastic network interfaces (ENIs) that the instance type supports attaching.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MinimumEniQuantity")]
                [Validation(Required=false)]
                public int? MinimumEniQuantity { get; set; }

                /// <summary>
                /// <para>The minimum number of GPUs. Valid values: positive integers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MinimumGpuAmount")]
                [Validation(Required=false)]
                public int? MinimumGpuAmount { get; set; }

                /// <summary>
                /// <para>The minimum initial vCPU credit for burstable instances t5 and t6.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("MinimumInitialCredit")]
                [Validation(Required=false)]
                public int? MinimumInitialCredit { get; set; }

                /// <summary>
                /// <para>The minimum memory size. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MinimumMemorySize")]
                [Validation(Required=false)]
                public float? MinimumMemorySize { get; set; }

                /// <summary>
                /// <para>The processor models of the instance. N indicates multiple processor models can be specified. N ranges from 1 to 10.</para>
                /// </summary>
                [NameInMap("PhysicalProcessorModels")]
                [Validation(Required=false)]
                public List<string> PhysicalProcessorModels { get; set; }

            }

            /// <summary>
            /// <para>The instance type of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g6.large</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>When alternative mode is enabled, if issues like inventory shortages occur, similar instance types of the same size are supplemented based on the currently selected instance type, or switches in alternative zones are created and added to the scaling group.</para>
            /// </summary>
            [NameInMap("InstanceTypeCandidateOptions")]
            [Validation(Required=false)]
            public DescribeScalingConfigurationsResponseBodyScalingConfigurationsInstanceTypeCandidateOptions InstanceTypeCandidateOptions { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsInstanceTypeCandidateOptions : TeaModel {
                /// <summary>
                /// <para>When supplementing switches in other zones, specify the CIDR blocks for eligible switches.</para>
                /// </summary>
                [NameInMap("AllowCidrBlocks")]
                [Validation(Required=false)]
                public List<string> AllowCidrBlocks { get; set; }

                /// <summary>
                /// <para>Indicates whether ESS can add vSwitches from other zones.</para>
                /// <remarks>
                /// <para>The instance type remains unchanged. Only alternative zones are considered. If all selected zones in the scaling group cannot scale out due to inventory shortages or similar issues, ESS automatically adds a vSwitch from a new zone to the scaling group based on this setting.
                /// For example, if the scaling group is configured with zones cn-hangzhou-h and cn-hangzhou-g, and neither zone can scale out, ESS might create a vSwitch in zone cn-hangzhou-k based on real-time inventory availability and add it to the scaling group.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowCrossAz")]
                [Validation(Required=false)]
                public bool? AllowCrossAz { get; set; }

                /// <summary>
                /// <para>Whether to allow supplementing instance types from different generations.</para>
                /// <list type="bullet">
                /// <item><description>For example, if the current type is ecs.c7.large, enabling this allows alternatives like ecs.c6.large and ecs.c8.large.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowDifferentGeneration")]
                [Validation(Required=false)]
                public bool? AllowDifferentGeneration { get; set; }

                /// <summary>
                /// <para>Whether to enable alternative mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The price cap for alternative instance types.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaxPrice")]
                [Validation(Required=false)]
                public float? MaxPrice { get; set; }

            }

            /// <summary>
            /// <para>The collection of ECS instance types.</para>
            /// </summary>
            [NameInMap("InstanceTypes")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The network billing type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PayByBandwidth: Pay-by-bandwidth. InternetMaxBandwidthOut is the fixed bandwidth value.</para>
            /// </description></item>
            /// <item><description><para>PayByTraffic: Pay-by-data-transfer. InternetMaxBandwidthOut is only a bandwidth cap. Billing is based on actual network traffic.</para>
            /// </description></item>
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
            /// <para>10</para>
            /// </summary>
            [NameInMap("InternetMaxBandwidthIn")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthIn { get; set; }

            /// <summary>
            /// <para>The maximum outbound public bandwidth. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InternetMaxBandwidthOut")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <para>Whether the instance is I/O optimized. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>none: Not I/O optimized.</para>
            /// </description></item>
            /// <item><description><para>optimized: I/O optimized.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("IoOptimized")]
            [Validation(Required=false)]
            public string IoOptimized { get; set; }

            /// <summary>
            /// <para>The number of randomly generated IPv6 addresses assigned to the elastic network interface.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Ipv6AddressCount")]
            [Validation(Required=false)]
            public int? Ipv6AddressCount { get; set; }

            /// <summary>
            /// <para>The name of the key pair used to log on to the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>keypair****</para>
            /// </summary>
            [NameInMap("KeyPairName")]
            [Validation(Required=false)]
            public string KeyPairName { get; set; }

            /// <summary>
            /// <para>The status of the scaling configuration within the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Active: The scaling configuration is active. The scaling group uses active scaling configurations to automatically create ECS instances.</para>
            /// </description></item>
            /// <item><description><para>Inactive: The scaling configuration is inactive. Inactive scaling configurations exist in the scaling group but are not used to automatically create ECS instances.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("LifecycleState")]
            [Validation(Required=false)]
            public string LifecycleState { get; set; }

            /// <summary>
            /// <para>The weight of the ECS instance as a backend server. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LoadBalancerWeight")]
            [Validation(Required=false)]
            public int? LoadBalancerWeight { get; set; }

            /// <summary>
            /// <para>Memory size. Unit: GiB.</para>
            /// <para>Specifying both CPU and Memory defines a range of instance types. For example, CPU=2 and Memory=16 defines all instance types with 2 vCPUs and 16 GiB memory. Auto Scaling determines available instance types based on I/O optimization, zone, and other factors, then creates the lowest-priced instance according to price sorting.</para>
            /// <remarks>
            /// <para>This range-based configuration takes effect only in cost optimization mode when no instance type is specified in the scaling configuration.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <para>The list of elastic network interfaces.</para>
            /// </summary>
            [NameInMap("NetworkInterfaces")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsNetworkInterfaces> NetworkInterfaces { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsNetworkInterfaces : TeaModel {
                /// <summary>
                /// <para>The elastic network interface type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Primary: Primary network interface.</para>
                /// </description></item>
                /// <item><description><para>Secondary: Secondary elastic network interface.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Primary</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The number of randomly generated IPv6 addresses assigned to the primary network interface.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Ipv6AddressCount")]
                [Validation(Required=false)]
                public int? Ipv6AddressCount { get; set; }

                /// <summary>
                /// <para>The communication mode of the elastic network interface. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Standard: Uses TCP communication mode.</para>
                /// </description></item>
                /// <item><description><para>HighPerformance: Enables ERI (Elastic RDMA Interface) and uses RDMA communication mode.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HighPerformance</para>
                /// </summary>
                [NameInMap("NetworkInterfaceTrafficMode")]
                [Validation(Required=false)]
                public string NetworkInterfaceTrafficMode { get; set; }

                /// <summary>
                /// <para>The number of secondary private IPv4 addresses assigned to the network interface. Valid values: 1–49.</para>
                /// <list type="bullet">
                /// <item><description><para>The value cannot exceed the IP address limit for the instance type. For more information, see <a href="https://help.aliyun.com/zh/ecs/user-guide/overview-of-instance-families">Instance families</a>.</para>
                /// </description></item>
                /// <item><description><para>NetworkInterface.N.SecondaryPrivateIpAddressCount assigns secondary private IPv4 addresses (excluding the primary private IP) to the network interface. The system randomly assigns addresses from the available CIDR block of the virtual switch (NetworkInterface.N.VSwitchId).</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("SecondaryPrivateIpAddressCount")]
                [Validation(Required=false)]
                public int? SecondaryPrivateIpAddressCount { get; set; }

                /// <summary>
                /// <para>The IDs of one or more security groups to which the elastic network interface belongs.</para>
                /// </summary>
                [NameInMap("SecurityGroupIds")]
                [Validation(Required=false)]
                public List<string> SecurityGroupIds { get; set; }

            }

            /// <summary>
            /// <para>Whether to use the password preset in the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PasswordInherit")]
            [Validation(Required=false)]
            public bool? PasswordInherit { get; set; }

            /// <summary>
            /// <para>Whether to set an instance password. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Set instance password.</para>
            /// </description></item>
            /// <item><description><para>false: Do not set instance password.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PasswordSetted")]
            [Validation(Required=false)]
            public bool? PasswordSetted { get; set; }

            /// <summary>
            /// <para>The private pool ID. This is either the elastic provisioning service ID or the capacity reservation service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eap-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("PrivatePoolOptions.Id")]
            [Validation(Required=false)]
            public string PrivatePoolOptions_id { get; set; }

            /// <summary>
            /// <para>The private pool capacity option for instance startup. After elastic provisioning or capacity reservation services take effect, they generate private pool capacity for instance startup selection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Open: Open mode. Automatically matches open-type private pool capacity. If no matching private pool capacity exists, uses public pool resources to start the instance.</para>
            /// </description></item>
            /// <item><description><para>Target: Target mode. Starts the instance using the specified private pool capacity. If that capacity is unavailable, the instance fails to start.</para>
            /// </description></item>
            /// <item><description><para>None: Do not use mode. Instance startup does not use private pool capacity.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Open</para>
            /// </summary>
            [NameInMap("PrivatePoolOptions.MatchCriteria")]
            [Validation(Required=false)]
            public string PrivatePoolOptions_matchCriteria { get; set; }

            /// <summary>
            /// <para>The RAM role name of the ECS instance. RAM role names are provided and maintained by RAM. You can call ListRoles to query available RAM roles.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ramrole****</para>
            /// </summary>
            [NameInMap("RamRoleName")]
            [Validation(Required=false)]
            public string RamRoleName { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the ECS instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzn2ou7xo****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The resource pool strategy used when creating instances.</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when creating pay-as-you-go instances.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ResourcePoolOptions")]
            [Validation(Required=false)]
            public DescribeScalingConfigurationsResponseBodyScalingConfigurationsResourcePoolOptions ResourcePoolOptions { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsResourcePoolOptions : TeaModel {
                /// <summary>
                /// <para>The private pool ID. This is either the elastic provisioning service ID or the capacity reservation service ID.</para>
                /// </summary>
                [NameInMap("PrivatePoolIds")]
                [Validation(Required=false)]
                public List<string> PrivatePoolIds { get; set; }

                /// <summary>
                /// <para>Filters available Target private pools by tag.</para>
                /// </summary>
                [NameInMap("PrivatePoolTags")]
                [Validation(Required=false)]
                public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsResourcePoolOptionsPrivatePoolTags> PrivatePoolTags { get; set; }
                public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsResourcePoolOptionsPrivatePoolTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key of the private pool.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestKey</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value of the private pool.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestValue</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Resource pools include private pools generated after elastic provisioning or capacity reservation services take effect, along with public pools, for instance startup selection. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>PrivatePoolFirst: Private pool first. With this strategy, if ResourcePoolOptions.PrivatePoolIds is specified or PrivatePoolTags conditions are met, the corresponding private pool is prioritized. If no private pool is specified or the specified private pool lacks capacity, open-type private pools are automatically matched. If no matching private pool exists, public pool resources are used.</para>
                /// </description></item>
                /// <item><description><para>PrivatePoolOnly: Private pool only. With this strategy, ResourcePoolOptions.PrivatePoolIds must be specified. If the specified private pool lacks capacity, the instance fails to start.</para>
                /// </description></item>
                /// <item><description><para>PublicPoolFirst: Public pool first. Public pool resources are prioritized for instance creation. If public pool resources are insufficient, private pool resources supplement them. Open-type private pools are automatically matched first. If no matching private pool exists, specified ResourcePoolOptions.PrivatePoolIds or Target-type private pools meeting PrivatePoolTags conditions are used.</para>
                /// </description></item>
                /// <item><description><para>None: Do not use resource pool strategy.</para>
                /// </description></item>
                /// </list>
                /// 
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
            /// <para>This parameter is in invitational preview and is not yet available for general use.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("SchedulerOptions")]
            [Validation(Required=false)]
            public DescribeScalingConfigurationsResponseBodyScalingConfigurationsSchedulerOptions SchedulerOptions { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsSchedulerOptions : TeaModel {
                /// <summary>
                /// <remarks>
                /// <para>This parameter is in invitational preview and is not yet available for general use.</para>
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
            /// <para>Whether to enable security hardening. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Active: Enable security hardening. Applies only to public images.</para>
            /// </description></item>
            /// <item><description><para>Deactive: Disable security hardening. Applies to all image types.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("SecurityEnhancementStrategy")]
            [Validation(Required=false)]
            public string SecurityEnhancementStrategy { get; set; }

            /// <summary>
            /// <para>The ID of the security group to which the ECS instance belongs. ECS instances in the same security group can access each other.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp18kz60mefs****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The IDs of multiple security groups to which the ECS instance belongs. ECS instances in the same security group can access each other.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>Security options.</para>
            /// </summary>
            [NameInMap("SecurityOptions")]
            [Validation(Required=false)]
            public DescribeScalingConfigurationsResponseBodyScalingConfigurationsSecurityOptions SecurityOptions { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsSecurityOptions : TeaModel {
                /// <summary>
                /// <para>The confidential computing mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Enclave: The ECS instance uses Enclave to build a confidential computing environment. For more information, see <a href="https://help.aliyun.com/document_detail/203433.html">Use Enclave to build a confidential computing environment</a>.</para>
                /// </description></item>
                /// <item><description><para>TDX: Builds a TDX confidential computing environment. For more information, see <a href="https://help.aliyun.com/document_detail/479090.html">Build a TDX confidential computing environment</a>.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TDX</para>
                /// </summary>
                [NameInMap("ConfidentialComputingMode")]
                [Validation(Required=false)]
                public string ConfidentialComputingMode { get; set; }

            }

            /// <summary>
            /// <para>The reserved duration for the spot instance. Unit: hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SpotDuration")]
            [Validation(Required=false)]
            public int? SpotDuration { get; set; }

            /// <summary>
            /// <para>The interruption mode for spot instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Terminate</para>
            /// </summary>
            [NameInMap("SpotInterruptionBehavior")]
            [Validation(Required=false)]
            public string SpotInterruptionBehavior { get; set; }

            /// <summary>
            /// <para>The collection of spot instance information.</para>
            /// </summary>
            [NameInMap("SpotPriceLimits")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsSpotPriceLimits> SpotPriceLimits { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsSpotPriceLimits : TeaModel {
                /// <summary>
                /// <para>The instance type of the spot instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g6.large</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The bid price for the spot instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.125</para>
                /// </summary>
                [NameInMap("PriceLimit")]
                [Validation(Required=false)]
                public float? PriceLimit { get; set; }

            }

            /// <summary>
            /// <para>The preemption policy for pay-as-you-go instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>NoSpot: standard pay-as-you-go instance.</para>
            /// </description></item>
            /// <item><description><para>SpotWithPriceLimit: spot instance with a maximum price limit.</para>
            /// </description></item>
            /// <item><description><para>SpotAsPriceGo: system automatically bids based on current market price.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoSpot</para>
            /// </summary>
            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            /// <summary>
            /// <para>The storage set ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ss-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("StorageSetId")]
            [Validation(Required=false)]
            public string StorageSetId { get; set; }

            /// <summary>
            /// <para>The maximum number of partitions in the storage set. Value must be an integer greater than or equal to 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("StorageSetPartitionNumber")]
            [Validation(Required=false)]
            public int? StorageSetPartitionNumber { get; set; }

            /// <summary>
            /// <para>The ID of the automatic snapshot policy applied to the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-bp12m37ccmxvbmi5****</para>
            /// </summary>
            [NameInMap("SystemDiskAutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string SystemDiskAutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Whether Burst (performance burst) is enabled for the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported only when SystemDisk.Category is cloud_auto.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SystemDiskBurstingEnabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>Multiple disk categories for the system disk. The first disk category has the highest priority, followed by others in descending order. If Auto Scaling cannot use a higher-priority disk category, it automatically tries the next priority category to create the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>cloud: basic disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_efficiency: ultra disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_ssd: standard SSD.</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: ESSD.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("SystemDiskCategories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// <para>The disk category of the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>cloud: basic disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_efficiency: ultra disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_ssd: standard SSD.</para>
            /// </description></item>
            /// <item><description><para>ephemeral_ssd: local SSD.</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: ESSD.</para>
            /// </description></item>
            /// <item><description><para>cloud_auto: ESSD AutoPL.</para>
            /// </description></item>
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
            /// <para>The encryption algorithm used for the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>AES-256.</para>
            /// </description></item>
            /// <item><description><para>SM4-128.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AES-256</para>
            /// </summary>
            [NameInMap("SystemDiskEncryptAlgorithm")]
            [Validation(Required=false)]
            public string SystemDiskEncryptAlgorithm { get; set; }

            /// <summary>
            /// <para>Whether the system disk is encrypted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Encrypted.</para>
            /// </description></item>
            /// <item><description><para>false: Not encrypted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SystemDiskEncrypted")]
            [Validation(Required=false)]
            public bool? SystemDiskEncrypted { get; set; }

            /// <summary>
            /// <para>The KMS key ID used for the system disk.</para>
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
            /// <para>The performance level of the ESSD system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("SystemDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned IOPS (Input/Output Operations Per Second) performance metric for the system disk.</para>
            /// <remarks>
            /// <para>IOPS (Input/Output Operations Per Second) measures the number of I/O operations per second, indicating block storage read/write capability. Unit: operations.</para>
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
            /// <para>The collection of tag information.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsTags> Tags { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the instance. N ranges from 1 to 20.</para>
                /// <para>If you specify this value, it cannot be an empty string. It can contain up to 128 characters, must not start with <c>aliyun</c> or <c>acs:</c>, and must not contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>binary</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the instance. N ranges from 1 to 20.</para>
                /// <para>If you specify this value, it can be an empty string. It can contain up to 128 characters, must not start with <c>acs:</c>, and must not contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alterTable</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Whether to create the instance on a Dedicated Host. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>default: Create a non-Dedicated Host instance.</para>
            /// </description></item>
            /// <item><description><para>host: Create a Dedicated Host instance. If you do not specify DedicatedHostId, Alibaba Cloud automatically selects a Dedicated Host to place the instance.</para>
            /// </description></item>
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
            /// <para>The custom data for the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>echo hello ecs!</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>The weights corresponding to specified instance types, representing the capacity size of a single instance in the scaling group. Higher weights require fewer instances of that type to meet the desired capacity.</para>
            /// </summary>
            [NameInMap("WeightedCapacities")]
            [Validation(Required=false)]
            public List<int?> WeightedCapacities { get; set; }

            /// <summary>
            /// <para>The zone ID of the instance. You can call DescribeZones to get the zone list.</para>
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
