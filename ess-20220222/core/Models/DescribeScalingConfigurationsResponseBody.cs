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
        /// <para>The scaling configurations.</para>
        /// </summary>
        [NameInMap("ScalingConfigurations")]
        [Validation(Required=false)]
        public List<DescribeScalingConfigurationsResponseBodyScalingConfigurations> ScalingConfigurations { get; set; }
        public class DescribeScalingConfigurationsResponseBodyScalingConfigurations : TeaModel {
            /// <summary>
            /// <para>Specifies whether the instance on a dedicated host is associated with the dedicated host. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>default: The instance is not associated with the dedicated host. If the economical mode is enabled and the original dedicated host has insufficient resources when the instance is restarted, the instance is automatically deployed to another dedicated host in the automatic deployment resource pool.</description></item>
            /// <item><description>host: The instance is associated with the dedicated host. If the economical mode is enabled and the original dedicated host has insufficient resources when the instance is restarted, the instance fails to be restarted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Affinity")]
            [Validation(Required=false)]
            public string Affinity { get; set; }

            /// <summary>
            /// <para>The number of vCPUs.
            /// You can specify both the Cpu and Memory parameters to define the instance type range. For example, if you set Cpu to 2 and Memory to 16, all instance types that have 2 vCPUs and 16 GiB of memory are matched. Auto Scaling determines the available instance types based on factors such as I/O optimization and zones, and creates instances of the type that has the lowest price.</para>
            /// <remarks>
            /// <para>This configuration takes effect only when the scaling mode is set to cost optimization and no instance types are specified in the scaling configuration.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The CPU options.</para>
            /// </summary>
            [NameInMap("CpuOptions")]
            [Validation(Required=false)]
            public DescribeScalingConfigurationsResponseBodyScalingConfigurationsCpuOptions CpuOptions { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsCpuOptions : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable hardware-based nested virtualization. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>enabled: Enabled.</description></item>
                /// <item><description>disabled: Disabled.</description></item>
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
            /// <para>The time when the scaling configuration was created. The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mmZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2014-08-14T10:58Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The performance mode of the burstable instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: standard mode. For more information, see the &quot;Standard mode&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
            /// <item><description>Unlimited: unlimited mode. For more information, see the &quot;Unlimited mode&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("CreditSpecification")]
            [Validation(Required=false)]
            public string CreditSpecification { get; set; }

            /// <summary>
            /// <para>The custom priority of ECS instance type and vSwitch combination.</para>
            /// <remarks>
            /// <para>Notice: This parameter takes effect only when the scaling policy of the scaling group is set to priority-based policy.</notice>
            /// If an instance cannot be created by using ECS instance type and vSwitch combination that has the highest priority, Auto Scaling automatically uses the combination that has the next highest priority to create ECS instance.
            /// If you specify custom priorities for only some instance type and vSwitch combinations, the unspecified combinations have lower priorities than the specified ones. The priorities of the unspecified combinations are determined based on the vSwitch sequence in the scaling group and ECS instance type sequence in the scaling configuration.</para>
            /// <list type="bullet">
            /// <item><description>For example, if the vSwitch sequence in the scaling group is vsw1 and vsw2, ECS instance type sequence in the scaling configuration is type1 and type2, and the custom priority sequence is [&quot;vsw2+type2&quot;, &quot;vsw1+type2&quot;], the final priority sequence is: &quot;vsw2+type2&quot; &gt; &quot;vsw1+type2&quot; &gt; &quot;vsw1+type1&quot; &gt; &quot;vsw2+type1&quot;.</description></item>
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
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp14zolna43z266bq****</para>
                /// </summary>
                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

            /// <summary>
            /// <para>The data cloud disks.</para>
            /// </summary>
            [NameInMap("DataDisks")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsDataDisks> DataDisks { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsDataDisks : TeaModel {
                /// <summary>
                /// <para>The ID of the automatic snapshot policy applied to the data cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sp-bp19nq9enxqkomib****</para>
                /// </summary>
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the performance burst feature for the data cloud disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: enables the feature.</description></item>
                /// <item><description>false: disables the feature.<remarks>
                /// <para>This parameter is displayed only when the DataDisk.Category parameter is set to cloud_auto.
                /// &lt;props=&quot;china&quot;&gt;For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
                /// </remarks>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// <para>The disk types of the data cloud disks. The first disk type has the highest priority, and the priorities of other disk types decrease in sequence. If a disk type with a higher priority is unavailable, Auto Scaling automatically attempts to create the data cloud disk by using the disk type with the next highest priority. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud: basic cloud disk. The DeleteWithInstance property of a basic cloud disk created along with an instance is set to true.</description></item>
                /// <item><description>cloud_efficiency: ultra disk.</description></item>
                /// <item><description>cloud_ssd: standard SSD.</description></item>
                /// <item><description>cloud_essd: ESSD.</description></item>
                /// <item><description>ephemeral_ssd: local SSD.</description></item>
                /// <item><description>cloud_auto: ESSD AutoPL disk.</description></item>
                /// <item><description>cloud_regional_disk_auto: regional ESSD.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Categories")]
                [Validation(Required=false)]
                public List<string> Categories { get; set; }

                /// <summary>
                /// <para>The category of the data cloud disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud: basic cloud disk. The DeleteWithInstance attribute of a basic cloud disk created along with an instance is set to true.</description></item>
                /// <item><description>cloud_efficiency: ultra disk.</description></item>
                /// <item><description>cloud_ssd: standard SSD.</description></item>
                /// <item><description>ephemeral_ssd: local SSD.</description></item>
                /// <item><description>cloud_essd: ESSD.</description></item>
                /// <item><description>cloud_auto: ESSD AutoPL disk.</description></item>
                /// <item><description>cloud_regional_disk_auto: regional ESSD.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cloud</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>Specifies whether to release the data cloud disk when the instance is released. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: releases the data cloud disk when the instance is released.</description></item>
                /// <item><description>false: retains the data cloud disk when the instance is released.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                /// <summary>
                /// <para>The description of the data cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The mount point of the data cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/dev/xvdb</para>
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// <para>The name of the data cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssdData</para>
                /// </summary>
                [NameInMap("DiskName")]
                [Validation(Required=false)]
                public string DiskName { get; set; }

                /// <summary>
                /// <para>Specifies whether to encrypt the data cloud disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: encrypts the data cloud disk.</description></item>
                /// <item><description>false: does not encrypt the data cloud disk.
                /// Default value: false.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public string Encrypted { get; set; }

                /// <summary>
                /// <para>The ID of the Key Management Service (KMS) key used to encrypt the data cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                /// <summary>
                /// <para>The performance level of the data cloud disk when it is an ESSD (standard SSD).</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <para>The provisioned IOPS (Input/Output Operations Per Second) performance metrics of the data cloud disk.</para>
                /// <remarks>
                /// <para>IOPS measures the number of I/O operations per second and indicates the read and write capabilities of the block storage. Unit: operations per second.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ProvisionedIops")]
                [Validation(Required=false)]
                public long? ProvisionedIops { get; set; }

                /// <summary>
                /// <para>The size of the data cloud disk. Unit: GiB. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud: 5 to 2000.</description></item>
                /// <item><description>cloud_efficiency: 20 to 32768.</description></item>
                /// <item><description>cloud_ssd: 20 to 32768.</description></item>
                /// <item><description>cloud_essd: 20 to 32768.</description></item>
                /// <item><description>ephemeral_ssd: 5 to 800.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>The ID of the snapshot used to create the data cloud disk.</para>
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
            /// <para>The ID of the dedicated host on which to create the ECS instance. Dedicated hosts do not support spot instances. If you specify the DedicatedHostId parameter, the SpotStrategy and SpotPriceLimit parameters are ignored.
            /// You can call the DescribeDedicatedHosts operation to query the list of dedicated host IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dh-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public string DedicatedHostId { get; set; }

            /// <summary>
            /// <para>The release protection property of the instance, which specifies whether the instance can be directly released by using the ECS console or the DeleteInstance API operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Release protection is enabled. The instance cannot be directly released by using the ECS console or the DeleteInstance API operation.</description></item>
            /// <item><description>false: Release protection is shutdown. The instance can be directly released by using the ECS console or the DeleteInstance API operation.<remarks>
            /// <para>This property applies only to pay-as-you-go instances. It prevents instances created by Auto Scaling during scale-out from being accidentally deleted, but does not affect normal scale-in activities. Instances with release protection enabled can still be released during scale-in activities.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
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
            /// <para>The ID of the High Performance Computing (HPC) cluster to which the ECS instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hpc-clus****</para>
            /// </summary>
            [NameInMap("HpcClusterId")]
            [Validation(Required=false)]
            public string HpcClusterId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the access channel for instance metadata. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: enabled.</description></item>
            /// <item><description>disabled: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("HttpEndpoint")]
            [Validation(Required=false)]
            public string HttpEndpoint { get; set; }

            /// <summary>
            /// <para>Specifies whether to forcibly use the security hardening mode (IMDSv2) when accessing instance metadata. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>optional: not forcibly used.</description></item>
            /// <item><description>required: forcibly used. If this value is set, instance metadata cannot be accessed in normal mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>optional</para>
            /// </summary>
            [NameInMap("HttpTokens")]
            [Validation(Required=false)]
            public string HttpTokens { get; set; }

            /// <summary>
            /// <para>The name of the image family. You can set this parameter to obtain the latest available image in the image family to create instances. If the ImageId parameter is specified, you cannot specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hangzhou-daily-update</para>
            /// </summary>
            [NameInMap("ImageFamily")]
            [Validation(Required=false)]
            public string ImageFamily { get; set; }

            /// <summary>
            /// <para>The ID of the image file, which is the image resource used for the automatic creation of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>centos6u5_64_20G_aliaegis_2014****.vhd</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The name of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>centos6u5_64_20G_aliaegis_2014****.vhd</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>Specifies whether to log on to the ECS instance as the ecs-user user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: yes.</description></item>
            /// <item><description>false: no.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ImageOptionsLoginAsNonRoot")]
            [Validation(Required=false)]
            public bool? ImageOptionsLoginAsNonRoot { get; set; }

            /// <summary>
            /// <para>The source of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system: public images provided by Alibaba Cloud.</description></item>
            /// <item><description>self: custom images created by you.</description></item>
            /// <item><description>others: shared images or community images provided by other Alibaba Cloud users.</description></item>
            /// <item><description>marketplace: images provided by Alibaba Cloud Marketplace.</description></item>
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
            /// <para>The generation of the ECS instance.</para>
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
            /// <para>The collection of intelligent configuration information used to filter instance types that meet your requirements.</para>
            /// </summary>
            [NameInMap("InstancePatternInfos")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsInstancePatternInfos> InstancePatternInfos { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsInstancePatternInfos : TeaModel {
                /// <summary>
                /// <para>The architecture type of the instance type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>X86: x86 computing.</description></item>
                /// <item><description>Heterogeneous: heterogeneous computing, such as GPU or FPGA.</description></item>
                /// <item><description>BareMental: ECS Bare Metal server.</description></item>
                /// <item><description>Arm: Arm computing.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Architectures")]
                [Validation(Required=false)]
                public List<string> Architectures { get; set; }

                /// <summary>
                /// <para>Specifies whether the instance type is a burstable instance type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Exclude: excludes burstable instance types.</description></item>
                /// <item><description>Include: includes burstable instance types.</description></item>
                /// <item><description>Required: includes only burstable instance types.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Include</para>
                /// </summary>
                [NameInMap("BurstablePerformance")]
                [Validation(Required=false)]
                public string BurstablePerformance { get; set; }

                /// <summary>
                /// <para>The number of vCPU cores of the instance type.</para>
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
                /// <para>N indicates that you can specify multiple CPU architectures. Valid values of N: 1 to 2.</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description>X86.</description></item>
                /// <item><description>ARM.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("CpuArchitectures")]
                [Validation(Required=false)]
                public List<string> CpuArchitectures { get; set; }

                /// <summary>
                /// <para>The instance types to be excluded. You can use a wildcard (*) to exclude a single instance type or an entire instance family. Examples:</para>
                /// <list type="bullet">
                /// <item><description>ecs.c6.large: excludes the ecs.c6.large instance type.</description></item>
                /// <item><description>ecs.c6.*: excludes all instance types in the c6 instance family.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ExcludedInstanceTypes")]
                [Validation(Required=false)]
                public List<string> ExcludedInstanceTypes { get; set; }

                /// <summary>
                /// <para>The GPU type.</para>
                /// </summary>
                [NameInMap("GpuSpecs")]
                [Validation(Required=false)]
                public List<string> GpuSpecs { get; set; }

                /// <summary>
                /// <para>The instance categorization. Valid values:</para>
                /// <remarks>
                /// <para>N indicates that you can specify multiple instance categories in the Settings. Valid values of N: 1 to 10.</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description>General-purpose: general-purpose.</description></item>
                /// <item><description>Compute-optimized: compute-optimized.</description></item>
                /// <item><description>Memory-optimized: memory-optimized.</description></item>
                /// <item><description>Big data: big data.</description></item>
                /// <item><description>Local SSDs: local SSD.</description></item>
                /// <item><description>High Clock Speed: high frequency.</description></item>
                /// <item><description>Enhanced: enhanced.</description></item>
                /// <item><description>Shared: shared.</description></item>
                /// <item><description>Compute-optimized with GPU: GPU computing.</description></item>
                /// <item><description>Visual Compute-optimized: visual compute-optimized.</description></item>
                /// <item><description>Heterogeneous Service: heterogeneous service.</description></item>
                /// <item><description>Compute-optimized with FPGA: FPGA-accelerated compute-optimized.</description></item>
                /// <item><description>Compute-optimized with NPU: NPU-accelerated compute-optimized.</description></item>
                /// <item><description>ECS Bare Metal: ECS Bare Metal server.</description></item>
                /// <item><description>High Performance Compute: high-performance computing (HPC).</description></item>
                /// </list>
                /// </summary>
                [NameInMap("InstanceCategories")]
                [Validation(Required=false)]
                public List<string> InstanceCategories { get; set; }

                /// <summary>
                /// <para>The level of the instance family. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>EntryLevel: entry-level instance families, which are shared instance families. These instance families are more cost-effective but do not guarantee consistent computing performance. They are suitable for workloads with low CPU utilization. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared instance families</a>.</description></item>
                /// <item><description>EnterpriseLevel: enterprise-level instance families. These instance families provide stable performance and dedicated resources, and are suitable for workloads that require high stability. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</description></item>
                /// <item><description>CreditEntryLevel: credit entry-level instance families, which are burstable instances. These instance families use CPU credits to maintain computing performance and are suitable for workloads with low CPU utilization but occasional CPU bursts. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Burstable instances</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EnterpriseLevel</para>
                /// </summary>
                [NameInMap("InstanceFamilyLevel")]
                [Validation(Required=false)]
                public string InstanceFamilyLevel { get; set; }

                /// <summary>
                /// <para>The instance families to be queried. N indicates that you can specify multiple instance families. Valid values of N: 1 to 10.</para>
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
                /// <para>The maximum number of vCPU cores of the instance type.</para>
                /// <remarks>
                /// <para>The value of MaximumCpuCoreCount cannot exceed four times the value of MinimumCpuCoreCount.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MaximumCpuCoreCount")]
                [Validation(Required=false)]
                public int? MaximumCpuCoreCount { get; set; }

                /// <summary>
                /// <para>The maximum number of GPUs for the instance. Valid values: positive integers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaximumGpuAmount")]
                [Validation(Required=false)]
                public int? MaximumGpuAmount { get; set; }

                /// <summary>
                /// <para>The maximum memory size of the instance. Unit: GiB.</para>
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
                /// <para>The minimum baseline vCPU computing performance (the sum of all vCPUs) for t5 and t6 burstable instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("MinimumBaselineCredit")]
                [Validation(Required=false)]
                public int? MinimumBaselineCredit { get; set; }

                /// <summary>
                /// <para>The minimum number of vCPU cores of the instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MinimumCpuCoreCount")]
                [Validation(Required=false)]
                public int? MinimumCpuCoreCount { get; set; }

                /// <summary>
                /// <para>The minimum value for the maximum number of IPv6 addresses supported by a single elastic network interfaces (ENIs) on the instance. Each ENI is a network interface controller (NIC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinimumEniIpv6AddressQuantity")]
                [Validation(Required=false)]
                public int? MinimumEniIpv6AddressQuantity { get; set; }

                /// <summary>
                /// <para>The minimum value for the maximum number of IPv4 addresses supported by a single elastic network interfaces (ENIs) on the instance. Each ENI is a network interface controller (NIC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MinimumEniPrivateIpAddressQuantity")]
                [Validation(Required=false)]
                public int? MinimumEniPrivateIpAddressQuantity { get; set; }

                /// <summary>
                /// <para>The minimum value for the maximum number of elastic network interfaces (ENIs) that can be attached to the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MinimumEniQuantity")]
                [Validation(Required=false)]
                public int? MinimumEniQuantity { get; set; }

                /// <summary>
                /// <para>The minimum number of GPUs for the instance. Valid values: positive integers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MinimumGpuAmount")]
                [Validation(Required=false)]
                public int? MinimumGpuAmount { get; set; }

                /// <summary>
                /// <para>The minimum initial vCPU credit value for t5 and t6 burstable instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("MinimumInitialCredit")]
                [Validation(Required=false)]
                public int? MinimumInitialCredit { get; set; }

                /// <summary>
                /// <para>The minimum memory size of the instance. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MinimumMemorySize")]
                [Validation(Required=false)]
                public float? MinimumMemorySize { get; set; }

                /// <summary>
                /// <para>The processor model of the instance. N indicates that you can specify multiple processor models. Valid values of N: 1 to 10.</para>
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
            /// <para>After the fallback mode is configured, if issues such as insufficient inventory occur, the system supplements the selected instance types with similar instance types of the same size, or creates vSwitches in fallback zones and adds them to the scaling group.</para>
            /// </summary>
            [NameInMap("InstanceTypeCandidateOptions")]
            [Validation(Required=false)]
            public DescribeScalingConfigurationsResponseBodyScalingConfigurationsInstanceTypeCandidateOptions InstanceTypeCandidateOptions { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsInstanceTypeCandidateOptions : TeaModel {
                /// <summary>
                /// <para>The CIDR blocks of the vSwitches that can be selected when adding vSwitches from other zones is allowed.</para>
                /// </summary>
                [NameInMap("AllowCidrBlocks")]
                [Validation(Required=false)]
                public List<string> AllowCidrBlocks { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow adding vSwitches from other zones.</para>
                /// <remarks>
                /// <para>The instance types remain unchanged, and only new zones are selected as alternatives. When the scaling group fails to scale out in all selected zones due to inventory shortages or other issues, this configuration automatically adds vSwitches from new zones to the scaling group.
                /// For example, if the scaling group is configured with the cn-hangzhou-h and cn-hangzhou-g zones and fails to scale out in both zones, Auto Scaling may create a vSwitch in the cn-hangzhou-k zone and add it to the scaling group based on real-time inventory.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowCrossAz")]
                [Validation(Required=false)]
                public bool? AllowCrossAz { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow supplementing instance types from other generations.</para>
                /// <list type="bullet">
                /// <item><description>For example, if the current instance type is ecs.c7.large, enabling this option allows fallback to instance types such as ecs.c6.large and ecs.c8.large.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AllowDifferentGeneration")]
                [Validation(Required=false)]
                public bool? AllowDifferentGeneration { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the fallback mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The maximum price for fallback instance types.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaxPrice")]
                [Validation(Required=false)]
                public float? MaxPrice { get; set; }

            }

            /// <summary>
            /// <para>The collection of instance types for ECS instances.</para>
            /// </summary>
            [NameInMap("InstanceTypes")]
            [Validation(Required=false)]
            public List<string> InstanceTypes { get; set; }

            /// <summary>
            /// <para>The network billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PayByBandwidth: pay-by-bandwidth. In this case, the InternetMaxBandwidthOut parameter specifies the fixed bandwidth value.</description></item>
            /// <item><description>PayByTraffic: pay-by-traffic. In this case, the InternetMaxBandwidthOut parameter specifies the bandwidth cap, and you are billed based on the actual network traffic.</description></item>
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
            /// <para>Specifies whether the instance is an I/O optimized instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>none: non-I/O optimization.</description></item>
            /// <item><description>optimized: I/O optimization.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("IoOptimized")]
            [Validation(Required=false)]
            public string IoOptimized { get; set; }

            /// <summary>
            /// <para>The number of IPv6 addresses that are randomly generated for the elastic network interface controller (NIC).</para>
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
            /// <para>The lifecycle status of the scaling configuration in the scaling group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Active: The scaling configuration is active. The scaling group uses active scaling configurations for the automatic creation of ECS instances.</description></item>
            /// <item><description>Inacitve: The scaling configuration is inactive. Inactive scaling configurations exist in the scaling group, but the scaling group does not use them for the automatic creation of ECS instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("LifecycleState")]
            [Validation(Required=false)]
            public string LifecycleState { get; set; }

            /// <summary>
            /// <para>The weight of the ECS instance when it is used as an SLB backend server. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LoadBalancerWeight")]
            [Validation(Required=false)]
            public int? LoadBalancerWeight { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: GiB.
            /// You can specify both the Cpu and Memory parameters to define the instance type range. For example, if you set Cpu to 2 and Memory to 16, all instance types that have 2 vCPUs and 16 GiB of memory are matched. Auto Scaling determines the available instance types based on factors such as I/O optimization and zones, and creates instances of the type that has the lowest price.</para>
            /// <remarks>
            /// <para>This configuration takes effect only when the scaling mode is set to cost optimization and no instance types are specified in the scaling configuration.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <para>The list of elastic network interfaces (ENIs). Each ENI is a network interface controller (NIC).</para>
            /// </summary>
            [NameInMap("NetworkInterfaces")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsNetworkInterfaces> NetworkInterfaces { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsNetworkInterfaces : TeaModel {
                /// <summary>
                /// <para>The type of the elastic network interfaces (ENIs). Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Primary: primary network interface controller (NIC).</para>
                /// </description></item>
                /// <item><description><para>Secondary: secondary elastic network interfaces (ENIs).</para>
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
                /// <para>The number of randomly generated IPv6 addresses specified for the primary ENI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Ipv6AddressCount")]
                [Validation(Required=false)]
                public int? Ipv6AddressCount { get; set; }

                /// <summary>
                /// <para>The communication pattern of the elastic network interfaces (ENIs), which act as a network interface controller (NIC). Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Standard: uses the TCP communication pattern.</description></item>
                /// <item><description>HighPerformance: enables the Elastic RDMA Interface (ERI) and uses the RDMA communication pattern.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HighPerformance</para>
                /// </summary>
                [NameInMap("NetworkInterfaceTrafficMode")]
                [Validation(Required=false)]
                public string NetworkInterfaceTrafficMode { get; set; }

                /// <summary>
                /// <para>The number of secondary private IPv4 addresses specified for the ENI. Valid values: 1 to 49.</para>
                /// <list type="bullet">
                /// <item><description>The value cannot exceed the limit on the number of IP addresses for the instance type. For more information, see <a href="https://www.alibabacloud.com/help/en/ecs/user-guide/overview-of-instance-families">Instance families</a>.</description></item>
                /// <item><description>NetworkInterface.N.SecondaryPrivateIpAddressCount is used to specify the number of secondary private IPv4 addresses (excluding the primary private IP address of the ENI) to be assigned to the ENI. The system randomly assigns the addresses from the available CIDR block of the vSwitch (NetworkInterface.N.VSwitchId) to which the ENI belongs.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("SecondaryPrivateIpAddressCount")]
                [Validation(Required=false)]
                public int? SecondaryPrivateIpAddressCount { get; set; }

                /// <summary>
                /// <para>The IDs of one or more security groups to which the elastic network interfaces (ENIs) belong. Each ENI is a network interface controller (NIC).</para>
                /// </summary>
                [NameInMap("SecurityGroupIds")]
                [Validation(Required=false)]
                public List<string> SecurityGroupIds { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch to which the elastic network interfaces (ENIs) belong. Each ENI is a network interface controller (NIC).</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to use the password preset in the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PasswordInherit")]
            [Validation(Required=false)]
            public bool? PasswordInherit { get; set; }

            /// <summary>
            /// <para>Specifies whether an instance password is set. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: An instance password is set.</description></item>
            /// <item><description>false: No instance password is set.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PasswordSetted")]
            [Validation(Required=false)]
            public bool? PasswordSetted { get; set; }

            /// <summary>
            /// <para>The ID of the private pool. The ID is the same as the ID of the elasticity assurance or capacity reservation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eap-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("PrivatePoolOptions.Id")]
            [Validation(Required=false)]
            public string PrivatePoolOptions_id { get; set; }

            /// <summary>
            /// <para>The private pool type for starting the instance. After an elasticity assurance or capacity reservation takes effect, a private pool is generated. You can select a private pool type when you start an instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Open: open mode. The system automatically matches a private pool of the Open type. If no matching private pool is available, the system uses resources from the public pool to start the instance.</description></item>
            /// <item><description>Target: targeted mode. The system uses the specified private pool to start the instance. If the specified private pool is unavailable, the instance fails to be started.</description></item>
            /// <item><description>None: no private pool. The system does not use private pools to start the instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Open</para>
            /// </summary>
            [NameInMap("PrivatePoolOptions.MatchCriteria")]
            [Validation(Required=false)]
            public string PrivatePoolOptions_matchCriteria { get; set; }

            /// <summary>
            /// <para>The name of the Resource Access Management (RAM) role for the ECS instance. RAM roles are provided and maintained by RAM. You can call the ListRoles operation to query available RAM roles.</para>
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
            /// <para>The resource pool policy used when creating instances.</para>
            /// <list type="bullet">
            /// <item><description>This parameter takes effect only when creating pay-as-you-go instances.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ResourcePoolOptions")]
            [Validation(Required=false)]
            public DescribeScalingConfigurationsResponseBodyScalingConfigurationsResourcePoolOptions ResourcePoolOptions { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsResourcePoolOptions : TeaModel {
                /// <summary>
                /// <para>The ID of the private pool, which is the ID of the elasticity assurance or capacity reservation.</para>
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
                /// <para>Resource pools include private pools generated after the elasticity assurance or capacity reservation service takes effect, as well as public pools, which are available for selection when an instance starts. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PrivatePoolFirst: private pool first. When this policy is selected, if ResourcePoolOptions.PrivatePoolIds is specified or the PrivatePoolTags condition is met, the corresponding private pool is used first. If no private pool is specified or the specified private pool has insufficient capacity, the system automatically matches an open private pool. If no eligible private pool is available, the public pool is used to create the instance.</description></item>
                /// <item><description>PrivatePoolOnly: private pool only. When this policy is selected, ResourcePoolOptions.PrivatePoolIds must be specified. If the specified private pool has insufficient capacity, the instance fails to start.</description></item>
                /// <item><description>PublicPoolFirst: public pool first. The public pool is used first to create the instance. When public pool resources are insufficient, private pool resources are used as a supplement. The system preferentially matches an open private pool. If no eligible private pool is available, the system uses the Target private pool specified by ResourcePoolOptions.PrivatePoolIds or the one that meets the PrivatePoolTags condition.</description></item>
                /// <item><description>None: no resource pool policy is used.</description></item>
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
            /// <para>This parameter is in invitational preview and is not available for public use.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("SchedulerOptions")]
            [Validation(Required=false)]
            public DescribeScalingConfigurationsResponseBodyScalingConfigurationsSchedulerOptions SchedulerOptions { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsSchedulerOptions : TeaModel {
                /// <summary>
                /// <remarks>
                /// <para>This parameter is in invitational preview and is not available for public use.</para>
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
            /// <para>Specifies whether a vSwitch available for secondary elastic network interfaces (ENIs) must be selected from the list when the VSwitchIds parameter is specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Strict</para>
            /// </summary>
            [NameInMap("SecondaryEniVSwitchConstraint")]
            [Validation(Required=false)]
            public string SecondaryEniVSwitchConstraint { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable security hardening. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Active: enables security hardening. This value is applicable only to public images.</description></item>
            /// <item><description>Deactive: disables security hardening. This value is applicable to all image types.</description></item>
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
            /// <para>The IDs of the security groups to which the ECS instances belong. ECS instances in the same security group can access each other.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The security options.</para>
            /// </summary>
            [NameInMap("SecurityOptions")]
            [Validation(Required=false)]
            public DescribeScalingConfigurationsResponseBodyScalingConfigurationsSecurityOptions SecurityOptions { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsSecurityOptions : TeaModel {
                /// <summary>
                /// <para>The confidential computing mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Enclave: The ECS instance uses Enclave to build a confidential computing environment. For more information, see <a href="https://help.aliyun.com/document_detail/203433.html">Build a confidential computing environment by using Enclave</a>.</description></item>
                /// <item><description>TDX: builds a TDX confidential computing environment. For more information, see <a href="https://help.aliyun.com/document_detail/479090.html">Build a TDX confidential computing environment</a>.</description></item>
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
            /// <para>The protection period of the spot instance. Unit: hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SpotDuration")]
            [Validation(Required=false)]
            public int? SpotDuration { get; set; }

            /// <summary>
            /// <para>The interruption pattern of the spot instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Terminate</para>
            /// </summary>
            [NameInMap("SpotInterruptionBehavior")]
            [Validation(Required=false)]
            public string SpotInterruptionBehavior { get; set; }

            /// <summary>
            /// <para>The spot instances.</para>
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
            /// <para>The preemption policy for the pay-as-you-go instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NoSpot: regular pay-as-you-go instances.</description></item>
            /// <item><description>SpotWithPriceLimit: spot instances that have a maximum hourly price.</description></item>
            /// <item><description>SpotAsPriceGo: spot instances for which the system automatically bids based on the current market price.</description></item>
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
            /// <para>The maximum number of partitions in the storage set. The value must be an integer greater than or equal to 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("StorageSetPartitionNumber")]
            [Validation(Required=false)]
            public int? StorageSetPartitionNumber { get; set; }

            /// <summary>
            /// <para>The ID of the automatic snapshot policy applied to the system cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-bp12m37ccmxvbmi5****</para>
            /// </summary>
            [NameInMap("SystemDiskAutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string SystemDiskAutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the burst feature for the system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enabled.</description></item>
            /// <item><description>false: disabled.<remarks>
            /// <para>This parameter is supported only when SystemDisk.Category is set to cloud_auto.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SystemDiskBurstingEnabled")]
            [Validation(Required=false)]
            public bool? SystemDiskBurstingEnabled { get; set; }

            /// <summary>
            /// <para>The disk types for the system cloud disk. The first disk type has the highest priority, and the priorities of the other disk types decrease in sequence. If the disk type with a higher priority is unavailable, Auto Scaling automatically attempts to create the system cloud disk by using the disk type with the next highest priority. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic cloud disk.</description></item>
            /// <item><description>cloud_efficiency: ultra cloud disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD cloud disk.</description></item>
            /// <item><description>cloud_essd: ESSD cloud disk.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("SystemDiskCategories")]
            [Validation(Required=false)]
            public List<string> SystemDiskCategories { get; set; }

            /// <summary>
            /// <para>The category of the system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic cloud disk.</description></item>
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>ephemeral_ssd: local SSD.</description></item>
            /// <item><description>cloud_essd: ESSD.</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The description of the system cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test system disk.</para>
            /// </summary>
            [NameInMap("SystemDiskDescription")]
            [Validation(Required=false)]
            public string SystemDiskDescription { get; set; }

            /// <summary>
            /// <para>The encryption algorithm used for the system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AES-256.</description></item>
            /// <item><description>SM4-128.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AES-256</para>
            /// </summary>
            [NameInMap("SystemDiskEncryptAlgorithm")]
            [Validation(Required=false)]
            public string SystemDiskEncryptAlgorithm { get; set; }

            /// <summary>
            /// <para>Specifies whether the system cloud disk is encrypted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The system cloud disk is encrypted.</description></item>
            /// <item><description>false: The system cloud disk is not encrypted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SystemDiskEncrypted")]
            [Validation(Required=false)]
            public bool? SystemDiskEncrypted { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key used for the system cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("SystemDiskKMSKeyId")]
            [Validation(Required=false)]
            public string SystemDiskKMSKeyId { get; set; }

            /// <summary>
            /// <para>The name of the system cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd_Test</para>
            /// </summary>
            [NameInMap("SystemDiskName")]
            [Validation(Required=false)]
            public string SystemDiskName { get; set; }

            /// <summary>
            /// <para>The performance level of the system cloud disk when it is an ESSD (standard SSD).</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("SystemDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned IOPS (Input/Output Operations Per Second) performance metrics for the system cloud disk.</para>
            /// <remarks>
            /// <para>IOPS refers to the number of I/O operations that can be processed per second, which indicates the read and write processing capability of the block storage. Unit: operations per second.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SystemDiskProvisionedIops")]
            [Validation(Required=false)]
            public long? SystemDiskProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system cloud disk. Unit: GiB.</para>
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
                /// <para>The key of tag N of the instance. Valid values of N: 1 to 20.
                /// If you specify this parameter, it cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
                /// 
                /// <b>Example:</b>
                /// <para>binary</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of tag N of the instance. Valid values of N: 1 to 20.
                /// If you specify this parameter, it can be an empty string. The tag value can be up to 128 characters in length. It cannot start with acs:, and cannot contain http:// or https://.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alterTable</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to create the instance on a dedicated host. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>default: creates the instance on a non-dedicated host.</description></item>
            /// <item><description>host: creates the instance on a dedicated host. If you do not specify the DedicatedHostId parameter, Alibaba Cloud automatically selects a dedicated host for the instance.
            /// Default value: default.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Tenancy")]
            [Validation(Required=false)]
            public string Tenancy { get; set; }

            /// <summary>
            /// <para>The user data of the ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>echo hello ecs!</para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>The weight of the specified instance type, which indicates the capacity that a single instance of the specified instance type provides in the scaling group. A greater weight indicates that fewer instances of the instance type are required to meet the expected capacity.</para>
            /// </summary>
            [NameInMap("WeightedCapacities")]
            [Validation(Required=false)]
            public List<int?> WeightedCapacities { get; set; }

            /// <summary>
            /// <para>The zone ID of the instance. You can call the DescribeZones operation to query the zone list.</para>
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
