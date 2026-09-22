// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateLaunchTemplateRequest : TeaModel {
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public CreateLaunchTemplateRequestSystemDisk SystemDisk { get; set; }
        public class CreateLaunchTemplateRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy applied to the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-gc7c37d4ylw7mtnk****</para>
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the performance burst feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enable the performance burst feature.</description></item>
            /// <item><description>false: Disable the performance burst feature.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
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
            /// <item><description>cloud_essd: enterprise SSD (ESSD). You can use the <c>SystemDisk.PerformanceLevel</c> parameter to configure the performance level of the disk.</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL disk.</description></item>
            /// <item><description>cloud_essd_entry: ESSD Entry disk.</description></item>
            /// </list>
            /// <para>For retired instance types that are not I/O optimized instances, the default value is cloud. For other instance types, the default value is cloud_efficiency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>Specifies whether to release the system disk when the instance is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The system disk is released together with the instance.</description></item>
            /// <item><description>false: The system disk is not released together with the instance.</description></item>
            /// </list>
            /// <para>Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DeleteWithInstance")]
            [Validation(Required=false)]
            public bool? DeleteWithInstance { get; set; }

            /// <summary>
            /// <para>The description of the system disk. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testSystemDiskDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the system disk. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. The name can contain digits, colons (:), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>testSystemDiskName</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: encrypts the system disk.</description></item>
            /// <item><description>false: does not encrypt the system disk.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>Zone D in Hong Kong (China) and Zone A in Singapore do not support system disk encryption when you create an instance.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is in invitational preview and is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Iops")]
            [Validation(Required=false)]
            public int? Iops { get; set; }

            /// <summary>
            /// <para>The KMS key ID of the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d3fb40****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD used as the system disk. Settings for the performance level of the disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0 (default): A single disk can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: A single disk can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single disk can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single disk can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>For information about how to select ESSD performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">Enterprise SSDs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50000, 1000 × Capacity - Baseline performance}.</para>
            /// <para>Baseline performance = min{1,800 + 50 × Capacity, 50,000}</para>
            /// <remarks>
            /// <para>This parameter is available only when DiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a> and <a href="https://help.aliyun.com/document_detail/413275.html">Modify the provisioned performance of an ESSD AutoPL disk</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: 20 to 500.</description></item>
            /// <item><description>Other disk categories: 20 to 2048.</description></item>
            /// </list>
            /// <para>The value of this parameter must be greater than or equal to max{20, ImageSize}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

        /// <summary>
        /// <para>The automatic release time. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <list type="bullet">
        /// <item><description><para>If the value of seconds (<c>ss</c>) is not <c>00</c>, the time is automatically rounded down to the start of the current minute (<c>mm</c>).</para>
        /// </description></item>
        /// <item><description><para>The earliest release time must be at least half an hour from the current time.</para>
        /// </description></item>
        /// <item><description><para>The latest release time cannot be more than three years from the current time.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-01T12:05:00Z</para>
        /// </summary>
        [NameInMap("AutoReleaseTime")]
        [Validation(Required=false)]
        public string AutoReleaseTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables auto-renewal.</description></item>
        /// <item><description>false: does not enable auto-renewal.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <c>InstanceChargeType</c> is set to <c>PrePaid</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal period for a single renewal. Valid values: </para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If PeriodUnit is set to Week: 1, 2, and 3.</description></item>
        /// <item><description>If PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;If PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The running mode of the burstable instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: standard mode. For more information, see the performance constrained mode section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
        /// <item><description>Unlimited: unlimited mode. For more information, see the unlimited performance mode section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// <para>The list of data disk configurations.</para>
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<CreateLaunchTemplateRequestDataDisk> DataDisk { get; set; }
        public class CreateLaunchTemplateRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy applied to the data disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-m5e7fa9ute44ssa****</para>
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the performance burst feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enable the performance burst feature.</description></item>
            /// <item><description>false: Disable the performance burst feature.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BurstingEnabled")]
            [Validation(Required=false)]
            public bool? BurstingEnabled { get; set; }

            /// <summary>
            /// <para>The category of data disk N. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.</description></item>
            /// <item><description>cloud_essd: enterprise SSD (ESSD).</description></item>
            /// <item><description>cloud: basic disk.</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL disk.</description></item>
            /// <item><description>cloud_regional_disk_auto: regional ESSD.</description></item>
            /// <item><description>cloud_essd_entry: ESSD Entry disk.<remarks>
            /// <para>The cloud_essd_entry value is supported only when <c>InstanceType</c> is set to an instance type in the <c>ecs.u1</c> or <c>ecs.e</c> family.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description>elastic_ephemeral_disk_standard: elastic ephemeral disk - Standard.</description></item>
            /// <item><description>elastic_ephemeral_disk_premium: elastic ephemeral disk - Premium Edition.</description></item>
            /// </list>
            /// <para>For I/O optimized instances, the default value is cloud_efficiency. For non-I/O optimized instances, the default value is cloud.
            /// Default value optimization details:</para>
            /// <list type="bullet">
            /// <item><description>If InstanceType is set to a retired instance type that is not I/O optimized, the default parameter value is <c>cloud</c>.</description></item>
            /// <item><description>In other cases, the default value is <c>cloud_efficiency</c>.&lt;props=&quot;china&quot;&gt;After January 30, 2026, if the I/O optimized instance type does not support cloud_auto, the default value is cloud_efficiency. Otherwise, the default value is cloud_auto, and the performance burst feature is enabled by default (which incurs additional fees. For more information, see <a href="~~368372#p_75k_2hp_7gp~~">Billing examples</a>). For details, see <a href="https://www.aliyun.com/notice/117844">Change notice</a>.</description></item>
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
            /// <item><description>true: The data disk is released together with the instance.</description></item>
            /// <item><description>false: The data disk is not released together with the instance.</description></item>
            /// </list>
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
            /// <para>testDataDiskDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The mount point of the data disk. The naming convention varies based on the number of data disks attached:</para>
            /// <list type="bullet">
            /// <item><description><para>1 to 25 data disks: /dev/xvd<c>[b-z]</c></para>
            /// </description></item>
            /// <item><description><para>More than 25 data disks: /dev/xvd<c>[aa-zz]</c>. For example, the 26th data disk is named /dev/xvdaa, the 27th data disk is named /dev/xvdab, and so on.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is applicable only to full image (whole-machine image) scenarios. You can set this parameter to the mount point of the data disk in the full image and modify the corresponding <c>DataDisk.N.Size</c> and <c>DataDisk.N.Category</c> parameters to change the disk category and size of the data disk in the full image.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>/dev/xvdb</para>
            /// </summary>
            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            /// <summary>
            /// <para>The name of the data disk. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. The name can contain digits, colons (:), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDataDiskName</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the data disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public string Encrypted { get; set; }

            /// <summary>
            /// <para>The KMS key ID for the data disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD used as the data disk. The value of N must be the same as that in <c>DataDisk.N.Category=cloud_essd</c>. Settings for the performance level of the disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single disk can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1 (default): A single disk can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single disk can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single disk can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>For information about how to select ESSD performance levels, see <a href="https://help.aliyun.com/document_detail/122389.html">Enterprise SSDs</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50000, 1000 × Capacity - Baseline performance}.</para>
            /// <para>Baseline performance = min{1,800 + 50 × Capacity, 50,000}</para>
            /// <remarks>
            /// <para>This parameter is available only when DiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a> and <a href="https://help.aliyun.com/document_detail/413275.html">Modify the provisioned performance of an ESSD AutoPL disk</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>50000</para>
            /// </summary>
            [NameInMap("ProvisionedIops")]
            [Validation(Required=false)]
            public long? ProvisionedIops { get; set; }

            /// <summary>
            /// <para>The size of data disk N. Valid values of N: 1 to 16. Unit: GiB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud: 5 to 2000</description></item>
            /// <item><description>cloud_efficiency: 20 to 32768</description></item>
            /// <item><description>cloud_ssd: 20 to 32768</description></item>
            /// <item><description>cloud_essd: The valid value range varies based on the value of <c>DataDisk.N.PerformanceLevel</c>.<list type="bullet">
            /// <item><description>PL0: 1 to 32768.</description></item>
            /// <item><description>PL1: 20 to 32768.</description></item>
            /// <item><description>PL2: 461 to 32768.</description></item>
            /// <item><description>PL3: 1261 to 32768.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>cloud_auto: 1 to 32,768.</description></item>
            /// <item><description>cloud_essd_entry: 10 to 32,768.</description></item>
            /// </list>
            /// <para>The value of this parameter must be greater than or equal to the size of the snapshot specified by <c>SnapshotId</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The ID of the snapshot used to create data disk N. Valid values of N: 1 to 16. After you specify <c>DataDisk.N.SnapshotId</c>, <c>DataDisk.N.Size</c> is ignored. The actual size of the created disk is the size of the specified snapshot.</para>
            /// <remarks>
            /// <para>Snapshots created on or before July 15, 2013 cannot be used. Requests that use such snapshots are rejected.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>s-bp17441ohwka0yuh****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

        }

        /// <summary>
        /// <para>The release protection attribute of the instance. Specifies whether the instance can be released from the ECS console or by calling the <a href="https://help.aliyun.com/document_detail/25507.html">DeleteInstance</a> operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables release protection for the instance.</para>
        /// </description></item>
        /// <item><description><para>false: disables release protection for the instance.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This attribute applies only to pay-as-you-go instances. It can only prevent manual release operations, not system-initiated release operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The ID of the deployment set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds-bp1brhwhoqinyjd6****</para>
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// <para>The description of the instance. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testECSDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the operating system configuration of the instance.</para>
        /// <remarks>
        /// <para>This parameter will be deprecated. Use other parameters for better compatibility.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableVmOsConfig")]
        [Validation(Required=false)]
        public bool? EnableVmOsConfig { get; set; }

        /// <summary>
        /// <para>The hostname of the Elastic Compute Service server.</para>
        /// <list type="bullet">
        /// <item><description>The hostname cannot start or end with a period (.) or a hyphen (-). It cannot contain consecutive periods (.) or hyphens (-).</description></item>
        /// <item><description>For Windows instances: The hostname must be 2 to 15 characters in length and cannot contain periods (.) or consist entirely of digits. It can contain letters, digits, and hyphens (-).</description></item>
        /// <item><description>For other instances such as Linux: The hostname must be 2 to 64 characters in length. You can use periods (.) to separate the hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testHostName</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

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
        /// <remarks>
        /// <para>This parameter is not available for use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("HttpPutResponseHopLimit")]
        [Validation(Required=false)]
        public int? HttpPutResponseHopLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully use the security-hardened mode (IMDSv2) to access instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>optional: does not forcefully use the security-hardened mode.</description></item>
        /// <item><description>required: forcefully uses the security-hardened mode. After you set this parameter to required, you cannot access instance metadata in normal mode.</description></item>
        /// </list>
        /// <para>Default value: optional.</para>
        /// <remarks>
        /// <para>For more information about the modes for accessing instance metadata, see <a href="https://help.aliyun.com/document_detail/108460.html">Overview of instance metadata</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>optional</para>
        /// </summary>
        [NameInMap("HttpTokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

        /// <summary>
        /// <para>The image ID. You can call <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> to query available image resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>win2008r2_64_ent_sp1_en-us_40G_alibase_20170915.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image-related property information.</para>
        /// </summary>
        [NameInMap("ImageOptions")]
        [Validation(Required=false)]
        public CreateLaunchTemplateRequestImageOptions ImageOptions { get; set; }
        public class CreateLaunchTemplateRequestImageOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether instances that use this image support logon with the ecs-user user.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: supported.</description></item>
            /// <item><description>false: not supported.</description></item>
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
        /// <para>The source of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system: public images provided by Alibaba Cloud.</description></item>
        /// <item><description>self: custom images that you created.</description></item>
        /// <item><description>others: shared images from other Alibaba Cloud accounts.</description></item>
        /// <item><description>marketplace: images provided by &lt;props=&quot;china&quot;&gt;<ph><a href="https://market.aliyun.com/">Alibaba Cloud Marketplace</a></ph>&lt;props=&quot;intl&quot;&gt;<ph><a href="https://marketplace.alibabacloud.com/">Alibaba Cloud Marketplace</a></ph>. You can use Alibaba Cloud Marketplace images directly without subscribing to them first. Check the billing details of Alibaba Cloud Marketplace images on your own.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription. If you set this parameter to PrePaid, &lt;props=&quot;china&quot;&gt;<ph>confirm that your account supports balance payments and credit payments</ph>&lt;props=&quot;intl&quot;&gt;<ph>confirm that your account supports credit payments</ph>. Otherwise, an <c>InvalidPayMethod</c> fault is returned.</description></item>
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The name of the instance. The name must be 2 to 128 characters in length and can contain characters from the Unicode letter category (including letters in English, Chinese, and digits). The name can contain colons (:), underscores (_), periods (.), and hyphens (-). The default value is the <c>InstanceId</c> of the instance.</para>
        /// <para>When you create multiple ECS instances, you can set sequential instance names that contain brackets ([]) and commas (,). For more information, see <a href="https://help.aliyun.com/document_detail/196048.html">Batch configure sequential names or hostnames for multiple instances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-node-[1,4]-alibabacloud</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance family</a>. You can also invoke <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query the most recent instance type list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The billing method for network usage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayByBandwidth: pay-by-bandwidth.</description></item>
        /// <item><description>PayByTraffic: pay-by-traffic.</description></item>
        /// </list>
        /// <remarks>
        /// <para>In <b>pay-by-traffic</b> mode, the peak inbound and outbound bandwidths are used as the upper limits of bandwidths instead of guaranteed performance specifications. When resource contention occurs, these peak bandwidths may be limited. If you want guaranteed bandwidths for your business, use the <b>pay-by-bandwidth</b> billing mode.</para>
        /// </remarks>
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
        /// <item><description>none: The instance is not I/O optimized.</description></item>
        /// <item><description>optimized: The instance is I/O optimized.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>The number of randomly generated IPv6 addresses to assign to the primary ENI. Valid values: 1 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// <para>The name of the key pair.</para>
        /// <list type="bullet">
        /// <item><description>For Windows instances, this parameter is ignored. Even if you specify this parameter, only the <c>Password</c> content is used.</description></item>
        /// <item><description>For Linux instances, the password logon method is disabled during initialization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testKeyPairName</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The name of the launch template. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. The name can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testLaunchTemplateName</para>
        /// </summary>
        [NameInMap("LaunchTemplateName")]
        [Validation(Required=false)]
        public string LaunchTemplateName { get; set; }

        /// <summary>
        /// <para>The Elastic Network Interface (ENI) information.</para>
        /// </summary>
        [NameInMap("NetworkInterface")]
        [Validation(Required=false)]
        public List<CreateLaunchTemplateRequestNetworkInterface> NetworkInterface { get; set; }
        public class CreateLaunchTemplateRequestNetworkInterface : TeaModel {
            /// <summary>
            /// <para>Specifies whether to retain the ENI when the instance is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: does not retain the ENI.</para>
            /// </description></item>
            /// <item><description><para>false: retains the ENI.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: true.</para>
            /// <remarks>
            /// <para>This parameter takes effect only for secondary ENIs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DeleteOnRelease")]
            [Validation(Required=false)]
            public bool? DeleteOnRelease { get; set; }

            /// <summary>
            /// <para>The description of the secondary Elastic Network Interface (ENI). The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>. The value of N in <c>NetworkInterface.N</c> cannot be greater than 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testEniDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of the Elastic Network Interface (ENI). Valid values of N: 1 to 2. When you configure one ENI, you can configure one primary ENI or one secondary ENI. When you configure two ENIs, you can configure only one primary ENI and one secondary ENI at the same time.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Primary: primary ENI.</description></item>
            /// <item><description>Secondary: secondary ENI.</description></item>
            /// </list>
            /// <para>Default value: Secondary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Secondary</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The name of the Elastic Network Interface (ENI).</para>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values of N: 1 to 2. When you configure one ENI, you can configure one primary ENI or one secondary ENI. When you configure two ENIs, you can configure only one primary ENI and one secondary ENI at the same time.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to <c>Primary</c>, you do not need to configure this parameter.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testEniName</para>
            /// </summary>
            [NameInMap("NetworkInterfaceName")]
            [Validation(Required=false)]
            public string NetworkInterfaceName { get; set; }

            /// <summary>
            /// <para>The communication mode of the primary ENI. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: uses the TCP communication mode.</description></item>
            /// <item><description>HighPerformance: enables the Elastic RDMA Interface (ERI) and uses the RDMA communication mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("NetworkInterfaceTrafficMode")]
            [Validation(Required=false)]
            public string NetworkInterfaceTrafficMode { get; set; }

            /// <summary>
            /// <para>Adds an Elastic Network Interface (ENI) and sets the primary IP address.</para>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values of N: 1 to 2:</para>
            /// <list type="bullet">
            /// <item><description>If you configure one ENI, you can configure one primary ENI or one secondary ENI. If the <c>Amount</c> parameter is set to a value greater than 1 and you configure a primary ENI with this parameter specified, consecutive primary IP addresses starting from the specified IP address are allocated to multiple ECS instances during batch creation. In this case, you cannot attach a secondary ENI to the instances.</description></item>
            /// <item><description>If you configure two ENIs, you must configure one primary ENI and one secondary ENI at the same time. If the <c>Amount</c> parameter is set to a value greater than 1 and this parameter is specified for the primary ENI, you cannot configure a secondary ENI (that is, you cannot set <c>NetworkInterface.2.InstanceType=Secondary</c>).</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to <c>Primary</c>, this parameter has the same effect as <c>PrivateIpAddress</c>. However, you cannot specify both this parameter and <c>PrivateIpAddress</c>.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to <c>Secondary</c> or left empty, this parameter specifies the primary IP address of the secondary ENI. By default, a random IP address is selected from the vSwitch CIDR block to which the ENI belongs.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>You can attach up to one secondary ENI when you create an ECS instance. After the instance is created, you can invoke <a href="https://help.aliyun.com/document_detail/58504.html">CreateNetworkInterface</a> and <a href="https://help.aliyun.com/document_detail/58515.html">AttachNetworkInterface</a> to attach more secondary ENIs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><c>192.168.**.**</c></para>
            /// </summary>
            [NameInMap("PrimaryIpAddress")]
            [Validation(Required=false)]
            public string PrimaryIpAddress { get; set; }

            /// <summary>
            /// <para>The ID of the security group to which the Elastic Network Interface (ENI) belongs.</para>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values of N: 1 to 2. When you configure one ENI, you can configure one primary ENI or one secondary ENI. When you configure two ENIs, you can configure only one primary ENI and one secondary ENI at the same time.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to <c>Primary</c>, you must configure this parameter. In this case, this parameter has the same effect as <c>SecurityGroupId</c>. However, you cannot specify <c>SecurityGroupId</c>, <c>SecurityGroupIds.N</c>, or <c>NetworkInterface.N.SecurityGroupIds.N</c>.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to <c>Secondary</c> or left empty, this parameter is optional. Default value: the security group of the ECS instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp15ed6xe1yxeycg****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The IDs of one or more security groups to which the Elastic Network Interface (ENI) belongs.</para>
            /// <list type="bullet">
            /// <item><description>The first N specifies the ENI index. Valid values: 1 to 2. When you configure one ENI, you can configure one primary ENI or one secondary ENI. When you configure two ENIs, you can configure only one primary ENI and one secondary ENI at the same time.</description></item>
            /// <item><description>The second N specifies one or more security group IDs. The valid values of N depend on the maximum number of security groups to which an instance can belong. For more information, see <a href="~~25412#SecurityGroupQuota1~~">Security group limits</a>.</description></item>
            /// </list>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to <c>Primary</c>, you must configure this parameter or <c>NetworkInterface.N.SecurityGroupId</c>. In this case, this parameter has the same effect as <c>SecurityGroupIds.N</c>. However, you cannot specify <c>SecurityGroupId</c>, <c>SecurityGroupIds.N</c>, or <c>NetworkInterface.N.SecurityGroupId</c>.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to <c>Secondary</c> or left empty, this parameter is optional. Default value: the security group of the ECS instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the Elastic Network Interface (ENI) belongs.</para>
            /// <para>Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values of N: 1 to 2. When you configure one ENI, you can configure one primary ENI or one secondary ENI. When you configure two ENIs, you can configure only one primary ENI and one secondary ENI at the same time.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to <c>Primary</c>, you must configure this parameter. In this case, this parameter has the same effect as <c>VSwitchId</c>. However, you cannot specify both this parameter and <c>VSwitchId</c>.</para>
            /// </description></item>
            /// <item><description><para>If NetworkInterface.N.InstanceType is set to <c>Secondary</c> or left empty, this parameter is optional. Default value: the vSwitch to which the ECS instance belongs.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1s5fnvk4gn2tws0****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>classic: classic network. This feature has been retired. For more information, see <a href="https://help.aliyun.com/document_detail/2833134.html">Retirement notice</a>.</description></item>
        /// <item><description>vpc: VPC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the preset password of the image.</para>
        /// <remarks>
        /// <para>When you use this parameter, the Password parameter must be empty. Make sure that the image you use has a password preset.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The subscription duration of the resource. Unit: months. This parameter takes effect and is required only when <c>InstanceChargeType</c> is set to <c>PrePaid</c>. Valid values: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription period. Valid values: </para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Week.</description></item>
        /// <item><description>Month (default).</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;Month (default).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The private IP address of the instance.</para>
        /// <para>To assign a private IP address to a VPC-connected ECS instance, select an available IP address from the CIDR block of the vSwitch (<c>VSwitchId</c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>10.1.**.**</c></para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The name of the instance RAM role. You can call the RAM API <a href="https://help.aliyun.com/document_detail/28713.html">ListRoles</a> to query the instance RAM roles that you have created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRamRoleName</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the enterprise resource group to which the instance, block storage, and network interface controller (NIC) belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable security hardening for the operating system. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Active: Enables security hardening. This value is applicable only to public images.</description></item>
        /// <item><description>Deactive: Disables security hardening. This value is applicable to all image types.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Deactive</para>
        /// </summary>
        [NameInMap("SecurityEnhancementStrategy")]
        [Validation(Required=false)]
        public string SecurityEnhancementStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the new instance belongs. Instances in the same security group can communicate with each other. A security group can contain up to 1,000 instances.</para>
        /// <remarks>
        /// <para>You cannot specify both <c>SecurityGroupId</c> and <c>SecurityGroupIds.N</c> at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp15ed6xe1yxeycg****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of one or more security groups to which the instance belongs. The valid values of N depend on the maximum number of security groups to which an instance can belong. For more information, see <a href="https://help.aliyun.com/document_detail/25412.html">Limits</a>.</para>
        /// <remarks>
        /// <para>You cannot specify both <c>SecurityGroupId</c> and <c>SecurityGroupIds.N</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp15ed6xe1yxeycg7****</para>
        /// </summary>
        [NameInMap("SecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// <para>The security options.</para>
        /// </summary>
        [NameInMap("SecurityOptions")]
        [Validation(Required=false)]
        public CreateLaunchTemplateRequestSecurityOptions SecurityOptions { get; set; }
        public class CreateLaunchTemplateRequestSecurityOptions : TeaModel {
            [NameInMap("EnableSecureBoot")]
            [Validation(Required=false)]
            public bool? EnableSecureBoot { get; set; }

            /// <summary>
            /// <para>The trusted system mode. Set the value to vTPM.</para>
            /// <para>The following instance families support the trusted system mode:</para>
            /// <list type="bullet">
            /// <item><description>g7, c7, and r7.</description></item>
            /// <item><description>Security-enhanced instance families (g7t, c7t, and r7t).</description></item>
            /// </list>
            /// <para>When you create ECS instances of the preceding instance families, you must configure this parameter. Take note of the following items:</para>
            /// <list type="bullet">
            /// <item><description>To use Alibaba Cloud Trusted System, set this parameter to vTPM. Then, Alibaba Cloud Trusted System performs trusted verification when the instance starts.</description></item>
            /// <item><description>If you do not want to use Alibaba Cloud Trusted System, you can leave this parameter empty. However, if the ECS instance that you create uses the Enclave-based confidential computing mode (<c>SecurityOptions.ConfidentialComputingMode=Enclave</c>), the trusted system is also enabled for the instance.</description></item>
            /// <item><description>When you create a trusted ECS instance by calling an OpenAPI operation, you can use only <c>RunInstances</c>. <c>CreateInstance</c> does not support the <c>SecurityOptions.TrustedSystemMode</c> parameter.<remarks>
            /// <para>If you specify an instance as a trusted instance during creation, you can replace the system disk only with an image that supports the trusted system.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// <para>For more information about the trusted system, see <a href="https://help.aliyun.com/document_detail/201394.html">Overview of trusted features for security-enhanced instances</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vTPM</para>
            /// </summary>
            [NameInMap("TrustedSystemMode")]
            [Validation(Required=false)]
            public string TrustedSystemMode { get; set; }

        }

        /// <summary>
        /// <para>The protection period of the spot instance. Unit: hours. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: After a spot instance is created, Alibaba Cloud ensures that the instance is not automatically released within 1 hour. After the 1-hour protection period ends, the system compares the bid price with the market price and checks the resource inventory to determine whether to retain automatic release the instance.</description></item>
        /// <item><description>0: After a spot instance is created, Alibaba Cloud does not ensure that the instance runs for 1 hour. The system compares the bid price with the market price and checks the resource inventory to determine whether to retain automatic release the instance.</description></item>
        /// </list>
        /// <para>Alibaba Cloud sends an ECS system event notification 5 minutes before the instance is released. Spot instances are billed by second. Select an appropriate protection period based on the expected task execution duration.</para>
        /// <remarks>
        /// <para>This parameter takes effect when SpotStrategy is set to SpotWithPriceLimit or SpotAsPriceGo.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The maximum hourly price of the instance. This parameter supports up to three decimal places and takes effect when <c>SpotStrategy</c> is set to <c>SpotWithPriceLimit</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.97</para>
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The preemption policy for the pay-as-you-go instance. This parameter takes effect when <c>InstanceChargeType</c> is set to <c>PostPaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instance is a regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: The instance is a spot instance with a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The instance is a spot instance for which the market price at the time of purchase is automatically used as the bid price.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The tags of the instances, disks, and primary ENIs created by using this template version.</para>
        /// <details>
        /// <summary>Scenarios</summary>
        /// After you call the CreateLaunchTemplate operation to create a template, the auto-generated default version is used to create instances. These tags are applied to the instances, disks, and primary ENIs.
        /// </details>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateLaunchTemplateRequestTag> Tag { get; set; }
        public class CreateLaunchTemplateRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the instances, disks, and primary ENIs created by using this template version. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. The tag key cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instances, disks, and primary ENIs created by using this template version. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the enterprise resource group to which the launch template belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("TemplateResourceGroupId")]
        [Validation(Required=false)]
        public string TemplateResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tag information of the launch template itself.</para>
        /// <remarks>
        /// <para>Currently, you can create and query tags for launch templates only by calling API operations. You cannot create or view these tags in the console.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TemplateTag")]
        [Validation(Required=false)]
        public List<CreateLaunchTemplateRequestTemplateTag> TemplateTag { get; set; }
        public class CreateLaunchTemplateRequestTemplateTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the launch template. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the launch template. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. The tag value cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Instance user data of the instance. Instance user data must be encoded in Base64. The raw data can be up to 32 KB in size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. This parameter is required when you create a VPC-connected instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1s5fnvk4gn2tws0****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The description of the launch template version. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testVersionDescription</para>
        /// </summary>
        [NameInMap("VersionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp12433upq1y5scen****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

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
