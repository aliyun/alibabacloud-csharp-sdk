// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyScalingConfigurationRequest : TeaModel {
        [NameInMap("ImageOptions")]
        [Validation(Required=false)]
        public ModifyScalingConfigurationRequestImageOptions ImageOptions { get; set; }
        public class ModifyScalingConfigurationRequestImageOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to log on to the ECS instance as the ecs-user user. For more information, see <a href="https://help.aliyun.com/document_detail/388447.html">Manage logon usernames of ECS instances</a>. Valid values:</para>
            /// <para>true: yes.</para>
            /// <para>false: no.</para>
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
        public ModifyScalingConfigurationRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class ModifyScalingConfigurationRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// <para>The ID of the private pool. The private pool can be an Elastic Assurance service or a Capacity Reservation service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eap-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The capacity option of the private pool for starting the instance. The private pool is generated after an Elastic Assurance service or a Capacity Reservation service takes effect. You can select a private pool to start an instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Open: open mode. The system automatically matches the instance with an open private pool. If no open private pools are available, the instance is started using public pool resources. You do not need to set the \<c>PrivatePoolOptions.Id\\</c> parameter in this mode.</para>
            /// </description></item>
            /// <item><description><para>Target: specified mode. The instance is started using the capacity of a specified private pool. If the specified private pool is unavailable, the instance fails to start. You must specify the private pool ID by setting the \<c>PrivatePoolOptions.Id\\</c> parameter in this mode.</para>
            /// </description></item>
            /// <item><description><para>None: no mode. The instance is not started using the capacity of a private pool.</para>
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
        public ModifyScalingConfigurationRequestSystemDisk SystemDisk { get; set; }
        public class ModifyScalingConfigurationRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy used for the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-bp12m37ccmxvbmi5****</para>
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the performance burst feature for the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: enable.</para>
            /// </description></item>
            /// <item><description><para>false: disable.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is supported only when <c>SystemDisk.Category</c> is set to <c>cloud_auto</c>.</para>
            /// </remarks>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
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
            /// <item><description><para>cloud: basic disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_efficiency: ultra disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_ssd: standard SSD.</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: ESSD.</para>
            /// </description></item>
            /// <item><description><para>ephemeral_ssd: local SSD.</para>
            /// </description></item>
            /// </list>
            /// <para>You cannot specify this parameter and <c>SystemDiskCategories</c> at the same time. If neither this parameter nor <c>SystemDiskCategories</c> is specified, this parameter has a default value. If the instance type is from instance family I and the instance is not I/O optimized, the default value is \<c>cloud\\</c>. Otherwise, the default value is \<c>cloud_efficiency\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The description of the system disk. The description must be 2 to 256 English or Chinese characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test system disk.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the system disk. The name must be 2 to 128 English or Chinese characters in length. It must start with a letter or a Chinese character and cannot start with http\:// or https\://. It can contain digits, colons (:), underscores (_), and hyphens (-). Default value: empty</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdSystem</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>The encryption algorithm used for the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>AES-256.</para>
            /// </description></item>
            /// <item><description><para>SM4-128.</para>
            /// </description></item>
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
            /// <item><description><para>true: encrypt the system disk.</para>
            /// </description></item>
            /// <item><description><para>false: do not encrypt the system disk.</para>
            /// </description></item>
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
            /// <para>The ID of the KMS key used for the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD that is used as the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PL0: A single disk can deliver up to 10,000 random read/write IOPS.</para>
            /// </description></item>
            /// <item><description><para>PL1: A single disk can deliver up to 50,000 random read/write IOPS.</para>
            /// </description></item>
            /// <item><description><para>PL2: A single disk can deliver up to 100,000 random read/write IOPS.</para>
            /// </description></item>
            /// <item><description><para>PL3: A single disk can deliver up to 1,000,000 random read/write IOPS.</para>
            /// </description></item>
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
            /// <para>The pre-configured IOPS of the system disk.</para>
            /// <remarks>
            /// <para>IOPS, or input/output operations per second, is the number of I/O operations that a block storage device can process per second. It indicates the read and write performance of the block storage device.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB. Value range:</para>
            /// <list type="bullet">
            /// <item><description><para>Basic disks: 20 to 500.</para>
            /// </description></item>
            /// <item><description><para>ESSDs:</para>
            /// <list type="bullet">
            /// <item><description><para>PL0: 1 to 2048.</para>
            /// </description></item>
            /// <item><description><para>PL1: 20 to 2048.</para>
            /// </description></item>
            /// <item><description><para>PL2: 461 to 2048.</para>
            /// </description></item>
            /// <item><description><para>PL3: 1261 to 2048.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>ESSD AutoPL cloud disks: 1 to 2048.</para>
            /// </description></item>
            /// <item><description><para>Other disk categories: 20 to 2048.</para>
            /// </description></item>
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
        /// <para>Specifies whether to associate the instance on a dedicated host with the dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>default: The instance is not associated with the dedicated host. If you restart an instance that was stopped in economical mode, the instance may be placed on a different dedicated host in the automatic deployment resource pool if the resources of the original dedicated host are insufficient.</para>
        /// </description></item>
        /// <item><description><para>host: The instance is associated with the dedicated host. If you restart an instance that was stopped in economical mode, the instance is still placed on the original dedicated host. If the resources of the original dedicated host are insufficient, the instance fails to restart.</para>
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
        /// <para>You can specify both \<c>Cpu\\</c> and \<c>Memory\\</c> to define a range of instance types. For example, if you set \<c>Cpu\\</c> to 2 and \<c>Memory\\</c> to 16, all instance types with 2 vCPUs and 16 GiB of memory are matched. Auto Scaling determines the available instance types based on factors such as I/O optimization and zone, and then creates the instance of the lowest-priced instance type.</para>
        /// <remarks>
        /// <para>This configuration is effective only when the cost optimization mode is enabled and no instance types are specified in the scaling configuration.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>The performance mode of the burstable instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard: the standard mode. For more information about the instance performance, see the &quot;Performance modes&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">What is a burstable instance?</a>.</para>
        /// </description></item>
        /// <item><description><para>Unlimited: the unlimited mode. For more information about the instance performance, see the &quot;Performance modes&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">What is a burstable instance?</a>.</para>
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
        /// <para>The custom priority of the ECS instance type and vSwitch.</para>
        /// <remarks>
        /// <para>Notice: This parameter is in effect only when the scaling policy of the scaling group is set to the priority-based policy.</para>
        /// </remarks>
        /// <para>If an instance cannot be created using the instance type and vSwitch with a higher priority, Auto Scaling automatically uses the instance type and vSwitch combination with the next priority to create the instance.</para>
        /// <remarks>
        /// <para>If you specify custom priorities for only some instance type and vSwitch combinations, the combinations for which you do not specify custom priorities have a lower priority than the combinations for which you specify custom priorities. The priority of the combinations for which you do not specify custom priorities is determined by the order of vSwitches in the scaling group and the order of instance types in the scaling configuration.</para>
        /// <list type="bullet">
        /// <item><description>For example, if the vSwitches in the scaling group are ordered as vsw1 and vsw2, the instance types in the scaling configuration are ordered as type1 and type2, and the custom priority is set to [&quot;vsw2+type2&quot;, &quot;vsw1+type2&quot;], the final priority is: &quot;vsw2+type2&quot; &gt; &quot;vsw1+type2&quot; &gt; &quot;vsw1+type1&quot; &gt; &quot;vsw2+type1&quot;.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("CustomPriorities")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationRequestCustomPriorities> CustomPriorities { get; set; }
        public class ModifyScalingConfigurationRequestCustomPriorities : TeaModel {
            /// <summary>
            /// <para>The instance type of the ECS instance.</para>
            /// <remarks>
            /// <para>The instance type must be included in the list of instance types in the scaling configuration.</para>
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
            /// <para>The vSwitch must be included in the list of vSwitches in the scaling group.</para>
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
        /// <para>The collection of data disk information.</para>
        /// </summary>
        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationRequestDataDisks> DataDisks { get; set; }
        public class ModifyScalingConfigurationRequestDataDisks : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy used for the data disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-bp19nq9enxqkomib****</para>
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable performance burst for the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter takes effect only when <c>SystemDisk.Category</c> is set to <c>cloud_auto</c>.</para>
            /// </remarks>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// <para>The categories of the data disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>cloud: basic disk. The \<c>DeleteWithInstance\\</c> attribute of a basic disk that is created with an instance is \<c>true\\</c>.</para>
            /// </description></item>
            /// <item><description><para>cloud_efficiency: ultra disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_ssd: standard SSD.</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: ESSD.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>You cannot specify this parameter and <c>DataDisk.Category</c> at the same time.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// <para>The category of the data disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>cloud: basic disk. The \<c>DeleteWithInstance\\</c> attribute of a basic disk that is created with an instance is \<c>true\\</c>.</para>
            /// </description></item>
            /// <item><description><para>cloud_efficiency: ultra disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_ssd: standard SSD.</para>
            /// </description></item>
            /// <item><description><para>ephemeral_ssd: local SSD.</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: ESSD.</para>
            /// </description></item>
            /// </list>
            /// <para>You cannot specify this parameter and <c>DataDisk.Categories</c> at the same time. If neither this parameter nor <c>DataDisk.Categories</c> is specified, this parameter has a default value:</para>
            /// <list type="bullet">
            /// <item><description><para>For I/O optimized instances, the default value is \<c>cloud_efficiency\\</c>.</para>
            /// </description></item>
            /// <item><description><para>For non-I/O optimized instances, the default value is \<c>cloud\\</c>.</para>
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
            /// <para>Specifies whether to release the data disk when the instance is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The disk is released with the instance.</para>
            /// </description></item>
            /// <item><description><para>false: The disk is not released with the instance.</para>
            /// </description></item>
            /// </list>
            /// <para>You can set this parameter only for independent cloud disks (\<c>DataDisk.Category\\</c> is \<c>cloud\\</c>, \<c>cloud_efficiency\\</c>, \<c>cloud_ssd\\</c>, \<c>cloud_essd\\</c>, or \<c>cloud_auto\\</c>). Otherwise, an error occurs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DeleteWithInstance")]
            [Validation(Required=false)]
            public bool? DeleteWithInstance { get; set; }

            /// <summary>
            /// <para>The description of the data disk. The description must be 2 to 256 English or Chinese characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test data disk.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The mount point of the data disk. If you do not specify this parameter, the system allocates a mount point when the ECS instance is automatically created. The mount point starts from /dev/xvdb and goes to /dev/xvdz.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/dev/xvdd</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The name of the data disk. The name must be 2 to 128 English or Chinese characters in length. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdData</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>Specifies whether the system disk is encrypted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The system disk is encrypted.</para>
            /// </description></item>
            /// <item><description><para>false: The system disk is not encrypted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key for the data disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD that is used as the data disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PL0: A single disk can deliver up to 10,000 random read/write IOPS.</para>
            /// </description></item>
            /// <item><description><para>PL1: A single disk can deliver up to 50,000 random read/write IOPS.</para>
            /// </description></item>
            /// <item><description><para>PL2: A single disk can deliver up to 100,000 random read/write IOPS.</para>
            /// </description></item>
            /// <item><description><para>PL3: A single disk can deliver up to 1,000,000 random read/write IOPS.</para>
            /// </description></item>
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
            /// <para>The pre-configured IOPS of the data disk.</para>
            /// <remarks>
            /// <para>IOPS, or input/output operations per second, is the number of I/O operations that a block storage device can process per second. It indicates the read and write performance of the block storage device.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the data disk. Unit: GiB. Value range:</para>
            /// <list type="bullet">
            /// <item><description><para>cloud: 5 to 2000.</para>
            /// </description></item>
            /// <item><description><para>cloud_efficiency: 20 to 32768.</para>
            /// </description></item>
            /// <item><description><para>cloud_ssd: 20 to 32768.</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: 20 to 32768.</para>
            /// </description></item>
            /// <item><description><para>ephemeral_ssd: 5 to 800.</para>
            /// </description></item>
            /// </list>
            /// <para>If you specify this parameter, the disk size must be greater than or equal to the size of the snapshot specified by \<c>SnapshotId\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The snapshot that is used to create the data disk. If you specify this parameter, \<c>DataDisk.Size\\</c> is ignored, and the size of the created disk is the size of the specified snapshot.</para>
            /// <para>If the snapshot was created on or before July 15, 2013, the call is rejected, and the \<c>InvalidSnapshot.TooOld\\</c> error is returned.</para>
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
        /// <para>Specifies whether to create the ECS instance on a dedicated host. If you specify \<c>DedicatedHostId\\</c>, the \<c>SpotStrategy\\</c> and \<c>SpotPriceLimit\\</c> settings in the request are ignored. This is because dedicated hosts do not support spot instances.</para>
        /// <para>You can call the DescribeDedicatedHosts operation to query the list of dedicated host IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// <para>The release protection attribute of the instance. This parameter specifies whether you can release the instance using the ECS console or by calling the DeleteInstance operation. This prevents the instance from being accidentally released. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables release protection. You cannot release the instance using the ECS console or by calling the DeleteInstance operation.</para>
        /// </description></item>
        /// <item><description><para>false: disables release protection. You can release the instance using the ECS console or by calling the DeleteInstance operation.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This attribute applies only to pay-as-you-go instances. It prevents the instances that are scaled out by Auto Scaling from being accidentally released. This attribute does not affect normal scale-in activities. Instances for which release protection is enabled can be released during scale-in activities.</para>
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
        /// <para>The hostname of the ECS instance. A period (.) or a hyphen (-) cannot be used as the first or last character of the hostname. Consecutive periods (.) or hyphens (-) are not allowed. The naming conventions for hostnames vary based on the instance operating system:</para>
        /// <list type="bullet">
        /// <item><description><para>For Windows instances, the hostname must be 2 to 15 characters in length and can contain letters, digits, and hyphens (-). It cannot contain periods (.) or consist of only digits.</para>
        /// </description></item>
        /// <item><description><para>For other instance types, such as Linux, the hostname must be 2 to 64 characters in length. You can use periods (.) to separate the hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-).</para>
        /// </description></item>
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
        /// <item><description><para>enabled: enable.</para>
        /// </description></item>
        /// <item><description><para>disabled: disable.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: enabled.</para>
        /// <remarks>
        /// <para>For more information about instance metadata, see <a href="https://help.aliyun.com/document_detail/108460.html">Overview of instance metadata</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("HttpEndpoint")]
        [Validation(Required=false)]
        public string HttpEndpoint { get; set; }

        /// <summary>
        /// <para>Specifies whether to enforce the security-hardened mode (IMDSv2) when you access instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>optional: does not enforce the use of IMDSv2.</para>
        /// </description></item>
        /// <item><description><para>required: enforces the use of IMDSv2. If you set the value to \<c>required\\</c>, you cannot access instance metadata in normal mode.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: optional.</para>
        /// <remarks>
        /// <para>For more information about how to access instance metadata, see <a href="https://help.aliyun.com/document_detail/108460.html">Access modes of instance metadata</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>optional</para>
        /// </summary>
        [NameInMap("HttpTokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

        /// <summary>
        /// <para>The name of the image family. You can set this parameter to obtain the latest available image from the specified image family to create instances. If you have set the <c>ImageId</c> parameter, you cannot set this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou-daily-update</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The ID of the image file that is used to create the instances.</para>
        /// <remarks>
        /// <para>If the image that was previously used in the scaling configuration includes a system disk and data disks, the original data disk information is cleared after you change the image.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>centos6u5_64_20G_aliaegis_2014****.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the image file. The image name must be unique in a region. If you specify \<c>ImageId\\</c>, \<c>ImageName\\</c> is ignored.</para>
        /// <para>You cannot use \<c>ImageName\\</c> to specify a Marketplace image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>suse11sp3_64_20G_aliaegis_2015****.vhd</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The description of the ECS instance. The description must be 2 to 256 English or Chinese characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test instance.</para>
        /// </summary>
        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        /// <summary>
        /// <para>The name of the ECS instances that are automatically created using this scaling configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inst****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The collection of intelligent configuration information that is used to filter instance types that meet the specified requirements.</para>
        /// </summary>
        [NameInMap("InstancePatternInfos")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationRequestInstancePatternInfos> InstancePatternInfos { get; set; }
        public class ModifyScalingConfigurationRequestInstancePatternInfos : TeaModel {
            /// <summary>
            /// <para>The architecture type of the instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>X86: x86.</para>
            /// </description></item>
            /// <item><description><para>Heterogeneous: heterogeneous computing, such as GPU and FPGA.</para>
            /// </description></item>
            /// <item><description><para>BareMental: ECS Bare Metal Instance.</para>
            /// </description></item>
            /// <item><description><para>Arm: Arm.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: all architecture types.</para>
            /// </summary>
            [NameInMap("Architectures")]
            [Validation(Required=false)]
            public List<string> Architectures { get; set; }

            /// <summary>
            /// <para>Specifies whether to include burstable instance types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Exclude: do not include burstable instance types.</para>
            /// </description></item>
            /// <item><description><para>Include: include burstable instance types.</para>
            /// </description></item>
            /// <item><description><para>Required: include only burstable instance types.</para>
            /// </description></item>
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
            /// <para>The number of vCPU cores of the instance type in intelligent configuration mode. This parameter is used to filter instance types. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// <para>Note the following information:</para>
            /// <list type="bullet">
            /// <item><description><para>The \<c>InstancePatternInfo\\</c> parameter is applicable only to scaling groups whose NetworkType is set to VPC.</para>
            /// </description></item>
            /// <item><description><para>You must specify \<c>InstancePatternInfo.Cores\\</c> and \<c>InstancePatternInfo.Memory\\</c> at the same time.</para>
            /// </description></item>
            /// <item><description><para>If you specify instance types using the \<c>InstanceType\\</c> or \<c>InstanceTypes\\</c> parameter, Auto Scaling preferentially uses the specified instance types for scale-out activities. If the specified instance types are out of stock, Auto Scaling uses the lowest-priced instance type among those that meet the requirements specified by the \<c>InstancePatternInfo\\</c> parameter for scale-out activities.</para>
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
            /// <para>The CPU architecture of the instance. Valid values:</para>
            /// <remarks>
            /// <para>You can specify up to two CPU architectures.</para>
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
            /// <para>The instance types to exclude. You can use a wildcard character (\*) to exclude an instance type or an entire instance family. Examples:</para>
            /// <list type="bullet">
            /// <item><description><para>ecs.c6.large: excludes the ecs.c6.large instance type.</para>
            /// </description></item>
            /// <item><description><para>ecs.c6.\*: excludes all instance types of the c6 family.</para>
            /// </description></item>
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
            /// <para>The category of the instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>General-purpose: General-purpose.</para>
            /// </description></item>
            /// <item><description><para>Compute-optimized: compute-optimized.</para>
            /// </description></item>
            /// <item><description><para>Memory-optimized: memory-optimized.</para>
            /// </description></item>
            /// <item><description><para>Big data: big data.</para>
            /// </description></item>
            /// <item><description><para>Local SSDs: local SSD.</para>
            /// </description></item>
            /// <item><description><para>High Clock Speed: high frequency.</para>
            /// </description></item>
            /// <item><description><para>Enhanced: enhanced instance families.</para>
            /// </description></item>
            /// <item><description><para>Shared: shared-resource instances.</para>
            /// </description></item>
            /// <item><description><para>Compute-optimized with GPU: GPU.</para>
            /// </description></item>
            /// <item><description><para>Visual Compute-optimized: visual compute-optimized.</para>
            /// </description></item>
            /// <item><description><para>Heterogeneous Service: heterogeneous computing.</para>
            /// </description></item>
            /// <item><description><para>Compute-optimized with FPGA: FPGA.</para>
            /// </description></item>
            /// <item><description><para>Compute-optimized with NPU: NPU-accelerated.</para>
            /// </description></item>
            /// <item><description><para>ECS Bare Metal: ECS Bare Metal Instance.</para>
            /// </description></item>
            /// <item><description><para>High Performance Compute: high-performance computing (HPC).</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("InstanceCategories")]
            [Validation(Required=false)]
            public List<string> InstanceCategories { get; set; }

            /// <summary>
            /// <para>The level of the instance family. This parameter is used to filter instance types. This parameter takes effect only when \<c>CostOptimization\\</c> is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>EntryLevel: entry-level instances (shared). This instance type is cost-effective but does not provide stable computing performance. It is suitable for business scenarios that have low CPU utilization. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared instance families</a>.</para>
            /// </description></item>
            /// <item><description><para>EnterpriseLevel: enterprise-level instances. This instance type provides stable performance and dedicated resources, and is suitable for business scenarios that have high stability requirements. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// </description></item>
            /// <item><description><para>CreditEntryLevel: credit entry-level instances (burstable). This instance type provides CPU credits to ensure computing performance. It is suitable for business scenarios that have low and sporadic CPU utilization. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</para>
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
            /// <para>The instance families to query. You can specify up to 10 instance families.</para>
            /// </summary>
            [NameInMap("InstanceTypeFamilies")]
            [Validation(Required=false)]
            public List<string> InstanceTypeFamilies { get; set; }

            /// <summary>
            /// <para>The maximum hourly price that you can accept for a pay-as-you-go or spot instance in intelligent configuration mode. This parameter is used to filter instance types.</para>
            /// <remarks>
            /// <para>This parameter is required when \<c>SpotStrategy\\</c> is set to \<c>SpotWithPriceLimit\\</c>. In other cases, this parameter is optional.</para>
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
            /// <para>The value of \<c>MaximumCpuCoreCount\\</c> cannot be more than four times the value of \<c>MinimumCpuCoreCount\\</c>.</para>
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
            /// <para>The memory size of the instance type in intelligent configuration mode. Unit: GiB. This parameter is used to filter instance types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The minimum baseline vCPU computing performance (for all vCPUs) of a t5 or t6 burstable instance.</para>
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
            /// <para>The minimum number of IPv6 addresses that can be assigned to a single ENI of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinimumEniIpv6AddressQuantity")]
            [Validation(Required=false)]
            public int? MinimumEniIpv6AddressQuantity { get; set; }

            /// <summary>
            /// <para>The minimum number of IPv4 addresses that can be assigned to a single ENI of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MinimumEniPrivateIpAddressQuantity")]
            [Validation(Required=false)]
            public int? MinimumEniPrivateIpAddressQuantity { get; set; }

            /// <summary>
            /// <para>The minimum number of ENIs that can be attached to the instance.</para>
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
            /// <para>The minimum initial vCPU credit for a t5 or t6 burstable instance.</para>
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
            /// <para>The processor model of the instance. You can specify up to 10 processor models.</para>
            /// </summary>
            [NameInMap("PhysicalProcessorModels")]
            [Validation(Required=false)]
            public List<string> PhysicalProcessorModels { get; set; }

        }

        /// <summary>
        /// <para>After you enable the alternative mode, if issues such as insufficient inventory occur, the system supplements the selected instance types with similar instance types of the same size, or creates vSwitches in alternative zones and adds them to the scaling group.</para>
        /// </summary>
        [NameInMap("InstanceTypeCandidateOptions")]
        [Validation(Required=false)]
        public ModifyScalingConfigurationRequestInstanceTypeCandidateOptions InstanceTypeCandidateOptions { get; set; }
        public class ModifyScalingConfigurationRequestInstanceTypeCandidateOptions : TeaModel {
            /// <summary>
            /// <para>When supplementing with vSwitches from other zones is allowed, you must specify the optional CIDR blocks for the vSwitches.</para>
            /// </summary>
            [NameInMap("AllowCidrBlocks")]
            [Validation(Required=false)]
            public List<string> AllowCidrBlocks { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow supplementing with vSwitches from other zones.</para>
            /// <remarks>
            /// <para>The instance type remains unchanged, and only new zones are selected as alternatives. When the scaling group cannot be scaled out in any of the selected zones due to issues such as insufficient inventory, the system automatically adds a new vSwitch in another zone to the scaling group based on this configuration.
            /// For example, if the scaling group is configured with zones cn-hangzhou-h and cn-hangzhou-g, and scale-out fails in both zones, ESS may create a vSwitch in cn-hangzhou-k and add it to the scaling group based on real-time inventory.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowCrossAz")]
            [Validation(Required=false)]
            public bool? AllowCrossAz { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow supplementing with instance types from other generations.</para>
            /// <list type="bullet">
            /// <item><description>For example, if the current instance type is ecs.c7.large, you can enable this feature to use alternative instance types such as ecs.c6.large and ecs.c8.large.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowDifferentGeneration")]
            [Validation(Required=false)]
            public bool? AllowDifferentGeneration { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the alternative mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The maximum price for alternative instance types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.5</para>
            /// </summary>
            [NameInMap("MaxPrice")]
            [Validation(Required=false)]
            public float? MaxPrice { get; set; }

        }

        /// <summary>
        /// <para>The information about the specified instance types.</para>
        /// </summary>
        [NameInMap("InstanceTypeOverrides")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationRequestInstanceTypeOverrides> InstanceTypeOverrides { get; set; }
        public class ModifyScalingConfigurationRequestInstanceTypeOverrides : TeaModel {
            /// <summary>
            /// <para>If you want to specify the capacity of an instance type in a scaling configuration, specify this parameter and \<c>InstanceTypeOverride.WeightedCapacity\\</c>.</para>
            /// <para>This parameter is used to specify an instance type. You can specify this parameter multiple times. You can use this parameter with the \<c>InstanceTypeOverride.WeightedCapacity\\</c> parameter to enable custom weights for multiple instance types.</para>
            /// <remarks>
            /// <para>If you specify this parameter, you cannot specify \<c>instanceTypes\\</c>.</para>
            /// </remarks>
            /// <para>Valid values of InstanceType: available ECS instance types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c5.xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>If you want the scaling group to scale based on the capacity of instance types, specify this parameter after you specify \<c>LaunchTemplateOverride.InstanceType\\</c>.</para>
            /// <para>This parameter specifies the weight of an instance type, which indicates the capacity of a single instance of the specified instance type in the scaling group. A higher weight indicates that a smaller number of instances of the specified instance type are required to meet the expected capacity.</para>
            /// <para>You can set different weights for different instance types as needed because the performance metrics, such as the number of vCPUs and memory size, vary based on the instance type.</para>
            /// <para>For example:</para>
            /// <list type="bullet">
            /// <item><description><para>Current capacity: 0.</para>
            /// </description></item>
            /// <item><description><para>Expected capacity: 6.</para>
            /// </description></item>
            /// <item><description><para>Capacity of the ecs.c5.xlarge instance type: 4.</para>
            /// </description></item>
            /// </list>
            /// <para>To meet the expected capacity, the scaling group scales out two ecs.c5.xlarge instances.</para>
            /// <remarks>
            /// <para>The capacity of the scaling group after a scale-out activity cannot exceed the sum of the maximum capacity (MaxSize) and the maximum weight of an instance type.</para>
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
        /// <para>The instance types. If you use \<c>InstanceTypes\\</c>, \<c>InstanceType\\</c> is ignored.</para>
        /// <para>If an instance cannot be created using the instance type with a higher priority, Auto Scaling automatically uses the instance type with the next priority to create the instance.</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The billing method for network usage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PayByBandwidth: pay-by-bandwidth. If you set the value to PayByBandwidth, the value of \<c>InternetMaxBandwidthOut\\</c> is the selected fixed bandwidth.</para>
        /// </description></item>
        /// <item><description><para>PayByTraffic: pay-by-data-transfer. If you set the value to PayByTraffic, the value of \<c>InternetMaxBandwidthOut\\</c> is the maximum bandwidth, and the billing is based on the actual network traffic.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByBandwidth</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The maximum inbound public bandwidth. Unit: Mbit/s. Value range:</para>
        /// <list type="bullet">
        /// <item><description><para>If the purchased outbound public bandwidth is less than or equal to 10 Mbit/s: 1 to 10. The default value is 10.</para>
        /// </description></item>
        /// <item><description><para>If the purchased outbound public bandwidth is greater than 10 Mbit/s: 1 to the value of <c>InternetMaxBandwidthOut</c>. The default value is the value of <c>InternetMaxBandwidthOut</c>.</para>
        /// </description></item>
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
        /// <para>Specifies whether the instance is I/O optimized. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>none: The instance is not I/O optimized.</para>
        /// </description></item>
        /// <item><description><para>optimized: The instance is I/O optimized.</para>
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
        /// <para>The number of randomly generated IPv6 addresses to be assigned to the ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// <para>The name of the key pair that is used to log on to the ECS instance.</para>
        /// <list type="bullet">
        /// <item><description><para>For Windows instances, this parameter is ignored. The default value is empty.</para>
        /// </description></item>
        /// <item><description><para>For Linux instances, password-based logon is disabled by default.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KeyPair_Name</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The weight of the backend server. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("LoadBalancerWeight")]
        [Validation(Required=false)]
        public int? LoadBalancerWeight { get; set; }

        /// <summary>
        /// <para>The memory size. Unit: GiB.</para>
        /// <para>You can specify both \<c>Cpu\\</c> and \<c>Memory\\</c> to define a range of instance types. For example, if you set \<c>Cpu\\</c> to 2 and \<c>Memory\\</c> to 16, all instance types with 2 vCPUs and 16 GiB of memory are matched. Auto Scaling determines the available instance types based on factors such as I/O optimization and zone, and then creates the instance of the lowest-priced instance type.</para>
        /// <remarks>
        /// <para>This configuration is effective only when the cost optimization mode is enabled and no instance types are specified in the scaling configuration.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The list of ENIs.</para>
        /// </summary>
        [NameInMap("NetworkInterfaces")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationRequestNetworkInterfaces> NetworkInterfaces { get; set; }
        public class ModifyScalingConfigurationRequestNetworkInterfaces : TeaModel {
            /// <summary>
            /// <para>The type of the ENI. When you use this parameter, you must use \<c>NetworkInterfaces\\</c> to configure the primary ENI. You cannot set the \<c>SecurityGroupId\\</c> or \<c>SecurityGroupIds\\</c> parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Primary: primary ENI.</para>
            /// </description></item>
            /// <item><description><para>Secondary: secondary ENI.</para>
            /// </description></item>
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
            /// <para>The number of randomly generated IPv6 addresses to be assigned to the primary ENI. Note:</para>
            /// <para>This parameter takes effect only when \<c>NetworkInterface.InstanceType\\</c> is set to \<c>Primary\\</c>. You cannot set this parameter if \<c>NetworkInterface.InstanceType\\</c> is set to \<c>Secondary\\</c> or is empty.</para>
            /// <para>After you set this parameter, you cannot set \<c>Ipv6AddressCount\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Ipv6AddressCount")]
            [Validation(Required=false)]
            public int? Ipv6AddressCount { get; set; }

            /// <summary>
            /// <para>The communication mode of the NIC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Standard: uses the TCP communication mode.</para>
            /// </description></item>
            /// <item><description><para>HighPerformance: enables the Elastic RDMA Interface (ERI) and uses the RDMA communication mode.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: Standard.</para>
            /// <remarks>
            /// <para>The number of ENIs in RDMA mode cannot exceed the limit for the instance family. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HighPerformance</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// <para>The number of secondary private IPv4 addresses to assign to the NIC. Valid values: 1 to 49.</para>
            /// <list type="bullet">
            /// <item><description><para>The value cannot exceed the limit on the number of IP addresses for the instance type. For more information, see <a href="https://help.aliyun.com/zh/ecs/user-guide/overview-of-instance-families">Instance families</a>.</para>
            /// </description></item>
            /// <item><description><para>\<c>NetworkInterface.N.SecondaryPrivateIpAddressCount\\</c> is used to assign a number of secondary private IPv4 addresses to the NIC, excluding the primary private IP address of the NIC. The system randomly assigns the addresses from the available CIDR block of the vSwitch where the NIC is located (\<c>NetworkInterface.N.VSwitchId\\</c>).</para>
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
            /// <para>The IDs of one or more security groups to which the ENI belongs.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to overwrite the parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Overwrite the parameter.</para>
        /// </description></item>
        /// <item><description><para>false: Do not overwrite the parameter.</para>
        /// </description></item>
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
        /// <para>The password of the ECS instance. The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters can be:</para>
        /// <para>\`()\~!@#$%^&amp;\*-_+=|{}[]:;\&quot;&lt;&gt;,.?/</para>
        /// <para>For Windows instances, the password cannot start with a forward slash (/).</para>
        /// <remarks>
        /// <para>If you specify the \<c>Password\\</c> parameter, we recommend that you send requests over HTTPS to prevent password leaks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123abc****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the password that is preset in the image. If you use this parameter, make sure that a password is set for the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The name of the RAM role of the ECS instance. The RAM role is provided and maintained by RAM. You can call the ListRoles operation to query the available RAM roles. For information about how to create a RAM role, see API CreateRole.</para>
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
        /// <para>The resource pool policy to use when creating an instance. Note the following when you set this parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is in effect only when you create a pay-as-you-go instance.</para>
        /// </description></item>
        /// <item><description><para>You cannot set this parameter and \<c>PrivatePoolOptions.MatchCriteria\\</c> or \<c>PrivatePoolOptions.Id\\</c> at the same time.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResourcePoolOptions")]
        [Validation(Required=false)]
        public ModifyScalingConfigurationRequestResourcePoolOptions ResourcePoolOptions { get; set; }
        public class ModifyScalingConfigurationRequestResourcePoolOptions : TeaModel {
            /// <summary>
            /// <para>The ID of the private pool. The private pool can be an Elastic Assurance service or a Capacity Reservation service. You can only specify the ID of a Target private pool. You cannot specify this parameter and the \<c>PrivatePoolTags\\</c> parameter at the same time.</para>
            /// </summary>
            [NameInMap("PrivatePoolIds")]
            [Validation(Required=false)]
            public List<string> PrivatePoolIds { get; set; }

            /// <summary>
            /// <para>Filter available Target private pools by tag. You can specify up to 20 tags.
            /// Description:</para>
            /// <list type="bullet">
            /// <item><description><para>When you configure this parameter, the system filters only the associated Target private pools under your account to find private pools that match the tags and meet the constraints of the scaling group, such as zone and instance type.</para>
            /// </description></item>
            /// <item><description><para>Tag matching rule: The private pool must match all specified tags.</para>
            /// </description></item>
            /// <item><description><para>You cannot specify this parameter and the \<c>PrivatePoolIds\\</c> parameter at the same time.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("PrivatePoolTags")]
            [Validation(Required=false)]
            public List<ModifyScalingConfigurationRequestResourcePoolOptionsPrivatePoolTags> PrivatePoolTags { get; set; }
            public class ModifyScalingConfigurationRequestResourcePoolOptionsPrivatePoolTags : TeaModel {
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
            /// <para>The resource pool includes the private pool generated after an Elastic Assurance service or a Capacity Reservation service takes effect, and the public pool. You can select a resource pool to start an instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PrivatePoolFirst: The private pool is used first. If you select this policy and specify \<c>ResourcePoolOptions.PrivatePoolIds\\</c> or meet the \<c>PrivatePoolTags\\</c> conditions, the corresponding private pool is used first. If you do not specify a private pool or the specified private pool has insufficient capacity, the system automatically matches an open private pool. If no eligible private pools are available, a public pool is used to create the instance.</para>
            /// </description></item>
            /// <item><description><para>PrivatePoolOnly: Only the private pool is used. If you select this policy, you must specify \<c>ResourcePoolOptions.PrivatePoolIds\\</c>. If the specified private pool has insufficient capacity, the instance fails to start.</para>
            /// </description></item>
            /// <item><description><para>PublicPoolFirst: The public pool is used first. A public pool is used first to create the instance. If the public pool has insufficient resources, a private pool is used. The system preferentially matches an open private pool. If no eligible private pools are available, the system uses the Target private pool that is specified by \<c>ResourcePoolOptions.PrivatePoolIds\\</c> or meets the \<c>PrivatePoolTags\\</c> conditions. (This policy is in invitational preview and is not yet available for use.)</para>
            /// </description></item>
            /// <item><description><para>None: No resource pool policy is used.</para>
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
        /// <para>The name of the scaling configuration. The name must be 2 to 64 English or Chinese characters in length. It must start with a digit, a letter, or a Chinese character. The name can contain digits, underscores (_), hyphens (-), and periods (.).</para>
        /// <para>The name of a scaling configuration must be unique within a scaling group in the same region. If you do not specify this parameter, the ID of the scaling configuration is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-modify</para>
        /// </summary>
        [NameInMap("ScalingConfigurationName")]
        [Validation(Required=false)]
        public string ScalingConfigurationName { get; set; }

        /// <summary>
        /// <para>The scheduling options.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;testManagedPrivateSpaceId****&quot;]</para>
        /// </summary>
        [NameInMap("SchedulerOptions")]
        [Validation(Required=false)]
        public Dictionary<string, object> SchedulerOptions { get; set; }

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
        /// <para>The ID of the security group.</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The security options.</para>
        /// </summary>
        [NameInMap("SecurityOptions")]
        [Validation(Required=false)]
        public ModifyScalingConfigurationRequestSecurityOptions SecurityOptions { get; set; }
        public class ModifyScalingConfigurationRequestSecurityOptions : TeaModel {
            /// <summary>
            /// <para>The confidential computing mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Enclave: The ECS instance uses an enclave to build a confidential computing environment. For more information, see <a href="https://help.aliyun.com/document_detail/203433.html">Build a confidential computing environment using an enclave</a>.</para>
            /// </description></item>
            /// <item><description><para>TDX: builds a TDX confidential computing environment. For more information, see <a href="https://help.aliyun.com/document_detail/479090.html">Build a TDX confidential computing environment</a>.</para>
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
        /// <para>The protection period of the spot instance. Unit: hours. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: Alibaba Cloud ensures that the instance runs for 1 hour and is not automatically released. After 1 hour, the system automatically compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.</para>
        /// </description></item>
        /// <item><description><para>0: Alibaba Cloud does not ensure that the instance runs for 1 hour after it is created. The system automatically compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Alibaba Cloud sends a notification to you through ECS system events 5 minutes before the instance is released. Spot instances are billed by the second. Select a protection period based on the time required to complete your task.</para>
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
        /// <para>The interruption mode of the spot instance. Currently, only Terminate is supported, which is the default value. This value indicates that the instance is directly released.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Terminate</para>
        /// </summary>
        [NameInMap("SpotInterruptionBehavior")]
        [Validation(Required=false)]
        public string SpotInterruptionBehavior { get; set; }

        /// <summary>
        /// <para>The information about the spot instance types.</para>
        /// </summary>
        [NameInMap("SpotPriceLimits")]
        [Validation(Required=false)]
        public List<ModifyScalingConfigurationRequestSpotPriceLimits> SpotPriceLimits { get; set; }
        public class ModifyScalingConfigurationRequestSpotPriceLimits : TeaModel {
            /// <summary>
            /// <para>The instance type of the spot instance. This parameter is in effect when \<c>SpotStrategy\\</c> is set to \<c>SpotWithPriceLimit\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g6.large</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The bid for the spot instance. This parameter is in effect when \<c>SpotStrategy\\</c> is set to \<c>SpotWithPriceLimit\\</c>.</para>
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
        /// <item><description><para>NoSpot: a regular pay-as-you-go instance.</para>
        /// </description></item>
        /// <item><description><para>SpotWithPriceLimit: a spot instance for which you specify the maximum hourly price.</para>
        /// </description></item>
        /// <item><description><para>SpotAsPriceGo: a spot instance for which the system automatically bids based on the current market price.</para>
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
        /// <para>The ID of the storage set.</para>
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
        /// <para>The categories of the system disk. If a disk of a category with a higher priority cannot be created, Auto Scaling automatically tries to create a disk of a category with the next priority. Valid values:</para>
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
        /// <remarks>
        /// <para>You cannot specify this parameter and <c>SystemDisk.Category</c> at the same time.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SystemDiskCategories")]
        [Validation(Required=false)]
        public List<string> SystemDiskCategories { get; set; }

        /// <summary>
        /// <para>The tags of the ECS instance. You can specify up to 20 tags in key-value pairs. The following limits apply to keys and values:</para>
        /// <list type="bullet">
        /// <item><description><para>A key can be up to 64 characters in length, cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>. If you specify tags, the key cannot be an empty string.</para>
        /// </description></item>
        /// <item><description><para>A value can be up to 128 characters in length, cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>. The value can be an empty string.</para>
        /// </description></item>
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
        /// <item><description><para>default: Create the instance not on a dedicated host.</para>
        /// </description></item>
        /// <item><description><para>host: Create the instance on a dedicated host. If you do not specify \<c>DedicatedHostId\\</c>, Alibaba Cloud automatically selects a dedicated host for the instance.</para>
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
        /// <para>The custom data of the ECS instance. The data must be Base64-encoded. The raw data can be up to 32 KB in size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The ID of the zone to which the ECS instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
