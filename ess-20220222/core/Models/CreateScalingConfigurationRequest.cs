// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateScalingConfigurationRequest : TeaModel {
        [NameInMap("ImageOptions")]
        [Validation(Required=false)]
        public CreateScalingConfigurationRequestImageOptions ImageOptions { get; set; }
        public class CreateScalingConfigurationRequestImageOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to log on to the ECS instance as the ecs-user user. For more information, see <a href="https://help.aliyun.com/document_detail/388447.html">Manage the logon username of an ECS instance</a>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: yes.</para>
            /// </description></item>
            /// <item><description><para>false: no.</para>
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
        public CreateScalingConfigurationRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class CreateScalingConfigurationRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// <para>The ID of the private pool. It is the ID of the elasticity assurance or capacity reservation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eap-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The private pool options for instance startup. After an elasticity assurance or a capacity reservation takes effect, a private pool is generated for you to select when you start instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Open: open mode. The system automatically matches an open private pool. If no matching private pool is available, the system uses resources from the public pool. In this mode, you do not need to specify the PrivatePoolOptions.Id parameter.</para>
            /// </description></item>
            /// <item><description><para>Target: specified mode. The system uses the specified private pool to start the instance. If the specified private pool is unavailable, the instance fails to start. In this mode, you must specify the private pool ID by using the PrivatePoolOptions.Id parameter.</para>
            /// </description></item>
            /// <item><description><para>None: no private pool. The system does not use private pools to start the instance.</para>
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
        public CreateScalingConfigurationRequestSystemDisk SystemDisk { get; set; }
        public class CreateScalingConfigurationRequestSystemDisk : TeaModel {
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
            /// <para>Specifies whether to enable the burst (performance burst) feature for the system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables the feature.</description></item>
            /// <item><description>false: disables the feature.<remarks>
            /// <para>This parameter is supported only when <c>SystemDisk.Category</c> is set to <c>cloud_auto</c>.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
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
            /// <item><description><para>cloud: basic cloud disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_efficiency: ultra cloud disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_ssd: standard SSD cloud disk.</para>
            /// </description></item>
            /// <item><description><para>ephemeral_ssd: local SSD.</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: ESSD.</para>
            /// </description></item>
            /// <item><description><para>cloud_auto: ESSD AutoPL.</para>
            /// </description></item>
            /// </list>
            /// <para>You cannot specify this parameter together with <c>SystemDiskCategories</c>. If neither this parameter nor <c>SystemDiskCategories</c> is specified, the default value is used:</para>
            /// <list type="bullet">
            /// <item><description>For I/O optimized instances, the default value is cloud_efficiency.</description></item>
            /// <item><description>For non-I/O optimized instances, the default value is cloud.</description></item>
            /// </list>
            /// <para>This parameter specifies only one system cloud disk type. If you want the system to automatically try other types when the preferred disk type is unavailable, use <c>SystemDiskCategories</c> and configure multiple disk types in order of priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
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
            /// <para>The name of the system cloud disk. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), and hyphens (-). It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdSystem</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>The encryption algorithm used for the system cloud disk. Valid values:</para>
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
            /// <para>The settings of the performance level for the system cloud disk when it is an ESSD. Valid values:</para>
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
            /// <para>The provisioned IOPS (Input/Output Operations Per Second) performance metrics for the system cloud disk.</para>
            /// <remarks>
            /// <para>IOPS refers to the number of I/O operations that can be processed per second. It indicates the read and write processing capability of block storage. Unit: operations per second.</para>
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
        /// <para>Specifies whether to associate the instance on a dedicated host with the dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>default: The instance is not associated with the dedicated host. If an instance with the economical mode enabled is stopped and then started, and the resources of the original dedicated host are insufficient, the instance is automatically deployed to another dedicated host in the automatic deployment resource pool.</para>
        /// </description></item>
        /// <item><description><para>host: The instance is associated with the dedicated host. If an instance with the economical mode enabled is stopped and then started, it remains on the original dedicated host. If the resources of the original dedicated host are insufficient, the instance fails to start.</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The number of vCPUs. Unit: cores.</para>
        /// <para>You can specify both Cpu and Memory to define the range of instance types. For example, if you set Cpu to 2 and Memory to 16, all instance types with 2 vCPUs and 16 GiB of memory are matched. Auto Scaling determines the available instance types based on factors such as I/O optimization and zone, and creates instances with the lowest price.</para>
        /// <remarks>
        /// <para>This configuration takes effect only when the scaling mode is set to cost optimization and no instance type is specified in the scaling configuration.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>Specifies the running pattern of the burstable instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard: standard pattern.</para>
        /// </description></item>
        /// <item><description><para>Unlimited: unlimited pattern.</para>
        /// </description></item>
        /// </list>
        /// <para>For more information, see the performance schema section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// <para>The custom priority of the ECS instance type and vSwitch combination.</para>
        /// <remarks>
        /// <para>Notice: This parameter takes effect only when the scaling policy of the scaling group is set to the priority-based policy.</para>
        /// </remarks>
        /// <para>If an instance cannot be created based on the instance type and vSwitch combination with a higher priority, Auto Scaling automatically selects the combination with the next highest priority to create the instance.</para>
        /// <remarks>
        /// <para>If you specify custom priorities for only some instance type and vSwitch combinations, the unspecified combinations have lower priorities than the specified ones. The priorities of the unspecified combinations are determined based on the vSwitch sequence in the scaling group and the instance type sequence in the scaling configuration.</para>
        /// <list type="bullet">
        /// <item><description>Example: If the vSwitch sequence in the scaling group is vsw1 and vsw2, the instance type sequence in the scaling configuration is type1 and type2, and the custom priority sequence is [&quot;vsw2+type2&quot;, &quot;vsw1+type2&quot;], the final priority sequence is: &quot;vsw2+type2&quot; &gt; &quot;vsw1+type2&quot; &gt; &quot;vsw1+type1&quot; &gt; &quot;vsw2+type1&quot;.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("CustomPriorities")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationRequestCustomPriorities> CustomPriorities { get; set; }
        public class CreateScalingConfigurationRequestCustomPriorities : TeaModel {
            /// <summary>
            /// <para>The instance type of the ECS instance.</para>
            /// <remarks>
            /// <para>Notice: The instance type must be included in the instance type list of the scaling configuration.</para>
            /// </remarks>
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
            /// <para>Notice: The vSwitch must be included in the vSwitch list of the scaling group.</para>
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
        public List<CreateScalingConfigurationRequestDataDisks> DataDisks { get; set; }
        public class CreateScalingConfigurationRequestDataDisks : TeaModel {
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
            /// <para>Specifies whether to enable the burstable performance feature for the data cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables the feature.</description></item>
            /// <item><description>false: disables the feature. <remarks>
            /// <para>You can set this parameter only when <c>SystemDisk.Category</c> is set to <c>cloud_auto</c>.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL cloud disks</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// <para>The multiple disk types of the data cloud disk. If the disk type with a higher priority is unavailable, Auto Scaling automatically tries the disk type with the next highest priority to create the data cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic cloud disk. The DeleteWithInstance property of a basic cloud disk created together with the instance is set to true.</description></item>
            /// <item><description>cloud_efficiency: ultra cloud disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: ESSD.</description></item>
            /// <item><description>ephemeral_ssd: local SSD.</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL.</description></item>
            /// <item><description>cloud_regional_disk_auto: regional ESSD.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If you specify this parameter, you cannot specify <c>DataDisks.Category</c> at the same time.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// <para>The category of the data cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: basic cloud disk. The DeleteWithInstance attribute of a basic cloud disk created together with the instance is set to true.</description></item>
            /// <item><description>cloud_efficiency: ultra cloud disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD cloud disk.</description></item>
            /// <item><description>cloud_essd: ESSD.</description></item>
            /// <item><description>ephemeral_ssd: local SSD.</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL.</description></item>
            /// <item><description>cloud_regional_disk_auto: regional ESSD.</description></item>
            /// </list>
            /// <para>You cannot specify this parameter together with DataDisk.Categories. If neither this parameter nor DataDisk.Categories is specified, the default value is used:</para>
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
            /// <para>Specifies whether to release the data cloud disk when the instance is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: releases the data cloud disk when the instance is released.</description></item>
            /// <item><description>false: retains the data cloud disk when the instance is released.</description></item>
            /// </list>
            /// <para>You can set this parameter only for independent cloud disks (when DataDisks.Category is set to cloud, cloud_efficiency, cloud_ssd, or cloud_essd). Otherwise, an error is returned.</para>
            /// <para>Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DeleteWithInstance")]
            [Validation(Required=false)]
            public bool? DeleteWithInstance { get; set; }

            /// <summary>
            /// <para>The description of the data cloud disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test data disk.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The mount point of the data cloud disk. If you do not specify this parameter, the system automatically allocates a mount point by default during automatic creation of the ECS instance. The mount point starts from /dev/xvdb and ends at /dev/xvdz.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/dev/xvdb</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The name of the data cloud disk. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), and hyphens (-). It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The ID of the Key Management Service (KMS) key used by the data cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The settings of the performance level for the data cloud disk when it is an ESSD. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information about how to select the performance level of an ESSD, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned IOPS (Input/Output Operations Per Second) performance metrics of the data cloud disk.</para>
            /// <remarks>
            /// <para>IOPS indicates the number of I/O operations that can be processed per second. It measures the read and write capabilities of block storage. Unit: operations per second.</para>
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
            /// <item><description>cloud_essd: 20 to 32768.</description></item>
            /// <item><description>ephemeral_ssd: 5 to 800.</description></item>
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
            /// <para>The snapshot used to create the data cloud disk. If this parameter is specified, DataDisks.Size is ignored, and the actual size of the created disk is the size of the specified snapshot.</para>
            /// <para>If the snapshot was created on or before July 15, 2013, the call is rejected and the InvalidSnapshot.TooOld error code is returned.</para>
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
        /// <para>Specifies whether to create the ECS instance on a dedicated host. Because dedicated hosts do not support spot instances, the SpotStrategy and SpotPriceLimit parameters are automatically ignored if DedicatedHostId is specified.</para>
        /// <para>You can call the DescribeDedicatedHosts operation to query the list of dedicated host IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// <para>The release protection property of the instance. This property specifies whether the instance can be directly released by using the ECS console or the DeleteInstance API operation, which prevents accidental deletion of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables release protection for the instance. The instance cannot be directly released by using the ECS console or the DeleteInstance API operation.</para>
        /// </description></item>
        /// <item><description><para>false: shutdown release protection for the instance. The instance can be directly released by using the ECS console or the DeleteInstance API operation.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This property applies only to pay-as-you-go instances to prevent instances created by Auto Scaling during scale-out from being accidentally deleted. It does not affect normal scale-in activities. Instances with release protection enabled can still be released during scale-in activities.</para>
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
        /// <para>The hostname of the ECS instance. The hostname cannot start or end with a period (.) or a hyphen (-) and cannot contain consecutive periods (.) or hyphens (-). The naming requirements for different instance types are as follows:</para>
        /// <list type="bullet">
        /// <item><description>Windows instances: The hostname must be 2 to 15 characters in length and can contain letters, digits, and hyphens (-). It cannot contain periods (.) or contain only digits.</description></item>
        /// <item><description>Other instance types such as Linux instances: The hostname must be 2 to 64 characters in length and can contain multiple periods (.). The string between two periods is a segment, which can contain letters, digits, and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>host****</para>
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
        /// <item><description>enabled: enables the access channel.</description></item>
        /// <item><description>disabled: disables the access channel.</description></item>
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
        /// <para>Specifies whether to forcibly use the security-hardened mode (IMDSv2) to access instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>optional: does not forcibly use the security-hardened mode.</description></item>
        /// <item><description>required: forcibly uses the security-hardened mode. After you set this value, you cannot access instance metadata in normal mode.</description></item>
        /// </list>
        /// <para>Default value: optional.</para>
        /// <remarks>
        /// <para>For more information about the modes for accessing instance metadata, see <a href="https://help.aliyun.com/document_detail/108460.html">Access modes of instance metadata</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>optional</para>
        /// </summary>
        [NameInMap("HttpTokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

        /// <summary>
        /// <para>The name of the image family. You can set this parameter to obtain the latest available image in the image family to create instances. If <c>ImageId</c> is specified, you cannot specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou-daily-update</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The ID of the image file. The image resource used during automatic creation of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>centos6u5_64_20G_aliaegis****.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the image file. The image name must be unique within a region. If ImageId is specified, ImageName is ignored.</para>
        /// <para>You cannot use ImageName to specify an Alibaba Cloud Marketplace image.</para>
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
        /// <para>The name of the ECS instance during automatic creation by using this scaling configuration.</para>
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
        public List<CreateScalingConfigurationRequestInstancePatternInfos> InstancePatternInfos { get; set; }
        public class CreateScalingConfigurationRequestInstancePatternInfos : TeaModel {
            /// <summary>
            /// <para>The architecture type of the instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>X86: x86 computing.</description></item>
            /// <item><description>Heterogeneous: heterogeneous computing, such as GPU or FPGA.</description></item>
            /// <item><description>BareMental: ECS bare metal server.</description></item>
            /// <item><description>Arm: Arm computing.</description></item>
            /// </list>
            /// <para>Default value: all architecture types.</para>
            /// </summary>
            [NameInMap("Architectures")]
            [Validation(Required=false)]
            public List<string> Architectures { get; set; }

            /// <summary>
            /// <para>Specifies whether the instance type is a burstable instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Exclude: does not include burstable instance types.</description></item>
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
            /// <para>The number of vCPUs of the instance type in intelligent configuration mode. This parameter is used to filter instance types that meet your requirements. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>The InstancePatternInfos parameter is applicable only when the network type of the scaling group is VPC.</para>
            /// </description></item>
            /// <item><description><para>You must configure both InstancePatternInfos.Cores and InstancePatternInfos.Memory when you use the InstancePatternInfos parameter.</para>
            /// </description></item>
            /// <item><description><para>If you have already specified instance types by using the InstanceType or InstanceTypes parameter, Auto Scaling preferentially uses the specified instance types for scale-out. If the specified instance types are out of stock, Auto Scaling preferentially uses the instance type that has the lowest price among the instance types that meet the requirements specified by the InstancePatternInfos parameter.</para>
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
            /// <para>N indicates the Settings for multiple instance categories. Valid values of N: 1 to 10.</para>
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
            /// <item><description>ECS Bare Metal: ECS Bare Metal Instance.</description></item>
            /// <item><description>High Performance Compute: high-performance computing (HPC).</description></item>
            /// </list>
            /// </summary>
            [NameInMap("InstanceCategories")]
            [Validation(Required=false)]
            public List<string> InstanceCategories { get; set; }

            /// <summary>
            /// <para>The level of the instance family. This parameter is used to filter instance types that meet your requirements and takes effect when <c>CostOptimization</c> is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>EntryLevel: shared instance types. These instance types are more cost-effective but cannot ensure consistent computing performance. They are suitable for scenarios where the CPU utilization is typically low. For more information, see <a href="https://help.aliyun.com/document_detail/108489.html">Shared instance families</a>.</description></item>
            /// <item><description>EnterpriseLevel: enterprise-level instance types. These instance types provide consistent performance and dedicated resources. They are suitable for scenarios that require high stability. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</description></item>
            /// <item><description>CreditEntryLevel: credit-based entry-level instance types, which are burstable instances. These instance types use CPU credits to ensure computing performance and are suitable for scenarios where the CPU utilization is typically low but occasionally bursts. For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
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
            /// <para>The maximum acceptable hourly price for pay-as-you-go or spot instances in intelligent configuration mode. This parameter is used to filter instance types that meet your requirements.</para>
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
            /// <para>The maximum number of vCPUs of the instance type.</para>
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
            /// <para>The memory size of the instance type in intelligent configuration mode. Unit: GiB. This parameter is used to filter instance types that meet your requirements.</para>
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
            /// <para>The minimum number of vCPUs of the instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MinimumCpuCoreCount")]
            [Validation(Required=false)]
            public int? MinimumCpuCoreCount { get; set; }

            /// <summary>
            /// <para>The minimum upper limit on the number of IPv6 addresses per elastic network interfaces (ENIs) or network interface controller (NIC) for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinimumEniIpv6AddressQuantity")]
            [Validation(Required=false)]
            public int? MinimumEniIpv6AddressQuantity { get; set; }

            /// <summary>
            /// <para>The minimum upper limit on the number of IPv4 addresses per elastic network interfaces (ENIs) or network interface controller (NIC) for the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MinimumEniPrivateIpAddressQuantity")]
            [Validation(Required=false)]
            public int? MinimumEniPrivateIpAddressQuantity { get; set; }

            /// <summary>
            /// <para>The minimum upper limit on the number of network interface controller (NIC) devices that can be mounted to the instance.</para>
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
            /// <para>The physical processor model of the instance. N indicates that you can specify multiple processor models. Valid values of N: 1 to 10.</para>
            /// </summary>
            [NameInMap("PhysicalProcessorModels")]
            [Validation(Required=false)]
            public List<string> PhysicalProcessorModels { get; set; }

        }

        /// <summary>
        /// <para>The instance type of the ECS instance. For more information, see instance families.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>After you enable the candidate mode, if issues such as insufficient stock occur, the system supplements the currently selected instance types with similar instance types of the same size, or creates vSwitches in candidate zones and adds them to the scaling group.</para>
        /// </summary>
        [NameInMap("InstanceTypeCandidateOptions")]
        [Validation(Required=false)]
        public CreateScalingConfigurationRequestInstanceTypeCandidateOptions InstanceTypeCandidateOptions { get; set; }
        public class CreateScalingConfigurationRequestInstanceTypeCandidateOptions : TeaModel {
            /// <summary>
            /// <para>Specifies the CIDR blocks of the optional vSwitches when you add vSwitches in other zones.</para>
            /// </summary>
            [NameInMap("AllowCidrBlocks")]
            [Validation(Required=false)]
            public List<string> AllowCidrBlocks { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow supplementing vSwitches in other zones.</para>
            /// <remarks>
            /// <para>The instance types remain unchanged, and only new zones are used as candidates. If the scaling group cannot scale out in all selected zones due to issues such as insufficient stock, the system automatically adds vSwitches in new zones to the scaling group based on this configuration.
            /// For example, if the scaling group is configured with the cn-hangzhou-h and cn-hangzhou-g zones, and scale-out fails in both zones, Auto Scaling may create a vSwitch in the cn-hangzhou-k zone and add it to the scaling group based on real-time stock availability.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowCrossAz")]
            [Validation(Required=false)]
            public bool? AllowCrossAz { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow supplementing instance types of other generations.</para>
            /// <list type="bullet">
            /// <item><description>For example, if the current instance type is ecs.c7.large, instance types such as ecs.c6.large and ecs.c8.large can be used as candidates after this feature is enabled.</description></item>
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
        /// <para>The information used to specify instance types.</para>
        /// </summary>
        [NameInMap("InstanceTypeOverrides")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationRequestInstanceTypeOverrides> InstanceTypeOverrides { get; set; }
        public class CreateScalingConfigurationRequestInstanceTypeOverrides : TeaModel {
            /// <summary>
            /// <para>When you need the scaling group to scale based on the capacity of the instance type, specify both this parameter and WeightedCapacity.</para>
            /// <para>This parameter specifies the instance type and overrides the instance type in the launch template. You can specify N instance types to extend the launch template to support N instance types. Valid values of N: 1 to 20.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when LaunchTemplateId is specified.</para>
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
            /// <para>When you need to specify the capacity of the instance type in the scaling configuration, specify this parameter after you specify InstanceTypeOverrides.InstanceType.</para>
            /// <para>This parameter specifies the weight of the instance type, which indicates the capacity that a single instance of the instance type provides in the scaling group. A greater weight indicates that fewer instances of this instance type are required to meet the expected capacity.</para>
            /// <para>Because instance types have different performance metrics such as the number of vCPUs and memory size, you can configure different weights for different instance types based on your business requirements.</para>
            /// <para>Example:</para>
            /// <list type="bullet">
            /// <item><description>Current capacity: 0.</description></item>
            /// <item><description>Expected capacity: 6.</description></item>
            /// <item><description>Capacity of the ecs.c5.xlarge instance type: 4.</description></item>
            /// </list>
            /// <para>To meet the expected capacity, the scaling group scales out by adding two ecs.c5.xlarge instances.</para>
            /// <remarks>
            /// <para>During scale-out, the capacity of the scaling group cannot exceed the sum of the maximum capacity (MaxSize) and the maximum weight of the instance type.</para>
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
        /// <para>The multiple instance types. If InstanceTypes is specified, InstanceType is ignored.</para>
        /// <para>If an instance cannot be created based on the instance type with a higher priority, Auto Scaling automatically selects the instance type with the next highest priority to create the instance.</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The network billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PayByBandwidth: pay-by-bandwidth. In this case, InternetMaxBandwidthOut specifies the fixed bandwidth value.</para>
        /// </description></item>
        /// <item><description><para>PayByTraffic: pay-by-traffic. In this case, InternetMaxBandwidthOut specifies only the maximum bandwidth, and you are billed based on the actual network traffic.</para>
        /// </description></item>
        /// </list>
        /// <para>If this parameter is not specified, the default value is PayByBandwidth for the classic network and PayByTraffic for a VPC.</para>
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
        /// <item><description>If the purchased outbound public bandwidth is less than or equal to 10 Mbit/s: 1 to 10. Default value: 10.</description></item>
        /// <item><description>If the purchased outbound public bandwidth is greater than 10 Mbit/s: 1 to the value of <c>InternetMaxBandwidthOut</c>. Default value: the value of <c>InternetMaxBandwidthOut</c>.</description></item>
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
        /// <para>Specifies whether the instance is an I/O optimization instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>none: The instance is not an I/O optimization instance.</description></item>
        /// <item><description>optimized: The instance is an I/O optimization instance.</description></item>
        /// </list>
        /// <para>The default value is none for retired instance types and optimized for other instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>The number of IPv6 addresses that are randomly generated for the network interface controller (NIC).</para>
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
        /// <item><description>For Windows instances, this parameter is ignored and left empty by default. </description></item>
        /// <item><description>For Linux instances, password-based logon is disabled by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KeyPairTest</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The weight of the ECS instance as a load balancing backend server. Valid values: 1 to 100.</para>
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
        /// <para>You can specify both Cpu and Memory to define the range of instance types. For example, if you set Cpu to 2 and Memory to 16, all instance types with 2 vCPUs and 16 GiB of memory are matched. Auto Scaling determines the available instance types based on factors such as I/O optimization and zone, and creates instances with the lowest price.</para>
        /// <remarks>
        /// <para>This configuration takes effect only when the scaling mode is set to cost optimization and no instance type is specified in the scaling configuration.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The list of network interface controller (NIC) devices.</para>
        /// </summary>
        [NameInMap("NetworkInterfaces")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationRequestNetworkInterfaces> NetworkInterfaces { get; set; }
        public class CreateScalingConfigurationRequestNetworkInterfaces : TeaModel {
            /// <summary>
            /// <para>The elastic network interfaces (ENIs) type. When you use this parameter, you must use the NetworkInterfaces Settings for the primary network interface controller (NIC), and you cannot set the SecurityGroupId or SecurityGroupIds parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Primary: primary elastic network interface (ENI).</para>
            /// </description></item>
            /// <item><description><para>Secondary: secondary elastic network interface (ENI).</para>
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
            /// <para>The number of randomly generated IPv6 addresses for the primary ENI.
            /// Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>This parameter takes effect only when NetworkInterface.InstanceType is set to Primary. If NetworkInterface.InstanceType is set to Secondary or left empty, you cannot configure this parameter.</para>
            /// </description></item>
            /// <item><description><para>After you configure this parameter, you cannot configure Ipv6AddressCount.</para>
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
            /// <para>The communication pattern of the network interface controller (NIC). Valid values of the parameter:</para>
            /// <list type="bullet">
            /// <item><description>Standard: uses the TCP communication pattern.</description></item>
            /// <item><description>HighPerformance: enables the Elastic RDMA Interface (ERI) and uses the RDMA communication pattern.</description></item>
            /// </list>
            /// <para>Default value: Standard.</para>
            /// <remarks>
            /// <para>The number of elastic network interfaces (ENIs) in RDMA pattern cannot exceed the limit of the instance family. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HighPerformance</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// <para>The number of secondary private IPv4 addresses to be assigned to the ENI. Valid values: 1 to 49.</para>
            /// <list type="bullet">
            /// <item><description><para>The value cannot exceed the limit on the number of IP addresses for the instance type. For more information, see <a href="https://www.alibabacloud.com/help/en/ecs/user-guide/overview-of-instance-families">Instance families</a>.</para>
            /// </description></item>
            /// <item><description><para>NetworkInterface.N.SecondaryPrivateIpAddressCount specifies the number of secondary private IPv4 addresses to be assigned to the ENI, excluding the primary private IP address of the ENI. The system randomly assigns these addresses from the available CIDR block of the vSwitch (NetworkInterface.N.VSwitchId) to which the ENI belongs.</para>
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
            /// <para>The IDs of one or more security groups to which the elastic network interfaces (ENIs) belong.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the elastic network interfaces (ENIs) belong. N indicates the Settings for multiple vSwitches. Valid values of N: 1 to 10.</para>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>If InstanceType is set to Primary, you cannot set this parameter. The default value is the vSwitch to which the instance belongs.</description></item>
            /// <item><description>If InstanceType is set to Secondary or left empty, this parameter is optional.</description></item>
            /// <item><description>The system selects a vSwitch that is in the same zone as the primary network interface controller (NIC) and has the most active IP addresses.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The password of the ECS instance. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include:</para>
        /// <para>\<c>()</c> ~!@#$%^&amp;*-_+=\|{}[]:;\&quot;&lt;&gt;,.?/`</para>
        /// <para>For Windows instances, the password cannot start with a forward slash (/).</para>
        /// <remarks>
        /// <para>If you specify the Password parameter, send requests over HTTPS to prevent password leaks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123abc****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the preset password of the image. When you use this parameter, make sure that a password is preset in the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: uses the preset password of the image.</description></item>
        /// <item><description>false: does not use the preset password of the image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

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
        /// <para>rg-resource****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The resource pool policy used when creating the instance. Take note of the following items when you configure this parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when you create pay-as-you-go instances.</para>
        /// </description></item>
        /// <item><description><para>You cannot configure this parameter together with PrivatePoolOptions.MatchCriteria or PrivatePoolOptions.Id.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResourcePoolOptions")]
        [Validation(Required=false)]
        public CreateScalingConfigurationRequestResourcePoolOptions ResourcePoolOptions { get; set; }
        public class CreateScalingConfigurationRequestResourcePoolOptions : TeaModel {
            /// <summary>
            /// <para>The ID of the private pool, which is the ID of the elasticity assurance or capacity reservation service. You can only specify the ID of a private pool in Target mode, and you cannot specify this parameter together with PrivatePoolTags.</para>
            /// </summary>
            [NameInMap("PrivatePoolIds")]
            [Validation(Required=false)]
            public List<string> PrivatePoolIds { get; set; }

            /// <summary>
            /// <para>Filters available Target private pools by tag. Valid values of N: 1 to 20.
            /// Note:</para>
            /// <list type="bullet">
            /// <item><description>When you configure this parameter, the system filters private pools from the Target private pools associated with your account. The filtered private pools must match the tags and meet the scaling group constraints, such as zone and instance type.</description></item>
            /// <item><description>Tag matching rule: The private pool must match all specified tags.</description></item>
            /// <item><description>You cannot specify this parameter together with PrivatePoolIds.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("PrivatePoolTags")]
            [Validation(Required=false)]
            public List<CreateScalingConfigurationRequestResourcePoolOptionsPrivatePoolTags> PrivatePoolTags { get; set; }
            public class CreateScalingConfigurationRequestResourcePoolOptionsPrivatePoolTags : TeaModel {
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
            /// <para>Resource pools include private pools generated after the elasticity assurance or capacity reservation service takes effect, as well as public pools. They are available for selection when the instance starts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PrivatePoolFirst: private pools take precedence. When you select this policy, if ResourcePoolOptions.PrivatePoolIds is specified or the PrivatePoolTags condition is met, the corresponding private pool is preferentially used. If no private pool is specified or the specified private pool has insufficient capacity, the system automatically matches an open private pool. If no eligible private pool is available, the public pool is used to create the instance.</para>
            /// </description></item>
            /// <item><description><para>PrivatePoolOnly: only private pools are used. When you select this policy, you must specify ResourcePoolOptions.PrivatePoolIds. If the specified private pool has insufficient capacity, the instance fails to start.</para>
            /// </description></item>
            /// <item><description><para>PublicPoolFirst: public pool resources take precedence. The public pool is preferentially used to create the instance. When public pool resources are insufficient, private pool resources are used as a supplement. The system preferentially and automatically matches an open private pool. If no eligible private pool is available, the specified ResourcePoolOptions.PrivatePoolIds or a Target private pool that meets the PrivatePoolTags condition is used. (This policy is in invitational preview and is not supported yet.)</para>
            /// </description></item>
            /// <item><description><para>None: no resource pool policy is used.</para>
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
        /// <para>The name of the scaling configuration. The name must be 2 to 64 characters in length and can contain letters, digits, underscores (_), hyphens (-), and periods (.). It must start with a letter, digit, or Chinese character.</para>
        /// <para>The name must be unique within a scaling group in a region. If you do not specify this parameter, the ID of the scaling configuration is used by default.</para>
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
        public Dictionary<string, object> SchedulerOptions { get; set; }

        /// <summary>
        /// <para>Specifies whether a vSwitch available for secondary elastic network interfaces (ENIs) must be selected from the list when the VSwitchIds parameter is specified for the secondary ENIs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Strict: strict mode. If no vSwitch in the VSwitchIds list meets the requirements, instance creation fails.</description></item>
        /// <item><description>Tolerant: fault-tolerant mode. If no vSwitch in the VSwitchIds list meets the requirements, no secondary ENI is configured, and the instance is still created.</description></item>
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
        /// <para>Specifies whether to enable security hardening. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Active: enables security hardening. This value applies only to public images.</description></item>
        /// <item><description>Deactive: disables security hardening. This value applies to all image types.</description></item>
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
        /// <para>sg-280ih****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>Adds the ECS instance to multiple security groups at the same time. For more information, see the Security groups section in <a href="https://help.aliyun.com/document_detail/25412.html">Limits</a>.</para>
        /// <remarks>
        /// <para>You cannot specify both SecurityGroupId and SecurityGroupIds at the same time.</para>
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
        public CreateScalingConfigurationRequestSecurityOptions SecurityOptions { get; set; }
        public class CreateScalingConfigurationRequestSecurityOptions : TeaModel {
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
        /// <item><description>1: Alibaba Cloud guarantees that the instance runs for 1 hour after it is created and is not automatically released. After 1 hour, the system automatically compares your bid with the market price and checks resource inventory to determine whether to retain automatic release the instance.</description></item>
        /// <item><description>0: Alibaba Cloud does not guarantee that the instance runs for 1 hour after it is created. The system automatically compares your bid with the market price and checks resource inventory to determine whether to retain automatic release the instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Alibaba Cloud sends you a notification by using ECS system events 5 minutes before the instance is released. Spot instances are billed by the second. Select an appropriate protection period based on the execution duration of your tasks.</para>
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
        /// <para>The break mode of the spot instance. Currently, only terminate (default) is supported, which releases the instance directly.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Terminate</para>
        /// </summary>
        [NameInMap("SpotInterruptionBehavior")]
        [Validation(Required=false)]
        public string SpotInterruptionBehavior { get; set; }

        /// <summary>
        /// <para>The collection of billing information for spot instances.</para>
        /// </summary>
        [NameInMap("SpotPriceLimits")]
        [Validation(Required=false)]
        public List<CreateScalingConfigurationRequestSpotPriceLimits> SpotPriceLimits { get; set; }
        public class CreateScalingConfigurationRequestSpotPriceLimits : TeaModel {
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
            /// <para>The maximum hourly price for the spot instance. This parameter takes effect only when SpotStrategy is set to SpotWithPriceLimit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("PriceLimit")]
            [Validation(Required=false)]
            public float? PriceLimit { get; set; }

        }

        /// <summary>
        /// <para>The preemption policy for the pay-as-you-go instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: spot instance with a maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: spot instance whose price is automatically set based on the current market price.</description></item>
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
        /// <para>The maximum number of partitions in the storage set. Valid values: integers greater than or equal to 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        /// <summary>
        /// <para>The disk types for the system cloud disk. If a disk type with a higher priority is unavailable, Auto Scaling automatically attempts to use the disk type with the next highest priority to create the system cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud: basic cloud disk.</description></item>
        /// <item><description>cloud_efficiency: ultra cloud disk.</description></item>
        /// <item><description>cloud_ssd: standard SSD cloud disk.</description></item>
        /// <item><description>cloud_essd: ESSD cloud disk.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You cannot specify both this parameter and <c>SystemDisk.Category</c> at the same time.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SystemDiskCategories")]
        [Validation(Required=false)]
        public List<string> SystemDiskCategories { get; set; }

        /// <summary>
        /// <para>The tags of the ECS instance. Tags are passed in as key-value pairs. You can add up to 20 tags. The requirements for keys and values are as follows:</para>
        /// <list type="bullet">
        /// <item><description>A key can be up to 64 characters in length. It cannot start with aliyun or acs: and cannot contain <c>http://</c> or <c>https://</c>. A key cannot be an empty string.</description></item>
        /// <item><description>A value can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain <c>http://</c> or <c>https://</c>. A value can be an empty string.</description></item>
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
        /// <para>The user data of the ECS instance. It must be encoded in Base64. The maximum size of the raw data before encoding is 32 KB.</para>
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
