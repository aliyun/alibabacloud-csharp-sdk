// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateScalingConfigurationShrinkRequest : TeaModel {
        [NameInMap("ImageOptions")]
        [Validation(Required=false)]
        public CreateScalingConfigurationShrinkRequestImageOptions ImageOptions { get; set; }
        public class CreateScalingConfigurationShrinkRequestImageOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to use the ecs-user user to log on to the ECS instance. For more information, see <a href="https://help.aliyun.com/document_detail/388447.html">Manage logon usernames of ECS instances</a>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Yes.</para>
            /// </description></item>
            /// <item><description><para>false: No.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: false.</para>
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
        public CreateScalingConfigurationShrinkRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class CreateScalingConfigurationShrinkRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// <para>The ID of the private pool. This is the ID of the Elastic Assurance or Capacity Reservation service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eap-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The private pool capacity option for instance startup. After an Elastic Assurance or a Capacity Reservation service takes effect, a private pool is generated. You can select a private pool to start an instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Open: open mode. The system automatically matches the instance with an open private pool. If no eligible private pool is found, the instance is started using public pool resources. You do not need to set the PrivatePoolOptions.Id parameter in this mode.</para>
            /// </description></item>
            /// <item><description><para>Target: specified mode. The instance is started using the capacity of a specified private pool. If the specified private pool is unavailable, the instance fails to start. You must set the PrivatePoolOptions.Id parameter in this mode.</para>
            /// </description></item>
            /// <item><description><para>None: no private pool is used. The instance is started without using a private pool.</para>
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
        public CreateScalingConfigurationShrinkRequestSystemDisk SystemDisk { get; set; }
        public class CreateScalingConfigurationShrinkRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy to apply to the system disk.</para>
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
            /// <item><description><para>true: enables the feature.</para>
            /// </description></item>
            /// <item><description><para>false: disables the feature.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>You can set this parameter only when <c>SystemDisk.Category</c> is set to <c>cloud_auto</c>.</para>
            /// </remarks>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a>.</para>
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
            /// <item><description><para>ephemeral_ssd: local SSD.</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: ESSD.</para>
            /// </description></item>
            /// <item><description><para>cloud_auto: ESSD AutoPL disk.</para>
            /// </description></item>
            /// </list>
            /// <para>You cannot specify this parameter and <c>SystemDiskCategories</c> at the same time. If you do not specify this parameter or <c>SystemDiskCategories</c>, the default value of this parameter is used:</para>
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
            /// <para>The description of the system disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test system disk.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the system disk. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdSystem</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>The encryption algorithm for the system disk. Valid values:</para>
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
            /// <item><description><para>true: encrypts the disk.</para>
            /// </description></item>
            /// <item><description><para>false: does not encrypt the disk.</para>
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
            /// <para>The ID of the KMS key to use for the system disk.</para>
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
            /// <item><description><para>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</para>
            /// </description></item>
            /// <item><description><para>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</para>
            /// </description></item>
            /// <item><description><para>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</para>
            /// </description></item>
            /// <item><description><para>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: PL1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned IOPS of the system disk.</para>
            /// <remarks>
            /// <para>IOPS (input/output operations per second) indicates the number of I/O operations that a block storage device can process per second. It represents the read and write capabilities of the device.</para>
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
            /// <item><description><para>ESSD:</para>
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
            /// <item><description><para>ESSD AutoPL disk: 1 to 2048.</para>
            /// </description></item>
            /// <item><description><para>Other disk categories: 20 to 2048.</para>
            /// </description></item>
            /// </list>
            /// <para>The value of this parameter must be greater than or equal to max{1, ImageSize}.</para>
            /// <para>Default value: max{40, ImageSize}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to associate the instance with the dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>default: The instance is not associated with the dedicated host. When you restart an instance that was stopped in economical mode, the instance may be placed on a different dedicated host in the automatic deployment resource pool if the original dedicated host has insufficient resources.</para>
        /// </description></item>
        /// <item><description><para>host: The instance is associated with the dedicated host. When you restart an instance that was stopped in economical mode, the instance is still placed on the original dedicated host. If the original dedicated host has insufficient resources, the instance fails to restart.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Affinity")]
        [Validation(Required=false)]
        public string Affinity { get; set; }

        /// <summary>
        /// <para>Ensures the idempotence of the request. You can use the client to generate a unique parameter value to make sure that the same request is not repeated. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The number of vCPUs. Unit: cores.</para>
        /// <para>You can specify both Cpu and Memory to define a range of instance types. For example, if you set Cpu to 2 and Memory to 16, all instance types with 2 vCPUs and 16 GiB of memory are selected. Auto Scaling determines the available instance types based on factors such as I/O optimization and zone, and then creates an instance of the instance type that has the lowest price.</para>
        /// <remarks>
        /// <para>This configuration is effective only when the cost optimization policy is enabled for the scaling group and no instance types are specified in the scaling configuration.</para>
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
        /// <item><description><para>Standard: standard mode.</para>
        /// </description></item>
        /// <item><description><para>Unlimited: unlimited mode.</para>
        /// </description></item>
        /// </list>
        /// <para>For more information, see the Performance modes section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// <para>The custom priority for the combination of an ECS instance type and a vSwitch.</para>
        /// <remarks>
        /// <para>Notice: This is effective only when the scaling policy of the scaling group is set to the priority policy.</para>
        /// </remarks>
        /// <para>If an instance cannot be created from a combination of an instance type and a vSwitch with a higher priority, Auto Scaling automatically tries the next combination in the list.</para>
        /// <remarks>
        /// <para>If you specify custom priorities for only some combinations of instance types and vSwitches, the unspecified combinations have a lower priority than the specified ones. The unspecified combinations are still prioritized based on the order of vSwitches in the scaling group and the order of instance types in the scaling configuration.</para>
        /// <list type="bullet">
        /// <item><description>For example, if the vSwitch order in the scaling group is vsw1, vsw2, the instance type order in the scaling configuration is type1, type2, and the custom priority order is [&quot;vsw2+type2&quot;, &quot;vsw1+type2&quot;], the final priority will be: &quot;vsw2+type2&quot; &gt; &quot;vsw1+type2&quot; &gt; &quot;vsw1+type1&quot; &gt; &quot;vsw2+type1&quot;.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("CustomPriorities")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationShrinkRequestCustomPriorities> CustomPriorities { get; set; }
        public class CreateScalingConfigurationShrinkRequestCustomPriorities : TeaModel {
            /// <summary>
            /// <para>The instance type of the ECS instance.</para>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>Must be included in the list of instance types in the scaling configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g6.large</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch.</para>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>Must be included in the list of vSwitches in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp14zolna43z266bq****</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// <para>A collection of data disk information.</para>
        /// </summary>
        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationShrinkRequestDataDisks> DataDisks { get; set; }
        public class CreateScalingConfigurationShrinkRequestDataDisks : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy to apply to the data disk.</para>
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
            /// <item><description><para>true: Enables performance burst.</para>
            /// </description></item>
            /// <item><description><para>false: Disables performance burst.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is available only when <c>SystemDisk.Category</c> is set to <c>cloud_auto</c>.</para>
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
            /// <para>Multiple disk categories for the data disk. When a disk of a higher-priority category is unavailable, Auto Scaling automatically tries the next lower-priority category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>cloud: basic disk. The DeleteWithInstance attribute of a basic disk created with an instance is true.</para>
            /// </description></item>
            /// <item><description><para>cloud_efficiency: ultra disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_ssd: standard SSD.</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: ESSD.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If you specify this parameter, you cannot specify <c>DataDisks.Category</c>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// <para>The category of the data disk. Valid values:</para>
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
            /// <item><description><para>cloud_auto: ESSD AutoPL disk.</para>
            /// </description></item>
            /// </list>
            /// <para>You cannot specify this parameter and DataDisk.Categories at the same time. If you do not specify this parameter or DataDisk.Categories, the default value of this parameter is used:</para>
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
            /// <para>Specifies whether to release the data disk when the instance is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: releases the disk when the instance is released.</para>
            /// </description></item>
            /// <item><description><para>false: retains the disk when the instance is released.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter can be set only for separately purchased cloud disks (DataDisks.Category is cloud, cloud_efficiency, cloud_ssd, or cloud_essd). Otherwise, an error occurs.</para>
            /// <para>Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DeleteWithInstance")]
            [Validation(Required=false)]
            public bool? DeleteWithInstance { get; set; }

            /// <summary>
            /// <para>The description of the data disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test data disk.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The mount point of the data disk. If you do not specify this parameter, the system automatically assigns a mount point when creating the ECS instance, starting from /dev/xvdb and ending at /dev/xvdz.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/dev/xvdb</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The name of the data disk. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdData</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the data disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: encrypts the disk.</para>
            /// </description></item>
            /// <item><description><para>false: does not encrypt the disk.</para>
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
            /// <item><description><para>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</para>
            /// </description></item>
            /// <item><description><para>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</para>
            /// </description></item>
            /// <item><description><para>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</para>
            /// </description></item>
            /// <item><description><para>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>For information about how to select an ESSD performance level, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned IOPS of the data disk.</para>
            /// <remarks>
            /// <para>IOPS (input/output operations per second) indicates the number of I/O operations that a block storage device can process per second. It represents the read and write capabilities of the device.</para>
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
            /// <item><description><para>cloud: 5 to 2000.</para>
            /// </description></item>
            /// <item><description><para>cloud_efficiency: 20 to 32768.</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: 20 to 32768.</para>
            /// </description></item>
            /// <item><description><para>ephemeral_ssd: 5 to 800.</para>
            /// </description></item>
            /// </list>
            /// <para>If you specify this parameter, the disk size must be greater than or equal to the snapshot size specified by SnapshotId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The snapshot to use to create the data disk. If you specify this parameter, DataDisks.Size is ignored. The size of the created disk is the size of the specified snapshot.</para>
            /// <para>If the snapshot was created on or before July 15, 2013, the call is rejected and an InvalidSnapshot.TooOld error is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-280s7****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the dedicated host cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc-2zedxc67zqzt7lb4****</para>
        /// </summary>
        [NameInMap("DedicatedHostClusterId")]
        [Validation(Required=false)]
        public string DedicatedHostClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to create the ECS instance on a dedicated host. If you specify the DedicatedHostId parameter, the SpotStrategy and SpotPriceLimit settings in the request are automatically ignored. This is because dedicated hosts do not support creating preemptible instances.</para>
        /// <para>You can call the DescribeDedicatedHosts operation to query the list of dedicated host IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// <para>The release protection attribute of the instance. This specifies whether you can release the instance through the ECS console or by calling the DeleteInstance API. This prevents accidental release of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables release protection. You cannot release the instance through the ECS console or by calling the DeleteInstance API.</para>
        /// </description></item>
        /// <item><description><para>false: disables release protection. You can release the instance through the ECS console or by calling the DeleteInstance API.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This attribute applies only to pay-as-you-go instances to prevent accidental release of instances scaled out by Auto Scaling. It does not affect normal scale-in activities. Instances with release protection enabled can be released during scale-in activities.</para>
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
        /// <para>ds-bp1frxuzdg87zh4pz****</para>
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// <para>The hostname of the ECS instance. A period (.) or a hyphen (-) cannot be used as the first or last character of a hostname. Consecutive periods (.) or hyphens (-) are not allowed. The naming conventions for different instance types are as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>For Windows instances, the hostname must be 2 to 15 characters in length and can contain letters, digits, and hyphens (-). It cannot contain periods (.) or be all digits.</para>
        /// </description></item>
        /// <item><description><para>For other instance types, such as Linux, the hostname must be 2 to 64 characters in length. You can use periods (.) to separate the hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>host****</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The ID of the High Performance Computing (HPC) cluster to which the ECS instance belongs.</para>
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
        /// <item><description><para>enabled: enables the channel.</para>
        /// </description></item>
        /// <item><description><para>disabled: disables the channel.</para>
        /// </description></item>
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
        /// <para>Specifies whether to enforce the security-hardened mode (IMDSv2) when accessing instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>optional: does not enforce the mode.</para>
        /// </description></item>
        /// <item><description><para>required: enforces the mode. If you set this value, you cannot access instance metadata in normal mode.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: optional.</para>
        /// <remarks>
        /// <para>For information about instance metadata access modes, see <a href="https://help.aliyun.com/document_detail/108460.html">Instance metadata access modes</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>optional</para>
        /// </summary>
        [NameInMap("HttpTokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

        /// <summary>
        /// <para>The name of the image family. You can set this parameter to obtain the latest available image from the specified image family to create the instance. If you have specified the <c>ImageId</c> parameter, you cannot set this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou-daily-update</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The ID of the image file to use for creating instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>centos6u5_64_20G_aliaegis****.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the image file. Image names must be unique within a region. If you specify ImageId, ImageName is ignored.</para>
        /// <para>You cannot use ImageName to specify a Marketplace image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image****</para>
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
        /// <para>The name of the ECS instances that are created using the scaling configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>A collection of intelligent configuration information used to filter instance types that meet the requirements.</para>
        /// </summary>
        [NameInMap("InstancePatternInfos")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationShrinkRequestInstancePatternInfos> InstancePatternInfos { get; set; }
        public class CreateScalingConfigurationShrinkRequestInstancePatternInfos : TeaModel {
            /// <summary>
            /// <para>The architecture type of the instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>X86: X86 compute.</para>
            /// </description></item>
            /// <item><description><para>Heterogeneous: heterogeneous computing, such as GPU or FPGA.</para>
            /// </description></item>
            /// <item><description><para>BareMental: ECS Bare Metal Instance.</para>
            /// </description></item>
            /// <item><description><para>Arm: Arm compute.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: all architecture types are included.</para>
            /// </summary>
            [NameInMap("Architectures")]
            [Validation(Required=false)]
            public List<string> Architectures { get; set; }

            /// <summary>
            /// <para>Specifies whether to include burstable instance types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Exclude: does not include burstable instance types.</para>
            /// </description></item>
            /// <item><description><para>Include: includes burstable instance types.</para>
            /// </description></item>
            /// <item><description><para>Required: includes only burstable instance types.</para>
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
            /// <para>In intelligent configuration mode, the number of vCPU cores of the instance type. This is used to filter instance types that meet the requirements. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// <para>Note the following:</para>
            /// <list type="bullet">
            /// <item><description><para>The InstancePatternInfos parameter applies only when the network type of the scaling group is VPC.</para>
            /// </description></item>
            /// <item><description><para>When using InstancePatternInfos, you must specify both InstancePatternInfos.Cores and InstancePatternInfos.Memory.</para>
            /// </description></item>
            /// <item><description><para>If you have already specified instance types using the InstanceType or InstanceTypes parameter, Auto Scaling prioritizes the specified instance types for scale-outs. If the specified instance types are out of stock, Auto Scaling uses the instance type with the lowest price from the instance types that match the InstancePatternInfos parameter.</para>
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
            /// <para>You can specify multiple CPU architectures. N is an integer from 1 to 2.</para>
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
            /// <para>The instance types to exclude. You can use a wildcard character (\*) to exclude a single instance type or an entire instance family. For example:</para>
            /// <list type="bullet">
            /// <item><description><para>ecs.c6.large: excludes the ecs.c6.large instance type.</para>
            /// </description></item>
            /// <item><description><para>ecs.c6.\*: excludes all instance types in the c6 family.</para>
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
            /// <para>The category of the instance. Valid values:</para>
            /// <remarks>
            /// <para>You can specify multiple instance categories. N is an integer from 1 to 10.</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>General-purpose: General-purpose.</para>
            /// </description></item>
            /// <item><description><para>Compute-optimized: compute-optimized.</para>
            /// </description></item>
            /// <item><description><para>Memory-optimized: memory-optimized.</para>
            /// </description></item>
            /// <item><description><para>Big data: big data.</para>
            /// </description></item>
            /// <item><description><para>Local SSDs : local SSDs.</para>
            /// </description></item>
            /// <item><description><para>High Clock Speed : high frequency.</para>
            /// </description></item>
            /// <item><description><para>Enhanced : enhanced instance families.</para>
            /// </description></item>
            /// <item><description><para>Shared: shared-resource instances.</para>
            /// </description></item>
            /// <item><description><para>Compute-optimized with GPU : GPU compute-optimized.</para>
            /// </description></item>
            /// <item><description><para>Visual Compute-optimized : visual compute-optimized.</para>
            /// </description></item>
            /// <item><description><para>Heterogeneous Service : heterogeneous service.</para>
            /// </description></item>
            /// <item><description><para>Compute-optimized with FPGA : FPGA compute-optimized.</para>
            /// </description></item>
            /// <item><description><para>Compute-optimized with NPU : NPU compute-optimized.</para>
            /// </description></item>
            /// <item><description><para>ECS Bare Metal : ECS Bare Metal Instance.</para>
            /// </description></item>
            /// <item><description><para>High Performance Compute: high-performance computing.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("InstanceCategories")]
            [Validation(Required=false)]
            public List<string> InstanceCategories { get; set; }

            /// <summary>
            /// <para>The level of the instance family, used to filter instance types that meet the requirements. This parameter takes effect when <c>CostOptimization</c> is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>EntryLevel: entry-level, which refers to shared-resource instances. This level offers lower costs but cannot guarantee stable computing performance. It is suitable for business scenarios with low CPU utilization. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared-resource instances</a>.</para>
            /// </description></item>
            /// <item><description><para>EnterpriseLevel: enterprise-level. This level provides stable performance and dedicated resources, suitable for business scenarios that require high stability. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// </description></item>
            /// <item><description><para>CreditEntryLevel: credit entry-level, which refers to burstable instances. This level uses CPU credits to ensure computing performance and is suitable for business scenarios with low CPU utilization and occasional CPU bursts. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</para>
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
            /// <para>The instance families to query. You can specify multiple instance families. N is an integer from 1 to 10.</para>
            /// </summary>
            [NameInMap("InstanceTypeFamilies")]
            [Validation(Required=false)]
            public List<string> InstanceTypeFamilies { get; set; }

            /// <summary>
            /// <para>In intelligent configuration mode, the maximum hourly price you are willing to pay for a pay-as-you-go or preemptible instance. This is used to filter instance types that meet the requirements.</para>
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
            /// <para>The maximum number of vCPU cores for the instance type.</para>
            /// <remarks>
            /// <para>MaximumCpuCoreCount cannot be more than four times the value of MinimumCpuCoreCount.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("MaximumCpuCoreCount")]
            [Validation(Required=false)]
            public int? MaximumCpuCoreCount { get; set; }

            /// <summary>
            /// <para>The maximum number of GPUs for the instance. The value must be a positive integer.</para>
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
            /// <para>In intelligent configuration mode, the memory size of the instance type. Unit: GiB. This is used to filter instance types that meet the requirements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The minimum baseline vCPU performance (the sum of all vCPUs) for burstable instances of the t5 or t6 family.</para>
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
            /// <para>The minimum number of IPv6 addresses that can be assigned to a single ENI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinimumEniIpv6AddressQuantity")]
            [Validation(Required=false)]
            public int? MinimumEniIpv6AddressQuantity { get; set; }

            /// <summary>
            /// <para>The minimum number of private IPv4 addresses to assign to a single elastic network interface (ENI) of an instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MinimumEniPrivateIpAddressQuantity")]
            [Validation(Required=false)]
            public int? MinimumEniPrivateIpAddressQuantity { get; set; }

            /// <summary>
            /// <para>The minimum number of elastic network interfaces (ENIs) that can be attached to an instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MinimumEniQuantity")]
            [Validation(Required=false)]
            public int? MinimumEniQuantity { get; set; }

            /// <summary>
            /// <para>The minimum number of GPUs for the instance. The value must be a positive integer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MinimumGpuAmount")]
            [Validation(Required=false)]
            public int? MinimumGpuAmount { get; set; }

            /// <summary>
            /// <para>The minimum initial vCPU credit for burstable instances of the t5 or t6 family.</para>
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
            /// <para>The processor model of the instance. You can specify multiple processor models. N is an integer from 1 to 10.</para>
            /// </summary>
            [NameInMap("PhysicalProcessorModels")]
            [Validation(Required=false)]
            public List<string> PhysicalProcessorModels { get; set; }

        }

        /// <summary>
        /// <para>The instance type of the ECS instance. For more information, see Instance families.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>After you enable the candidate mode, if issues such as insufficient inventory occur, the system supplements the currently selected instance types with similar-sized alternatives or creates vSwitches in candidate zones and adds them to the scaling group.</para>
        /// </summary>
        [NameInMap("InstanceTypeCandidateOptions")]
        [Validation(Required=false)]
        public CreateScalingConfigurationShrinkRequestInstanceTypeCandidateOptions InstanceTypeCandidateOptions { get; set; }
        public class CreateScalingConfigurationShrinkRequestInstanceTypeCandidateOptions : TeaModel {
            /// <summary>
            /// <para>When supplementing with vSwitches from other zones is allowed, you must specify the CIDR blocks for the candidate vSwitches.</para>
            /// </summary>
            [NameInMap("AllowCidrBlocks")]
            [Validation(Required=false)]
            public List<string> AllowCidrBlocks { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow supplementing with vSwitches from other zones.</para>
            /// <remarks>
            /// <para>The instance type remains unchanged; only new zones are considered as candidates. When a scaling group cannot scale out in any of the selected zones due to issues like insufficient inventory, this configuration allows ESS to automatically add a vSwitch from a new zone to the scaling group.
            /// For example, if a scaling group is configured for zones cn-hangzhou-h and cn-hangzhou-g, and neither can be scaled out, ESS might create and add a vSwitch in cn-hangzhou-k based on real-time inventory.</para>
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
            /// <item><description>For example, if the current instance type is ecs.c7.large, enabling this allows ecs.c6.large and ecs.c8.large as candidate types.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowDifferentGeneration")]
            [Validation(Required=false)]
            public bool? AllowDifferentGeneration { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the candidate mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The maximum price for candidate instance types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.10</para>
            /// </summary>
            [NameInMap("MaxPrice")]
            [Validation(Required=false)]
            public float? MaxPrice { get; set; }

        }

        /// <summary>
        /// <para>Information about the specified instance types.</para>
        /// </summary>
        [NameInMap("InstanceTypeOverrides")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationShrinkRequestInstanceTypeOverrides> InstanceTypeOverrides { get; set; }
        public class CreateScalingConfigurationShrinkRequestInstanceTypeOverrides : TeaModel {
            /// <summary>
            /// <para>If you want the scaling group to scale based on the capacity of instance types, specify both this parameter and WeightedCapacity.</para>
            /// <para>This parameter specifies the instance type and overwrites the instance type in the launch template. You can specify this parameter up to 20 times. N is an integer from 1 to 20.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when a launch template is specified by the LaunchTemplateId parameter.</para>
            /// </remarks>
            /// <para>Valid values for InstanceType: available ECS instance types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c5.xlarge</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>To specify the capacity of an instance type in the scaling configuration, specify this parameter after you specify InstanceTypeOverrides.InstanceType.</para>
            /// <para>This parameter specifies the weight of the instance type. The weight indicates the capacity of a single instance of the specified instance type in the scaling group. A higher weight means that fewer instances of that type are needed to meet the desired capacity.</para>
            /// <para>You can configure different weights for different instance types based on their performance metrics, such as the number of vCPUs and memory size.</para>
            /// <para>For example:</para>
            /// <list type="bullet">
            /// <item><description><para>Current capacity: 0.</para>
            /// </description></item>
            /// <item><description><para>Expected capacity: 6.</para>
            /// </description></item>
            /// <item><description><para>Capacity of ecs.c5.xlarge: 4.</para>
            /// </description></item>
            /// </list>
            /// <para>To meet the expected capacity, the scaling group will scale out two ecs.c5.xlarge instances.</para>
            /// <remarks>
            /// <para>During a scale-out, the capacity of the scaling group cannot exceed the sum of MaxSize and the maximum weight of the instance type.</para>
            /// </remarks>
            /// <para>Valid values for WeightedCapacity: 1 to 500.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("WeightedCapacity")]
            [Validation(Required=false)]
            public int? WeightedCapacity { get; set; }

        }

        /// <summary>
        /// <para>Multiple instance types. If you use InstanceTypes, InstanceType is ignored.</para>
        /// <para>If an instance cannot be created from an instance type with a higher priority, Auto Scaling automatically tries the next instance type in the list.</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The billing method for network usage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PayByBandwidth: pay-by-bandwidth. InternetMaxBandwidthOut specifies the fixed bandwidth.</para>
        /// </description></item>
        /// <item><description><para>PayByTraffic: pay-by-data-transfer. InternetMaxBandwidthOut specifies the maximum bandwidth. You are charged for the actual data transfer.</para>
        /// </description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the default value is PayByBandwidth for classic network and PayByTraffic for VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The maximum inbound public bandwidth. Unit: Mbit/s. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If the purchased outbound public bandwidth is less than or equal to 10 Mbit/s: 1 to 10. Default value: 10.</para>
        /// </description></item>
        /// <item><description><para>If the purchased outbound public bandwidth is greater than 10 Mbit/s: 1 to the value of <c>InternetMaxBandwidthOut</c>. Default value: the value of <c>InternetMaxBandwidthOut</c>.</para>
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
        /// <para>none: The instance is not I/O optimized.
        /// optimized: The instance is I/O optimized.</para>
        /// <para>For retired instance types, the default value is none. For other instance types, the default value is optimized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>The number of randomly generated IPv6 addresses to assign to the ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// <para>The name of the key pair to use to log on to the ECS instance.</para>
        /// <list type="bullet">
        /// <item><description><para>For Windows instances, this parameter is ignored. The default value is empty.</para>
        /// </description></item>
        /// <item><description><para>For Linux instances, password-based logon is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KeyPairTest</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The weight of the ECS instance as a backend server of the load balancer. Valid values: 1 to 100.</para>
        /// <para>Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("LoadBalancerWeight")]
        [Validation(Required=false)]
        public int? LoadBalancerWeight { get; set; }

        /// <summary>
        /// <para>The memory size. Unit: GiB.</para>
        /// <para>You can specify both Cpu and Memory to define a range of instance types. For example, if you set Cpu to 2 and Memory to 16, all instance types with 2 vCPUs and 16 GiB of memory are selected. Auto Scaling determines the available instance types based on factors such as I/O optimization and zone, and then creates an instance of the instance type that has the lowest price.</para>
        /// <remarks>
        /// <para>This configuration is effective only when the cost optimization policy is enabled for the scaling group and no instance types are specified in the scaling configuration.</para>
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
        public List<CreateScalingConfigurationShrinkRequestNetworkInterfaces> NetworkInterfaces { get; set; }
        public class CreateScalingConfigurationShrinkRequestNetworkInterfaces : TeaModel {
            /// <summary>
            /// <para>The type of ENI. When using this parameter, you must use NetworkInterfaces to set the primary NIC and cannot set the SecurityGroupId or SecurityGroupIds parameters. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Primary: primary NIC.</para>
            /// </description></item>
            /// <item><description><para>Secondary: secondary NIC.</para>
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
            /// <para>The number of randomly generated IPv6 addresses to assign to the primary NIC.
            /// Note:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter takes effect only when NetworkInterface.InstanceType is set to Primary. If NetworkInterface.InstanceType is set to Secondary or is empty, you cannot set this parameter.</para>
            /// </description></item>
            /// <item><description><para>If you set this parameter, you cannot set Ipv6AddressCount.</para>
            /// </description></item>
            /// </list>
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
            /// <item><description><para>Standard: uses TCP communication mode.</para>
            /// </description></item>
            /// <item><description><para>HighPerformance: enables the Elastic RDMA Interface (ERI) and uses RDMA communication mode.</para>
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
            /// <item><description><para>The value cannot exceed the IP address limit for the instance type. For more information, see <a href="https://help.aliyun.com/en/ecs/user-guide/overview-of-instance-families">Instance families</a>.</para>
            /// </description></item>
            /// <item><description><para>NetworkInterface.N.SecondaryPrivateIpAddressCount is used to assign a number of secondary private IPv4 addresses to the NIC (excluding the primary private IP address). The system randomly assigns these addresses from the available CIDR block of the vSwitch (NetworkInterface.N.VSwitchId) where the NIC is located.</para>
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
            /// <para>One or more security group IDs to which the ENI belongs.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The password of the ECS instance. The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters can be:</para>
        /// <para>\<c>()</c> ~!@#$%^&amp;*-_+=\|{}[]:;\&quot;&lt;&gt;,.?/`</para>
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
        /// <para>Specifies whether to use the password preset in the image. If you use this parameter, make sure that a password is preset in the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: uses the preset password.</para>
        /// </description></item>
        /// <item><description><para>false: does not use the preset password.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The name of the RAM role for the ECS instance. The name is provided and maintained by RAM. You can call the ListRoles operation to query the available RAM roles.</para>
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
        /// <para>rg-resource****</para>
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
        /// <item><description><para>This parameter takes effect only when creating pay-as-you-go instances.</para>
        /// </description></item>
        /// <item><description><para>You cannot set this parameter at the same time as PrivatePoolOptions.MatchCriteria and PrivatePoolOptions.Id.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResourcePoolOptions")]
        [Validation(Required=false)]
        public CreateScalingConfigurationShrinkRequestResourcePoolOptions ResourcePoolOptions { get; set; }
        public class CreateScalingConfigurationShrinkRequestResourcePoolOptions : TeaModel {
            /// <summary>
            /// <para>The ID of the private pool. This is the ID of the Elastic Assurance or Capacity Reservation service. This parameter can only accept Target mode private pool IDs and cannot be specified at the same time as the PrivatePoolTags parameter.</para>
            /// </summary>
            [NameInMap("PrivatePoolIds")]
            [Validation(Required=false)]
            public List<string> PrivatePoolIds { get; set; }

            /// <summary>
            /// <para>Filter available Target private pools by tags. N is an integer from 1 to 20.
            /// Note:</para>
            /// <list type="bullet">
            /// <item><description><para>When this parameter is configured, the system only selects from the associated Target private pools under the account that have matching tags and also meet the scaling group constraints (such as zone, instance type, etc.).</para>
            /// </description></item>
            /// <item><description><para>Tag matching rule: The private pool must match all specified tags.</para>
            /// </description></item>
            /// <item><description><para>This parameter cannot be specified at the same time as the PrivatePoolIds parameter.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("PrivatePoolTags")]
            [Validation(Required=false)]
            public List<CreateScalingConfigurationShrinkRequestResourcePoolOptionsPrivatePoolTags> PrivatePoolTags { get; set; }
            public class CreateScalingConfigurationShrinkRequestResourcePoolOptionsPrivatePoolTags : TeaModel {
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
            /// <para>The resource pool, which includes private pools generated after an Elastic Assurance or Capacity Reservation service takes effect, and the public pool, can be selected for instance startup. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PrivatePoolFirst: Private pool first. When this policy is selected, if you specify ResourcePoolOptions.PrivatePoolIds or meet the PrivatePoolTags conditions, the corresponding private pool is used first. If no private pool is specified or the specified private pool has insufficient capacity, the system automatically matches an open-type private pool. If no eligible private pool is found, the instance is created using the public pool.</para>
            /// </description></item>
            /// <item><description><para>PrivatePoolOnly: Private pool only. When this policy is selected, you must specify ResourcePoolOptions.PrivatePoolIds. If the specified private pool has insufficient capacity, the instance fails to start.</para>
            /// </description></item>
            /// <item><description><para>PublicPoolFirst: Public pool resources first. The system prioritizes creating the instance using the public pool. When public pool resources are insufficient, private pool resources are used as a supplement. The system first automatically matches an open-type private pool. If no eligible private pool is found, it uses a Target-type private pool that is specified by ResourcePoolOptions.PrivatePoolIds or meets the PrivatePoolTags conditions. (This policy is in invitational preview and is not yet available for use.)</para>
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
        /// <para>The name of the scaling configuration. The name must be 2 to 64 characters in length, and can contain digits, underscores (_), hyphens (-), and periods (.). It must start with a digit, a letter, or a Chinese character.</para>
        /// <para>The name of a scaling configuration must be unique within a scaling group in a region. If you do not specify this parameter, the ID of the scaling configuration is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scalingconfig****</para>
        /// </summary>
        [NameInMap("ScalingConfigurationName")]
        [Validation(Required=false)]
        public string ScalingConfigurationName { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group to which the scaling configuration belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp14wlu85wrpchm0****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The scheduling options.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;testManagedPrivateSpaceId****&quot;]</para>
        /// </summary>
        [NameInMap("SchedulerOptions")]
        [Validation(Required=false)]
        public string SchedulerOptionsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable security hardening. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Active: enables security hardening. This setting is valid only for public images.</para>
        /// </description></item>
        /// <item><description><para>Deactive: disables security hardening. This setting is valid for all image types.</para>
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
        /// <para>The ID of the security group to which the ECS instance belongs. ECS instances in the same security group can communicate with each other.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-280ih****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>Adds the ECS instance to multiple security groups. For more information, see the Security groups section in <a href="https://help.aliyun.com/document_detail/25412.html">Limits</a>.</para>
        /// <remarks>
        /// <para>You cannot specify both SecurityGroupId and SecurityGroupIds.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The security options.</para>
        /// </summary>
        [NameInMap("SecurityOptions")]
        [Validation(Required=false)]
        public CreateScalingConfigurationShrinkRequestSecurityOptions SecurityOptions { get; set; }
        public class CreateScalingConfigurationShrinkRequestSecurityOptions : TeaModel {
            /// <summary>
            /// <para>The confidential computing mode. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para>Enclave: The ECS instance uses an Enclave to build a confidential computing environment. For more information, see <a href="https://help.aliyun.com/document_detail/203433.html">Build a confidential computing environment using an Enclave</a>.</para>
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
        /// <para>The protection period of the preemptible instance. Unit: hours. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: The instance is retained for 1 hour after it is created. After 1 hour, the system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.</para>
        /// </description></item>
        /// <item><description><para>0: The instance is not guaranteed to be retained for 1 hour after it is created. The system compares the bid price with the market price and checks the resource inventory to determine whether to retain or release the instance.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Alibaba Cloud sends a notification to you through an ECS system event 5 minutes before the instance is released. Preemptible instances are billed by the second. We recommend that you select a protection period based on the time required for your task to complete.</para>
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
        /// <para>The interruption mode of the preemptible instance. Currently, only terminate is supported, which releases the instance by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Terminate</para>
        /// </summary>
        [NameInMap("SpotInterruptionBehavior")]
        [Validation(Required=false)]
        public string SpotInterruptionBehavior { get; set; }

        /// <summary>
        /// <para>A collection of billing information for preemptible instances.</para>
        /// </summary>
        [NameInMap("SpotPriceLimits")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationShrinkRequestSpotPriceLimits> SpotPriceLimits { get; set; }
        public class CreateScalingConfigurationShrinkRequestSpotPriceLimits : TeaModel {
            /// <summary>
            /// <para>The instance type of the preemptible instance. This parameter takes effect when SpotStrategy is set to SpotWithPriceLimit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g6.large</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The bid price for the preemptible instance. This parameter takes effect when SpotStrategy is set to SpotWithPriceLimit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("PriceLimit")]
            [Validation(Required=false)]
            public float? PriceLimit { get; set; }

        }

        /// <summary>
        /// <para>The preemption policy for pay-as-you-go instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NoSpot: The instance is a regular pay-as-you-go instance.</para>
        /// </description></item>
        /// <item><description><para>SpotWithPriceLimit: The instance is a preemptible instance with a user-defined maximum hourly price.</para>
        /// </description></item>
        /// <item><description><para>SpotAsPriceGo: The instance is a preemptible instance for which the price is automatically bid based on the current market price.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
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
        /// <para>The maximum number of partitions in the storage set. The value must be greater than or equal to 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        /// <summary>
        /// <para>Multiple disk categories for the system disk. When a disk of a higher-priority category is unavailable, Auto Scaling automatically tries the next lower-priority category to create the system disk. Valid values:</para>
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
        /// <para>If you specify this parameter, you cannot specify <c>SystemDisk.Category</c>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SystemDiskCategories")]
        [Validation(Required=false)]
        public List<string> SystemDiskCategories { get; set; }

        /// <summary>
        /// <para>The tags of the ECS instance. You can specify up to 20 tags in key-value pairs. The following limits apply to keys and values:</para>
        /// <list type="bullet">
        /// <item><description><para>A key can be up to 64 characters in length and cannot start with aliyun or acs:. It cannot contain <c>http://</c> or <c>https://</c>. If you use tags, the key cannot be an empty string.</para>
        /// </description></item>
        /// <item><description><para>A value can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain <c>http://</c> or <c>https://</c>. The value can be an empty string.</para>
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
        /// <item><description><para>default: creates the instance on a non-dedicated host.</para>
        /// </description></item>
        /// <item><description><para>host: creates the instance on a dedicated host. If you do not specify DedicatedHostId, Alibaba Cloud automatically selects a dedicated host for the instance.</para>
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
        /// <para>The custom data of the ECS instance. The data must be Base64 encoded. The raw data can be up to 32 KB in size.</para>
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
