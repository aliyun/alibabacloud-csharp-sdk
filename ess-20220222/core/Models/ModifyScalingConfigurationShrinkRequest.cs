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
            /// <para>Specifies whether the ECS instance uses the ecs-user account to log on. For more information, see <a href="https://help.aliyun.com/document_detail/388447.html">Manage the logon name of an ECS instance</a>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The ecs-user account is used.</para>
            /// </description></item>
            /// <item><description><para>false: The ecs-user account is not used.</para>
            /// </description></item>
            /// </list>
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
            /// <para>The private pool ID, which is the ID of the elasticity assurance or capacity reservation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eap-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The private pool option for instance startup. A private pool is generated after an elasticity assurance or capacity reservation takes effect. You can select a private pool when you start an instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Open: open mode. The system automatically matches an open private pool. If no matching private pool is available, the public pool is used to start the instance. You do not need to specify PrivatePoolOptions.Id in this mode.</para>
            /// </description></item>
            /// <item><description><para>Target: specified mode. A specified private pool is used to start the instance. If the specified private pool is unavailable, the instance fails to start. In this mode, you must specify the private pool ID, which means PrivatePoolOptions.Id is required.</para>
            /// </description></item>
            /// <item><description><para>None: no private pool is used. The instance does not use any private pool capacity for startup.</para>
            /// </description></item>
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
            /// <para>The ID of the automatic snapshot policy applied to the system cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-bp12m37ccmxvbmi5****</para>
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the burst feature for the system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables the burst feature.</description></item>
            /// <item><description>false: does not enable the burst feature.<remarks>
            /// <para>This parameter is supported only when <c>SystemDisk.Category</c> is set to <c>cloud_auto</c>.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;For more information, see [ESSD AutoPL disks](
            /// <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// <para>The category of the system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic cloud disk.</description></item>
            /// <item><description>cloud_efficiency: ultra cloud disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: Enterprise SSD (ESSD).</description></item>
            /// <item><description>ephemeral_ssd: local SSD.</description></item>
            /// </list>
            /// <para>This parameter cannot be specified together with <c>SystemDiskCategories</c>. If neither this parameter nor <c>SystemDiskCategories</c> is specified, a default value is used. If the instance type belongs to Generation I instance families and the instance is not an I/O optimization instance, the default value is cloud. Otherwise, the default value is cloud_efficiency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The description of the system cloud disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test system disk.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the system cloud disk. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), and hyphens (-). It must start with a letter or Chinese character and cannot start with http:// or https://. Default value: empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdSystem</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>The encryption algorithm for the system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AES-256.</description></item>
            /// <item><description>SM4-128.</description></item>
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
            /// <para>Specifies whether to encrypt the system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: encrypts the system cloud disk.</description></item>
            /// <item><description>false: does not encrypt the system cloud disk.</description></item>
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
            /// <para>The ID of the KMS key used for the system cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The performance level (PL) of the system cloud disk when the disk is an ESSD. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information about how to select an ESSD performance level, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned IOPS (Input/Output Operations Per Second) performance metrics for the system cloud disk.</para>
            /// <remarks>
            /// <para>IOPS (Input/Output Operations Per Second) refers to the number of I/O operations that can be processed per second, representing the read/write (output/input) capability of block storage. Unit: operations per second.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system cloud disk. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Basic cloud disk: 20 to 500.</description></item>
            /// <item><description>ESSD:<list type="bullet">
            /// <item><description>PL0: 1 to 2048.</description></item>
            /// <item><description>PL1: 20 to 2048.</description></item>
            /// <item><description>PL2: 461 to 2048.</description></item>
            /// <item><description>PL3: 1261 to 2048.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>ESSD AutoPL: 1 to 2048.</description></item>
            /// <item><description>Other cloud disk types: 20 to 2048.</description></item>
            /// </list>
            /// <para>The value of this parameter must be greater than or equal to max{1, ImageSize}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether the instance on a dedicated host is associated with the dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>default: The instance is not associated with the dedicated host. When an instance that has the economical mode enabled is restarted, the instance may be placed on another dedicated host in the automatic deployment resource pool if the original dedicated host has insufficient resources.</para>
        /// </description></item>
        /// <item><description><para>host: The instance is associated with the dedicated host. When an instance that has the economical mode enabled is restarted, the instance remains on the original dedicated host. If the original dedicated host has insufficient resources, the instance fails to restart.</para>
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
        /// <para>The number of vCPUs. Unit: cores.</para>
        /// <para>You can specify both CPU and Memory to define the range of instance types. For example, CPU=2 and Memory=16 defines all instance types with 2 vCPUs and 16 GiB of memory. Auto Scaling determines the set of active instance types based on factors such as I/O optimization and zones, and then creates instances of the lowest-priced instance type based on sorting by price.</para>
        /// <remarks>
        /// <para>This configuration takes effect only when the cost optimization mode is enabled and no instance type is specified in the scaling configuration.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>Modifies the running mode of a burstable instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard: standard mode. For more information, see the performance constrained mode section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</para>
        /// </description></item>
        /// <item><description><para>Unlimited: unlimited mode. For more information, see the unlimited mode section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</para>
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
        /// <para>The custom priorities for ECS instance type + vSwitch combinations.</para>
        /// <remarks>
        /// <para>Notice: This parameter takes effect only when the scaling policy of the scaling group is set to priority-based policy.</para>
        /// </remarks>
        /// <para>When an instance cannot be created based on the instance type and vSwitch combination with a higher priority, Auto Scaling automatically selects the next-priority instance type and vSwitch combination to create the instance.</para>
        /// <remarks>
        /// <para>If you specify custom priorities for only some instance type + vSwitch combinations, the unspecified combinations have lower priorities than the specified ones. The unspecified combinations are still prioritized based on the vSwitch order of the scaling group and the instance type order of the scaling configuration.</para>
        /// <list type="bullet">
        /// <item><description>For example, if the vSwitch order of the scaling group is vsw1 and vsw2, the instance type order of the scaling configuration is type1 and type2, and the custom priority order is [&quot;vsw2+type2&quot;, &quot;vsw1+type2&quot;], the final priority is: &quot;vsw2+type2&quot; &gt; &quot;vsw1+type2&quot; &gt; &quot;vsw1+type1&quot; &gt; &quot;vsw2+type1&quot;.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("CustomPriorities")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationShrinkRequestCustomPriorities> CustomPriorities { get; set; }
        public class ModifyScalingConfigurationShrinkRequestCustomPriorities : TeaModel {
            /// <summary>
            /// <para>The instance type of the ECS instance.</para>
            /// <remarks>
            /// <para>The instance type must be included in the instance type list of the scaling configuration.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c6a.4xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch.</para>
            /// <remarks>
            /// <para>The vSwitch must be included in the vSwitch list of the scaling group.</para>
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
        /// <para>The collection of data cloud disk information.</para>
        /// </summary>
        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationShrinkRequestDataDisks> DataDisks { get; set; }
        public class ModifyScalingConfigurationShrinkRequestDataDisks : TeaModel {
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
            /// <para>Specifies whether to enable the burst feature for the data cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables the burst feature.</description></item>
            /// <item><description>false: does not enable the burst feature.<remarks>
            /// <para>This parameter is supported only when <c>SystemDisk.Category</c> is set to <c>cloud_auto</c>.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// <para>The multiple disk types of the data cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic cloud disk. The DeleteWithInstance property of a basic cloud disk created along with the instance is set to true.</description></item>
            /// <item><description>cloud_efficiency: ultra cloud disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: ESSD.</description></item>
            /// <item><description>ephemeral_ssd: local SSD.</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL.</description></item>
            /// <item><description>cloud_regional_disk_auto: regional ESSD.</description></item>
            /// </list>
            /// <remarks>
            /// <para>You cannot specify this parameter together with <c>DataDisk.Category</c>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// <para>The category of the data cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic cloud disk. The DeleteWithInstance attribute of a basic cloud disk created along with the instance is set to true.</description></item>
            /// <item><description>cloud_efficiency: ultra cloud disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: ESSD.</description></item>
            /// <item><description>ephemeral_ssd: local SSD.</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL.</description></item>
            /// <item><description>cloud_regional_disk_auto: regional ESSD.</description></item>
            /// </list>
            /// <para>This parameter cannot be specified together with <c>DataDisk.Categories</c>. If neither this parameter nor <c>DataDisk.Categories</c> is specified, the default value is used:</para>
            /// <list type="bullet">
            /// <item><description><para>For I/O optimized instances, the default value is cloud_efficiency.</para>
            /// </description></item>
            /// <item><description><para>For non-I/O optimized instances, the default value is cloud.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>Specifies whether the data cloud disk is released when the instance is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The data cloud disk is released when the instance is released.</description></item>
            /// <item><description>false: The data cloud disk is retained when the instance is released.</description></item>
            /// </list>
            /// <para>This parameter can be set only for independent cloud disks (DataDisk.Category is set to cloud, cloud_efficiency, cloud_ssd, cloud_essd, or cloud_auto). Otherwise, an error is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DeleteWithInstance")]
            [Validation(Required=false)]
            public bool? DeleteWithInstance { get; set; }

            /// <summary>
            /// <para>The description of the system cloud disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test data disk.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The mount point of the data cloud disk. If you do not specify this parameter, the system uses the default behavior to allocate a mount point during automatic creation of the ECS instance. The mount points range from /dev/xvdb to /dev/xvdz.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/dev/xvdd</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The name of the data cloud disk. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), and hyphens (-). It must start with a letter or Chinese character and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
            /// <item><description>false: does not encrypt the data cloud disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key for the data cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The performance level of the data cloud disk when the disk is an ESSD. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information about how to select an ESSD performance level, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
            /// </remarks>
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
            /// <para>IOPS (Input/Output Operations Per Second) measures the number of read and write operations that a block storage device can process per second.</para>
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
            /// <para>After you specify this parameter, the disk size must be greater than or equal to the size of the snapshot specified by SnapshotId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The ID of the snapshot used to create the data cloud disk. After this parameter is specified, DataDisk.Size is ignored, and the size of the created disk is the size of the specified snapshot.</para>
            /// <para>If the snapshot was created on or before July 15, 2013, the request is rejected and the error message InvalidSnapshot.TooOld is returned.</para>
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
        /// <para>Specifies whether to create the ECS instance on a dedicated host. Because dedicated hosts do not support the creation of spot instances, if you specify the DedicatedHostId parameter, the SpotStrategy and SpotPriceLimit settings in the request are automatically ignored.</para>
        /// <para>You can call the DescribeDedicatedHosts operation to query the list of dedicated host IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// <para>The release protection property of the instance. Specifies whether the instance can be directly released from the ECS console or by calling the DeleteInstance operation, to prevent accidental deletion. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables release protection. The instance cannot be directly released from the ECS console or by calling the DeleteInstance operation.</para>
        /// </description></item>
        /// <item><description><para>false: Disables release protection. The instance can be directly released from the ECS console or by calling the DeleteInstance operation.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This property applies only to pay-as-you-go instances. It prevents instances created by Auto Scaling scale-out activities from being accidentally deleted, but does not affect normal scale-in activities. Instances with release protection enabled can still be released by scale-in activities.</para>
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
        /// <para>ds-bp13v7bjnj9gis****</para>
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// <para>The hostname of the Elastic Compute Service (ECS) server. A period (.) or a hyphen (-) cannot be used as the first or last character, or used consecutively. In addition, the naming conventions for different types of instances are as follows: </para>
        /// <list type="bullet">
        /// <item><description>Windows instances: The hostname must be 2 to 15 characters in length and can contain letters, digits, and hyphens (-). It cannot contain periods (.) or consist entirely of digits. </description></item>
        /// <item><description>Other instances (such as Linux): The hostname must be 2 to 64 characters in length and can contain multiple periods (.). Each segment between two periods (.) can contain letters, digits, and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hos****</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The ID of the HPC cluster to which the ECS instance belongs.</para>
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
        /// <item><description>enabled: enabled.</description></item>
        /// <item><description>disabled: disabled.</description></item>
        /// </list>
        /// <para>Default value: enabled.</para>
        /// <remarks>
        /// <para>For information about instance metadata, see <a href="https://help.aliyun.com/document_detail/108460.html">Overview of instance metadata</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("HttpEndpoint")]
        [Validation(Required=false)]
        public string HttpEndpoint { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully use the security-hardened mode (IMDSv2) to access instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>optional: does not forcefully use the security-hardened mode.</description></item>
        /// <item><description>required: forcefully uses the security-hardened mode. After you set this value, instance metadata cannot be accessed in normal mode.</description></item>
        /// </list>
        /// <para>Default value: optional.</para>
        /// <remarks>
        /// <para>For more information about the modes for accessing instance metadata, see <a href="https://help.aliyun.com/document_detail/108460.html">Instance metadata access modes</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>optional</para>
        /// </summary>
        [NameInMap("HttpTokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

        /// <summary>
        /// <para>The name of the image family. You can set this parameter to obtain the latest available image from the specified image family for instance creation. If you have specified the <c>ImageId</c> parameter, you cannot specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou-daily-update</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The ID of the image file used for automatic creation of instances.</para>
        /// <remarks>
        /// <para>If the image previously used in the scaling configuration includes a system cloud disk and data cloud disks, the data cloud disk information is purged after you change the image.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>centos6u5_64_20G_aliaegis_2014****.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the image. Image names must be unique within a region. If you specify ImageId, ImageName is ignored.</para>
        /// <para>You cannot use ImageName to specify images from Alibaba Cloud Marketplace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>suse11sp3_64_20G_aliaegis_2015****.vhd</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The description of the ECS instance. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test instance.</para>
        /// </summary>
        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        /// <summary>
        /// <para>The name of the ECS instance that is automatically created by using the scaling configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inst****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The collection of intelligent configuration information used to filter instance types that meet the requirements.</para>
        /// </summary>
        [NameInMap("InstancePatternInfos")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationShrinkRequestInstancePatternInfos> InstancePatternInfos { get; set; }
        public class ModifyScalingConfigurationShrinkRequestInstancePatternInfos : TeaModel {
            /// <summary>
            /// <para>The architecture types of the instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>X86: x86 computing.</description></item>
            /// <item><description>Heterogeneous: heterogeneous computing, such as GPU or FPGA.</description></item>
            /// <item><description>BareMental: ECS Bare Metal Instance.</description></item>
            /// <item><description>Arm: Arm computing.</description></item>
            /// </list>
            /// <para>Default value: all architecture types are included.</para>
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
            /// <para>The number of vCPU cores of the instance type in intelligent configuration mode, used to filter instance types that meet the requirements. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// <para>Note the following information:</para>
            /// <list type="bullet">
            /// <item><description><para>The InstancePatternInfo parameter applies only to scaling groups whose network type is VPC.</para>
            /// </description></item>
            /// <item><description><para>You must specify both InstancePatternInfo.Cores and InstancePatternInfo.Memory.</para>
            /// </description></item>
            /// <item><description><para>If you have specified instance types by using the InstanceType or InstanceTypes parameter, Auto Scaling preferentially uses the specified instance types for scale-out. When the specified instance types are out of stock, Auto Scaling selects the lowest-priced instance type from those that match the InstancePatternInfo parameter values.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Cores")]
            [Validation(Required=false)]
            public int? Cores { get; set; }

            /// <summary>
            /// <para>The CPU architectures of the instance. Valid values:</para>
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
            /// <para>The instance types to exclude. You can use wildcard characters (*) to exclude a single instance type or an entire instance family. Examples:</para>
            /// <list type="bullet">
            /// <item><description>ecs.c6.large: excludes the ecs.c6.large instance type.</description></item>
            /// <item><description>ecs.c6.*: excludes the entire c6 instance family.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExcludedInstanceTypes")]
            [Validation(Required=false)]
            public List<string> ExcludedInstanceTypes { get; set; }

            /// <summary>
            /// <para>The GPU types.</para>
            /// </summary>
            [NameInMap("GpuSpecs")]
            [Validation(Required=false)]
            public List<string> GpuSpecs { get; set; }

            /// <summary>
            /// <para>The categorization of the instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>General-purpose: general-purpose.</description></item>
            /// <item><description>Compute-optimized: compute-optimized.</description></item>
            /// <item><description>Memory-optimized: memory-optimized.</description></item>
            /// <item><description>Big data: big data.</description></item>
            /// <item><description>Local SSDs: local SSD.</description></item>
            /// <item><description>High Clock Speed: high frequency.</description></item>
            /// <item><description>Enhanced: enhanced.</description></item>
            /// <item><description>Shared: shared.</description></item>
            /// <item><description>Compute-optimized with GPU: GPU-accelerated compute-optimized.</description></item>
            /// <item><description>Visual Compute-optimized: visual compute-optimized.</description></item>
            /// <item><description>Heterogeneous Service: heterogeneous service.</description></item>
            /// <item><description>Compute-optimized with FPGA: FPGA compute-optimized.</description></item>
            /// <item><description>Compute-optimized with NPU: NPU compute-optimized.</description></item>
            /// <item><description>ECS Bare Metal: ECS Bare Metal Instance.</description></item>
            /// <item><description>High Performance Compute: high-performance computing (HPC).</description></item>
            /// </list>
            /// </summary>
            [NameInMap("InstanceCategories")]
            [Validation(Required=false)]
            public List<string> InstanceCategories { get; set; }

            /// <summary>
            /// <para>The level of the instance family, used to filter instance types that meet the requirements. This parameter takes effect when <c>CostOptimization</c> is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>EntryLevel: entry level, which refers to shared instance types. These instance types are more cost-effective but cannot guarantee stable computing performance. They are suitable for scenarios with low CPU utilization. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared instance families</a>.</description></item>
            /// <item><description>EnterpriseLevel: enterprise level. These instance types provide stable performance and dedicated resources. They are suitable for scenarios that require high stability. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</description></item>
            /// <item><description>CreditEntryLevel: credit entry level, which refers to burstable instances. These instance types use CPU credits to ensure computing performance. They are suitable for scenarios with low average CPU utilization and occasional bursts. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EnterpriseLevel</para>
            /// </summary>
            [NameInMap("InstanceFamilyLevel")]
            [Validation(Required=false)]
            public string InstanceFamilyLevel { get; set; }

            /// <summary>
            /// <para>The instance families to query. N indicates that you can specify multiple instance families. Valid values of N: 1 to 10.</para>
            /// </summary>
            [NameInMap("InstanceTypeFamilies")]
            [Validation(Required=false)]
            public List<string> InstanceTypeFamilies { get; set; }

            /// <summary>
            /// <para>The maximum hourly price for pay-as-you-go or spot instances in intelligent configuration mode, used to filter instance types that meet the requirements.</para>
            /// <remarks>
            /// <para>This parameter is required when SpotStrategy is set to SpotWithPriceLimit. In other cases, this parameter is optional.</para>
            /// </remarks>
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
            /// <para>MaximumCpuCoreCount cannot exceed 4 times the value of MinimumCpuCoreCount.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("MaximumCpuCoreCount")]
            [Validation(Required=false)]
            public int? MaximumCpuCoreCount { get; set; }

            /// <summary>
            /// <para>The maximum number of GPUs of the instance. Valid values: positive integers.</para>
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
            /// <para>The memory size of the instance type in intelligent configuration mode. Unit: GiB. This parameter is used to filter instance types that meet the requirements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The minimum baseline vCPU computing performance (sum of all vCPUs) for burstable instances (t5 and t6).</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("MinimumBaselineCredit")]
            [Validation(Required=false)]
            public int? MinimumBaselineCredit { get; set; }

            /// <summary>
            /// <para>The minimum number of vCPU cores of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MinimumCpuCoreCount")]
            [Validation(Required=false)]
            public int? MinimumCpuCoreCount { get; set; }

            /// <summary>
            /// <para>The minimum upper limit of IPv6 addresses on a single elastic network interfaces (ENIs) of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinimumEniIpv6AddressQuantity")]
            [Validation(Required=false)]
            public int? MinimumEniIpv6AddressQuantity { get; set; }

            /// <summary>
            /// <para>The minimum number of IPv4 addresses per ENI supported by the instance.
            /// [_single.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MinimumEniPrivateIpAddressQuantity")]
            [Validation(Required=false)]
            public int? MinimumEniPrivateIpAddressQuantity { get; set; }

            /// <summary>
            /// <para>The minimum number of elastic network interfaces (ENIs) supported by the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MinimumEniQuantity")]
            [Validation(Required=false)]
            public int? MinimumEniQuantity { get; set; }

            /// <summary>
            /// <para>The minimum number of GPUs of the instance. Valid values: positive integers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MinimumGpuAmount")]
            [Validation(Required=false)]
            public int? MinimumGpuAmount { get; set; }

            /// <summary>
            /// <para>The minimum initial vCPU credits for burstable instances (t5 and t6).</para>
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
            /// <para>The processor models of the instance. N indicates that you can specify multiple processor models. Valid values of N: 1 to 10.</para>
            /// </summary>
            [NameInMap("PhysicalProcessorModels")]
            [Validation(Required=false)]
            public List<string> PhysicalProcessorModels { get; set; }

        }

        /// <summary>
        /// <para>After the fallback mode is enabled, when issues such as insufficient inventory are encountered, similar instance types of the same size are supplemented based on the currently selected instance types, or vSwitches in alternative zones are created and added to the scaling group.</para>
        /// </summary>
        [NameInMap("InstanceTypeCandidateOptions")]
        [Validation(Required=false)]
        public ModifyScalingConfigurationShrinkRequestInstanceTypeCandidateOptions InstanceTypeCandidateOptions { get; set; }
        public class ModifyScalingConfigurationShrinkRequestInstanceTypeCandidateOptions : TeaModel {
            /// <summary>
            /// <para>The CIDR blocks for optional vSwitches when supplementing vSwitches in other zones.</para>
            /// </summary>
            [NameInMap("AllowCidrBlocks")]
            [Validation(Required=false)]
            public List<string> AllowCidrBlocks { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow supplementing vSwitches in other zones.</para>
            /// <remarks>
            /// <para>The instance type remains unchanged. Only alternative zones are selected. When all selected zones of the scaling group cannot be used for scale-out due to issues such as insufficient inventory, new zone vSwitches are automatically added to the scaling group based on this configuration.
            /// For example, if the scaling group is configured with the cn-hangzhou-h and cn-hangzhou-g zones, and neither zone can be used for scale-out, Auto Scaling may create a vSwitch in cn-hangzhou-k based on real-time inventory and add it to the scaling group.</para>
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
            /// <para>1.5</para>
            /// </summary>
            [NameInMap("MaxPrice")]
            [Validation(Required=false)]
            public float? MaxPrice { get; set; }

        }

        /// <summary>
        /// <para>The information about specified instance types.</para>
        /// </summary>
        [NameInMap("InstanceTypeOverrides")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationShrinkRequestInstanceTypeOverrides> InstanceTypeOverrides { get; set; }
        public class ModifyScalingConfigurationShrinkRequestInstanceTypeOverrides : TeaModel {
            /// <summary>
            /// <para>To specify the capacity of an instance type in the scaling configuration, specify both this parameter and InstanceTypeOverride.WeightedCapacity.</para>
            /// <para>This parameter specifies the instance type. You can specify multiple instance types and use the InstanceTypeOverride.WeightedCapacity parameter to extend multi-instance-type support with custom weights.</para>
            /// <remarks>
            /// <para>You cannot specify this parameter together with instanceTypes.</para>
            /// </remarks>
            /// <para>Valid values of InstanceType: ECS instance types that are available for purchase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c5.xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>To scale the scaling group based on instance type capacity, specify this parameter after specifying LaunchTemplateOverride.InstanceType.</para>
            /// <para>This parameter specifies the weight of the instance type, which represents the capacity of a single instance of this type in the scaling group. A larger weight means fewer instances of this type are required to meet the expected capacity.</para>
            /// <para>Because instance types differ in vCPUs, memory, and other performance metrics, you can assign different weights to different instance types based on your requirements.</para>
            /// <para>Example:</para>
            /// <list type="bullet">
            /// <item><description>Current capacity: 0.</description></item>
            /// <item><description>Expected number of instances: 6.</description></item>
            /// <item><description>Capacity of ecs.c5.xlarge: 4.</description></item>
            /// </list>
            /// <para>To meet the expected capacity, the scaling group scales out 2 ecs.c5.xlarge instances.</para>
            /// <remarks>
            /// <para>During scale-out, the capacity of the scaling group cannot exceed the sum of the maximum capacity (MaxSize) and the maximum weight of the instance types.</para>
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
        /// <para>The instance types for multiple instance type support. If InstanceTypes is specified, InstanceType is ignored.</para>
        /// <para>When instances cannot be created by using the instance type with a higher priority, Auto Scaling automatically selects the instance type with the next priority to create instances.</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The billing method for network usage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayByBandwidth: pay-by-bandwidth. In this case, the value of InternetMaxBandwidthOut specifies the fixed bandwidth value. </description></item>
        /// <item><description>PayByTraffic: pay-by-traffic. In this case, the value of InternetMaxBandwidthOut specifies only the maximum bandwidth, and billing is based on the actual network traffic.</description></item>
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
        /// <item><description>If the purchased maximum outbound public bandwidth is less than or equal to 10 Mbit/s: 1 to 10. Default value: 10.</description></item>
        /// <item><description>If the purchased maximum outbound public bandwidth is greater than 10 Mbit/s: 1 to the value of <c>InternetMaxBandwidthOut</c>. Default value: the value of <c>InternetMaxBandwidthOut</c>.</description></item>
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
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is an I/O optimized instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>none: The instance is not an I/O optimized instance.</description></item>
        /// <item><description>optimized: The instance is an I/O optimization instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>The number of randomly generated IPv6 addresses allocated to the elastic network interfaces (ENIs).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// <para>The name of the key pair used to log on to the ECS instance. </para>
        /// <list type="bullet">
        /// <item><description>For Windows instances, this parameter is ignored and is empty by default. </description></item>
        /// <item><description>For Linux instances, password-based logon is disabled during initialization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KeyPair_Name</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The weight of SLB backend server. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("LoadBalancerWeight")]
        [Validation(Required=false)]
        public int? LoadBalancerWeight { get; set; }

        /// <summary>
        /// <para>The memory size. Unit: GiB.</para>
        /// <para>You can specify both CPU and Memory to define the range of instance types. For example, CPU=2 and Memory=16 defines all instance types with 2 vCPUs and 16 GiB of memory. Auto Scaling determines the set of active instance types based on factors such as I/O optimization and zones, and then creates instances of the lowest-priced instance type based on sorting by price.</para>
        /// <remarks>
        /// <para>This configuration takes effect only when the cost optimization mode is enabled and no instance type is specified in the scaling configuration.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The list of elastic network interfaces (ENIs).</para>
        /// </summary>
        [NameInMap("NetworkInterfaces")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationShrinkRequestNetworkInterfaces> NetworkInterfaces { get; set; }
        public class ModifyScalingConfigurationShrinkRequestNetworkInterfaces : TeaModel {
            /// <summary>
            /// <para>The type of the elastic network interfaces (ENIs). When you use this parameter, you must use NetworkInterfaces to set the primary network interface controller (NIC). You cannot set SecurityGroupId or SecurityGroupIds at the same time. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Primary: primary network interface controller (NIC).</description></item>
            /// <item><description>Secondary: secondary network interface controller (NIC).</description></item>
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
            /// <para>The number of randomly generated IPv6 addresses for the primary ENI. Note the following items:</para>
            /// <para>This parameter takes effect only when NetworkInterface.InstanceType is set to Primary. If NetworkInterface.InstanceType is set to Secondary or left empty, you cannot specify this parameter.</para>
            /// <para>After you specify this parameter, you cannot specify Ipv6AddressCount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Ipv6AddressCount")]
            [Validation(Required=false)]
            public int? Ipv6AddressCount { get; set; }

            /// <summary>
            /// <para>The communication mode of the network interface controller (NIC). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: uses the TCP communication mode.</description></item>
            /// <item><description>HighPerformance: enables the Elastic RDMA Interface (ERI) and uses the RDMA communication mode.</description></item>
            /// </list>
            /// <para>Default value: Standard.</para>
            /// <remarks>
            /// <para>The number of elastic network interfaces (ENIs) in RDMA mode cannot exceed the limit of the instance family. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HighPerformance</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// <para>The number of secondary private IPv4 addresses to assign to the ENI. Valid values: 1 to 49.</para>
            /// <list type="bullet">
            /// <item><description><para>The value cannot exceed the limit on the number of IP addresses for the instance type. For more information, see <a href="https://www.alibabacloud.com/help/en/ecs/user-guide/overview-of-instance-families">Instance families</a>.</para>
            /// </description></item>
            /// <item><description><para>NetworkInterface.N.SecondaryPrivateIpAddressCount specifies the number of secondary private IPv4 addresses to assign to the ENI (excluding the primary private IP address of the ENI). The system randomly assigns IP addresses from the available CIDR block of the vSwitch (NetworkInterface.N.VSwitchId) to which the ENI belongs.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("SecondaryPrivateIpAddressCount")]
            [Validation(Required=false)]
            public int? SecondaryPrivateIpAddressCount { get; set; }

            /// <summary>
            /// <para>The IDs of one or more security groups to which the elastic network interfaces (ENIs) belongs.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The IDs of the vSwitches to which the elastic network interfaces (ENIs) belongs. N specifies that you can set multiple vSwitches. Valid values of N: 1 to 10.</para>
            /// <para>Note the following items:</para>
            /// <list type="bullet">
            /// <item><description>If InstanceType is set to Primary, you cannot set this parameter. The default value is the vSwitch of the instance.</description></item>
            /// <item><description>If InstanceType is set to Secondary or left empty, this parameter is optional.</description></item>
            /// <item><description>The system selects a vSwitch that is in the same zone as the primary network interface controller (NIC) and has the most available IP addresses.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to override existing data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: overrides existing data.</description></item>
        /// <item><description>false: does not override existing data.</description></item>
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
        /// <para>The password of the ECS instance. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported:</para>
        /// <para>`()~!@#$%^&amp;*-_+=\|{}[]:;\&quot;&lt;&gt;,.?/</para>
        /// <para>For Windows instances, the password cannot start with a forward slash (/).</para>
        /// <remarks>
        /// <para>If you specify the Password parameter, we recommend that you send the request over HTTPS to prevent password leaks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123abc****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the password preset in the image. To use this parameter, ensure that a password is configured for the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The name of the RAM role associated with the ECS instance. This name is provided and maintained by RAM. You can call the ListRoles operation to query available RAM roles. For more information about how to create a RAM role, see the CreateRole operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RamRoleTest</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the ECS instance belongs.</para>
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
        /// <para>The resource pool policy used when creating instances. After you specify this parameter, note the following items:</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when pay-as-you-go instances are created.</para>
        /// </description></item>
        /// <item><description><para>This parameter cannot be specified together with PrivatePoolOptions.MatchCriteria or PrivatePoolOptions.Id.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResourcePoolOptions")]
        [Validation(Required=false)]
        public ModifyScalingConfigurationShrinkRequestResourcePoolOptions ResourcePoolOptions { get; set; }
        public class ModifyScalingConfigurationShrinkRequestResourcePoolOptions : TeaModel {
            /// <summary>
            /// <para>The private pool IDs, which are the elasticity assurance IDs or capacity reservation IDs. Only Target-type private pool IDs can be specified for this parameter. This parameter cannot be specified together with the PrivatePoolTags parameter.</para>
            /// </summary>
            [NameInMap("PrivatePoolIds")]
            [Validation(Required=false)]
            public List<string> PrivatePoolIds { get; set; }

            /// <summary>
            /// <para>Filters available Target private pools by tags. Valid values of N: 1 to 20.
            /// Note:</para>
            /// <list type="bullet">
            /// <item><description>When this parameter is specified, the system filters only the Target private pools associated with the account that match the tags and satisfy the scaling group constraints (such as zone and instance type).</description></item>
            /// <item><description>Tag matching rule: A private pool must match all specified tags.</description></item>
            /// <item><description>This parameter cannot be specified together with the PrivatePoolIds parameter.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("PrivatePoolTags")]
            [Validation(Required=false)]
            public List<ModifyScalingConfigurationShrinkRequestResourcePoolOptionsPrivatePoolTags> PrivatePoolTags { get; set; }
            public class ModifyScalingConfigurationShrinkRequestResourcePoolOptionsPrivatePoolTags : TeaModel {
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
            /// <para>Resource pools include private pools generated after elasticity assurance or capacity reservation takes effect, and public pools, which are available for instance startup. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PrivatePoolFirst: private pool first. When this strategy is selected, if ResourcePoolOptions.PrivatePoolIds is specified or PrivatePoolTags conditions are met, the corresponding private pools are used first. If no private pool is specified or the specified private pool has insufficient capacity, open-type private pools are automatically matched. If no eligible private pool is available, the public pool is used to create instances.</para>
            /// </description></item>
            /// <item><description><para>PrivatePoolOnly: private pool only. When this strategy is selected, you must specify ResourcePoolOptions.PrivatePoolIds. If the specified private pool has insufficient capacity, the instance fails to start.</para>
            /// </description></item>
            /// <item><description><para>PublicPoolFirst: public pool first. The public pool is used first to create instances. When public pool resources are insufficient, private pool resources are used as a supplement. Open-type private pools are automatically matched first. If no eligible private pool is available, the Target-type private pools specified by ResourcePoolOptions.PrivatePoolIds or matching PrivatePoolTags conditions are used. (This strategy is in invitational preview and is not available for use.)</para>
            /// </description></item>
            /// <item><description><para>None: does not use a resource pool strategy.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: None.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrivatePoolFirst</para>
            /// </summary>
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public string Strategy { get; set; }

        }

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
        /// <para>The name of the scaling configuration. The name must be 2 to 64 characters in length and can contain letters, digits, underscores (_), hyphens (-), and periods (.). It must start with a letter, digit, or Chinese character.</para>
        /// <para>The name of the scaling configuration must be unique within a scaling group in the same region. If you do not specify this parameter, the ID of the scaling configuration is used by default.</para>
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
        /// <para>{&quot;managedPrivateSpaceId&quot;:&quot;testManagedPrivateSpaceId****&quot;}</para>
        /// </summary>
        [NameInMap("SchedulerOptions")]
        [Validation(Required=false)]
        public string SchedulerOptionsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether a vSwitch must be selected from the VSwitchIds list for the secondary elastic network interfaces (ENIs) when the VSwitchIds parameter is set for the secondary network interface controller (NIC).</para>
        /// <list type="bullet">
        /// <item><description>Strict: strict mode. If no vSwitch in VSwitchIds meets the conditional requirements, instance creation fails.</description></item>
        /// <item><description>Tolerant: tolerant mode. If no vSwitch in VSwitchIds meets the conditional requirements, no secondary network interface controller (NIC) is configured, but the instance is still created as active.</description></item>
        /// </list>
        /// <para>Default value: Strict.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Strict</para>
        /// </summary>
        [NameInMap("SecondaryEniVSwitchConstraint")]
        [Validation(Required=false)]
        public string SecondaryEniVSwitchConstraint { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the ECS instance belongs. ECS instances in the same security group can access each other.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-F876F****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the security groups to which the instance belongs.</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The security options.</para>
        /// </summary>
        [NameInMap("SecurityOptions")]
        [Validation(Required=false)]
        public ModifyScalingConfigurationShrinkRequestSecurityOptions SecurityOptions { get; set; }
        public class ModifyScalingConfigurationShrinkRequestSecurityOptions : TeaModel {
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
        /// <para>The protection period of the spot instance. Unit: hours. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: After a spot instance is created, Alibaba Cloud ensures that the instance is not automatically released within 1 hour. After 1 hour, the system compares the bid price with the market price and checks resource availability to determine whether to retain automatic release the instance.</description></item>
        /// <item><description>0: After a spot instance is created, Alibaba Cloud does not ensure that the instance runs for 1 hour. The system compares the bid price with the market price and checks resource availability to determine whether to retain automatic release the instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Alibaba Cloud sends an ECS system event notification 5 minutes before the instance is released. Spot instances are billed by second. We recommend that you select an appropriate protection period based on the expected task execution duration.</para>
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
        /// <para>The interruption mode of the spot instance. Currently, only Terminate (default) is supported, which directly releases the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Terminate</para>
        /// </summary>
        [NameInMap("SpotInterruptionBehavior")]
        [Validation(Required=false)]
        public string SpotInterruptionBehavior { get; set; }

        /// <summary>
        /// <para>The information about spot instance types.</para>
        /// </summary>
        [NameInMap("SpotPriceLimits")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationShrinkRequestSpotPriceLimits> SpotPriceLimits { get; set; }
        public class ModifyScalingConfigurationShrinkRequestSpotPriceLimits : TeaModel {
            /// <summary>
            /// <para>The instance type of the spot instance. This parameter takes effect only when SpotStrategy is set to SpotWithPriceLimit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g6.large</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The bid price for the spot instance. This parameter takes effect only when SpotStrategy is set to SpotWithPriceLimit.</para>
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
        /// <item><description>NoSpot: a regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: a spot instance with a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: a spot instance for which the market price at the time of purchase is automatically used as the bid price.</description></item>
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
        /// <para>The maximum number of partitions in the storage set. The value must be an integer that is greater than or equal to 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        /// <summary>
        /// <para>The multi-disk types for the system cloud disk. When a disk type with a higher priority is unavailable, Auto Scaling automatically attempts the next-priority disk type to create the system cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud: basic cloud disk.</description></item>
        /// <item><description>cloud_efficiency: ultra cloud disk.</description></item>
        /// <item><description>cloud_ssd: standard SSD.</description></item>
        /// <item><description>cloud_essd: Enterprise SSD (ESSD).</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you specify this parameter, you cannot specify <c>SystemDisk.Category</c> at the same time.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SystemDiskCategories")]
        [Validation(Required=false)]
        public List<string> SystemDiskCategories { get; set; }

        /// <summary>
        /// <para>The tags of the ECS instance. Tags are specified as key-value pairs. You can specify up to 20 tags. The following limits apply to Key and Value: </para>
        /// <list type="bullet">
        /// <item><description>Key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>. Key cannot be an empty string. </description></item>
        /// <item><description>Value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>. Value can be an empty string.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;:&quot;value1&quot;,&quot;key2&quot;:&quot;value2&quot;, ... &quot;key5&quot;:&quot;value5&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>Specifies whether to create the instance on a dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>default: creates an instance that is not on a dedicated host.</para>
        /// </description></item>
        /// <item><description><para>host: creates an instance on a dedicated host. If you do not specify DedicatedHostId, Alibaba Cloud automatically selects a dedicated host for the instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Tenancy")]
        [Validation(Required=false)]
        public string Tenancy { get; set; }

        /// <summary>
        /// <para>The user data of the ECS instance. The data must be encoded in Base64. The maximum size of the raw data before encoding is 32 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The zone ID of the ECS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
