// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateLaunchTemplateVersionRequest : TeaModel {
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public CreateLaunchTemplateVersionRequestSystemDisk SystemDisk { get; set; }
        public class CreateLaunchTemplateVersionRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy applied to the system disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-bp1dgzpaxwc4load****</para>
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable performance burst. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
            /// <item><description>cloud: basic disk</description></item>
            /// <item><description>cloud_efficiency: ultra disk</description></item>
            /// <item><description>cloud_ssd: standard SSD</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL disk</description></item>
            /// <item><description>cloud_essd: ESSD. You can use the <c>SystemDisk.PerformanceLevel</c> parameter for the performance level settings of the disk.</description></item>
            /// <item><description>cloud_essd_entry: ESSD Entry disk</description></item>
            /// </list>
            /// <para>Default value: cloud for retired instance types that are not I/O optimization instances, and cloud_efficiency for other instance types.</para>
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
            /// <item><description>true: Release the system disk when the instance is released.</description></item>
            /// <item><description>false: Do not release the system disk when the instance is released.</description></item>
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
            /// <para>The name of the system disk. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssdSystem</para>
            /// </summary>
            [NameInMap("DiskName")]
            [Validation(Required=false)]
            public string DiskName { get; set; }

            /// <summary>
            /// <para>Specifies whether to encrypt the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Encrypts the system disk.</para>
            /// </description></item>
            /// <item><description><para>false: Does not encrypt the system disk.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// <remarks>
            /// <para>You cannot encrypt the system disk when you create an instance in Hong Kong (China) Zone D or Singapore Zone A.</para>
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
            /// <para>This parameter is not available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>30000</para>
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
            /// <para>The performance level settings of the ESSD used as the system disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0 (default): A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>For more details about how to select the performance level of an ESSD, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The number of provisioned read/write IOPS for the ESSD AutoPL disk. Valid values: 0 to min{50000, 1000 × Capacity - Baseline performance}.</para>
            /// <para>Baseline performance = min{1800 + 50 × Capacity, 50000}.</para>
            /// <remarks>
            /// <para>This parameter is supported only when DiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a> and <a href="https://help.aliyun.com/document_detail/413275.html">Modify the provisioned performance of an ESSD AutoPL disk</a>.</para>
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
            /// <item><description>cloud: 20 to 500</description></item>
            /// <item><description>Other disk categories: 20 to 2048</description></item>
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
        /// <para>The automatic release time. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>If the value of seconds (<c>ss</c>) is not <c>00</c>, the time is automatically rounded down to the current minute (<c>mm</c>).</para>
        /// </description></item>
        /// <item><description><para>The release time must be at least 30 minutes later than the current time.</para>
        /// </description></item>
        /// <item><description><para>The release time cannot be more than three years later than the current time.</para>
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
        /// <para>Specifies whether to enable auto-renewal. This parameter takes effect only when the <c>InstanceChargeType</c> parameter is set to <c>PrePaid</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enables auto-renewal.</description></item>
        /// <item><description>false: Disables auto-renewal.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal period. Valid values: </para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Valid values when PeriodUnit is set to Week: 1, 2, and 3.</description></item>
        /// <item><description>Valid values when PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;Valid values when PeriodUnit is set to Month: 1, 2, 3, 6, 12, 24, 36, 48, and 60.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The operating mode of the burstable instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: standard mode. For more information about the instance performance in this mode, see the &quot;Standard mode&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
        /// <item><description>Unlimited: unlimited mode. For more information about the instance performance in this mode, see the &quot;Unlimited mode&quot; section in <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("CreditSpecification")]
        [Validation(Required=false)]
        public string CreditSpecification { get; set; }

        /// <summary>
        /// <para>The data disks.</para>
        /// </summary>
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<CreateLaunchTemplateVersionRequestDataDisk> DataDisk { get; set; }
        public class CreateLaunchTemplateVersionRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The ID of the automatic snapshot policy applied to the data disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("AutoSnapshotPolicyId")]
            [Validation(Required=false)]
            public string AutoSnapshotPolicyId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable performance burst. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
            /// <item><description>cloud_efficiency: ultra disk</description></item>
            /// <item><description>cloud_ssd: standard SSD</description></item>
            /// <item><description>cloud_essd: ESSD</description></item>
            /// <item><description>cloud: basic disk</description></item>
            /// <item><description>cloud_auto: ESSD AutoPL disk</description></item>
            /// <item><description>cloud_regional_disk_auto: regional ESSD</description></item>
            /// <item><description>cloud_essd_entry: ESSD Entry disk<remarks>
            /// <para>The <c>cloud_essd_entry</c> value is supported only when <c>InstanceType</c> is set to an instance type in the <c>ecs.u1</c> or <c>ecs.e</c> family.</para>
            /// </remarks>
            /// </description></item>
            /// <item><description>elastic_ephemeral_disk_standard: standard elastic ephemeral disk</description></item>
            /// <item><description>elastic_ephemeral_disk_premium: Premium Edition elastic ephemeral disk</description></item>
            /// </list>
            /// <para>Default value: cloud_efficiency for I/O optimization instances, and cloud for non-I/O optimization instances.
            /// Parameter default value description:</para>
            /// <list type="bullet">
            /// <item><description>If the instance type is a retired instance type that is not I/O optimization, the default value is <c>cloud</c>.</description></item>
            /// <item><description>In other cases, the default value is <c>cloud_efficiency</c>.&lt;props=&quot;china&quot;&gt; After January 30, 2026, if the I/O optimization instance type does not support cloud_auto, the default value is cloud_efficiency. Otherwise, the default value is cloud_auto, and performance burst is enabled by default, which incurs additional fees. For more details, see <a href="~~368372#p_75k_2hp_7gp~~">Billing examples</a> and <a href="https://www.aliyun.com/notice/117844">Announcement on changes</a>.</description></item>
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
            /// <item><description>true: Release the data disk when the instance is released.</description></item>
            /// <item><description>false: Do not release the data disk when the instance is released.</description></item>
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
            /// <para>The mount point of the data disk. The naming conventions for mount points vary based on the number of attached data disks:</para>
            /// <list type="bullet">
            /// <item><description><para>1 to 25 data disks: /dev/xvd<c>[b-z]</c></para>
            /// </description></item>
            /// <item><description><para>More than 25 data disks: /dev/xvd<c>[aa-zz]</c>. For example, the 26th data disk is named /dev/xvdaa, and the 27th data disk is named /dev/xvdab.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is applicable only to full images. You can set this parameter to the mount point of the data disk in the full image and modify the <c>DataDisk.N.Size</c> and <c>DataDisk.N.Category</c> parameters to change the category and size of the data disk in the full image.</para>
            /// </remarks>
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
            /// <para>The ID of the Key Management Service (KMS) key used by the data disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0e478b7a-4262-4802-b8cb-00d****</para>
            /// </summary>
            [NameInMap("KMSKeyId")]
            [Validation(Required=false)]
            public string KMSKeyId { get; set; }

            /// <summary>
            /// <para>The performance level settings of the ESSD used as the data disk. The value of N must be the same as that in <c>DataDisk.N.Category=cloud_essd</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1 (default): A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// <para>For more details about how to select the performance level of an ESSD, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSD</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The number of provisioned read/write IOPS for the ESSD AutoPL disk. Valid values: 0 to min{50000, 1000 × Capacity - Baseline performance}.</para>
            /// <para>Baseline performance = min{1800 + 50 × Capacity, 50000}.</para>
            /// <remarks>
            /// <para>This parameter is supported only when DiskCategory is set to cloud_auto. For more information, see <a href="https://help.aliyun.com/document_detail/368372.html">ESSD AutoPL disks</a> and <a href="https://help.aliyun.com/document_detail/413275.html">Modify the provisioned performance of an ESSD AutoPL disk</a>.</para>
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
            /// <item><description>cloud_essd: The valid values are subject to the value of <c>DataDisk.N.PerformanceLevel</c>.   <list type="bullet">
            /// <item><description>PL0: 1 to 32768</description></item>
            /// <item><description>PL1: 20 to 32768</description></item>
            /// <item><description>PL2: 461 to 32768</description></item>
            /// <item><description>PL3: 1261 to 32768</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>cloud_auto: 1 to 32768</description></item>
            /// <item><description>cloud_essd_entry: 10 to 32768</description></item>
            /// </list>
            /// <para>The value of this parameter must be greater than or equal to the size of the snapshot specified by the <c>SnapshotId</c> parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The ID of the snapshot used to create data disk N. Valid values of N: 1 to 16. When the <c>DataDisk.N.SnapshotId</c> parameter is specified, the <c>DataDisk.N.Size</c> parameter is ignored. The size of the created disk is the same as that of the specified snapshot.</para>
            /// <para>You cannot use snapshots that were created on or before July 15, 2013. Otherwise, an error is returned and your request is rejected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-bp17441ohwka0yuh****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

        }

        /// <summary>
        /// <para>The release protection property of the instance. This property specifies whether the instance can be released by using the ECS console or by calling the <a href="https://help.aliyun.com/document_detail/25507.html">DeleteInstance</a> operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables release protection for the instance.</para>
        /// </description></item>
        /// <item><description><para>false: Disables release protection for the instance.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This property applies only to pay-as-you-go instances. It can prevent only manual release operations, but not system release operations.</para>
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
        /// <para>The instance description. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the operating system configuration of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableVmOsConfig")]
        [Validation(Required=false)]
        public bool? EnableVmOsConfig { get; set; }

        /// <summary>
        /// <para>The hostname of the cloud server.</para>
        /// <list type="bullet">
        /// <item><description>The hostname cannot start or end with a period (.) or a hyphen (-). It cannot contain consecutive periods (.) or hyphens (-).</description></item>
        /// <item><description>For a Windows instance, the hostname must be 2 to 15 characters in length. It cannot contain periods (.) or contain only digits. It can contain letters, digits, and hyphens (-).</description></item>
        /// <item><description>For an instance of other operating systems such as Linux, the hostname must be 2 to 64 characters in length. It can contain multiple periods (.). The characters between two consecutive periods are considered a segment. Each segment can contain letters, digits, and hyphens (-).</description></item>
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
        /// <item><description>enabled: Enables the access channel.</description></item>
        /// <item><description>disabled: Disables the access channel.</description></item>
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
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("HttpPutResponseHopLimit")]
        [Validation(Required=false)]
        public int? HttpPutResponseHopLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly use the security hardening mode (IMDSv2) to access instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>optional: Does not forcibly use the security hardening mode.</description></item>
        /// <item><description>required: Forcibly uses the security hardening mode. After you set this value, you cannot access instance metadata in normal mode.</description></item>
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
        /// <para>The image ID. This is the image resource selected when the instance is started. You can call the <a href="https://help.aliyun.com/document_detail/25534.html">DescribeImages</a> operation to query the available image resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>win2008r2_64_ent_sp1_en-us_40G_alibase_20170915.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image-related properties.</para>
        /// </summary>
        [NameInMap("ImageOptions")]
        [Validation(Required=false)]
        public CreateLaunchTemplateVersionRequestImageOptions ImageOptions { get; set; }
        public class CreateLaunchTemplateVersionRequestImageOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether instances that use this image support logons by the ecs-user user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
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
        /// <para>The image source.</para>
        /// <remarks>
        /// <para>This parameter will be deprecated soon. To improve compatibility, use other parameters instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription. If you select this billing method, you must confirm that your account supports balance payment and credit payment. Otherwise, an <c>InvalidPayMethod</c> fault is returned.</description></item>
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription. If you select this billing method, you must confirm that your account supports credit payment. Otherwise, an <c>InvalidPayMethod</c> fault is returned.</description></item>
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;partner&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription. If you select this billing method, you must confirm that your account supports credit payment. Otherwise, an <c>InvalidPayMethod</c> fault is returned.</description></item>
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
        /// <para>The instance name. The name must be 2 to 128 characters in length and can contain letters and digits in the Unicode letter category. It can contain colons (:), underscores (_), periods (.), and hyphens (-). The default value is the <c>InstanceId</c> of the instance.</para>
        /// <para>When you create multiple ECS instances, you can specify sequential instance names in batches. The names can contain brackets ([]) and commas (,). For more information, see <a href="https://help.aliyun.com/document_detail/196048.html">Specify sequential instance names or hostnames</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-node-[1,4]-alibabacloud</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">instance family</a>. You can also invoke the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the most recent instance type list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The billing method for outbound Internet bandwidth. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayByBandwidth: pay-by-bandwidth</description></item>
        /// <item><description>PayByTraffic: pay-by-traffic</description></item>
        /// </list>
        /// <remarks>
        /// <para>In the <b>pay-by-traffic</b> pattern, the peak inbound and outbound bandwidths are used as upper limits of bandwidths instead of guaranteed performance specifications. In the event of resource contention, the peak bandwidths cannot be guaranteed. If your business requires guaranteed bandwidths, use the <b>pay-by-bandwidth</b> pattern.</para>
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
        /// <para>50</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// <para>The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is an I/O optimized instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>none: The instance is not I/O optimization.</description></item>
        /// <item><description>optimized: The instance is I/O optimization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>The number of IPv6 addresses to be randomly generated for the primary ENI. Valid values: 1 to 10.</para>
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
        /// <item><description>For a Windows instance, this parameter is ignored. Even if this parameter is specified, only the <c>Password</c> parameter takes effect.</description></item>
        /// <item><description>For a Linux instance, password logon is disabled by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testKeyPairName</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The launch template ID. For more information, call the <a href="https://help.aliyun.com/document_detail/73759.html">DescribeLaunchTemplates</a> operation. You must specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to identify the launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-m5eiaupmvm2op9d****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The name of the launch template. The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>. It can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testLaunchTemplateName</para>
        /// </summary>
        [NameInMap("LaunchTemplateName")]
        [Validation(Required=false)]
        public string LaunchTemplateName { get; set; }

        /// <summary>
        /// <para>The elastic network interface controller (NIC) information.</para>
        /// </summary>
        [NameInMap("NetworkInterface")]
        [Validation(Required=false)]
        public List<CreateLaunchTemplateVersionRequestNetworkInterface> NetworkInterface { get; set; }
        public class CreateLaunchTemplateVersionRequestNetworkInterface : TeaModel {
            /// <summary>
            /// <para>Specifies whether to retain the ENI when the instance is released. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Do not retain the ENI.</para>
            /// </description></item>
            /// <item><description><para>false: Retain the ENI.</para>
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
            /// <para>The description of the secondary elastic network interface controller (NIC). The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>. The value of N in <c>NetworkInterface.N</c> cannot be greater than 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testNetworkInterfaceDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The Elastic Network Interface (ENI) type. Valid values of N: 1 and 2. If N is set to 1, you can configure one primary ENI or one secondary ENI. If N is set to 2, you must configure one primary ENI and one secondary ENI.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Primary: primary ENI</description></item>
            /// <item><description>Secondary: secondary ENI</description></item>
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
            /// <para>The name of the secondary elastic network interface controller (NIC). The value of N in <c>NetworkInterface.N</c> cannot be greater than 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testNetworkInterfaceName</para>
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
            /// <para>The primary private IP address of the secondary elastic network interface controller (NIC). The value of N in <c>NetworkInterface.N</c> cannot be greater than 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para><c>192.168.**.**</c></para>
            /// </summary>
            [NameInMap("PrimaryIpAddress")]
            [Validation(Required=false)]
            public string PrimaryIpAddress { get; set; }

            /// <summary>
            /// <para>The ID of the security group to which the secondary elastic network interface controller (NIC) belongs. The security group of the secondary elastic network interface controller (NIC) and the security group of the instance must be in the same VPC. The value of N in <c>NetworkInterface.N</c> cannot be greater than 1.</para>
            /// <remarks>
            /// <para>You cannot specify both <c>NetworkInterface.N.SecurityGroupId</c> and <c>NetworkInterface.N.SecurityGroupIds.N</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp15ed6xe1yxeycg****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The IDs of one or more security groups to which the secondary elastic network interface controller (NIC) belongs. The security groups and the secondary elastic network interface controller (NIC) must be in the same VPC. The valid values of N in <c>SecurityGroupIds.N</c> depend on the quota of security groups to which the secondary elastic network interface controller (NIC) can be added. For more information, see <a href="https://help.aliyun.com/document_detail/25412.html">Limits</a>. The value of N in <c>NetworkInterface.N</c> cannot be greater than 1.</para>
            /// <remarks>
            /// <para>You cannot specify both <c>NetworkInterface.N.SecurityGroupId</c> and <c>NetworkInterface.N.SecurityGroupIds.N</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the secondary elastic network interface controller (NIC) belongs. The instance and the secondary elastic network interface controller (NIC) must be in the same active zone of the same VPC, but they can belong to different vSwitches. The value of N in <c>NetworkInterface.N</c> cannot be greater than 1.</para>
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
        /// <item><description>vpc: VPC</description></item>
        /// <item><description>classic: classic network. The classic network is no longer available. For more information, see <a href="https://help.aliyun.com/document_detail/2833134.html">Notice on the discontinuation of the classic network</a>.</description></item>
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
        /// <para>Specifies whether to use the preset password of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>When you specify this parameter, leave the Password parameter empty. Make sure that the specified image has a preset password.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The subscription period of the instance. Unit: months. This parameter is required and takes effect only when <c>InstanceChargeType</c> is set to <c>PrePaid</c>. Valid values: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription Billable methods. Valid values: </para>
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
        /// <para>When you specify a private IP address for a VPC-type ECS instance, make sure that the IP address is an idle IP address within the CIDR block of the vSwitch specified by <c>VSwitchId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>10.1.**.**</c></para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The name of the instance RAM role. You can call the RAM API operation <a href="https://help.aliyun.com/document_detail/28713.html">ListRoles</a> to query the instance RAM roles that you have created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRamRoleName</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
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
        /// <para>The ID of the security group to which the instance created by using this version belongs. Instances in the same security group can access each other.</para>
        /// <remarks>
        /// <para>You cannot specify both <c>SecurityGroupId</c> and <c>SecurityGroupIds.N</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp15ed6xe1yxeycg****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The security groups to which the instance is added. The valid values of N are subject to the quota of security groups to which an instance can be added. For more information, see <a href="https://help.aliyun.com/document_detail/25412.html">Limits</a>.</para>
        /// <remarks>
        /// <para>You cannot specify both <c>SecurityGroupId</c> and <c>SecurityGroupIds.N</c> at the same time.</para>
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
        public CreateLaunchTemplateVersionRequestSecurityOptions SecurityOptions { get; set; }
        public class CreateLaunchTemplateVersionRequestSecurityOptions : TeaModel {
            /// <summary>
            /// <para>The trusted system mode. Valid values: vTPM.</para>
            /// <para>Currently, the trusted system mode supports the following instance families:</para>
            /// <list type="bullet">
            /// <item><description>g7, c7, and r7.</description></item>
            /// <item><description>Security-enhanced instance families (g7t, c7t, and r7t).</description></item>
            /// </list>
            /// <para>When you create an ECS instance of the preceding instance families, you must configure the settings for this parameter. Details:</para>
            /// <list type="bullet">
            /// <item><description>If you use the Alibaba Cloud trusted system, set this parameter to vTPM. This way, the Alibaba Cloud trusted system performs trusted verification when the instance starts.</description></item>
            /// <item><description>If you do not use the Alibaba Cloud trusted system, you can leave this parameter empty. However, if the ECS instance that you create uses the Enclave-based confidential computing mode (<c>SecurityOptions.ConfidentialComputingMode=Enclave</c>), the trusted system is also enabled for the instance.</description></item>
            /// <item><description>To create a trusted ECS instance by invoking an API operation, you can only invoke the <c>RunInstances</c> operation. The <c>CreateInstance</c> operation does not support the <c>SecurityOptions.TrustedSystemMode</c> parameter.<remarks>
            /// <para>If you specify an instance as a trusted instance when you create it, you can only use images that support the trusted system when you replace the system disk.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// <para>For more information about the trusted system, see <a href="https://help.aliyun.com/document_detail/201394.html">Overview of the trusted feature for security-enhanced instances</a>.</para>
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
        /// <item><description>1: Alibaba Cloud guarantees that the instance is not subject to automatic release for 1 hour after it is created. After 1 hour, the system compares the bid price with the marketplace price and checks the resource inventory to determine whether to retain or revoke the instance.</description></item>
        /// <item><description>0: Alibaba Cloud does not guarantee that the instance is retained for 1 hour after it is created. The system compares the bid price with the marketplace price and checks the resource inventory to determine whether to retain or revoke the instance.</description></item>
        /// </list>
        /// <para>Alibaba Cloud sends you a notification by using an ECS system event 5 minutes before the instance is revoked. Spot instances use second billing. We recommend that you select an appropriate protection period based on the execution duration of your specific tasks.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when SpotStrategy is set to SpotWithPriceLimit or SpotAsPriceGo.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The maximum hourly price of the instance. The value can be accurate to three decimal places.</para>
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
        /// <item><description>NoSpot: Spot instance is a regular pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: Spot instance is a preemptible instance with a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: Spot instance is a preemptible instance for which the market price is automatically used as the bid price.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The tags of the instances, disks, and primary ENIs created by using this version.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateLaunchTemplateVersionRequestTag> Tag { get; set; }
        public class CreateLaunchTemplateVersionRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the instances, disks, and primary ENIs created by using this version. Valid values of N: 1 to 20. If you specify this parameter, it cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instances, disks, and primary ENIs created by using this version. Valid values of N: 1 to 20. If you specify this parameter, it can be an empty string. The tag value can be up to 128 characters in length and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Instance user data of the instance. Instance user data must be encoded in Base64. The maximum size of the raw data is 32 KB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyBoZWxsbyBl****</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch. This parameter is required when you create a VPC-type instance.</para>
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
        /// <para>The ID of the virtual private cloud (VPC) to which the instance belongs.</para>
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
