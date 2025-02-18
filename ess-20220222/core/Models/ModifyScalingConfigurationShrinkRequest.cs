// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyScalingConfigurationShrinkRequest : TeaModel {
        [NameInMap("ImageOptions")]
        [Validation(Required=false)]
        public ModifyScalingConfigurationShrinkRequestImageOptions ImageOptions { get; set; }
        public class ModifyScalingConfigurationShrinkRequestImageOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to use ecs-user to log on to an ECS instance created from the scaling configuration. For information about logon usernames, see <a href="https://help.aliyun.com/document_detail/388447.html">Manage the logon username of an instance</a>. Valid values:</para>
            /// <para>true</para>
            /// <para>false</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("LoginAsNonRoot")]
            [Validation(Required=false)]
            public bool? LoginAsNonRoot { get; set; }

        }

        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public ModifyScalingConfigurationShrinkRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class ModifyScalingConfigurationShrinkRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// <para>The ID of the private pool. The ID of a private pool is the same as the ID of the elasticity assurance or capacity reservation for which the private pool is generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eap-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The type of the private pool that you want to use to start ECS instances. A private pool is generated when an elasticity assurance or a capacity reservation takes effect. You can specify a private pool for Auto Scaling to start ECS instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Open: open private pool. Auto Scaling selects a matching open private pool to start ECS instances. If no matching open private pools exist, the resources in the public pool are used. In this case, you do not need to specify PrivatePoolOptions.Id.</description></item>
            /// <item><description>Target: specified private pool. Auto Scaling uses the resources in the specified private pool to start ECS instances. If the specified private pool does not exist, Auto Scaling cannot start ECS instances. If you set this parameter to Target, you must specify PrivatePoolOptions.Id.</description></item>
            /// <item><description>None: no private pool. Auto Scaling does not use the resources of private pools to start ECS instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Open</para>
            /// </summary>
            [NameInMap("MatchCriteria")]
            [Validation(Required=false)]
            public string MatchCriteria { get; set; }

        }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public ModifyScalingConfigurationShrinkRequestSystemDisk SystemDisk { get; set; }
        public class ModifyScalingConfigurationShrinkRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy that you want to apply to the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-bp12m37ccmxvbmi5****</para>
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the Burst feature for the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <remarks>
            /// <para> If you set <c>SystemDisk.Category</c> to <c>cloud_auto</c>, you can specify this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// <para>The category of the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic disk.</description></item>
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: Enterprise SSD (ESSD).</description></item>
            /// <item><description>ephemeral_ssd: local SSD.</description></item>
            /// </list>
            /// <para>If you specify SystemDisk.Category, you cannot specify <c>SystemDiskCategories</c>. If you do not specify SystemDisk.Category or <c>SystemDiskCategories</c>, the default value of SystemDisk.Category is used. The default value for non-I/O optimized instances of Generation I instance families is cloud. The default value for other instances is cloud_efficiency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The description of the system disk. The description must be 2 to 256 characters in length. The description can contain letters but cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test system disk.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the system disk. The name must be 2 to 128 characters in length, and can contain letters, digits, colons (:), underscores (_), and hyphens (-). The name must start with a letter but cannot start with <c>http:// </c>or <c>https://</c>. </para>
            /// <para>Default value: null.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdSystem</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>The encryption algorithm of the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AES-256</description></item>
            /// <item><description>SM4-128</description></item>
            /// </list>
            /// <para>Default value: AES-256.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AES-256</para>
            /// </summary>
            [NameInMap("EncryptAlgorithm")]
            [Validation(Required=false)]
            public string EncryptAlgorithm { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the system disk. Valid values:</para>
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
            public bool? Encrypted { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key that you want to use to encrypt the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The performance level (PL) of the system disk that is an ESSD. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: An ESSD can provide up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: An ESSD can provide up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: An ESSD can provide up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: An ESSD can provide up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <remarks>
            /// <para> For more information about how to select ESSD PLs, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The IOPS metric that is preconfigured for the system disk.</para>
            /// <remarks>
            /// <para>IOPS measures the number of read and write operations that an EBS device can process per second.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Basic disk: 20 to 500.</para>
            /// </description></item>
            /// <item><description><para>ESSD: Valid values vary based on the performance level of the ESSD.</para>
            /// <list type="bullet">
            /// <item><description>PL0 ESSD: 1 to 2048.</description></item>
            /// <item><description>PL1 ESSD: 20 to 2048.</description></item>
            /// <item><description>PL2 ESSD: 461 to 2048.</description></item>
            /// <item><description>PL3 ESSD: 1261 to 2048.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>ESSD AutoPL disk: 1 to 2048.</para>
            /// </description></item>
            /// <item><description><para>Other disk categories: 20 to 2048.</para>
            /// </description></item>
            /// </list>
            /// <para>The value of this parameter must be at least 1 and greater than or equal to the image size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to associate the instance on a dedicated host with the dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>default: does not associate the instance on the dedicated host with the dedicated host. If you restart an instance that was stopped in Economical Mode and the original dedicated host of the instance has insufficient resources, the instance is automatically deployed to another dedicated host in the automatic deployment resource pool.</description></item>
        /// <item><description>host: associates the instance on a dedicated host with the dedicated host. If you restart an instance that was stopped in Economical Mode, the instance remains on the original dedicated host. If the original dedicated host has insufficient resources, the instance cannot be started.</description></item>
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
        /// <para>You can specify the number of vCPUs and the memory size to determine the range of instance types. For example, you can set Cpu to 2 and Memory to 16 to specify instance types that have 2 vCPUs and 16 GiB of memory. If you specify Cpu and Memory, Auto Scaling determines the available instance types based on factors such as I/O optimization requirements and zones. Then, Auto Scaling preferentially creates instances by using the lowest-priced instance type.</para>
        /// <remarks>
        /// <para>You can specify CPU and Memory to determine the range of instance types only if you set Scaling Policy to Cost Optimization Policy and you do not specify an instance type in the scaling configuration.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>The performance mode of burstable instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: the standard mode. For more information, see the &quot;Standard mode&quot; section in the <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a> topic.</description></item>
        /// <item><description>Unlimited: the unlimited mode. For more information, see the &quot;Unlimited mode&quot; section in the <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a> topic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// <para>The priority of the custom &quot;ECS instance type + vSwitch&quot; combination.</para>
        /// <remarks>
        /// <para> This setting is valid only if the scaling policy of the scaling group is a priority policy.</para>
        /// </remarks>
        /// <para>If Auto Scaling cannot create ECS instances by using the custom &quot;ECS instance type + vSwitch&quot; combination of the highest priority, Auto Scaling creates ECS instances by using the custom &quot;ECS instance type + vSwitch&quot; combination of the next highest priority.</para>
        /// <remarks>
        /// <para> If you specify the priorities of only a part of custom &quot;ECS instance type + vSwitch&quot; combinations, Auto Scaling preferentially creates ECS instances by using the custom combinations that have the specified priorities. If the custom combinations that have the specified priorities do not provide sufficient resources, Auto Scaling creates ECS instances by using the custom combinations that do not have the specified priorities based on the specified orders of vSwitches and instance types.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Example: The specified order of vSwitches for your scaling group is vsw1 and vsw2, and the specified order of instance types in your scaling configuration is type1 and type 2. In addition, you use CustomPriorities to specify [&quot;vsw2+type2&quot;, &quot;vsw1+type2&quot;]. In this example, the vsw2+type2 combination has the highest priority and the vsw2+type1 combination has the lowest priority. The vsw1+type2 combination has a higher priority than the vsw1+type1 combination.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("CustomPriorities")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationShrinkRequestCustomPriorities> CustomPriorities { get; set; }
        public class ModifyScalingConfigurationShrinkRequestCustomPriorities : TeaModel {
            /// <summary>
            /// <para>The ECS instance type.</para>
            /// <remarks>
            /// <para> The ECS instance type must be included in the instance types specified in the scaling configuration.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c6a.4xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// <remarks>
            /// <para> The vSwitch must be included in the vSwitch list of the scaling group.</para>
            /// </remarks>
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
        public List<ModifyScalingConfigurationShrinkRequestDataDisks> DataDisks { get; set; }
        public class ModifyScalingConfigurationShrinkRequestDataDisks : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy that you want to apply to the data disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-bp19nq9enxqkomib****</para>
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the Burst feature for the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <remarks>
            /// <para> If you set <c>SystemDisk.Category</c> to <c>cloud_auto</c>, you can specify this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// <para>The categories of data disks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic disk. The DeleteWithInstance attribute of a basic disk created along with each ECS instance is set to true.</description></item>
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: ESSD.</description></item>
            /// </list>
            /// <remarks>
            /// <para> If you specify this parameter, you cannot specify <c>DataDisk.Category</c>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// <para>The category of the data disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic disk. The DeleteWithInstance attribute of a basic disk created along with each ECS instance is set to true.</description></item>
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>ephemeral_ssd: local SSD.</description></item>
            /// <item><description>cloud_essd: ESSD.</description></item>
            /// </list>
            /// <para>If you specify this parameter, you cannot specify <c>DataDisk.Categories</c>. If you leave this parameter and <c>DataDisk.Categories</c> empty at the same time, the default value of this parameter is used.</para>
            /// <list type="bullet">
            /// <item><description>For I/O optimized instances, the default value is cloud_efficiency.</description></item>
            /// <item><description>For non-I/O optimized instances, the default value is cloud.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>Specifies whether to release the data disk if the instance to which the data disk is attached is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <para>If you set DataDisk.Category to cloud, cloud_efficiency, cloud_ssd, cloud_essd, or cloud_auto, you can specify this parameter. If you specify this parameter for data disks of other categories, an error is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DeleteWithInstance")]
            [Validation(Required=false)]
            public bool? DeleteWithInstance { get; set; }

            /// <summary>
            /// <para>The description of the system disk. The description must be 2 to 256 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test data disk.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The mount target of the data disk. If you do not specify this parameter, the system automatically assigns a mount target when Auto Scaling creates an ECS instance. Valid values: /dev/xvdb to /dev/xvdz.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/dev/xvdd</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The name of the system disk. The name must be 2 to 128 characters in length, and can contain letters, digits, colons (:), underscores (_), and hyphens (-). The name must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdData</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The ID of the Key Management Service (KMS) key that you want to apply to the data disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The PL of the data disk that is an ESSD. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: An ESSD can provide up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: An ESSD can provide up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: An ESSD can provide up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: An ESSD can provide up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <remarks>
            /// <para> For more information about how to select ESSD PLs, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
            /// </remarks>
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
            /// <item><description>5 to 2000 if you set DataDisk.Category to cloud.</description></item>
            /// <item><description>20 to 32768 if you set DataDisk.Category to cloud_efficiency.</description></item>
            /// <item><description>20 to 32768 if you set DataDisk.Category to cloud_ssd.</description></item>
            /// <item><description>20 to 32768 if you set DataDisk.Category to cloud_essd.</description></item>
            /// <item><description>5 to 800 if you set DataDisk.Category to ephemeral_ssd.</description></item>
            /// </list>
            /// <para>Set Size to a value that is greater than or equal to the size of the snapshot specified by SnapshotId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The ID of the snapshot that you want to use to create data disks. If you specify this parameter, DataDisk.Size is ignored. The size of the data disk created by using the snapshot is the same as the size of the snapshot.</para>
            /// <para>If the snapshot was created on or before July 15, 2013, the API request is rejected and the InvalidSnapshot.TooOld message is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-snapshot****</para>
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
        /// <para>The ID of the dedicated host on which you want to create ECS instances. You cannot create preemptible instances on dedicated hosts. If you specify DedicatedHostId, SpotStrategy and SpotPriceLimit are ignored.</para>
        /// <para>You can call the DescribeDedicatedHosts operation to query the most recent list of dedicated host IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Release Protection feature for ECS instances. If you enable this feature, you cannot directly release the ECS instances in the ECS console or by calling the DeleteInstance operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables the Release Protection feature. In this case, you cannot directly release the ECS instances in the ECS console or by calling the DeleteInstance operation.</description></item>
        /// <item><description>false: disables the Release Protection feature. In this case, you can directly release the ECS instances in the ECS console or by calling the DeleteInstance operation.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can enable the Release Protection feature only for pay-as-you-go instances to prevent accidental instance deletion. The Release Protection feature does not affect normal scaling activities. An instance that meets the criteria of scale-in policies can be removed from a scaling group during a scale-in event, regardless of whether you enabled the Release Protection feature for the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The ID of the deployment set of the ECS instances that are created by using the scaling configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-bp13v7bjnj9gis****</para>
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// <para>The hostname of the ECS instance. The hostname cannot start or end with a period (.) or a hyphen (-). The hostname cannot contain consecutive periods (.) or hyphens (-). Naming conventions for different types of instances:</para>
        /// <list type="bullet">
        /// <item><description>Windows instances: The hostname must be 2 to 15 characters in length, and can contain letters, digits, and hyphens (-). The hostname cannot contain periods (.) or contain only digits.</description></item>
        /// <item><description>Other instances, such as Linux instances: The hostname must be 2 to 64 characters in length. Separate a hostname into multiple segments with periods (.). Each segment can contain letters, digits, and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hos****</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The ID of the Elastic High Performance Computing (E-HPC) cluster to which the ECS instances belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hpc-clusterid</para>
        /// </summary>
        [NameInMap("HpcClusterId")]
        [Validation(Required=false)]
        public string HpcClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the access channel for instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled</description></item>
        /// <item><description>disabled</description></item>
        /// </list>
        /// <para>Default value: enabled.</para>
        /// <remarks>
        /// <para> For information about instance metadata, see <a href="https://help.aliyun.com/document_detail/108460.html">Obtain instance metadata</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("HttpEndpoint")]
        [Validation(Required=false)]
        public string HttpEndpoint { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly use the security hardening mode (IMDSv2) to access instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>optional: does not forcibly use the security hardening mode (IMDSv2).</description></item>
        /// <item><description>required: forcibly uses the security hardening mode (IMDSv2). If you set this parameter to required, you cannot access instance metadata in normal mode.</description></item>
        /// </list>
        /// <para>Default value: optional.</para>
        /// <remarks>
        /// <para> For more information about instance metadata access modes, see <a href="https://help.aliyun.com/document_detail/108460.html">Access modes of instance metadata</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>optional</para>
        /// </summary>
        [NameInMap("HttpTokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

        /// <summary>
        /// <para>The name of the image family. If you specify this parameter, the latest custom images that are available in the specified image family are returned. Then, you can use the images to create instances. If you specify ImageId, you cannot specify ImageFamily.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou-daily-update</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The ID of the image that is used by Auto Scaling to automatically create ECS instances.</para>
        /// <remarks>
        /// <para>If the image that is specified in the scaling configuration contains system disks and data disks, the data that is stored in the data disks is cleared after you modify the image.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>centos6u5_64_20G_aliaegis_2014****.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the image. Each image name must be unique in a region. If you specify ImageId, ImageName is ignored.</para>
        /// <para>You cannot use ImageName to specify images from Alibaba Cloud Marketplace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>suse11sp3_64_20G_aliaegis_2015****.vhd</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The description of the ECS instance. The description must be 2 to 256 characters in length. The description can contain letters but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test instance.</para>
        /// </summary>
        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        /// <summary>
        /// <para>The name of the Elastic Compute Service (ECS) instance that is automatically created by using the scaling configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inst****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The intelligent configuration settings, which determine the available instance types.</para>
        /// </summary>
        [NameInMap("InstancePatternInfos")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationShrinkRequestInstancePatternInfos> InstancePatternInfos { get; set; }
        public class ModifyScalingConfigurationShrinkRequestInstancePatternInfos : TeaModel {
            /// <summary>
            /// <para>The architecture types of the instance types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>X86: x86.</description></item>
            /// <item><description>Heterogeneous: heterogeneous computing, such as GPU-accelerated or FPGA-accelerated.</description></item>
            /// <item><description>BareMetal: ECS Bare Metal Instance.</description></item>
            /// <item><description>Arm: Arm.</description></item>
            /// </list>
            /// <para>By default, all values are selected.</para>
            /// </summary>
            [NameInMap("Architectures")]
            [Validation(Required=false)]
            public List<string> Architectures { get; set; }

            /// <summary>
            /// <para>Specifies whether to include burstable instance types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Exclude: excludes burstable instance types.</description></item>
            /// <item><description>Include: includes burstable instance types.</description></item>
            /// <item><description>Required: includes only burstable instance types.</description></item>
            /// </list>
            /// <para>Default value: Include.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Include</para>
            /// </summary>
            [NameInMap("BurstablePerformance")]
            [Validation(Required=false)]
            public string BurstablePerformance { get; set; }

            /// <summary>
            /// <para>The number of vCPUs per instance type in intelligent configuration mode. You can specify this parameter to filter the available instance types. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>.</para>
            /// <para>Before you specify this parameter, take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>You can specify InstancePatternInfo only if your scaling group resides in a virtual private cloud (VPC).</description></item>
            /// <item><description>If you specify InstancePatternInfo, you must also specify InstancePatternInfo.Cores and InstancePatternInfo.Memory.</description></item>
            /// <item><description>Auto Scaling preferentially uses the instance type specified by InstanceType or InstanceTypes to create instances. If the specified instance type does not have sufficient inventory, Auto Scaling selects the lowest-priced instance type specified by InstancePatternInfo to create instances.</description></item>
            /// </list>
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
            /// <para> You can specify up to two CPU architectures.</para>
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
            /// <para>The instance types that you want to exclude. You can use an asterisk (\*) as a wildcard character to exclude an instance type or an instance family. Examples:</para>
            /// <list type="bullet">
            /// <item><description>ecs.c6.large: excludes the ecs.c6.large instance type.</description></item>
            /// <item><description>ecs.c6.\*: excludes the c6 instance family.</description></item>
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
            /// <para>The categories of the instance types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>General-purpose: general-purpose instance type.</description></item>
            /// <item><description>Compute-optimized: compute-optimized instance type.</description></item>
            /// <item><description>Memory-optimized: memory-optimized instance type.</description></item>
            /// <item><description>Big data: big data instance type.</description></item>
            /// <item><description>Local SSDs: instance type that uses local SSDs.</description></item>
            /// <item><description>High Clock Speed: instance type that has a high clock speed.</description></item>
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
            /// <para>The level of the instance family. You can specify this parameter to obtain the available instance types. This parameter takes effect only if you set <c>CostOptimization</c> to true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>EntryLevel: entry-level (shared instance types). Instance types of this level are the most cost-effective but may not ensure stable computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared instance families</a>.</description></item>
            /// <item><description>EnterpriseLevel: enterprise-level. Instance types of this level provide stable performance and dedicated resources and are suitable for business scenarios that require high stability. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>.</description></item>
            /// <item><description>CreditEntryLevel: credit entry-level (burstable instance types). CPU credits are used to ensure computing performance. Instance types of this level are suitable for scenarios in which the CPU utilization is low but may fluctuate in specific cases. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview</a> of burstable instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EnterpriseLevel</para>
            /// </summary>
            [NameInMap("InstanceFamilyLevel")]
            [Validation(Required=false)]
            public string InstanceFamilyLevel { get; set; }

            /// <summary>
            /// <para>The instance families that you want to specify. You can specify up to 10 instance families in each call.</para>
            /// </summary>
            [NameInMap("InstanceTypeFamilies")]
            [Validation(Required=false)]
            public List<string> InstanceTypeFamilies { get; set; }

            /// <summary>
            /// <para>The maximum hourly price of pay-as-you-go or preemptible instances in intelligent configuration mode. You can specify this parameter to obtain the available instance types.</para>
            /// <remarks>
            /// <para> If you set SpotStrategy to SpotWithPriceLimit, you must specify this parameter. In other cases, this parameter is optional.</para>
            /// </remarks>
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
            /// <para>The memory size per instance type in intelligent configuration mode. Unit: GiB. You can specify this parameter to filter the available instance types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The baseline vCPU computing performance (overall baseline performance of all vCPUs) of each t5 or t6 burstable instance.</para>
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
            /// <para>The initial vCPU credits of each t5 or t6 burstable instance.</para>
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
            /// <para>The processor models of the instance types. You can specify up to 10 processor models.</para>
            /// </summary>
            [NameInMap("PhysicalProcessorModels")]
            [Validation(Required=false)]
            public List<string> PhysicalProcessorModels { get; set; }

        }

        /// <summary>
        /// <para>The instance types.</para>
        /// </summary>
        [NameInMap("InstanceTypeOverrides")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationShrinkRequestInstanceTypeOverrides> InstanceTypeOverrides { get; set; }
        public class ModifyScalingConfigurationShrinkRequestInstanceTypeOverrides : TeaModel {
            /// <summary>
            /// <para>The instance type. If you want to specify the capacity of instance types in the scaling configuration, specify InstanceType and WeightedCapacity at the same time.</para>
            /// <para>You can use InstanceType to specify multiple instance types and WeightedCapacity to specify the weights of the instance types.</para>
            /// <remarks>
            /// <para>If you specify InstanceType, you cannot specify InstanceTypes.</para>
            /// </remarks>
            /// <para>You can use InstanceType to specify only instance types that are available for purchase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c5.xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The weight of the instance type. The weight specifies the capacity of an instance of the specified instance type in the scaling group. If you want Auto Scaling to scale instances in the scaling group based on the weighted capacity of the instances, specify WeightedCapacity after you specify InstanceType.</para>
            /// <para>A higher weight specifies that a smaller number of instances of the specified instance type are required to meet the expected capacity requirement.</para>
            /// <para>Performance metrics, such as the number of vCPUs and the memory size of each instance type, may vary. You can specify different weights for different instance types based on your business requirements.</para>
            /// <para>Example:</para>
            /// <list type="bullet">
            /// <item><description>Current capacity: 0</description></item>
            /// <item><description>Expected capacity: 6</description></item>
            /// <item><description>Capacity of ecs.c5.xlarge: 4</description></item>
            /// </list>
            /// <para>To meet the expected capacity requirement, Auto Scaling must create and add two ecs.c5.xlarge instances.</para>
            /// <remarks>
            /// <para>The capacity of the scaling group cannot exceed the sum of the maximum number of instances that is specified by MaxSize and the maximum weight of the instance types.</para>
            /// </remarks>
            /// <para>Valid values of WeightedCapacity: 1 to 500.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public int? WeightedCapacity { get; set; }

        }

        /// <summary>
        /// <para>The instance type. If you specify InstanceTypes, InstanceType is ignored.</para>
        /// <para>Auto Scaling creates instances based on the priorities of instance types. If Auto Scaling cannot create instances by using the instance type that has the highest priority, Auto Scaling creates instances by using the instance type that has the next highest priority.</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The billing method for network usage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayByBandwidth: pay-by-bandwidth. You are charged for the bandwidth specified by InternetMaxBandwidthOut.</description></item>
        /// <item><description>PayByTraffic: pay-by-traffic. You are charged for the actual traffic generated. InternetMaxBandwidthOut specifies only the maximum available bandwidth.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByBandwidth</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The maximum inbound public bandwidth. Unit: Mbit/s. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the purchased outbound public bandwidth is less than or equal to 10 Mbit/s, the valid values of this parameter are 1 to 10. The default value is 10.</description></item>
        /// <item><description>If the purchased outbound public bandwidth is greater than 10 Mbit/s, the valid values of this parameter are 1 to the value of <c>InternetMaxBandwidthOut</c>. The default value is the value of <c>InternetMaxBandwidthOut</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// <para>The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 0 to 100.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>Specifies whether to create I/O optimized instances from the scaling configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>none: creates non-I/O optimized instances from the scaling configuration.</description></item>
        /// <item><description>optimized: creates I/O optimized instances from the scaling configuration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>The number of randomly generated IPv6 addresses that you want to allocate to the elastic network interface (ENI).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// <para>The name of the key pair that you can use to log on to an ECS instance.</para>
        /// <list type="bullet">
        /// <item><description>Windows instances do not support this parameter.</description></item>
        /// <item><description>By default, the username and password authentication method is disabled for Linux instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KeyPair_Name</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The weight of an ECS instance as a backend server. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("LoadBalancerWeight")]
        [Validation(Required=false)]
        public int? LoadBalancerWeight { get; set; }

        /// <summary>
        /// <para>The memory size. Unit: GiB.</para>
        /// <para>You can specify the number of vCPUs and the memory size to determine the range of instance types. For example, you can set Cpu to 2 and Memory to 16 to specify instance types that have 2 vCPUs and 16 GiB of memory. If you specify Cpu and Memory, Auto Scaling determines the available instance types based on factors such as I/O optimization requirements and zones. Then, Auto Scaling preferentially creates instances by using the lowest-priced instance type.</para>
        /// <remarks>
        /// <para>You can specify CPU and Memory to determine the range of instance types only if you set Scaling Policy to Cost Optimization Policy and you do not specify an instance type in the scaling configuration.</para>
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
        public List<ModifyScalingConfigurationShrinkRequestNetworkInterfaces> NetworkInterfaces { get; set; }
        public class ModifyScalingConfigurationShrinkRequestNetworkInterfaces : TeaModel {
            /// <summary>
            /// <para>The ENI type. If you specify this parameter, you must use NetworkInterfaces to specify a primary ENI. In addition, you cannot specify SecurityGroupId or SecurityGroupIds. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Primary: the primary ENI.</description></item>
            /// <item><description>Secondary: the secondary ENI.</description></item>
            /// </list>
            /// <para>Default value: Secondary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Primary</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The number of randomly generated IPv6 addresses that you want to allocate to the primary ENI. Before you specify this parameter, take note of the following items:</para>
            /// <para>This parameter takes effect only if you set NetworkInterface.InstanceType to Primary. If you set NetworkInterface.InstanceType to Secondary or leave it empty, you cannot specify this parameter.</para>
            /// <para>After you specify this parameter, you can no longer specify Ipv6AddressCount.</para>
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
            /// <item><description>Standard: uses the TCP communication mode.</description></item>
            /// <item><description>HighPerformance: uses the remote direct memory access (RDMA) communication mode with Elastic RDMA Interface (ERI) enabled.</description></item>
            /// </list>
            /// <para>Default value: Standard.</para>
            /// <remarks>
            /// <para> The number of ERIs on an instance cannot exceed the maximum number of ERIs supported by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HighPerformance</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// <para>The IDs of the security groups to which you want to assign the ENI.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to overwrite existing data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Override")]
        [Validation(Required=false)]
        public bool? Override { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The password of the ECS instance. The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported:</para>
        /// <para>\`()~!@#$%^&amp;\*-_+=|{}[]:;\&quot;&lt;&gt;,.?/</para>
        /// <para>The password of a Windows instance cannot start with a forward slash (/).</para>
        /// <remarks>
        /// <para> We recommend that you use HTTPS to send requests if you specify Password to avoid password leakage.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123abc****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the password that is preconfigured in the image. Before you use this parameter, make sure that a password is configured in the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The name of the RAM role that you want to attach to the ECS instance. The name is provided and maintained by Resource Access Management (RAM). You can call the ListRoles operation to query the available RAM roles. You can call the CreateRole operation to create RAM roles.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RamRoleTest</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the ECS instances belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcd1234abcd****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The ID of the scaling configuration that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asc-bp16har3jpj6fjbx****</para>
        /// </summary>
        [NameInMap("ScalingConfigurationId")]
        [Validation(Required=false)]
        public string ScalingConfigurationId { get; set; }

        /// <summary>
        /// <para>The name of the scaling configuration. The name must be 2 to 64 characters in length, and can contain letters, digits, underscores (_), hyphens (-), and periods (.). The name must start with a letter or a digit.</para>
        /// <para>The name of the scaling configuration must be unique in a region. If you do not specify this parameter, the scaling configuration ID is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-modify</para>
        /// </summary>
        [NameInMap("ScalingConfigurationName")]
        [Validation(Required=false)]
        public string ScalingConfigurationName { get; set; }

        /// <summary>
        /// <para>The scheduler options.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;testManagedPrivateSpaceId****&quot;]</para>
        /// </summary>
        [NameInMap("SchedulerOptions")]
        [Validation(Required=false)]
        public string SchedulerOptionsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the security group with which ECS instances are associated. The ECS instances that are associated with the same security group can access each other.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-F876F****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the security groups.</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        [NameInMap("SecurityOptions")]
        [Validation(Required=false)]
        public ModifyScalingConfigurationShrinkRequestSecurityOptions SecurityOptions { get; set; }
        public class ModifyScalingConfigurationShrinkRequestSecurityOptions : TeaModel {
            /// <summary>
            /// <para>The confidential computing mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enclave: An enclave-based confidential computing environment is built on the instance. For more information, see <a href="https://help.aliyun.com/document_detail/203433.html">Build a confidential computing environment by using Enclave</a>.</description></item>
            /// <item><description>TDX: A Trust Domain Extensions (TDX) confidential computing environment is built on the instance. For more information, see <a href="https://help.aliyun.com/document_detail/479090.html">Build a TDX confidential computing environment</a>.</description></item>
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
        /// <para>The protection period of preemptible instances. Unit: hours. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: After a preemptible instance is created, Alibaba Cloud ensures that the instance is not automatically released within 1 hour. After the 1-hour protection period ends, Alibaba Cloud compares the bidding price with the market price and checks the resource inventory to determine whether to release the instance.</description></item>
        /// <item><description>0: After a preemptible instance is created, Alibaba Cloud does not ensure that the instance is not automatically released within 1 hour. Alibaba Cloud compares the biding price with the market price and checks the resource inventory to determine whether to release the instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Alibaba Cloud notifies you of ECS system events 5 minutes before an instance is released. Preemptible instances are billed by second. We recommend that you specify a protection period based on your business requirements.</para>
        /// </remarks>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The interruption mode of the preemptible instance. Default value: Terminate. Set the value to Terminate. This value specifies that the preemptible instance is to be released.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Terminate</para>
        /// </summary>
        [NameInMap("SpotInterruptionBehavior")]
        [Validation(Required=false)]
        public string SpotInterruptionBehavior { get; set; }

        /// <summary>
        /// <para>The preemptible instance types.</para>
        /// </summary>
        [NameInMap("SpotPriceLimits")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationShrinkRequestSpotPriceLimits> SpotPriceLimits { get; set; }
        public class ModifyScalingConfigurationShrinkRequestSpotPriceLimits : TeaModel {
            /// <summary>
            /// <para>The instance type of the preemptible instance. This parameter takes effect only if you set SpotStrategy to SpotWithPriceLimit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g6.large</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The price limit of the preemptible instance. This parameter takes effect only if you set SpotStrategy to SpotWithPriceLimit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.125</para>
            /// </summary>
            [NameInMap("PriceLimit")]
            [Validation(Required=false)]
            public float? PriceLimit { get; set; }

        }

        /// <summary>
        /// <para>The preemption policy of pay-as-you-go instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instances are created as regular pay-as-you-go instances.</description></item>
        /// <item><description>SpotWithPriceLimit: The instances are preemptible instances that have a user-defined maximum hourly price.</description></item>
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
        /// <b>Example:</b>
        /// <para>ss-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("StorageSetId")]
        [Validation(Required=false)]
        public string StorageSetId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        /// <summary>
        /// <para>The categories of the system disks. If Auto Scaling cannot create disks by using the disk category of the highest priority, Auto Scaling creates disks by using the disk category of the next highest priority. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud: basic disk.</description></item>
        /// <item><description>cloud_efficiency: ultra disk.</description></item>
        /// <item><description>cloud_ssd: standard SSD.</description></item>
        /// <item><description>cloud_essd: ESSD.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you specify this parameter, you cannot specify <c>SystemDisk.Category</c>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SystemDiskCategories")]
        [Validation(Required=false)]
        public List<string> SystemDiskCategories { get; set; }

        /// <summary>
        /// <para>The tags of the ECS instance. Specify the tags as key-value pairs. You can specify up to 20 tags. When you specify tag keys and tag values, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>A tag key can be up to 64 characters in length. The key cannot start with <c>acs:</c> or <c>aliyun</c>, and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot be an empty string.</description></item>
        /// <item><description>A tag value can be up to 128 characters in length. The value cannot start with <c>acs:</c> or <c>aliyun</c>, and cannot contain <c>http://</c> or <c>https://</c>. The tag value can be an empty string.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;:&quot;value1&quot;,&quot;key2&quot;:&quot;value2&quot;, ... &quot;key5&quot;:&quot;value5&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>Specifies whether to create ECS instances on dedicated hosts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>default: creates ECS instances on non-dedicated hosts.</description></item>
        /// <item><description>host: creates ECS instances on dedicated hosts. If you do not specify DedicatedHostId, the system randomly selects a dedicated host for an ECS instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Tenancy")]
        [Validation(Required=false)]
        public string Tenancy { get; set; }

        /// <summary>
        /// <para>The user data of the Elastic Compute Service (ECS) instance. The user data must be encoded in Base64 format. The size of raw data before Base64 encoding cannot exceed 32 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo hello ecs!</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The zone ID of the ECS instances that are created by using the scaling configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
